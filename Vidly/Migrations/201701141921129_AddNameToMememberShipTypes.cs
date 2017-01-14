using System.Data.Entity.Core.Metadata.Edm;

namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddNameToMememberShipTypes : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE MembershipTypes Set Name='Pay As You Go' Where Id = 1");
            Sql("UPDATE MembershipTypes Set Name='Monthly' Where Id = 2");
            Sql("UPDATE MembershipTypes Set Name='Quartly' Where Id = 3");
            Sql("UPDATE MembershipTypes Set Name='Yearly' Where Id = 4");
        }
        
        public override void Down()
        {
        }
    }
}
