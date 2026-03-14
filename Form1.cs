using AppCahierText.Model;
using AppCahierText.Shared;
using System;
using System.Linq;
using System.Windows.Forms;

namespace AppCahierText
{
    public partial class frmConnexion : Form
    {
        public frmConnexion()
        {
            InitializeComponent();
        }

        private void frmConnexion_Load(object sender, EventArgs e)
        {
            txtIdentifiant.Focus();
        }

        private void btnSeConnecter_Click(object sender, EventArgs e)
        {
            // 1. Validation des champs vides
            if (string.IsNullOrWhiteSpace(txtIdentifiant.Text) || string.IsNullOrWhiteSpace(txtMotDePasse.Text))
            {
                MessageBox.Show("Veuillez remplir tous les champs.", "Champs obligatoires", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (BdCahierTexteContext db = new BdCahierTexteContext())
                {
                    // 2. Recherche de l'utilisateur par identifiant
                    var leUser = db.Utilisateurs
                                   .FirstOrDefault(u => u.IdentifiantUtilisateur == txtIdentifiant.Text.Trim());

                    if (leUser == null)
                    {
                        MessageErreur();
                        return;
                    }

                    // 3. CORRECTION : Vérification du mot de passe
                    // On appelle directement Crypto.VerifyMd5Hash sans créer d'objet MD5 ici
                    bool isValid = Crypto.VerifyMd5Hash(txtMotDePasse.Text, leUser.MotDePasse);

                    if (!isValid)
                    {
                        MessageErreur();
                        return;
                    }

                    // 4. Détermination du profil (Rôle)
                    string profil = DeterminerProfil(db, leUser.IdUtilisateur);

                    if (string.IsNullOrEmpty(profil))
                    {
                        MessageBox.Show("Cet utilisateur n'a aucun rôle assigné.", "Accès refusé", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        return;
                    }

                    // 5. Ouverture du formulaire MDI
                    var f = new frmMDI();
                    f.profil = profil;
                    f.FormClosed += (s, args) => this.Close();
                    f.Show();
                    this.Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur de base de données : {ex.GetBaseException().Message}", "Erreur critique", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MessageErreur()
        {
            MessageBox.Show("Identifiant ou mot de passe incorrect.", "Connexion refusée", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtMotDePasse.Clear();
            txtIdentifiant.Focus();
        }

        private string DeterminerProfil(BdCahierTexteContext db, int idUser)
        {
            if (db.ChefsDepartements.Any(c => c.IdUtilisateur == idUser)) return "ChefDepartement";
            if (db.ResponsablesClasses.Any(r => r.IdUtilisateur == idUser)) return "ResponsableClasse";
            if (db.Professeurs.Any(p => p.IdUtilisateur == idUser)) return "Professeur";
            return null;
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}