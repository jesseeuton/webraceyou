namespace WBY.Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class substanceunit : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.SubstanceUnit",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.SubstanceVehicle", "CostPerUnit", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.SubstanceVehicle", "Name", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.SubstanceVehicle", "Name", c => c.String());
            DropColumn("dbo.SubstanceVehicle", "CostPerUnit");
            DropTable("dbo.SubstanceUnit");
        }
    }
}
