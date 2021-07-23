namespace CodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Urunlers",
                c => new
                    {
                        İd = c.Int(nullable: false, identity: true),
                        Urunad = c.String(),
                        marka = c.String(),
                        kategori = c.String(),
                        stok = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.İd);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Urunlers");
        }
    }
}
