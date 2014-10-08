namespace WBY.Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class userprofilehistory : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.UserProfileHistory",
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
            DropIndex("dbo.UserProfileHistory", new[] { "UserProfileId" });
            DropForeignKey("dbo.UserProfileHistory", "UserProfileId", "dbo.UserProfile");
            DropTable("dbo.UserProfileHistory");
        }
    }
}
