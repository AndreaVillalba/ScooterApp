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
    public partial class formRegistrar : Form
    {
        private IEcoScooterService service;
        public formRegistrar()
        {
            InitializeComponent();
        }

        public formRegistrar(IEcoScooterService service) : this()
        {
            this.service = service;
        }

        private void cmdRegistroUsuario_Click(object sender, EventArgs e)

        {
            try
            {
                service.RegisterUser(dateBirth.Value, txtDNI.Text, txtEmail.Text, txtNombre.Text, Convert.ToInt32(txtTelephon.Text.Replace(" ", "")),
                    Convert.ToInt32(txtCVV.Text), dateExpiration.Value, txtLogin.Text, Convert.ToInt32(txtCardNumber.Text.Replace(" - ", "")), txtPassword.Text);
                MessageBox.Show(this, "Registro exitoso", "Bienvenido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                formInicioSesion formInicioSesion = new formInicioSesion(service);
                formInicioSesion.Show();

            }
            catch (ServiceException serviceException)
            {
                MessageBox.Show(this, serviceException.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void formRegistrar_Load(object sender, EventArgs e)
        {
           
            dateExpiration.MaxDate = DateTime.Today.AddYears(10);
            dateExpiration.MinDate = DateTime.Today;


            dateBirth.MaxDate = DateTime.Today;
            cmdRegistroUsuario.Enabled = false;
        }

  

        private void validarLleno()
        {
            if (txtLogin.Text.Length == 0 || txtPassword.Text.Length == 0 || txtNombre.Text.Length == 0 || txtDNI.Text.Length == 0 ||
            txtTelephon.Text.Length == 0 || txtCVV.Text.Length == 0 || txtCardNumber.Text.Length == 0 || dateBirth.Value == null || dateExpiration.Value == null)
                cmdRegistroUsuario.Enabled = false;
            else
                cmdRegistroUsuario.Enabled = true;
          }



        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            validarLleno();
        }



        private void dateExpiration_ValueChanged(object sender, EventArgs e)
        {
            validarLleno();
        }

        private void txtLogin_TextChanged(object sender, EventArgs e)
        {
            validarLleno();
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            validarLleno();

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            validarLleno();
        }



        private void dateBirth_ValueChanged(object sender, EventArgs e)
        {
            validarLleno();
        }

 

        private void txtCVV_TextChanged(object sender, EventArgs e)
        {
            validarLleno();
        }

        private void txtDNI_TextChanged(object sender, EventArgs e)
        {
            validarLleno();
        }

        private void txtTelephon_TextChanged(object sender, EventArgs e)
        {
            validarLleno();
        }

        private void txtCardNumber_TextChanged(object sender, EventArgs e)
        {
            validarLleno();
        }

        private void tsRegresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            formInicioSesion formInicio = new formInicioSesion(service);
            formInicio.ShowDialog();
        }

        private void Label12_Click(object sender, EventArgs e)
        {

        }

        private void Label13_Click(object sender, EventArgs e)
        {

        }
    }
}
