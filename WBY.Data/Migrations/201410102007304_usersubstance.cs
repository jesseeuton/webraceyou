namespace WBY.Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class usersubstance : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.UserSubstance",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserProfileId = c.Int(nullable: false),
                        SubstanceId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Substance", t => t.SubstanceId, cascadeDelete: true)
                .ForeignKey("dbo.UserProfile", t => t.UserProfileId, cascadeDelete: true)
                .Index(t => t.UserProfileId)
                .Index(t => t.SubstanceId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.UserSubstance", "UserProfileId", "dbo.UserProfile");
            DropForeignKey("dbo.UserSubstance", "SubstanceId", "dbo.Substance");
            DropIndex("dbo.UserSubstance", new[] { "SubstanceId" });
            DropIndex("dbo.UserSubstance", new[] { "UserProfileId" });
            DropTable("dbo.UserSubstance");
        }
    }
}
