namespace Schools.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangingColorTOString : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Subjects", "ConvertedColor", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Subjects", "ConvertedColor");
        }
    }
}
