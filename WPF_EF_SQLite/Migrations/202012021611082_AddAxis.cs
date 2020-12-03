namespace WPF_EF_SQLite.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddAxis : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Axis",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Position = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Axis");
        }
    }
}
