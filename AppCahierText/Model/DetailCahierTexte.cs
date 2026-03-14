using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppCahierText.Model
{
    [Table("DetailCahierTextes")]
    public class DetailCahierTexte
    {
        [Key]
        public int IdDetail { get; set; }

        [Required(ErrorMessage = "L'heure de début est requise"), MaxLength(5)]
        public string HeureDebut { get; set; } 

        [Required(ErrorMessage = "L'heure de fin est requise"), MaxLength(5)]
        public string HeureFin { get; set; } 

        [Required, MaxLength(200)]
        public string ChapitreCours { get; set; }

        [Required, DataType(DataType.MultilineText)]
        public string ResumeCours { get; set; }

        public int IdCahierTexte { get; set; }

        [ForeignKey("IdCahierTexte")]
        public virtual CahierTexte CahierTexte { get; set; }

        public int IdMatiere { get; set; }

        [ForeignKey("IdMatiere")]
        public virtual Matiere Matiere { get; set; }
    }
}
