namespace WindowsEFEscuela.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class correcciones : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Aula", "Codigo", c => c.String(maxLength: 1, fixedLength: true, unicode: false));
            DropColumn("dbo.Materia", "Codigo");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Materia", "Codigo", c => c.String(nullable: false, maxLength: 1, fixedLength: true, unicode: false));
            AlterColumn("dbo.Aula", "Codigo", c => c.String(nullable: false, maxLength: 1, fixedLength: true, unicode: false));
        }
    }
}
