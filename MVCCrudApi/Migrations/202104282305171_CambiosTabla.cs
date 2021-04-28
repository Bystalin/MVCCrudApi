namespace MVCCrudApi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CambiosTabla : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.people", "correo", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.people", "name", c => c.String(nullable: false, maxLength: 100, unicode: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.people", "name", c => c.String(nullable: false, maxLength: 50, unicode: false));
            DropColumn("dbo.people", "correo");
        }
    }
}
