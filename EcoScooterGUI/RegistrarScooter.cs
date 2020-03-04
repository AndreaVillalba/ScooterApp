using EcoScooter.Services;
using EcoScooter.Entities;
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
    public partial class formRegistrarScooter : Form
    {
        IEcoScooterService service;
        ScooterState state;
       
        public formRegistrarScooter(IEcoScooterService service)
        {
            InitializeComponent();
            this.service = service;
        }

        private void RegistrarScooter_Load(object sender, EventArgs e)
        {
            foreach (String s in service.GetStations())
                cboxEstacion.Items.Add(s);

            cboxEstacion.Enabled = false;
            rbtnDisponible.Checked = false;
            rbtnMantenimiento.Checked = false;
            rbtnUso.Checked = false;
           // cmdRegistrarScooter.Enabled = false;
           
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

        private void cmdRegistrarScooter_Click(object sender, EventArgs e)
        {
            
            try
            {
                string station_id = "";

                if (rbtnUso.Checked || rbtnMantenimiento.Checked || rbtnDisponible.Checked)
                {

                    if (rbtnDisponible.Checked)
                    {
                        state = ScooterState.available;
                        cboxEstacion.Show();
                        if (cboxEstacion.SelectedItem == null) station_id = "";
                        else station_id = cboxEstacion.SelectedItem.ToString();
                    }
                    else if (rbtnMantenimiento.Checked)
                        state = ScooterState.inMaintenance;
                    else
                        state = ScooterState.inUse;

                    service.RegisterScooter(registerDate.Value, state, station_id);
                    MessageBox.Show(this, "Scooter registrado con exito", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    rbtnDisponible.Checked = false;
                    rbtnMantenimiento.Checked = false;
                    rbtnUso.Checked = false;
                    cboxEstacion.Text = "";
                }
                else
                    MessageBox.Show(this, "Debe seleccionar el estado del scooter", "", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
                catch (ServiceException serviceException)
                {
                    MessageBox.Show(this, serviceException.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
             }
            
        }

        private void rbtnDisponible_CheckedChanged(object sender, EventArgs e)
        {
            cboxEstacion.Enabled = true;
           // validarLleno();
           

        }

        private void rbtnMantenimiento_CheckedChanged(object sender, EventArgs e)
        {
            cboxEstacion.Enabled = false;
            cboxEstacion.Text = "";
           // validarLleno();
        }

        private void rbtnUso_CheckedChanged(object sender, EventArgs e)
        {
            cboxEstacion.Enabled = false;
            cboxEstacion.Text = "";
           // validarLleno();

        }


    }
}
