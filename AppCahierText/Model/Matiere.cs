using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppCahierText.Model
{
    [Table("Matieres")]
    public class Matiere
    {
        [Key]
        public int IdMatiere { get; set; }

        [Required(ErrorMessage = "Le libellé est requis")]
        [MaxLength(200)]
        public string LibelleMatiere { get; set; }

        [Required]
        public int? VolumeHoraireMatiere { get; set; }

        [Required]
        [MaxLength(80)]
        public string Niveau { get; set; }

        // --- Début de la liaison avec Syllabus ---
        public int? SyllabusId { get; set; }

        [ForeignKey("SyllabusId")]
        public virtual Syllabus Syllabus { get; set; }
        // --- Fin de la liaison ---

        public Matiere() { }
    }
}