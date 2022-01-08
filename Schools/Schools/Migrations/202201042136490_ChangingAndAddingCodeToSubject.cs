namespace Schools.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangingAndAddingCodeToSubject : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Subjects", "Code", c => c.String());
            DropColumn("dbo.Subjects", "Name");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Subjects", "Name", c => c.String());
            DropColumn("dbo.Subjects", "Code");
        }
    }
}
