namespace ManagePhones.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Orderattributes : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.RepairOrder", "Cliente_Id", c => c.Int());
            CreateIndex("dbo.RepairOrder", "Cliente_Id");
            AddForeignKey("dbo.RepairOrder", "Cliente_Id", "dbo.Cliente", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.RepairOrder", "Cliente_Id", "dbo.Cliente");
            DropIndex("dbo.RepairOrder", new[] { "Cliente_Id" });
            DropColumn("dbo.RepairOrder", "Cliente_Id");
        }
    }
}
