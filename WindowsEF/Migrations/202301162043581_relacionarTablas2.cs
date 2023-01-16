namespace WindowsEF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class relacionarTablas2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Producto", "categoria_Id", "dbo.Categoria");
            DropIndex("dbo.Producto", new[] { "categoria_Id" });
            RenameColumn(table: "dbo.Producto", name: "categoria_Id", newName: "CategoriaId");
            AlterColumn("dbo.Producto", "CategoriaId", c => c.Int(nullable: false));
            CreateIndex("dbo.Producto", "CategoriaId");
            AddForeignKey("dbo.Producto", "CategoriaId", "dbo.Categoria", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Producto", "CategoriaId", "dbo.Categoria");
            DropIndex("dbo.Producto", new[] { "CategoriaId" });
            AlterColumn("dbo.Producto", "CategoriaId", c => c.Int());
            RenameColumn(table: "dbo.Producto", name: "CategoriaId", newName: "categoria_Id");
            CreateIndex("dbo.Producto", "categoria_Id");
            AddForeignKey("dbo.Producto", "categoria_Id", "dbo.Categoria", "Id");
        }
    }
}
