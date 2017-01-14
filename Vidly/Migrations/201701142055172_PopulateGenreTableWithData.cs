namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateGenreTableWithData : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO GenreTypes (Id, Genre) VALUES (1, 'Action')");
            Sql("INSERT INTO GenreTypes (Id, Genre) VALUES (2, 'Thriller')");
            Sql("INSERT INTO GenreTypes (Id, Genre) VALUES (3, 'Family')");
            Sql("INSERT INTO GenreTypes (Id, Genre) VALUES (4, 'Romance')");
            Sql("INSERT INTO GenreTypes (Id, Genre) VALUES (5, 'Comedy')");
        }
        
        public override void Down()
        {
        }
    }
}
