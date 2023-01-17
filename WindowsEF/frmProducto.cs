using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsEF.Dac;
using WindowsEF.Models;

namespace WindowsEF
{
    public partial class frmProducto : Form
    {
        public frmProducto()
        {
            InitializeComponent();
        }

        private void frmProducto_Load(object sender, EventArgs e)
        {
            MostrarTodosProductos();
        }

        private void MostrarTodosProductos()
        {
            grdProducto.DataSource = AbmProducto.SelectAll();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            Producto producto = new Producto()
            {
                Nombre = txtNombre.Text,
                Precio = Convert.ToDecimal(txtPrecio.Text),
                LineaProducto = txtLineaProducto.Text,

            };

            int filasAfectadas = AbmProducto.Insert(producto);

            if (filasAfectadas > 0)
            {
                lblMsjInsertar.ForeColor = Color.Green;
                lblMsjInsertar.Text = "Insert ok";
                Limpiar();
                MostrarTodosProductos();

            }
            else
            {
                lblMsjInsertar.ForeColor = Color.Red;
                lblMsjInsertar.Text = "Error al insertar";
            }

        }

        private void Limpiar()
        {
            txtNombre.Text = "";
            txtId.Text = "";
        }

        private void btModificar_Click(object sender, EventArgs e)
        {
            Producto producto = new Producto()
            {
                ProductoId = Convert.ToInt32(txtId.Text),
                Nombre = txtNombre.Text,
                Precio = Convert.ToDecimal(txtPrecio.Text),
                LineaProducto = txtLineaProducto.Text,

            };
            

            int filasAfectadas = AbmProducto.Update(producto);

            if (filasAfectadas > 0)
            {
                lblMsjModificar.ForeColor = Color.Green;
                lblMsjModificar.Text = "Update ok";
                Limpiar();
                MostrarTodosProductos();

            }
            else
            {
                lblMsjModificar.ForeColor = Color.Red;
                lblMsjModificar.Text = "Error al actualizar";
            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Producto producto = new Producto()
            {
                ProductoId = Convert.ToInt32(txtId.Text),
                Nombre = txtNombre.Text,
                Precio = Convert.ToDecimal(txtPrecio.Text),
                LineaProducto = txtLineaProducto.Text,

            };

            int filasAfectadas = AbmProducto.Delete(producto);

            if (filasAfectadas > 0)
            {
                lblMsjEliminar.ForeColor = Color.Green;
                lblMsjEliminar.Text = "Delete ok";
                Limpiar();
                MostrarTodosProductos();

            }
            else
            {
                lblMsjEliminar.ForeColor = Color.Red;
                lblMsjEliminar.Text = "Error al eliminar";
            }

        }

        private void btnBuscarPorId_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtId.Text);

            Producto producto = AbmProducto.SelectWhereById(id);
            Limpiar();

            lblBuscarPorId.Text = "Nombre: " + producto.Nombre;

        }
    }
}
