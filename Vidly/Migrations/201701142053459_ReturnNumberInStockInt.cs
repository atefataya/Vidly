namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ReturnNumberInStockInt : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Movies", "GenreType_Id", "dbo.GenreTypes");
            DropIndex("dbo.Movies", new[] { "GenreType_Id" });
            AlterColumn("dbo.Movies", "Name", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.Movies", "GenreType_Id", c => c.Byte(nullable: false));
            AlterColumn("dbo.GenreTypes", "Genre", c => c.String(nullable: false, maxLength: 255));
            CreateIndex("dbo.Movies", "GenreType_Id");
            AddForeignKey("dbo.Movies", "GenreType_Id", "dbo.GenreTypes", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Movies", "GenreType_Id", "dbo.GenreTypes");
            DropIndex("dbo.Movies", new[] { "GenreType_Id" });
            AlterColumn("dbo.GenreTypes", "Genre", c => c.String());
            AlterColumn("dbo.Movies", "GenreType_Id", c => c.Byte());
            AlterColumn("dbo.Movies", "Name", c => c.String());
            CreateIndex("dbo.Movies", "GenreType_Id");
            AddForeignKey("dbo.Movies", "GenreType_Id", "dbo.GenreTypes", "Id");
        }
    }
}
