namespace AppCahierText.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateClasse : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Utilisateurs", "Profil", c => c.String(nullable: false, maxLength: 50, storeType: "nvarchar"));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Utilisateurs", "Profil");
        }
    }
}
