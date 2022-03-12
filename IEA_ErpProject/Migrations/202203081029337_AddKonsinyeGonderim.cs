namespace IEA_ErpProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddKonsinyeGonderim : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.tblKonsinyeGonderimler",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CariTur = c.String(maxLength: 15),
                        CariAdi = c.String(maxLength: 200),
                        CariId = c.String(),
                        GonderimTarih = c.DateTime(nullable: false),
                        Aciklama = c.String(maxLength: 250),
                        UrunId = c.Int(nullable: false),
                        Adet = c.Int(nullable: false),
                        isDeleted = c.Boolean(nullable: false),
                        CreatedUser = c.Int(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        UpdatedUser = c.Int(nullable: false),
                        UpdatedDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.tblKonsinyeGonderimler");
        }
    }
}
