namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMembershipTypes2 : DbMigration
    {
        public override void Up()
        {
            Sql("Delete from MemberShipTypes");
            Sql("Insert INTO MemberShipTypes (Id, Name, SignUpFee, DurationInMonth, DiscountRate) Values (1, 'Pay as You Go', 0, 0, 0)");
            Sql("Insert INTO MemberShipTypes (Id, Name, SignUpFee, DurationInMonth, DiscountRate) Values (2, 'Monthly', 30, 1, 10)");
            Sql("Insert INTO MemberShipTypes (Id, Name, SignUpFee, DurationInMonth, DiscountRate) Values (3, 'Quarterly', 90, 3, 15)");
            Sql("Insert INTO MemberShipTypes (Id, Name, SignUpFee, DurationInMonth, DiscountRate) Values (4, 'Annual', 300, 12, 20)");
        }
        
        public override void Down()
        {
        }
    }
}
