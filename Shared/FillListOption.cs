using AppCahierText.Model;
using System.Collections.Generic;
using System.Linq;

namespace AppCahierText.Shared
{
    public static class FillListOption
    {
        public static List<ListItem> fillAnneeAcademique()
        {
            using (var db = new BdCahierTexteContext())
            {
                List<ListItem> lalist = new List<ListItem>();
                lalist.Add(new ListItem { Value = "0", Text = "Sélectionner" });

                var liste = db.AnneesAcademiques.AsNoTracking().ToList();
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
    }
}