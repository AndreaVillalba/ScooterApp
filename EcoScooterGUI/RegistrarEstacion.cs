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
    public partial class formRegistrarEstacion : Form
    {
        IEcoScooterService service;
        public formRegistrarEstacion(IEcoScooterService service)
        {
            InitializeComponent();
            this.service = service;
        }

        private void formRegistrarEstacion_Load(object sender, EventArgs e)
        {
            cmdRegistrarEstacion.Enabled = false;
            //txtLatitud.PromptChar = '';
        }

        private void tsRegresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            formEmpleadoLoggeado formEmpleado = new formEmpleadoLoggeado(service);
            formEmpleado.ShowDialog();

        }

        private void tsCerrarSesion_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "¿Seguro que quiere cerrar sesion?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                service.LogOut();
                this.Hide();
                formInicioSesion formInicio = new formInicioSesion(service);
                formInicio.ShowDialog();
            }
        }

        private void cmdRegistrarEstacion_Click(object sender, EventArgs e)
        {
            try
            {
                service.RegisterStation(txtAddress.Text, Convert.ToDouble(txtLatitud.Text), Convert.ToDouble(txtLongitud.Text), txtStationID.Text);
                MessageBox.Show(this, "Estacion registrada con exito", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtAddress.Text = "";
                txtLongitud.Text = "";
                txtLatitud.Text = "";
                txtStationID.Text = "";

            }
            catch (ServiceException serviceException)
            {
                MessageBox.Show(this, serviceException.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (FormatException)
            {
                MessageBox.Show(this, "Los siguientes campos deben ser numeros: \n - Latitud\n - Longitud", "Error en el formato", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void txtAddress_Click(object sender, EventArgs e)
        {
            txtAddress.Text = "";
            validarLleno();
        }

   

        private void txtStationID_Click(object sender, EventArgs e)
        {
            txtStationID.Text = "";
            validarLleno();
        }

        private void validarLleno()
        {
            if (txtAddress.TextLength == 0 || txtLatitud.Text.Length == 0 || txtLongitud.Text.Length == 0 || txtStationID.Text.Length == 0)
                cmdRegistrarEstacion.Enabled = false;
            else
                cmdRegistrarEstacion.Enabled = true;
        }


        private void txtAddress_TextChanged(object sender, EventArgs e)
        {
            validarLleno();
        }



        private void txtStationID_TextChanged(object sender, EventArgs e)
        {
            validarLleno();
        }


     




        private void txtLatitud_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.' || e.KeyChar == ',')
                this.txtLatitud.SelectionStart = this.txtLatitud.Text.IndexOf(",") + 1;
        }



        private void txtLatitud_TextChanged_1(object sender, EventArgs e)
        {
            validarLleno();
        }

        private void txtLongitud_TextChanged(object sender, EventArgs e)
        {
            validarLleno();
        }
    }
}
