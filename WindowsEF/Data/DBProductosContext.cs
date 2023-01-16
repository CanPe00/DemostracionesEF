using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsEF.Models;

namespace WindowsEF.Data
{
    public class DBProductosContext:DbContext
    {
        //Constructor
        public DBProductosContext():base("KeyDB"){ }

        //Propiedades DBSETS
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Producto> Productos { get; set; }

    }
}
