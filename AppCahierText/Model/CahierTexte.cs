using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCahierText.Model
{
    public class CahierTexte
    {
        [Key]
        public int IdCahierTexte { get; set; }

        [Required, MaxLength(150)]
        public string TitreCahierTexte { get; set; }

        [Required, MaxLength(250)]
        public string DescriptionCahierTexte { get; set; }


        public DateTime DateCahierTexte { get; set; } = DateTime.Now;


        public int? Annee { get; set; }

        public int? IdResponsableClasse { get; set; }

        [ForeignKey("IdResponsableClasse")]
        public virtual ResponsableClasse ResponsableClasse { get; set; }
    }
}
