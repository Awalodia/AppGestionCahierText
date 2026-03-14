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
        BdCahierTexteContext db = new BdCahierTexteContext();

        public frmUtilisateurs()
        {
            InitializeComponent();
        }

        // ✅ CORRECTION : Méthode Load demandée par le Designer
        private void frmUtilisateurs_Load(object sender, EventArgs e)
        {
            Actualiser();
        }

        private void Actualiser()
        {
            dgvUtilisateurs.DataSource = db.Utilisateurs
                .Select(u => new {
                    u.IdUtilisateur,
                    u.NomUtilisateur,
                    u.PrenomUtilisateur,
                    u.Profil,
                    u.IdentifiantUtilisateur
                }).ToList();
        }

        private void Effacer()
        {
            txtNom.Text = txtPrenom.Text = txtEmail.Text = txtTel.Text = "";
            txtAdresse.Text = txtIdentifiant.Text = txtPassword.Text = "";
            if (profil.Items.Count > 0) profil.SelectedIndex = -1;
            txtNom.Focus();
        }

        // ✅ CORRECTION : Méthode Click demandée par le Designer
        private void btnAjouter_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtIdentifiant.Text) || string.IsNullOrWhiteSpace(profil.Text))
                {
                    MessageBox.Show("Identifiant et Profil obligatoires !");
                    return;
                }

                Utilisateur user = new Utilisateur
                {
                    NomUtilisateur = txtNom.Text.Trim(),
                    PrenomUtilisateur = txtPrenom.Text.Trim(),
                    EmailUtilisateur = txtEmail.Text.Trim(),
                    TelephoneUtilisateur = txtTel.Text.Trim(), // Utilise txtTel
                    AdresseUtilisateur = txtAdresse.Text.Trim(), // Utilise txtAdresse
                    IdentifiantUtilisateur = txtIdentifiant.Text.Trim(),
                    Profil = profil.Text,
                    MotDePasse = Crypto.GetMd5Hash(txtPassword.Text)
                };

                db.Utilisateurs.Add(user);
                db.SaveChanges();
                MessageBox.Show("Succès !");
                Effacer();
                Actualiser();
            }
            catch (Exception ex) { MessageBox.Show("Erreur : " + ex.Message); }
        }

        // ✅ CORRECTION : Méthode Click demandée par le Designer
        private void btnModifier_Click(object sender, EventArgs e)
        {
            // Logique de modification
            Actualiser();
        }

        // ✅ CORRECTION : Méthode Click demandée par le Designer
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
                }
            }
        }
    }
}