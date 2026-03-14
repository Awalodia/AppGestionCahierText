namespace AppCahierText.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class test : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Utilisateurs", "Identifiant");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Utilisateurs", "Identifiant", c => c.String(unicode: false));
        }
    }
}