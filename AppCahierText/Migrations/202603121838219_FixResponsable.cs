namespace AppCahierText.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FixResponsable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Utilisateurs", "IdResponsable", c => c.Int());
            AddColumn("dbo.Utilisateurs", "IdClasse", c => c.Int());
            CreateIndex("dbo.Utilisateurs", "IdClasse");
            AddForeignKey("dbo.Utilisateurs", "IdClasse", "dbo.Classes", "IdClasse", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Utilisateurs", "IdClasse", "dbo.Classes");
            DropIndex("dbo.Utilisateurs", new[] { "IdClasse" });
            DropColumn("dbo.Utilisateurs", "IdClasse");
            DropColumn("dbo.Utilisateurs", "IdResponsable");
        }
    }
}
