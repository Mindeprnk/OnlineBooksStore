namespace OnlineBooksStore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingValuestoBookClass : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Books", "Genre_Id", "dbo.Genres");
            DropIndex("dbo.Books", new[] { "Genre_Id" });
            RenameColumn(table: "dbo.Books", name: "Genre_Id", newName: "GenreId");
            AddColumn("dbo.Books", "NumberInStock", c => c.Byte(nullable: false));
            AlterColumn("dbo.Books", "GenreId", c => c.Byte(nullable: false));
            CreateIndex("dbo.Books", "GenreId");
            AddForeignKey("dbo.Books", "GenreId", "dbo.Genres", "Id", cascadeDelete: true);
            DropColumn("dbo.Books", "Stock");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Books", "Stock", c => c.Int(nullable: false));
            DropForeignKey("dbo.Books", "GenreId", "dbo.Genres");
            DropIndex("dbo.Books", new[] { "GenreId" });
            AlterColumn("dbo.Books", "GenreId", c => c.Byte());
            DropColumn("dbo.Books", "NumberInStock");
            RenameColumn(table: "dbo.Books", name: "GenreId", newName: "Genre_Id");
            CreateIndex("dbo.Books", "Genre_Id");
            AddForeignKey("dbo.Books", "Genre_Id", "dbo.Genres", "Id");
        }
    }
}
