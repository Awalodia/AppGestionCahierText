using System.ComponentModel.DataAnnotations;

namespace AppCahierText.Model
{
    public class Utilisateur
    {
        [Key]
        public int IdUtilisateur { get; set; }

        [Required, MaxLength(80)]
        public string NomUtilisateur { get; set; }

        [Required, MaxLength(80)]
        public string PrenomUtilisateur { get; set; }

        [Required, MaxLength(50)]
        public string Profil { get; set; }

        [MaxLength(300)]
        public string AdresseUtilisateur { get; set; }

        [Required, MaxLength(80)]
        public string EmailUtilisateur { get; set; }

        [Required, MaxLength(20)]
        public string TelephoneUtilisateur { get; set; }

        [Required, MaxLength(20)]
        public string IdentifiantUtilisateur { get; set; }

        [Required, MaxLength(300)]
        public string MotDePasse { get; set; }
    }
}