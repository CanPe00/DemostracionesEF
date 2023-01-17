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
    public partial class frmCategoria : Form
    {
        

        public frmCategoria()
        {
            InitializeComponent();
        }

        private void frmCategoria_Load(object sender, EventArgs e)
        {
            MostrarTodasCategorias();
        }

        private void MostrarTodasCategorias()
        {
            grdCategoria.DataSource = AbmCategoria.SelectAll();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            Categoria categoria = new Categoria() {
                Nombre = txtNombre.Text
            };

            int filasAfectadas = AbmCategoria.Insert(categoria);

            if (filasAfectadas>0)
            {
                lblMsjInsertar.ForeColor = Color.Green;
                lblMsjInsertar.Text = "Insert ok";
                Limpiar();
                MostrarTodasCategorias();

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
            Categoria categoria = new Categoria()
            {
                Nombre = txtNombre.Text,
                Id = Convert.ToInt32(txtId.Text)
            };

            int filasAfectadas = AbmCategoria.Update(categoria);

            if (filasAfectadas > 0)
            {
                lblMsjModificar.ForeColor = Color.Green;
                lblMsjModificar.Text = "Update ok";
                Limpiar();
                MostrarTodasCategorias();

            }
            else
            {
                lblMsjModificar.ForeColor = Color.Red;
                lblMsjModificar.Text = "Error al actualizar";
            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Categoria categoria = new Categoria()
            {
                Nombre = txtNombre.Text,
                Id=Convert.ToInt32(txtId.Text)
            };

            int filasAfectadas = AbmCategoria.Delete(categoria);

            if (filasAfectadas > 0)
            {
                lblMsjEliminar.ForeColor = Color.Green;
                lblMsjEliminar.Text = "Delete ok";
                Limpiar();
                MostrarTodasCategorias();

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

            Categoria categoria = AbmCategoria.SelectWhereById(id);
            Limpiar();

            lblBuscarPorId.Text = "Nombre: " + categoria.Nombre;
        }

        private void grdCategoria_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
            txtId.Text = grdCategoria.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtNombre.Text = grdCategoria.Rows[e.RowIndex].Cells[1].Value.ToString();
        }
    }
}
