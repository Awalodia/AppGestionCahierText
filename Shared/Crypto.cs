using System;
using System.Security.Cryptography;
using System.Text;

namespace AppCahierText.Shared
{
    public static class Crypto
    {
        /// <summary>
        /// Transforme une chaîne de caractères en empreinte MD5 (hexadécimal).
        /// </summary>
        public static string GetMd5Hash(string input)
        {
            if (string.IsNullOrEmpty(input)) return string.Empty;

            using (MD5 md5Hash = MD5.Create())
            {
                // Conversion de la chaîne en tableau d'octets
                byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

                // Construction de la chaîne hexadécimale
                StringBuilder sBuilder = new StringBuilder();
                for (int i = 0; i < data.Length; i++)
                {
                    sBuilder.Append(data[i].ToString("x2"));
                }

                return sBuilder.ToString();
            }
        }

        /// <summary>
        /// Vérifie si une saisie correspond à un hash stocké en base de données.
        /// </summary>
        public static bool VerifyMd5Hash(string input, string hash)
        {
            // On hache la nouvelle saisie
            string hashOfInput = GetMd5Hash(input);

            // Comparaison insensible à la casse
            StringComparer comparer = StringComparer.OrdinalIgnoreCase;

            return comparer.Compare(hashOfInput, hash) == 0;
        }
    }
}