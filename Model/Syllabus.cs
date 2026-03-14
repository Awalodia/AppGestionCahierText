using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCahierText.Model
{
    public class Syllabus
    {
        [Key]
        public int SyllabusId { get; set; }

        [Required, MaxLength(80)]
        public string LibelleSyllabus { get; set; }

        [Required, MaxLength(500)]
        public string DescriptionSyllabus { get; set; }

        public int? VolumeHoraireSyllabus { get; set; }

        [Required, MaxLength(20)]
        public string NiveauSyllabus { get; set; }

        public virtual ICollection<DetailsSyllabus> DetailsSyllabus { get; set; }


    }
}
