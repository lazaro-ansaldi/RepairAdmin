namespace DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Reset : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cliente",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Apellido = c.String(),
                        Nombre = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Marca",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Modelo",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                        Descripcion = c.String(),
                        Marca_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Marca", t => t.Marca_Id)
                .Index(t => t.Marca_Id);
            
            CreateTable(
                "dbo.Phone",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Imei = c.String(),
                        Descripcion = c.String(),
                        Modelo_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Modelo", t => t.Modelo_Id)
                .Index(t => t.Modelo_Id);
            
            CreateTable(
                "dbo.RepairOrder",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IsSd = c.Boolean(nullable: false),
                        IsSim = c.Boolean(nullable: false),
                        FechaEgreso = c.DateTime(),
                        FechaIngreso = c.DateTime(nullable: false),
                        NroOrden = c.Int(nullable: false),
                        Phone_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Phone", t => t.Phone_Id)
                .Index(t => t.Phone_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.RepairOrder", "Phone_Id", "dbo.Phone");
            DropForeignKey("dbo.Phone", "Modelo_Id", "dbo.Modelo");
            DropForeignKey("dbo.Modelo", "Marca_Id", "dbo.Marca");
            DropIndex("dbo.RepairOrder", new[] { "Phone_Id" });
            DropIndex("dbo.Phone", new[] { "Modelo_Id" });
            DropIndex("dbo.Modelo", new[] { "Marca_Id" });
            DropTable("dbo.RepairOrder");
            DropTable("dbo.Phone");
            DropTable("dbo.Modelo");
            DropTable("dbo.Marca");
            DropTable("dbo.Cliente");
        }
    }
}
