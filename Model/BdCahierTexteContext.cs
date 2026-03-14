using MySql.Data.EntityFramework;
using System.Data.Entity;

namespace AppCahierText.Model
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class BdCahierTexteContext : DbContext
    {
        public BdCahierTexteContext() : base("connCahierTexte")
        {
        }

        public DbSet<Matiere> Matieres { get; set; }
        public DbSet<AnneeAcademique> AnneesAcademiques { get; set; }
        public DbSet<Classe> Classes { get; set; }
        public DbSet<Utilisateur> Utilisateurs { get; set; }
        public DbSet<Professeur> Professeurs { get; set; }
        public DbSet<ChefDepartement> ChefsDepartements { get; set; } 
        public DbSet<ResponsableClasse> ResponsablesClasses { get; set; }
        public DbSet<Syllabus> Syllabus { get; set; }
        public DbSet<CahierTexte> CahierTextes { get; set; }
        public DbSet<DetailsSyllabus> DetailsSyllabus { get; set; }
    }
}