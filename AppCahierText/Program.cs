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
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // 1. Initialisation de la base et du premier utilisateur
            FirstUser();

            // 2. Lancement du formulaire de connexion
            // On vérifie si frmConnexion existe bien dans AppCahierText.Views.Account
            Application.Run(new frmConnexion());
        }

        public static void FirstUser()
        {
            try
            {
                using (BdCahierTexteContext db = new BdCahierTexteContext())
                {
                    // Optionnel : Force la création de la base si elle n'existe pas
                    // db.Database.CreateIfNotExists();

                    // On vérifie si un administrateur existe déjà
                    if (db.Utilisateurs.Any(u => u.IdentifiantUtilisateur == "admin"))
                        return;

                    // Création de l'administrateur par défaut
                    // Note : Assurez-vous que ChefDepartement est une sous-classe de Utilisateur
                    ChefDepartement admin = new ChefDepartement
                    {
                        NomUtilisateur = "Diallo",
                        PrenomUtilisateur = "Awa",
                        EmailUtilisateur = "awa@gmail.com",
                        AdresseUtilisateur = "Centenaire",
                        TelephoneUtilisateur = "774430961",
                        IdentifiantUtilisateur = "admin",
                        // Mot de passe par défaut : passer123
                        MotDePasse = Crypto.GetMd5Hash("passer123"),
                        Profil = "ChefDepartement"
                    };

                    db.Utilisateurs.Add(admin);
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                // Message détaillé pour aider au débogage (problème de chaîne de connexion, serveur MySQL off, etc.)
                MessageBox.Show("Erreur critique lors de l'accès à la base de données :\n" + ex.GetBaseException().Message,
                                "Erreur de démarrage", MessageBoxButtons.OK, MessageBoxIcon.Stop);

                // On peut décider de fermer l'application si la base est inaccessible
                // Environment.Exit(0);
            }
        }
    }
}