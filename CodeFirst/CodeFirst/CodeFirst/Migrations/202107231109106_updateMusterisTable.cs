namespace CodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateMusterisTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.musteris", "sehir", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.musteris", "sehir");
        }
    }
}
