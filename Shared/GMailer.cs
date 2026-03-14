using System;
using System.Net;
using System.Net.Mail;
using AppCahierText.Shared; // Pour utiliser le Logger

namespace AppCahierText.Shared
{
    public class GMailer
    {
        // ─── Configuration globale (Static) ────────────────────
        public static string GmailUser { get; set; } = "votre.email@gmail.com";
        public static string GmailPassword { get; set; } = "votre_mot_de_passe_application";
        public static string GmailHost { get; set; } = "smtp.gmail.com";
        public static int GmailPort { get; set; } = 587;
        public static bool GmailSSL { get; set; } = true;

        // ─── Paramètres du message (Instance) ───────────────────
        public string ToEmail { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public bool IsHtml { get; set; } = false;

        // ─── Envoyer le message ───────────────────────────────────
        public void Send()
        {
            if (string.IsNullOrWhiteSpace(GmailUser) || string.IsNullOrWhiteSpace(GmailPassword))
            {
                Logger.Erreur("Configuration GMailer manquante (User/Password).");
                throw new InvalidOperationException("Configuration SMTP incomplète.");
            }

            try
            {
                using (MailMessage mail = new MailMessage())
                {
                    mail.From = new MailAddress(GmailUser, "Gestion Cahier de Texte");
                    mail.To.Add(new MailAddress(ToEmail));
                    mail.Subject = Subject;
                    mail.Body = Body;
                    mail.IsBodyHtml = IsHtml;

                    using (SmtpClient smtp = new SmtpClient(GmailHost, GmailPort))
                    {
                        smtp.EnableSsl = GmailSSL;
                        smtp.UseDefaultCredentials = false;
                        smtp.Credentials = new NetworkCredential(GmailUser, GmailPassword);
                        smtp.DeliveryMethod = SmtpDeliveryMethod.Network;

                        // Timeout de 10 secondes pour ne pas bloquer l'application
                        smtp.Timeout = 10000;

                        smtp.Send(mail);
                    }
                }
            }
            catch (Exception ex)
            {
                Logger.Erreur($"Échec de l'envoi d'email à {ToEmail}", ex);
                throw; // On relance l'erreur pour informer l'interface utilisateur
            }
        }

        // ─── Méthode Statique pour envoi rapide ───────────────────────────────
        public static void EnvoyerMotDePasse(string destinataire, string nomUtilisateur, string nouveauMotDePasse)
        {
            GMailer mailer = new GMailer
            {
                ToEmail = destinataire,
                Subject = "Réinitialisation de mot de passe",
                IsHtml = true,
                Body = $@"
                    <div style='font-family: Arial, sans-serif; border: 1px solid #ddd; padding: 20px;'>
                        <h2 style='color: #2c3e50;'>Bonjour {nomUtilisateur},</h2>
                        <p>Votre mot de passe a été réinitialisé par l'administrateur.</p>
                        <p style='font-size: 1.2em;'>Nouveau mot de passe : <strong>{nouveauMotDePasse}</strong></p>
                        <p style='color: #e74c3c;'><strong>Important :</strong> Changez ce mot de passe dès votre première connexion.</p>
                        <br/>
                        <p>Cordialement,<br/>L'administration du Cahier de Texte</p>
                    </div>"
            };

            mailer.Send();
        }
    }
}