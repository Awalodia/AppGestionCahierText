using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppCahierText.Model
{
    public class ResponsableClasse : Utilisateur
    {
        // 1. Ajoutez une clé primaire spécifique pour éviter les conflits d'héritage
        [Key]
        public int IdResponsable { get; set; }

        [Required, MaxLength(10)]
        public string MatriculeResponsable { get; set; }

        // 2. Ajoutez la clé étrangère pour la Classe (Indispensable pour IdClasse)
        public int IdClasse { get; set; }

        // 3. Ajoutez la propriété de navigation (Indispensable pour r.Classe.LibelleClasse)
        [ForeignKey("IdClasse")]
        public virtual Classe Classe { get; set; }
    }
}