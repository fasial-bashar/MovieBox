namespace MovieBox.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Actor",
                c => new
                    {
                        Actor_ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Age = c.String(),
                    })
                .PrimaryKey(t => t.Actor_ID);
            
            CreateTable(
                "dbo.Movie",
                c => new
                    {
                        Movie_ID = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Director = c.String(),
                        ReleaseDate = c.DateTime(nullable: false),
                        Genre = c.String(),
                        Price = c.String(),
                        Actor_Actor_ID = c.Int(),
                        Sale_Sale_ID = c.Int(),
                        ComingSoon_Movie_ID = c.Int(),
                    })
                .PrimaryKey(t => t.Movie_ID)
                .ForeignKey("dbo.Actor", t => t.Actor_Actor_ID)
                .ForeignKey("dbo.Sale", t => t.Sale_Sale_ID)
                .ForeignKey("dbo.ComingSoon", t => t.ComingSoon_Movie_ID)
                .Index(t => t.Actor_Actor_ID)
                .Index(t => t.Sale_Sale_ID)
                .Index(t => t.ComingSoon_Movie_ID);
            
            CreateTable(
                "dbo.Sale",
                c => new
                    {
                        Sale_ID = c.Int(nullable: false, identity: true),
                        MovieName = c.String(),
                        Price = c.String(),
                    })
                .PrimaryKey(t => t.Sale_ID);
            
            CreateTable(
                "dbo.ComingSoon",
                c => new
                    {
                        Movie_ID = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Director = c.String(),
                        ReleaseDate = c.DateTime(nullable: false),
                        Genre = c.String(),
                        Actor_Actor_ID = c.Int(),
                        Sale_Sale_ID = c.Int(),
                    })
                .PrimaryKey(t => t.Movie_ID)
                .ForeignKey("dbo.Actor", t => t.Actor_Actor_ID)
                .ForeignKey("dbo.Sale", t => t.Sale_Sale_ID)
                .Index(t => t.Actor_Actor_ID)
                .Index(t => t.Sale_Sale_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ComingSoon", "Sale_Sale_ID", "dbo.Sale");
            DropForeignKey("dbo.Movie", "ComingSoon_Movie_ID", "dbo.ComingSoon");
            DropForeignKey("dbo.ComingSoon", "Actor_Actor_ID", "dbo.Actor");
            DropForeignKey("dbo.Movie", "Sale_Sale_ID", "dbo.Sale");
            DropForeignKey("dbo.Movie", "Actor_Actor_ID", "dbo.Actor");
            DropIndex("dbo.ComingSoon", new[] { "Sale_Sale_ID" });
            DropIndex("dbo.ComingSoon", new[] { "Actor_Actor_ID" });
            DropIndex("dbo.Movie", new[] { "ComingSoon_Movie_ID" });
            DropIndex("dbo.Movie", new[] { "Sale_Sale_ID" });
            DropIndex("dbo.Movie", new[] { "Actor_Actor_ID" });
            DropTable("dbo.ComingSoon");
            DropTable("dbo.Sale");
            DropTable("dbo.Movie");
            DropTable("dbo.Actor");
        }
    }
}
