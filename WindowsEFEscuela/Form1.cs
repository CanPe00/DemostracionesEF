using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsEFEscuela.Dac;
using WindowsEFEscuela.Models;

namespace WindowsEFEscuela
{
    public partial class frmAlumnos : Form
    {
        public frmAlumnos()
        {
            InitializeComponent();
        }

        private void frmAlumnos_Load_1(object sender, EventArgs e)
        {
            MostrarTodosAlumnos();
            
            List<Profesor> profesores = AbmProfesor.SelectAll();
            foreach (Profesor profesor in profesores)
            {
                cboProfesor.Items.Add(profesor.Nombre);

            }
            //cboProfesor.DataSource = AbmProfesor.SelectAll();

        }

        private void MostrarTodosAlumnos()
        {
            grdAlumnos.DataSource=AbmAlumno.SelectAll();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            if (validarInsert())
            {
                Alumno alumno = new Alumno()
                {
                    Nombre = txtNombre.Text,
                    Apellido = txtApellido.Text,
                    FechaNacimiento = dtpFechaNac.Value.Date,

                    ProfesorId = cboProfesor.SelectedIndex + 1
                };


                int filasAfectadas = AbmAlumno.Insert(alumno);

                if (filasAfectadas > 0)
                {
                    lblMsjInsertar.ForeColor = Color.Green;
                    lblMsjInsertar.Text = "Insert ok";
                    Limpiar();
                    MostrarTodosAlumnos();

                }
                else
                {
                    lblMsjInsertar.ForeColor = Color.Red;
                    lblMsjInsertar.Text = "Error al insertar";
                }

            }
            else
            {
                MessageBox.Show("Debe completar todos los datos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private bool validarInsert()
        {
            if (txtNombre.Text == "")
            { return false; }
            else if (txtApellido.Text == "")
            { return false; }
            else if (cboProfesor.SelectedIndex == -1)
            { return false; }
            return true;
        }

        private void Limpiar()
        {
            txtNombre.Text = "";
            txtId.Text = "";
            txtApellido.Text = "";
            
        }

        private void btModificar_Click(object sender, EventArgs e)
        {
            if (validar())
            {
                Alumno alumno = new Alumno()
                {
                    Nombre = txtNombre.Text,
                    Apellido = txtApellido.Text,
                    FechaNacimiento = dtpFechaNac.Value,
                    ProfesorId = cboProfesor.SelectedIndex + 1,
                    IdAlumno = Convert.ToInt32(txtId.Text)
                };



                int filasAfectadas = AbmAlumno.Update(alumno);

                if (filasAfectadas > 0)
                {
                    lblMsjModificar.ForeColor = Color.Green;
                    lblMsjModificar.Text = "Update ok";
                    Limpiar();
                    MostrarTodosAlumnos();

                }
                else
                {
                    lblMsjModificar.ForeColor = Color.Red;
                    lblMsjModificar.Text = "Error al actualizar";
                }

            }
            else
            {
                MessageBox.Show("Debe completar todos los datos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private bool validar()
        {
            if (txtNombre.Text=="")
            { return false; }
            else if (txtId.Text == "")
            { return false; }
            else if(txtApellido.Text=="")
            { return false; }
            else if(cboProfesor.SelectedIndex == -1)
            { return false; }
            return true;

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (validar())
            {
                Alumno alumno = new Alumno()
                {
                    Nombre = txtNombre.Text,
                    Apellido = txtApellido.Text,
                    FechaNacimiento = dtpFechaNac.Value,
                    ProfesorId = cboProfesor.SelectedIndex + 1,
                    IdAlumno = Convert.ToInt32(txtId.Text)
                };

                int filasAfectadas = AbmAlumno.Delete(alumno);

                if (filasAfectadas > 0)
                {
                    lblMsjEliminar.ForeColor = Color.Green;
                    lblMsjEliminar.Text = "Delete ok";
                    Limpiar();
                    MostrarTodosAlumnos();

                }
                else
                {
                    lblMsjEliminar.ForeColor = Color.Red;
                    lblMsjEliminar.Text = "Error al eliminar";
                }

            }
            else
            {
                MessageBox.Show("Debe completar todos los datos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnBuscarPorId_Click(object sender, EventArgs e)
        {
            if (txtId.Text!= "")
            {
                int id = Convert.ToInt32(txtId.Text);

                Alumno alumno = AbmAlumno.SelectWhereById(id);
                Limpiar();

                lblBuscarPorId.Text = "Nombre: " + alumno.Nombre;
            }
            else
            {
                MessageBox.Show("Debe ingresar ID","ERROR",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void grdAlumnos_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = grdAlumnos.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtNombre.Text = grdAlumnos.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtApellido.Text = grdAlumnos.Rows[e.RowIndex].Cells[2].Value.ToString();
            dtpFechaNac.Value = (DateTime)grdAlumnos.Rows[e.RowIndex].Cells[3].Value;
            cboProfesor.SelectedIndex = (int) grdAlumnos.Rows[e.RowIndex].Cells[5].Value - 1 ;

        }
    }
}
