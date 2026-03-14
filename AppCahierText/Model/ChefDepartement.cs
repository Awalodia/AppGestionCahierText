using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppCahierText.Model
{
    // On précise que cette classe fait partie de la hiérarchie des Utilisateurs
    public class ChefDepartement : Utilisateur
    {
        // On peut ajouter une propriété spécifique si nécessaire
        // public string Specialite { get; set; }

        public ChefDepartement()
        {
            // On peut forcer une valeur ou un comportement ici
        }
    }
}