namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CustomerModelChanged : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MemberShipTypes",
                c => new
                    {
                        Id = c.Byte(nullable: false),
                        SignUpFee = c.Short(nullable: false),
                        DurationInMonth = c.Byte(nullable: false),
                        DiscountRate = c.Byte(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Customers", "IsSubscribedToNewLetter", c => c.Boolean(nullable: false));
            AddColumn("dbo.Customers", "MemberShipTypeId", c => c.Short(nullable: false));
            AddColumn("dbo.Customers", "MemberShipType_Id", c => c.Byte());
            CreateIndex("dbo.Customers", "MemberShipType_Id");
            AddForeignKey("dbo.Customers", "MemberShipType_Id", "dbo.MemberShipTypes", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Customers", "MemberShipType_Id", "dbo.MemberShipTypes");
            DropIndex("dbo.Customers", new[] { "MemberShipType_Id" });
            DropColumn("dbo.Customers", "MemberShipType_Id");
            DropColumn("dbo.Customers", "MemberShipTypeId");
            DropColumn("dbo.Customers", "IsSubscribedToNewLetter");
            DropTable("dbo.MemberShipTypes");
        }
    }
}
