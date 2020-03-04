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
    public partial class formVistaUserLogged : Form
    {
        private IEcoScooterService service;

        public formVistaUserLogged(IEcoScooterService service)
        {
            InitializeComponent();
            this.service = service;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void cboxEstacion_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void formVistaUserLogged_Load(object sender, EventArgs e)
        {
            //cboxEstacion.Items.Add("hola");
            foreach (String s in service.GetStations())
                cboxEstacion.Items.Add(s);
         
        }

        private void btnDevolver_Click(object sender, EventArgs e)
        {
            try
            {
                if (cboxEstacion.SelectedItem == null) service.ReturnScooter("");
                else
                {
                    

                  
                    service.ReturnScooter(cboxEstacion.SelectedItem.ToString());
                    MessageBox.Show(this, "Devolucion realizada con exito", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    if (MessageBox.Show(this, "¿Hay algun incidente que desea reportar?", "¡Gracias por confiar en nostros!", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
                    {
                        //this.Hide();
                        formRegistrarIncidente formRegistrar = new formRegistrarIncidente(service);
                        formRegistrar.ShowDialog();
                    }




                }


            }
            catch (ServiceException serviceException)
            {
                MessageBox.Show(this, serviceException.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAlquilar_Click(object sender, EventArgs e)
        {
            try
            {
                if (cboxEstacion.SelectedItem == null) service.ReturnScooter("");
                else service.RentScooter(cboxEstacion.SelectedItem.ToString());
                MessageBox.Show(this, "Alquiler realizado con exito", "", MessageBoxButtons.OK, MessageBoxIcon.Information);



            }
            catch (ServiceException serviceException)
            {
                MessageBox.Show(this, serviceException.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "¿Seguro que quiere cerrar sesion?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                service.LogOut();
                formInicioSesion formInicio = new formInicioSesion(service);
                this.Hide();
                formInicio.Show();
                
            }

        }

        private void CmdSalir_Click(object sender, EventArgs e)
        {

        }

        private void tsMisRutas_Click(object sender, EventArgs e)
        {
            this.Hide();
            formRutas formruta = new formRutas(service);
            formruta.ShowDialog();
        }
    }
}
