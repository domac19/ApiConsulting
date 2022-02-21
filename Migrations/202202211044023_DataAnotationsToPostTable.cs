namespace ApiConsulting.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DataAnotationsToPostTable : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Posts", "Title", c => c.String(nullable: false, maxLength: 500));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Posts", "Title", c => c.String());
        }
    }
}
