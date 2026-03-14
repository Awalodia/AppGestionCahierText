using AppCahierText.Model;
using System.Collections.Generic;
using System.Linq;

namespace AppCahierText.Shared
{
    public static class FillListOption
    {
        /// <summary>
        /// Remplit la liste des années académiques
        /// </summary>
        public static List<ListItem> fillAnneeAcademique()
        {
            using (var db = new BdCahierTexteContext())
            {
                List<ListItem> lalist = new List<ListItem>();

                // Valeur par défaut pour forcer une sélection valide
                lalist.Add(new ListItem { Value = "0", Text = "Sélectionner une année..." });

                var liste = db.AnneesAcademiques.AsNoTracking().OrderByDescending(a => a.IdAnneeAcademique).ToList();
                foreach (var t in liste)
                {
                    lalist.Add(new ListItem
                    {
                        Value = t.IdAnneeAcademique.ToString(),
                        Text = t.LibelleAnneeAcademique
                    });
                }
                return lalist;
            }
        }

        /// <summary>
        /// Remplit la liste des classes
        /// </summary>
        public static List<ListItem> fillClasse()
        {
            using (var db = new BdCahierTexteContext())
            {
                List<ListItem> lalist = new List<ListItem>();
                lalist.Add(new ListItem { Value = "0", Text = "Sélectionner une classe..." });

                var liste = db.Classes.AsNoTracking().OrderBy(c => c.LibelleClasse).ToList();
                foreach (var t in liste)
                {
                    lalist.Add(new ListItem
                    {
                        Value = t.IdClasse.ToString(),
                        Text = t.LibelleClasse
                    });
                }
                return lalist;
            }
        }

        /// <summary>
        /// Remplit la liste des responsables (Utilisateurs de type responsable)
        /// </summary>
        public static List<ListItem> fillEnseignant()
        {
            using (var db = new BdCahierTexteContext())
            {
                List<ListItem> lalist = new List<ListItem>();
                lalist.Add(new ListItem { Value = "0", Text = "Sélectionner un enseignant..." });

                // On récupère les responsables enregistrés dans la table ResponsablesClasses
                var liste = db.ResponsablesClasses.AsNoTracking().OrderBy(r => r.NomUtilisateur).ToList();
                foreach (var t in liste)
                {
                    lalist.Add(new ListItem
                    {
                        Value = t.IdUtilisateur.ToString(),
                        Text = t.PrenomUtilisateur + " " + t.NomUtilisateur
                    });
                }
                return lalist;
            }
        }
    }
}