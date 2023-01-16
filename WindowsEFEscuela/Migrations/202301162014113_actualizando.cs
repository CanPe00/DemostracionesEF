namespace WindowsEFEscuela.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class actualizando : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Docente", "Titulo", c => c.String(nullable: false, maxLength: 50, unicode: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Docente", "Titulo");
        }
    }
}
