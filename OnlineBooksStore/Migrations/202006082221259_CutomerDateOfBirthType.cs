namespace OnlineBooksStore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CutomerDateOfBirthType : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "Birthdate", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "Birthdate");
        }
    }
}
