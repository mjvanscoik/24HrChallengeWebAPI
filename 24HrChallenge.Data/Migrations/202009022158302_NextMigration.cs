namespace _24HrChallenge.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NextMigration : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ApplicationUser", "FirstName", c => c.String());
            AddColumn("dbo.ApplicationUser", "LastName", c => c.String());
        }
        
        public override void Down()
        {
            AddColumn("dbo.Post", "ModifiedUtc", c => c.DateTimeOffset(precision: 7));
            AddColumn("dbo.Post", "CreatedUtc", c => c.DateTimeOffset(nullable: false, precision: 7));
        }
    }
}
