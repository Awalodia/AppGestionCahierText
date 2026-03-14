using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCahierText.Model
{
    public class Professeur : Utilisateur
    {
        [Required, MaxLength(80)]
        public string SpecialiteProfesseur { get; set; }




    }
}