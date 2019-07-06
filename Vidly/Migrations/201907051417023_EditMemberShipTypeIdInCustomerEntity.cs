namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EditMemberShipTypeIdInCustomerEntity : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Customers", "MemberShipType_Id", "dbo.MemberShipTypes");
            DropIndex("dbo.Customers", new[] { "MemberShipType_Id" });
            DropColumn("dbo.Customers", "MemberShipTypeId");
            RenameColumn(table: "dbo.Customers", name: "MemberShipType_Id", newName: "MemberShipTypeId");
            AlterColumn("dbo.Customers", "MemberShipTypeId", c => c.Byte(nullable: false));
            AlterColumn("dbo.Customers", "MemberShipTypeId", c => c.Byte(nullable: false));
            CreateIndex("dbo.Customers", "MemberShipTypeId");
            AddForeignKey("dbo.Customers", "MemberShipTypeId", "dbo.MemberShipTypes", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Customers", "MemberShipTypeId", "dbo.MemberShipTypes");
            DropIndex("dbo.Customers", new[] { "MemberShipTypeId" });
            AlterColumn("dbo.Customers", "MemberShipTypeId", c => c.Byte());
            AlterColumn("dbo.Customers", "MemberShipTypeId", c => c.Short(nullable: false));
            RenameColumn(table: "dbo.Customers", name: "MemberShipTypeId", newName: "MemberShipType_Id");
            AddColumn("dbo.Customers", "MemberShipTypeId", c => c.Short(nullable: false));
            CreateIndex("dbo.Customers", "MemberShipType_Id");
            AddForeignKey("dbo.Customers", "MemberShipType_Id", "dbo.MemberShipTypes", "Id");
        }
    }
}
