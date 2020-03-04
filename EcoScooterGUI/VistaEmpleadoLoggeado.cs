using EcoScooter.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EcoScooterGUI
{
    public partial class formEmpleadoLoggeado : Form
    {
        private IEcoScooterService service;
        public formEmpleadoLoggeado()
        {
            InitializeComponent();
        }

        public formEmpleadoLoggeado( IEcoScooterService service):this()
        {
            this.service = service;
        }

        private void formEmpleadoLoggeado_Load(object sender, EventArgs e)
        {

        }

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "¿Seguro que quiere cerrar sesion?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                service.LogOut();
                this.Hide();
                formInicioSesion formInicio = new formInicioSesion(service);
                formInicio.ShowDialog();
            }

                
        }

        private void pboxRegisterStation_Click(object sender, EventArgs e)
        {
            this.Hide();
            formRegistrarEstacion formEstacion = new formRegistrarEstacion(service);
            formEstacion.ShowDialog();
        }

        private void pboxRegisterScooter_Click(object sender, EventArgs e)
        {
            this.Hide();
            formRegistrarScooter formScooter = new formRegistrarScooter(service);
            formScooter.ShowDialog();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
