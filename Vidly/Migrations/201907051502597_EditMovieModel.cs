namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EditMovieModel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "ReleasedDateTime", c => c.DateTime(nullable: false));
            AddColumn("dbo.Movies", "AddedDateTime", c => c.DateTime(nullable: false));
            AddColumn("dbo.Movies", "NumberInStock", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Movies", "NumberInStock");
            DropColumn("dbo.Movies", "AddedDateTime");
            DropColumn("dbo.Movies", "ReleasedDateTime");
        }
    }
}
