namespace CodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateMusterisTable2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.musteris", "musteri_unvan", c => c.String());
            DropColumn("dbo.musteris", "musteri_unvanlar");
        }
        
        public override void Down()
        {
            AddColumn("dbo.musteris", "musteri_unvanlar", c => c.String());
            DropColumn("dbo.musteris", "musteri_unvan");
        }
    }
}
