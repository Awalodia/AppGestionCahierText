using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCahierText.Model
{
    public class ResponsableClasse : Utilisateur
    {
        [Required, MaxLength(10)]
        public string MatriculeResponsable { get; set; }
       
    }
}