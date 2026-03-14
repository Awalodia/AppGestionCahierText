using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppCahierText.Model
{
    [Table("CahierTextes")]
    public class CahierTexte
    {
        [Key]
        public int IdCahierTexte { get; set; }

        [Required(ErrorMessage = "Le titre est requis"), MaxLength(150)]
        public string TitreCahierTexte { get; set; }

        [MaxLength(250)]
        public string DescriptionCahierTexte { get; set; }

        public DateTime DateCahierTexte { get; set; } = DateTime.Now;

       
        public int? Annee { get; set; }

        
        public int? IdResponsableClasse { get; set; }

        [ForeignKey("IdResponsableClasse")]
        public virtual ResponsableClasse ResponsableClasse { get; set; }

        public virtual ICollection<DetailCahierTexte> Details { get; set; }

        public CahierTexte()
        {
            this.Details = new HashSet<DetailCahierTexte>();
        }
    }
}