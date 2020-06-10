namespace OnlineBooksStore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class newmigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Genres",
                c => new
                    {
                        Id = c.Byte(nullable: false),
                        Name = c.String(nullable: false, maxLength: 255),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Books", "ReleaseDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Books", "DateAdded", c => c.DateTime(nullable: false));
            AddColumn("dbo.Books", "Stock", c => c.Int(nullable: false));
            AddColumn("dbo.Books", "Genre_Id", c => c.Byte());
            AlterColumn("dbo.Books", "Name", c => c.String(nullable: false, maxLength: 255));
            CreateIndex("dbo.Books", "Genre_Id");
            AddForeignKey("dbo.Books", "Genre_Id", "dbo.Genres", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Books", "Genre_Id", "dbo.Genres");
            DropIndex("dbo.Books", new[] { "Genre_Id" });
            AlterColumn("dbo.Books", "Name", c => c.String());
            DropColumn("dbo.Books", "Genre_Id");
            DropColumn("dbo.Books", "Stock");
            DropColumn("dbo.Books", "DateAdded");
            DropColumn("dbo.Books", "ReleaseDate");
            DropTable("dbo.Genres");
        }
    }
}
