namespace WindowsEFEscuela.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class correcciones2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Aula", "Capacidad", c => c.Int(nullable: false));
            AlterColumn("dbo.Aula", "Codigo", c => c.String(nullable: false, maxLength: 1, fixedLength: true, unicode: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Aula", "Codigo", c => c.String(maxLength: 1, fixedLength: true, unicode: false));
            AlterColumn("dbo.Aula", "Capacidad", c => c.Int());
        }
    }
}
