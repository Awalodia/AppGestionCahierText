using AppCahierText.Model;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Classe
{
    [Key]
    public int IdClasse { get; set; }

    // Si tu veux un identifiant textuel ou un code spécifique :
    public string IdLibelle { get; set; }

    [Required, MaxLength(10)]
    public string LibelleClasse { get; set; }

    public int IdAnneeAcademique { get; set; }

    [ForeignKey("IdAnneeAcademique")]
    public virtual AnneeAcademique AnneeAcademique { get; set; }
}