namespace ZooApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Enförstamigrering : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Animals",
                c => new
                    {
                        AnimalId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.AnimalId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Animals");
        }
    }
}
