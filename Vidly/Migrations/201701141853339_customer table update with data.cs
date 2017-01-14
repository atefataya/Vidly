namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class customertableupdatewithdata : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Movies", "Year");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Movies", "Year", c => c.String());
        }
    }
}
