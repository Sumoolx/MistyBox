namespace Conn.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class deci : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("SCOTT.Nothing");
            AddColumn("SCOTT.Nothing", "Salary", c => c.Decimal(nullable: false, precision: 20, scale: 6));
            AlterColumn("SCOTT.Nothing", "Id", c => c.Decimal(nullable: false, precision: 10, scale: 0, identity: true));
            AddPrimaryKey("SCOTT.Nothing", "Id");
        }
        
        public override void Down()
        {
            DropPrimaryKey("SCOTT.Nothing");
            AlterColumn("SCOTT.Nothing", "Id", c => c.Int(nullable: false, identity: true));
            DropColumn("SCOTT.Nothing", "Salary");
            AddPrimaryKey("SCOTT.Nothing", "Id");
        }
    }
}
