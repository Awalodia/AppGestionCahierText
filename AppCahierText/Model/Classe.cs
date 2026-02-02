using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCahierText.Model
{
    public class Classe
    {
        [Key]
        public int IdClasse { get; set; }
        [Required, MaxLength(10)]
        public string LibelleClasse { get; set; }
        public int IdAnneeAcademique { get; set; }
        [ForeignKey("IdAnneeAcademique")]
        public virtual AnneeAcademique AnneeAcademique { get; set; }

    }
}
