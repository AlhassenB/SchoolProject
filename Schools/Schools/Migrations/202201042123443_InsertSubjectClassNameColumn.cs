using System;
using System.Data.Entity.Migrations;

namespace Schools.Migrations
{
    public partial class InsertSubjectClassNameColumn : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Subjects", "SubjectClassName", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Subjects", "SubjectClassName");
        }
    }
}
