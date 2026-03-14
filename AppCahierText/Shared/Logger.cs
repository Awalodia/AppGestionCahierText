using System;
using System.IO;
using System.Configuration;

namespace AppCahierText.Shared
{
    public static class Logger
    {
        private static readonly string logPath;

        static Logger()
        {
            try
            {
                string folder = ConfigurationManager.AppSettings["ErrorFolder"] ??
                                Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Logs");

                if (!Directory.Exists(folder))
                {
                    Directory.CreateDirectory(folder);
                }

                logPath = Path.Combine(folder, "app.log");
            }
            catch
            {
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

        public static void WriteFileError(string message, string contexte = "")
        {
            string msg = string.IsNullOrWhiteSpace(contexte) ? message : $"[{contexte}] {message}";
            Ecrire("ERROR", msg);
        }

        private static void Ecrire(string niveau, string message)
        {
            try
            {
                string ligne = $"[{DateTime.Now:yyyy-MM-dd HH:mm:ss}] [{niveau}] {message}";

                lock (logPath)
                {
                    File.AppendAllText(logPath, ligne + Environment.NewLine);
                }
            }
            catch
            {
                
            }
        }
    }
}