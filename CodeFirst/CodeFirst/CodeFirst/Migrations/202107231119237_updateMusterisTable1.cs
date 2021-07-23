namespace CodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateMusterisTable1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.musteris", "musteri_unvan", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.musteris", "musteri_unvan");
        }
    }
}
