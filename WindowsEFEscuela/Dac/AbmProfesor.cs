using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsEFEscuela.Data;
using WindowsEFEscuela.Models;

namespace WindowsEFEscuela.Dac
{
    public class AbmProfesor
    {
        private static DBEscuelaContext context = new DBEscuelaContext();

        public static List<Profesor> SelectAll()
        {
            return context.Profesores.ToList();
        }

        public static Profesor SelectWhereById(int id)
        {
            return context.Profesores.Find(id);
        }

        public static int Insert(Profesor profesor)
        {
            context.Profesores.Add(profesor);
            return context.SaveChanges();
        }

        public static int Update(Profesor profesor)
        {
            Profesor profesorOriginal = context.Profesores.Find(profesor.ProfesorId);

            profesorOriginal.Nombre = profesor.Nombre;
            profesorOriginal.Apellido = profesor.Apellido;
            profesorOriginal.Titulo = profesor.Titulo;
            return context.SaveChanges();

        }

        public static int Delete(Profesor profesor)
        {
            Profesor profesorOriginal = context.Profesores.Find(profesor.ProfesorId);
            if (profesorOriginal != null)
            {
                context.Profesores.Remove(profesor);
                return context.SaveChanges();

            }
            return 0;

        }
    }
}
