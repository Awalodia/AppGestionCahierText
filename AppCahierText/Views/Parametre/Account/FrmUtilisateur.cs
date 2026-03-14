using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using AppCahierText.Model;
using AppCahierText.Shared;

namespace AppCahierText.Views.Account
{
    public partial class frmUtilisateurs : Form
    {
        // On garde un contexte pour le chargement, mais on utilisera des "using" pour les actions
        BdCahierTexteContext db = new BdCahierTexteContext();

        public frmUtilisateurs()
        {
            InitializeComponent();
        }

        private void frmUtilisateurs_Load(object sender, EventArgs e)
        {
            Actualiser();
        }

        private void Actualiser()
        {
            // Re-instancier le contexte pour forcer le rafraîchissement des données
            db = new BdCahierTexteContext();
            dgvUtilisateurs.DataSource = db.Utilisateurs
                .Select(u => new {
                    u.IdUtilisateur,
                    u.NomUtilisateur,
                    u.PrenomUtilisateur,
                    u.Profil,
                    u.IdentifiantUtilisateur,
                    u.EmailUtilisateur
                }).ToList();

            if (dgvUtilisateurs.Columns.Contains("IdUtilisateur"))
                dgvUtilisateurs.Columns["IdUtilisateur"].Visible = false;
        }

        private void Effacer()
        {
            txtNom.Clear();
            txtPrenom.Clear();
            txtEmail.Clear();
            txtTel.Clear();
            txtAdresse.Clear();
            txtIdentifiant.Clear();
            txtPassword.Clear();
            if (profil.Items.Count > 0) profil.SelectedIndex = -1;
            txtNom.Focus();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtIdentifiant.Text) || string.IsNullOrWhiteSpace(profil.Text) || string.IsNullOrWhiteSpace(txtPassword.Text))
                {
                    MessageBox.Show("Identifiant, Profil et Mot de passe sont obligatoires pour un nouvel utilisateur !");
                    return;
                }

                using (var ctx = new BdCahierTexteContext())
                {
                    Utilisateur user = new Utilisateur
                    {
                        NomUtilisateur = txtNom.Text.Trim(),
                        PrenomUtilisateur = txtPrenom.Text.Trim(),
                        EmailUtilisateur = txtEmail.Text.Trim(),
                        TelephoneUtilisateur = txtTel.Text.Trim(),
                        AdresseUtilisateur = txtAdresse.Text.Trim(),
                        IdentifiantUtilisateur = txtIdentifiant.Text.Trim(),
                        Profil = profil.Text,
                        MotDePasse = Crypto.GetMd5Hash(txtPassword.Text) // Hachage MD5
                    };

                    ctx.Utilisateurs.Add(user);
                    ctx.SaveChanges();
                }

                MessageBox.Show("Utilisateur ajouté avec succès !");
                Effacer();
                Actualiser();
            }
            catch (Exception ex) { MessageBox.Show("Erreur lors de l'ajout : " + ex.GetBaseException().Message); }
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            try
            {
                // Vérifier si une ligne est sélectionnée
                if (dgvUtilisateurs.CurrentRow == null)
                {
                    MessageBox.Show("Veuillez sélectionner un utilisateur dans la liste.");
                    return;
                }

                int id = (int)dgvUtilisateurs.CurrentRow.Cells["IdUtilisateur"].Value;

                using (var ctx = new BdCahierTexteContext())
                {
                    var user = ctx.Utilisateurs.Find(id);
                    if (user != null)
                    {
                        user.NomUtilisateur = txtNom.Text.Trim();
                        user.PrenomUtilisateur = txtPrenom.Text.Trim();
                        user.EmailUtilisateur = txtEmail.Text.Trim();
                        user.TelephoneUtilisateur = txtTel.Text.Trim();
                        user.AdresseUtilisateur = txtAdresse.Text.Trim();
                        user.IdentifiantUtilisateur = txtIdentifiant.Text.Trim();
                        user.Profil = profil.Text;

                        // On ne change le mot de passe que si l'utilisateur en a saisi un nouveau
                        if (!string.IsNullOrWhiteSpace(txtPassword.Text))
                        {
                            user.MotDePasse = Crypto.GetMd5Hash(txtPassword.Text);
                        }

                        ctx.SaveChanges();
                        MessageBox.Show("Utilisateur mis à jour !");
                        Actualiser();
                        Effacer();
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show("Erreur lors de la modification : " + ex.Message); }
        }

        private void btnEffacer_Click(object sender, EventArgs e)
        {
            Effacer();
        }

        private void dgvUtilisateurs_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int id = (int)dgvUtilisateurs.Rows[e.RowIndex].Cells["IdUtilisateur"].Value;
                var user = db.Utilisateurs.Find(id);
                if (user != null)
                {
                    txtNom.Text = user.NomUtilisateur;
                    txtPrenom.Text = user.PrenomUtilisateur;
                    txtEmail.Text = user.EmailUtilisateur;
                    txtTel.Text = user.TelephoneUtilisateur;
                    txtAdresse.Text = user.AdresseUtilisateur;
                    txtIdentifiant.Text = user.IdentifiantUtilisateur;
                    profil.Text = user.Profil;

                    // On laisse le champ password vide par sécurité lors de la sélection
                    txtPassword.Text = "";
                }
            }
        }
    }
}