using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsEFEscuela.Data;
using WindowsEFEscuela.Models;

namespace WindowsEFEscuela.Dac
{
    public class AbmAlumno
    {
        private static DBEscuelaContext context= new DBEscuelaContext();

        public static List<Alumno> SelectAll()
        {
            return context.Alumnos.ToList();
        }

        public static Alumno SelectWhereById(int id)
        {
            return context.Alumnos.Find(id);
        }

        public static int Insert(Alumno alumno)
        {
            context.Alumnos.Add(alumno);
            return context.SaveChanges();
        }

        public static int Update(Alumno alumno)
        {
            Alumno alumnoOriginal = context.Alumnos.Find(alumno.IdAlumno);
            alumnoOriginal.Nombre= alumno.Nombre;
            alumnoOriginal.Apellido= alumno.Apellido;
            alumnoOriginal.FechaNacimiento=alumno.FechaNacimiento;
            alumnoOriginal.ProfesorId= alumno.ProfesorId;
            return context.SaveChanges();

        }

        public static int Delete(Alumno alumno)
        {
            Alumno alumnoOriginal = context.Alumnos.Find(alumno.IdAlumno);
            if (alumnoOriginal!=null)
            {
                context.Alumnos.Remove(alumnoOriginal);
                return context.SaveChanges() ;

            }
            return 0;

        }
    }
}
