namespace WBY.Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class substancevehicle : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.SubstanceVehicle",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        Name = c.String(),
                        SubstanceId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Substance", t => t.SubstanceId, cascadeDelete: true)
                .Index(t => t.SubstanceId);
            
        }
        
        public override void Down()
        {
            DropIndex("dbo.SubstanceVehicle", new[] { "SubstanceId" });
            DropForeignKey("dbo.SubstanceVehicle", "SubstanceId", "dbo.Substance");
            DropTable("dbo.SubstanceVehicle");
        }
    }
}
