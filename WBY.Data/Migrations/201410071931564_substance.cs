namespace WBY.Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class substance : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Substance",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        Name = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Substance");
        }
    }
}
