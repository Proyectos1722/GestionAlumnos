using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DAL.Models;

namespace GUI
{
    public partial class FrmGestionAlumnos : MaterialSkin.Controls.MaterialForm
    {
       Alumno alumno=new Alumno();
        public FrmGestionAlumnos()
        {
            InitializeComponent();
        }

        private void FrmGestionAlumnos_Load(object sender, EventArgs e)
        {
            cargarDatos();
        }
        public void cargarDatos()
        {
            using (GestionAlumnoEntities db=new GestionAlumnoEntities())
            {
                try
                {
                    dataGridView1.DataSource = db.Alumno.ToList();
                    cbxComboCiuda.DisplayMember = "NCiudad";
                    cbxComboCiuda.ValueMember = "idCiudad";
                    cbxComboCiuda.DataSource = CiudadesBLL.GetCiudades();
                }
                catch (Exception e) 
                {
                    MessageBox.Show("Ha ocurrido un Error:" +e.Message);
                }
               

            }
        }

        private void bntGUARDAR_Click(object sender, EventArgs e)
        {
            try
            {
                int ID = !string.IsNullOrEmpty(txtID.Text) ? Convert.ToInt16(txtID.Text) : 0;

               //if (ID == 0)//Cuando sea uno nuevo lo agrego
               if (ID == 0)
               
                {
                   
                    alumno.Nombre = Convert.ToString(txtNombre.Text);
                    alumno.Apellido = Convert.ToString(txtApellido.Text);
                    alumno.Nacionalidad = Convert.ToString(txtNacionalidad.Text);
                    alumno.Fecha_De_Nacimiento = txtFechaDeNacimiento.Value;
                    alumno.Edad = Convert.ToInt32(txtEdad.Text);
                    alumno.Procedencia = Convert.ToString(txtPrecedencia.Text);
                    AlumnosBLL.Crear(alumno);
                    


                }
                else //SOLO ACTUALIZO
                {
                   
                    alumno.ID = Convert.ToInt32(txtID.Text);
                    alumno.Nombre = Convert.ToString(txtNombre.Text);
                    alumno.Apellido = Convert.ToString(txtApellido.Text);
                    alumno.Nacionalidad = Convert.ToString(txtNacionalidad.Text);
                    alumno.Fecha_De_Nacimiento = txtFechaDeNacimiento.Value;
                    alumno.Edad = Convert.ToInt32(txtEdad.Text);
                    alumno.Procedencia = Convert.ToString(txtPrecedencia.Text);
                    AlumnosBLL.Actualizar(alumno);
                }
                MessageBox.Show("Datos Guardado");
                cargarDatos();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Algo no ha funcionado correctamente");
            }
        }

        private void bntELIMINAR_Click(object sender, EventArgs e)
        {
            try
            {
                
                DialogResult resp = MessageBox.Show("SEGURO QUE DESEAS ELIMIAR ESE REGISTRO", "CONFIRMACION", MessageBoxButtons.YesNo);
                if (resp==DialogResult.Yes)
                {
                    int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                    AlumnosBLL.Eliminar(id);
                    MessageBox.Show("REGISTRO ELIMINADO", "CONFIRMACION");

                }

      
                cargarDatos();
            }
            catch (Exception)
            {
                MessageBox.Show("Algo no ha funcionado correctamente");
            }
        }
        public void LIMPIAR()
        {
            try
            {
                txtNombre.Text = "";
                txtApellido.Text = "";
                txtNacionalidad.Text = "";
                txtFechaDeNacimiento.Value = DateTime.Now;
                txtEdad.Text = "";
                txtPrecedencia.Text = "";
                txtID.Text = "";

            }
            catch (Exception)
            {
                MessageBox.Show("Algo no ha funcionado correctamente");
            }
        }

            

        private void bntNUEVO_Click(object sender, EventArgs e)
        {
            LIMPIAR();
        }

        private void txtCriterio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar==13)
            {
                AlumnosBLL.BuscarNombreApellido(txtCriterio.Text);
                dataGridView1.DataSource = AlumnosBLL.ListaAlumnos;
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                Alumno alumno= row.DataBoundItem as Alumno;
                txtNombre.Text = alumno.Nombre;
                txtApellido.Text = alumno.Apellido;
                txtNacionalidad.Text = alumno.Nacionalidad;
                txtFechaDeNacimiento.Value = alumno.Fecha_De_Nacimiento.Value;
                txtEdad.Text = alumno.Edad.ToString();
                txtPrecedencia.Text = alumno.Procedencia;
                txtID.Text = alumno.ID.ToString();
                    
            }

        }

        private void btnBUSCAR_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
