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
        // On initialise le contexte de base de données
        private BdCahierTexteContext db = new BdCahierTexteContext();

        public frmUtilisateurs()
        {
            InitializeComponent();
            dgvUtilisateurs.AutoGenerateColumns = true;
        }

        private void frmUtilisateurs_Load(object sender, EventArgs e)
        {
            // Remplir la liste déroulante des profils
            if (profil.Items.Count == 0)
            {
                profil.Items.AddRange(new string[] { "Administrateur", "Professeur", "Etudiant", "ChefDepartement" });
            }
            Actualiser();
        }

        private void Actualiser()
        {
            try
            {
                // On recrée le contexte pour rafraîchir les données
                db = new BdCahierTexteContext();

                var liste = db.Utilisateurs
                    .Select(u => new {
                        u.IdUtilisateur,
                        Nom = u.NomUtilisateur,
                        Prenom = u.PrenomUtilisateur,
                        u.Profil,
                        Identifiant = u.IdentifiantUtilisateur,
                        Email = u.EmailUtilisateur,
                        Telephone = u.TelephoneUtilisateur
                    }).ToList();

                dgvUtilisateurs.DataSource = null;
                dgvUtilisateurs.DataSource = liste;

                if (dgvUtilisateurs.Columns.Contains("IdUtilisateur"))
                    dgvUtilisateurs.Columns["IdUtilisateur"].Visible = false;

                dgvUtilisateurs.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur de chargement : " + ex.Message);
            }
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtIdentifiant.Text) || profil.SelectedIndex == -1)
                {
                    MessageBox.Show("L'identifiant et le profil sont obligatoires.");
                    return;
                }

                Utilisateur user = new Utilisateur
                {
                    NomUtilisateur = txtNom.Text.Trim(),
                    PrenomUtilisateur = txtPrenom.Text.Trim(),
                    EmailUtilisateur = txtEmail.Text.Trim(),
                    TelephoneUtilisateur = txtTel.Text.Trim(),
                    AdresseUtilisateur = txtAdresse.Text.Trim(),
                    IdentifiantUtilisateur = txtIdentifiant.Text.Trim(),
                    Profil = profil.Text,
                    MotDePasse = Crypto.GetMd5Hash(txtPassword.Text)
                };

                db.Utilisateurs.Add(user);
                db.SaveChanges();

                MessageBox.Show("Utilisateur ajouté !");
                Actualiser();
                EffacerChamps();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.GetBaseException().Message);
            }
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvUtilisateurs.CurrentRow == null) return;
                int id = (int)dgvUtilisateurs.CurrentRow.Cells["IdUtilisateur"].Value;

                var user = db.Utilisateurs.Find(id);
                if (user != null)
                {
                    user.NomUtilisateur = txtNom.Text.Trim();
                    user.PrenomUtilisateur = txtPrenom.Text.Trim();
                    user.EmailUtilisateur = txtEmail.Text.Trim();
                    user.TelephoneUtilisateur = txtTel.Text.Trim();
                    user.AdresseUtilisateur = txtAdresse.Text.Trim();
                    user.IdentifiantUtilisateur = txtIdentifiant.Text.Trim();
                    user.Profil = profil.Text;

                    if (!string.IsNullOrWhiteSpace(txtPassword.Text))
                        user.MotDePasse = Crypto.GetMd5Hash(txtPassword.Text);

                    db.SaveChanges();
                    MessageBox.Show("Utilisateur mis à jour !");
                    Actualiser();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (dgvUtilisateurs.CurrentRow == null) return;

            var result = MessageBox.Show("Supprimer cet utilisateur ?", "Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                int id = (int)dgvUtilisateurs.CurrentRow.Cells["IdUtilisateur"].Value;
                var user = db.Utilisateurs.Find(id);
                if (user != null)
                {
                    db.Utilisateurs.Remove(user);
                    db.SaveChanges();
                    Actualiser();
                    EffacerChamps();
                }
            }
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
                }
            }
        }

        private void btnEffacer_Click(object sender, EventArgs e) => EffacerChamps();

        private void EffacerChamps()
        {
            txtNom.Clear(); txtPrenom.Clear(); txtEmail.Clear();
            txtTel.Clear(); txtAdresse.Clear(); txtIdentifiant.Clear();
            txtPassword.Clear(); profil.SelectedIndex = -1;
            txtNom.Focus();
        }
    }
}