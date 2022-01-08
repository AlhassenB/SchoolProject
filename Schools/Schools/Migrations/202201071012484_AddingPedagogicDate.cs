namespace Schools.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingPedagogicDate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Subjects", "PedagogicDate", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Subjects", "PedagogicDate");
        }
    }
}
