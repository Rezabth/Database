namespace ZooApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Animalrace : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Animals", "Race", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Animals", "Race");
        }
    }
}
