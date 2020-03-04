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
    public partial class formRutas : Form
    {
        IEcoScooterService service;
        public formRutas(IEcoScooterService service)
        {
            InitializeComponent();
            this.service = service;
        }

        private IBindingList getRoutes(DateTime dateFrom, DateTime dateTo)
        {
            BindingList<object> bindingList = new BindingList<object>();
            ICollection<String> routesId = service.GetUserRoutesIds(dateFrom, dateTo);
            foreach ( string id in routesId)
            {
                service.GetRouteDescription(int.Parse(id), out DateTime start, out DateTime end,
                    out decimal price, out string originStation, out string destinationStation);
                bindingList.Add(new {ds_id = id, ds_start = start, ds_end = end, ds_price = price,
                    ds_originStation = originStation, ds_destinationStation = destinationStation});
            }

            return bindingList;
        }

        private void cmdBuscarRutas_Click(object sender, EventArgs e)
        {
            try
            {
                bsRutas.DataSource = getRoutes(dateFrom.Value, dateTo.Value);
                dgwRutas.Visible = true;
            }catch(ServiceException serviceException)
            {
                MessageBox.Show(this, serviceException.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }


        }

        private void formRutas_Load(object sender, EventArgs e)
        {
            dgwRutas.Visible = false;
        }

      

        private void tsCerrarSesion_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "¿Seguro que quiere cerrar sesion?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                service.LogOut();
                formInicioSesion formInicio = new formInicioSesion(service);
                this.Hide();
                formInicio.Show();

            }
        }

        private void tsRegresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            formVistaUserLogged formVistaUser = new formVistaUserLogged(service);
            formVistaUser.Show();
        }
    }
}
