namespace ZooApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AnimalEmail : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Animals", "Email", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Animals", "Email");
        }
    }
}
