namespace IEA_ErpProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateBaseEntity : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.tblKonsinyeGonderimler", "CreatedUser", c => c.String());
            AlterColumn("dbo.tblKonsinyeGonderimler", "CreatedDate", c => c.DateTime());
            AlterColumn("dbo.tblKonsinyeGonderimler", "UpdatedUser", c => c.String());
            AlterColumn("dbo.tblKonsinyeGonderimler", "UpdatedDate", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.tblKonsinyeGonderimler", "UpdatedDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.tblKonsinyeGonderimler", "UpdatedUser", c => c.Int(nullable: false));
            AlterColumn("dbo.tblKonsinyeGonderimler", "CreatedDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.tblKonsinyeGonderimler", "CreatedUser", c => c.Int(nullable: false));
        }
    }
}
