namespace KitchenLogic.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCommit : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        UrlFriendlyName = c.String(),
                        Order = c.Int(nullable: false),
                        Enabled = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Ingredients",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        UrlFriendlyName = c.String(),
                        Description = c.String(),
                        Enabled = c.Boolean(nullable: false),
                        CategoryId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Categories", t => t.CategoryId, cascadeDelete: true)
                .Index(t => t.CategoryId);
            
            CreateTable(
                "dbo.Posts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        UrlFriendlyTitle = c.String(),
                        MainImage = c.String(),
                        Created = c.DateTime(nullable: false),
                        Author = c.String(),
                        Content = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Ingredients", "CategoryId", "dbo.Categories");
            DropIndex("dbo.Ingredients", new[] { "CategoryId" });
            DropTable("dbo.Posts");
            DropTable("dbo.Ingredients");
            DropTable("dbo.Categories");
        }
    }
}
