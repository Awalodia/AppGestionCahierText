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
          
            if (string.IsNullOrWhiteSpace(txtIdentifiant.Text) || string.IsNullOrWhiteSpace(txtMotDePasse.Text))
            {
                MessageBox.Show("Veuillez remplir tous les champs.", "Champs obligatoires", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (BdCahierTexteContext db = new BdCahierTexteContext())
                {
                
                    var leUser = db.Utilisateurs
                                   .FirstOrDefault(u => u.IdentifiantUtilisateur == txtIdentifiant.Text.Trim());

                  
                    if (leUser == null)
                    {
                        MessageErreur();
                        return;
                    }

                 
                    bool isValid = Crypto.VerifyMd5Hash(txtMotDePasse.Text, leUser.MotDePasse);

                    if (!isValid)
                    {
                        MessageErreur();
                        return;
                    }

                  
                    string profil = DeterminerProfil(db, leUser);

                    if (string.IsNullOrEmpty(profil))
                    {
                        MessageBox.Show("Votre compte n'a pas de profil valide assigné. Veuillez contacter l'administrateur.",
                                        "Accès refusé", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        return;
                    }

                   
                    var f = new frmMDI();
                    f.profil = profil;

                 
                    f.FormClosed += (s, args) => this.Close();

                    f.Show();
                    this.Hide(); 
                }
            }
            catch (Exception ex)
            {
                
                MessageBox.Show($"Erreur de connexion : {ex.GetBaseException().Message}",
                                "Erreur critique", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

      
        private void MessageErreur()
        {
            MessageBox.Show("Identifiant ou mot de passe incorrect.", "Échec de connexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            txtMotDePasse.Clear();
            txtIdentifiant.Focus();
        }

        private string DeterminerProfil(BdCahierTexteContext db, Utilisateur leUser)
        {
            
            if (!string.IsNullOrEmpty(leUser.Profil))
                return leUser.Profil;

            
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