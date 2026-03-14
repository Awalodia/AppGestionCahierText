using AppCahierText.Model;
using AppCahierText.Shared;
using AppCahierText.Views.Account;
using System;
using System.Linq;
using System.Windows.Forms;

namespace AppCahierText
{
    static class Program
    {

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            FirstUser();

 
            Application.Run(new frmConnexion());
        }

        public static void FirstUser()
        {
            try
            {
                using (BdCahierTexteContext db = new BdCahierTexteContext())
                {
                 
                    if (db.Utilisateurs.Any(u => u.IdentifiantUtilisateur == "admin"))
                        return;

                  
                    ChefDepartement admin = new ChefDepartement
                    {
                        NomUtilisateur = "Diallo",
                        PrenomUtilisateur = "Awa",
                        EmailUtilisateur = "awa@gmail.com",
                        AdresseUtilisateur = "Centenaire",
                        TelephoneUtilisateur = "774430961",
                        IdentifiantUtilisateur = "admin",
                        MotDePasse = Crypto.GetMd5Hash("passer123"),
                        Profil = "ChefDepartement"
                    };

                    db.Utilisateurs.Add(admin);
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                
                MessageBox.Show("Erreur critique lors de l'accès à la base de données :\n" + ex.GetBaseException().Message,
                                "Erreur de démarrage", MessageBoxButtons.OK, MessageBoxIcon.Stop);

            }
        }
    }
}