using System;
using System.IO;
using System.Configuration;

namespace AppCahierText.Shared
{
    public static class Logger
    {
        // On définit le chemin du fichier log
        private static readonly string logPath;

        static Logger()
        {
            try
            {
                // Récupération du dossier depuis App.config ou dossier par défaut "Logs"
                string folder = ConfigurationManager.AppSettings["ErrorFolder"] ??
                                Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Logs");

                // Création du dossier s'il n'existe pas
                if (!Directory.Exists(folder))
                {
                    Directory.CreateDirectory(folder);
                }

                logPath = Path.Combine(folder, "app.log");
            }
            catch
            {
                // Backup au cas où le dossier configurer est inaccessible
                logPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "error.log");
            }
        }

        public static void Info(string message) => Ecrire("INFO", message);

        public static void Avertissement(string message) => Ecrire("WARN", message);

        public static void Erreur(string message) => Ecrire("ERROR", message);

        public static void Erreur(string message, Exception ex)
        {
            string detail = $"{message} | Exception: {ex.Message} | Stack: {ex.StackTrace}";
            Ecrire("ERROR", detail);
        }

        // Pour compatibilité avec ton code existant dans frmClasse
        public static void WriteFileError(string message, string contexte = "")
        {
            string msg = string.IsNullOrWhiteSpace(contexte) ? message : $"[{contexte}] {message}";
            Ecrire("ERROR", msg);
        }

        private static void Ecrire(string niveau, string message)
        {
            try
            {
                // Format : [2026-03-09 08:30:00] [ERROR] Message d'erreur
                string ligne = $"[{DateTime.Now:yyyy-MM-dd HH:mm:ss}] [{niveau}] {message}";

                // On utilise Lock pour éviter les conflits si deux erreurs arrivent en même temps
                lock (logPath)
                {
                    File.AppendAllText(logPath, ligne + Environment.NewLine);
                }
            }
            catch
            {
                // Un logger ne doit jamais faire planter l'application principale
            }
        }
    }
}