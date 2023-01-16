namespace WindowsEF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class relacionarTablas : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Producto", "categoria_Id", c => c.Int());
            CreateIndex("dbo.Producto", "categoria_Id");
            AddForeignKey("dbo.Producto", "categoria_Id", "dbo.Categoria", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Producto", "categoria_Id", "dbo.Categoria");
            DropIndex("dbo.Producto", new[] { "categoria_Id" });
            DropColumn("dbo.Producto", "categoria_Id");
        }
    }
}
