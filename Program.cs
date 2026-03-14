using AppCahierText.Model;
using AppCahierText.Shared;
using AppCahierText.Views.Account; // ✅ Indispensable pour trouver frmConnexion et frmUtilisateurs
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

            // 1. On prépare la base de données avec l'admin par défaut
            firstUser();

            // 2. On lance l'application sur la page de Connexion
            // Si tu veux tester DIRECTEMENT le formulaire utilisateur sans te connecter, 
            // remplace la ligne ci-dessous par : Application.Run(new frmUtilisateurs());
            Application.Run(new frmConnexion());
        }

        public static void firstUser()
        {
            try
            {
                using (BdCahierTexteContext db = new BdCahierTexteContext())
                {
                    // Vérifier si l'admin existe déjà (on cherche dans la table générale des utilisateurs)
                    if (db.Utilisateurs.Any(u => u.IdentifiantUtilisateur == "admin"))
                        return;

                    // Hachage du mot de passe
                    string passHache = Crypto.GetMd5Hash("passer123");

                    // Création de l'objet ChefDepartement
                    ChefDepartement cd = new ChefDepartement
                    {
                        NomUtilisateur = "Diallo",
                        PrenomUtilisateur = "Awa",
                        EmailUtilisateur = "awa@gmail.com",
                        AdresseUtilisateur = "Centenaire",
                        TelephoneUtilisateur = "77-443-09-61",
                        IdentifiantUtilisateur = "admin",
                        MotDePasse = passHache,

                        // ✅ L'OUBLI ÉTAIT ICI : 
                        // C'est cette valeur qui débloque l'affichage du menu dans frmMDI
                        Profil = "ChefDepartement"
                    };

                    db.Utilisateurs.Add(cd);
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                Logger.Erreur("Erreur lors de l'initialisation de l'admin", ex);
            }
        }
    }
}