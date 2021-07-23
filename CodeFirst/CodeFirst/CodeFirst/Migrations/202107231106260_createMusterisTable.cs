namespace CodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class createMusterisTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.musteris",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        musteri_ad = c.String(),
                        musteri_soyad = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.musteris");
        }
    }
}
