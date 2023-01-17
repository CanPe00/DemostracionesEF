using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsEF.Data;
using WindowsEF.Models;

namespace WindowsEF.Dac
{
    public static class AbmCategoria
    {
        //Creamo instancia de nuestro DBContext
        private static DBProductosContext context = new DBProductosContext(); 
        public static List<Categoria> SelectAll()
        {
            return context.Categorias.ToList();
        }

        public static Categoria SelectWhereById(int id)
        {
            return context.Categorias.Find(id);
        }

        public static int Insert(Categoria categoria)
        {
            context.Categorias.Add(categoria);
            return context.SaveChanges();
        }

        public static int Update(Categoria categoria)
        {
            Categoria categoriaOrigen = context.Categorias.Find(categoria.Id);
            categoriaOrigen.Nombre = categoria.Nombre;
            return context.SaveChanges();
        }

        public static int Delete(Categoria categoria)
        {
            Categoria categoriaOrigen = context.Categorias.Find(categoria.Id);
            if (categoriaOrigen != null)
            {
                context.Categorias.Remove(categoriaOrigen);
                return context.SaveChanges();
            }

            return 0;
        }
    }
}
