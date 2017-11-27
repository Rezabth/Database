namespace ZooApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AnimalKeeper : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Keepers",
                c => new
                    {
                        KeeperId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.KeeperId);
            
            AddColumn("dbo.Animals", "KeeperId", c => c.Int(nullable: false));
            CreateIndex("dbo.Animals", "KeeperId");
            AddForeignKey("dbo.Animals", "KeeperId", "dbo.Keepers", "KeeperId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Animals", "KeeperId", "dbo.Keepers");
            DropIndex("dbo.Animals", new[] { "KeeperId" });
            DropColumn("dbo.Animals", "KeeperId");
            DropTable("dbo.Keepers");
        }
    }
}
