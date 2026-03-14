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
            // Met le focus sur l'identifiant dès l'ouverture
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
                    // 2. Recherche de l'utilisateur par identifiant (Trim pour éviter les espaces inutiles)
                    var leUser = db.Utilisateurs
                                   .FirstOrDefault(u => u.IdentifiantUtilisateur == txtIdentifiant.Text.Trim());

                    // Si l'utilisateur n'existe pas
                    if (leUser == null)
                    {
                        MessageErreur();
                        return;
                    }

                    // 3. Vérification du mot de passe haché (MD5)
                    // On compare le texte clair saisi avec le hachage stocké en base
                    bool isValid = Crypto.VerifyMd5Hash(txtMotDePasse.Text, leUser.MotDePasse);

                    if (!isValid)
                    {
                        MessageErreur();
                        return;
                    }

                    // 4. Détermination du profil (Rôle pour les droits d'accès)
                    string profil = DeterminerProfil(db, leUser);

                    if (string.IsNullOrEmpty(profil))
                    {
                        MessageBox.Show("Votre compte n'a pas de profil valide assigné. Veuillez contacter l'administrateur.",
                                        "Accès refusé", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        return;
                    }

                    // 5. Succès : Ouverture du formulaire principal (MDI)
                    var f = new frmMDI();
                    f.profil = profil; // On transmet le rôle au formulaire principal

                    // Si on ferme le formulaire principal, on ferme toute l'application
                    f.FormClosed += (s, args) => this.Close();

                    f.Show();
                    this.Hide(); // Cache le formulaire de connexion
                }
            }
            catch (Exception ex)
            {
                // GetBaseException() permet d'avoir l'erreur réelle (souvent liée à SQL Server)
                MessageBox.Show($"Erreur de connexion : {ex.GetBaseException().Message}",
                                "Erreur critique", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Affiche un message générique en cas d'erreur d'identification pour la sécurité.
        /// </summary>
        private void MessageErreur()
        {
            MessageBox.Show("Identifiant ou mot de passe incorrect.", "Échec de connexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            txtMotDePasse.Clear();
            txtIdentifiant.Focus();
        }

        /// <summary>
        /// Logique pour identifier le rôle de l'utilisateur.
        /// </summary>
        private string DeterminerProfil(BdCahierTexteContext db, Utilisateur leUser)
        {
            // Priorité 1 : Vérifier si le profil est directement renseigné dans la table Utilisateur
            if (!string.IsNullOrEmpty(leUser.Profil))
                return leUser.Profil;

            // Priorité 2 (Fallback) : Vérifier dans les tables de jointure si nécessaire
            if (db.ChefsDepartements.Any(c => c.IdUtilisateur == leUser.IdUtilisateur)) return "ChefDepartement";
            if (db.Professeurs.Any(p => p.IdUtilisateur == leUser.IdUtilisateur)) return "Professeur";
            if (db.ResponsablesClasses.Any(r => r.IdUtilisateur == leUser.IdUtilisateur)) return "ResponsableClasse";

            return null;
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}