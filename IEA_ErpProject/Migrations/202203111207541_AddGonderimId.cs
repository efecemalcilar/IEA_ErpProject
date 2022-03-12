namespace IEA_ErpProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddGonderimId : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.tblKonsinyeGonderimler", "GonderimId", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.tblKonsinyeGonderimler", "GonderimId");
        }
    }
}
