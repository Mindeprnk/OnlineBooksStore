namespace OnlineBooksStore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class BooksTable : DbMigration
    {
        public override void Up()
        {

            CreateTable(
               "dbo.Books",
               c => new
               {
                   Id = c.Int(nullable: false, identity: true),
                   Name = c.String(nullable: false, maxLength: 255),
                   GenreId = c.Byte(nullable: false),
                   DateAdded = c.DateTime(nullable: false),
                   ReleaseDate = c.DateTime(nullable: false),
                   NumberInStock = c.Byte(nullable: false),
               })
               .PrimaryKey(t => t.Id)
               .ForeignKey("dbo.Genres", t => t.GenreId, cascadeDelete: true)
               .Index(t => t.GenreId);

        }


        public override void Down()
        {
            DropForeignKey("dbo.Books", "GenreId", "dbo.Genres");
            DropIndex("dbo.Books", new[] { "GenreId" });
            DropTable("dbo.Books");
        }
    }
}
