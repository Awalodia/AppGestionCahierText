
namespace AppCahierText.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialClean : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AnneeAcademiques",
                c => new
                    {
                        IdAnneeAcademique = c.Int(nullable: false, identity: true),
                        LibelleAnneeAcademique = c.String(nullable: false, maxLength: 10, storeType: "nvarchar"),
                        ValueAnneAcademique = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.IdAnneeAcademique);
            
            CreateTable(
                "dbo.CahierTextes",
                c => new
                    {
                        IdCahierTexte = c.Int(nullable: false, identity: true),
                        TitreCahierTexte = c.String(nullable: false, maxLength: 150, storeType: "nvarchar"),
                        DescriptionCahierTexte = c.String(nullable: false, maxLength: 250, storeType: "nvarchar"),
                        DateCahierTexte = c.DateTime(nullable: false, precision: 0),
                        Annee = c.Int(),
                        IdResponsableClasse = c.Int(),
                    })
                .PrimaryKey(t => t.IdCahierTexte)
                .ForeignKey("dbo.Utilisateurs", t => t.IdResponsableClasse)
                .Index(t => t.IdResponsableClasse);
            
            CreateTable(
                "dbo.Utilisateurs",
                c => new
                    {
                        IdUtilisateur = c.Int(nullable: false, identity: true),
                        NomUtilisateur = c.String(nullable: false, maxLength: 80, storeType: "nvarchar"),
                        PrenomUtilisateur = c.String(nullable: false, maxLength: 80, storeType: "nvarchar"),
                        Profil = c.String(nullable: false, maxLength: 50, storeType: "nvarchar"),
                        AdresseUtilisateur = c.String(maxLength: 300, storeType: "nvarchar"),
                        EmailUtilisateur = c.String(nullable: false, maxLength: 80, storeType: "nvarchar"),
                        TelephoneUtilisateur = c.String(nullable: false, maxLength: 20, storeType: "nvarchar"),
                        IdentifiantUtilisateur = c.String(nullable: false, maxLength: 20, storeType: "nvarchar"),
                        MotDePasse = c.String(nullable: false, maxLength: 300, storeType: "nvarchar"),
                        MatriculeResponsable = c.String(maxLength: 10, storeType: "nvarchar"),
                        SpecialiteProfesseur = c.String(maxLength: 80, storeType: "nvarchar"),
                        Discriminator = c.String(nullable: false, maxLength: 128, storeType: "nvarchar"),
                    })
                .PrimaryKey(t => t.IdUtilisateur);
            
            CreateTable(
                "dbo.Classes",
                c => new
                    {
                        IdClasse = c.Int(nullable: false, identity: true),
                        IdLibelle = c.String(unicode: false),
                        LibelleClasse = c.String(nullable: false, maxLength: 10, storeType: "nvarchar"),
                        IdAnneeAcademique = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.IdClasse)
                .ForeignKey("dbo.AnneeAcademiques", t => t.IdAnneeAcademique, cascadeDelete: true)
                .Index(t => t.IdAnneeAcademique);
            
            CreateTable(
                "dbo.DetailsSyllabus",
                c => new
                    {
                        IdDetailsSyllabus = c.Int(nullable: false, identity: true),
                        SeanceSyllabus = c.String(nullable: false, maxLength: 10, storeType: "nvarchar"),
                        ContenuSyllabus = c.String(nullable: false, maxLength: 500, storeType: "nvarchar"),
                        SyllabusId = c.Int(),
                    })
                .PrimaryKey(t => t.IdDetailsSyllabus)
                .ForeignKey("dbo.Syllabus", t => t.SyllabusId)
                .Index(t => t.SyllabusId);
            
            CreateTable(
                "dbo.Syllabus",
                c => new
                    {
                        SyllabusId = c.Int(nullable: false, identity: true),
                        LibelleSyllabus = c.String(nullable: false, maxLength: 80, storeType: "nvarchar"),
                        DescriptionSyllabus = c.String(nullable: false, maxLength: 500, storeType: "nvarchar"),
                        VolumeHoraireSyllabus = c.Int(),
                        NiveauSyllabus = c.String(nullable: false, maxLength: 20, storeType: "nvarchar"),
                    })
                .PrimaryKey(t => t.SyllabusId);
            
            CreateTable(
                "dbo.Matieres",
                c => new
                    {
                        IdMatiere = c.Int(nullable: false, identity: true),
                        LibelleMatiere = c.String(nullable: false, maxLength: 200, storeType: "nvarchar"),
                        VolumeHoraireMatiere = c.Int(nullable: false),
                        Niveau = c.String(nullable: false, maxLength: 80, storeType: "nvarchar"),
                        SyllabusId = c.Int(),
                    })
                .PrimaryKey(t => t.IdMatiere)
                .ForeignKey("dbo.Syllabus", t => t.SyllabusId)
                .Index(t => t.SyllabusId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Matieres", "SyllabusId", "dbo.Syllabus");
            DropForeignKey("dbo.DetailsSyllabus", "SyllabusId", "dbo.Syllabus");
            DropForeignKey("dbo.Classes", "IdAnneeAcademique", "dbo.AnneeAcademiques");
            DropForeignKey("dbo.CahierTextes", "IdResponsableClasse", "dbo.Utilisateurs");
            DropIndex("dbo.Matieres", new[] { "SyllabusId" });
            DropIndex("dbo.DetailsSyllabus", new[] { "SyllabusId" });
            DropIndex("dbo.Classes", new[] { "IdAnneeAcademique" });
            DropIndex("dbo.CahierTextes", new[] { "IdResponsableClasse" });
            DropTable("dbo.Matieres");
            DropTable("dbo.Syllabus");
            DropTable("dbo.DetailsSyllabus");
            DropTable("dbo.Classes");
            DropTable("dbo.Utilisateurs");
            DropTable("dbo.CahierTextes");
            DropTable("dbo.AnneeAcademiques");
        }
    }
}
