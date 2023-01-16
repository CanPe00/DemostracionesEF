using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsEFEscuela.Models;

namespace WindowsEFEscuela.Data
{
    public class DBEscuelaContext:DbContext
    {
        public DBEscuelaContext() : base("KeyDB") { }

        //Propiedades DBSETS
        public DbSet<Alumno> Alumnos { get; set; }
        public DbSet<Profesor> Profesores { get; set; }

        public DbSet<Aula> Aulas { get; set; }
        public DbSet<Materia> Materias { get; set; }
    }
}
