using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsEF.Data;
using WindowsEF.Models;

namespace WindowsEF.Dac
{
    public static class AbmProducto
    {
        private static DBProductosContext context = new DBProductosContext();
        public static List<Producto> SelectAll()
        {
            return context.Productos.ToList();
        }

        public static Producto SelectWhereById(int id)
        {
            return context.Productos.Find(id);
        }

        public static int Insert(Producto producto)
        {
            context.Productos.Add(producto);
            return context.SaveChanges();
        }

        public static int Update(Producto producto)
        {
            Producto productoOrigen = context.Productos.Find(producto.ProductoId);
            productoOrigen.Nombre = producto.Nombre;
            productoOrigen.Precio= producto.Precio;
            productoOrigen.LineaProducto = producto.LineaProducto;
            productoOrigen.CategoriaId = producto.CategoriaId;
            return context.SaveChanges();
        }

        public static int Delete(Producto producto)
        {
            Producto productoOrigen = context.Productos.Find(producto.ProductoId);
            if (productoOrigen != null)
            {
                context.Productos.Remove(productoOrigen);
                return context.SaveChanges();
            }

            return 0;
        }
    }
}
