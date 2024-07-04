using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DirAlumnos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            refreshscreen();

        }

        public void refreshscreen()
        {
            dataGridView1.DataSource = AlumnoReg.Mostrar();
        }

        private void btAgregar_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            usuario.Login= txLogin.Text;
            usuario.Nombre=txNombre.Text;
            usuario.Materno=txPaterno.Text;
            usuario.Paterno=txPaterno.Text;
            usuario.Sueldo= Convert.ToDouble(txSueldo.Text);
            usuario.Ingreso = Convert.ToString("dd/MM/yyyy");
            
            int res = AlumnoReg.Agregar(usuario);

            if (res > 0)
            {
                MessageBox.Show("Exito de Guardado");
            }
            else
            {
                MessageBox.Show("Error de Guardado");
            }

            refreshscreen();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            txID.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["userID"].Value);
            txLogin.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["Login"].Value);
            txNombre.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["Nombre"].Value);
            txPaterno.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["Paterno"].Value);
            txMaterno.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["Materno"].Value);
            txSueldo.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["Sueldo"].Value);
            txFecha.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["Ingreso"].Value);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            usuario.Login = txLogin.Text;
            usuario.Sueldo = Convert.ToDouble(txSueldo.Text);

            int res = AlumnoReg.Modificar(usuario);

            if (res > 0)
            {
                MessageBox.Show("Modificacion con exito");
            }
            else
            {
                MessageBox.Show("Error de Modificacion");
            }

            refreshscreen();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string res = AlumnoReg.CSV();
            MessageBox.Show("Exito de creacion:"+res);
        }

            private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = AlumnoReg.MostrarTOP();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
