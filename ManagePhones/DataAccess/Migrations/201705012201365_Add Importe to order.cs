namespace ManagePhones.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddImportetoorder : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.RepairOrder", "Importe", c => c.Single());
            DropColumn("dbo.RepairOrder", "NroOrden");
        }
        
        public override void Down()
        {
            AddColumn("dbo.RepairOrder", "NroOrden", c => c.Int(nullable: false));
            DropColumn("dbo.RepairOrder", "Importe");
        }
    }
}
