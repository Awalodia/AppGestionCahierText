using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppCahierText.Model
{
    public class ResponsableClasse : Utilisateur
    {
        // On retire IdResponsable car il hérite de IdUtilisateur
        [Required, MaxLength(10)]
        public string MatriculeResponsable { get; set; }

        public int IdClasse { get; set; }

        [ForeignKey("IdClasse")]
        public virtual Classe Classe { get; set; }
    }
}