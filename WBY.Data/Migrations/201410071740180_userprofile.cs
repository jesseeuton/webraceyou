namespace WBY.Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class userprofile : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.UserProfile",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.UserProfilePreference",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserProfileId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.UserProfile", t => t.UserProfileId, cascadeDelete: true)
                .Index(t => t.UserProfileId);
            
        }
        
        public override void Down()
        {
            DropIndex("dbo.UserProfilePreference", new[] { "UserProfileId" });
            DropForeignKey("dbo.UserProfilePreference", "UserProfileId", "dbo.UserProfile");
            DropTable("dbo.UserProfilePreference");
            DropTable("dbo.UserProfile");
        }
    }
}
