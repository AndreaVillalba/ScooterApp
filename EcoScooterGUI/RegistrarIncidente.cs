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
    public partial class formRegistrarIncidente : Form
    {
        private IEcoScooterService service;
     
        public formRegistrarIncidente(IEcoScooterService service)
        {
            InitializeComponent();
            this.service = service;

        }

        private void formRegistrarIncidente_Load(object sender, EventArgs e)
        {

        }

        private void cmdGuardarIncidente_Click(object sender, EventArgs e)
        {
            try
            {
                service.RegisterIncident(txtDescription.Text, DateTime.Today, Convert.ToInt32( service.GetLastRental()));
                MessageBox.Show(this, "El incidente ha sido enviado exitosamente", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();

            }
            catch (ServiceException serviceException)
            {
                MessageBox.Show(this, serviceException.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tsRegresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            formVistaUserLogged formVistaUser = new formVistaUserLogged(service);
            formVistaUser.ShowDialog();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }

