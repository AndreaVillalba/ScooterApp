using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EcoScooter.Services;
//using UnitTestServiceEcoScooter;

namespace EcoScooterGUI
{
    public partial class formInicioSesion : Form
    {
        private IEcoScooterService service;
      
        //private Populate populate;
        public formInicioSesion()
        {
            InitializeComponent();

        }
       public formInicioSesion(IEcoScooterService service) : this()
        {
           
            this.service = service;
        }

       

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "Estas seguro que desea salir?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question)==DialogResult.Yes)
            {
                Application.Exit();
            }
           
        }

        private void poblarBaseDeDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog(); //control para abrir ficheros
        }

        private void registrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formRegistrar formulario = new formRegistrar(service);
            formulario.ShowDialog(); //opcion modal: hasta que no lo cierre no puedo hacer nada mas
        }

        private void cmdIniciarSesionUs_Click(object sender, EventArgs e)
        {
            // service.LoginUser(txtLogin.Text, txtPassword.Text);
            try
            {
                service.LoginUser(txtLoginUs.Text, txtPasswordUs.Text);
                txtLoginUs.Text = "Usuario";
                txtPasswordUs.Text = "Contraseña";
                txtPasswordUs.PasswordChar = '\0';
                this.Hide();
                formVistaUserLogged formVistaUserLogged = new formVistaUserLogged(service);
                formVistaUserLogged.ShowDialog();
              
          
            }
            catch(ServiceException serviceException)
            {
                MessageBox.Show(this, serviceException.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            //this.Close();
        }

        private void cmdIniciarSesionTrab_Click(object sender, EventArgs e)
        {
            try
            {
               
                service.LoginEmployee(txtLoginTrab.Text,  Convert.ToInt32( txtPasswordTrab.Text));
                txtPasswordTrab.Text = "PIN";
                txtLoginTrab.Text = "DNI";
                txtPasswordTrab.PasswordChar = '\0';
                this.Hide();
                formEmpleadoLoggeado formEmpleadoLoggeado = new formEmpleadoLoggeado(service);
                formEmpleadoLoggeado.ShowDialog();
         
                
            }
            catch (ServiceException serviceException)
            {
                MessageBox.Show(this, serviceException.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (FormatException)
            {
                MessageBox.Show(this, "Formato de pin incorrecto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        private void lblCrearCuenta_Click(object sender, EventArgs e)
        {
            this.Hide();
            formRegistrar formRegistrar = new formRegistrar(service);
            formRegistrar.ShowDialog();
        }

 

        private void txtLoginUs_Click(object sender, EventArgs e)
        {
            txtLoginUs.Text = "";
        }

        private void txtLoginTrab_Click(object sender, EventArgs e)
        {
            txtLoginTrab.Text = "";
        }

        private void txtPasswordUs_Click(object sender, EventArgs e)
        {
            txtPasswordUs.Text = "";
            txtPasswordUs.PasswordChar = '*';
            
        }

        private void txtPasswordTrab_Click(object sender, EventArgs e)
        {
            txtPasswordTrab.Text = "";
            txtPasswordTrab.PasswordChar = '*';
        }



        private void MostrarPassUs_CheckedChanged(object sender, EventArgs e)
        {
            if (MostrarPassUs.Checked)
            txtPasswordUs.PasswordChar= '\0' ;
            else
                txtPasswordUs.PasswordChar = '*';

        }

        private void MostrarPassTrab_CheckedChanged(object sender, EventArgs e)
        {
            if (MostrarPassTrab.Checked)
                txtPasswordTrab.PasswordChar = '\0';
            else
                txtPasswordTrab.PasswordChar = '*';
        }

        private void borrarTodaLaDataToolStripMenuItem_Click(object sender, EventArgs e)
        {


            if (MessageBox.Show(this, "¿Seguro que quiere eliminar todo?", "Borrar data", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                service.removeAllData();
                MessageBox.Show(this, "Base de datos vaciada con exito", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                service.LogOut();
            }

        }




     


        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tsPoblarBaseDatos_Click(object sender, EventArgs e)
        {
            try
            {
               
                if (MessageBox.Show(this, "¿Seguro que quiere poblar la base de datos?", "Insercion de datos", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    
                    // service.removeAllData();
                    service.RegisterUser(DateTime.Now.AddYears(-20), "1562738A", "andrea@gmail.com", "Andrea Villalba", 671299400, 344, DateTime.Now.AddYears(2), "andrea", 12345678, "hola");
                    service.RegisterUser(DateTime.Now.AddYears(-20), "1562338A", "ana@gmail.com", "Ana Villalba", 67123400, 544, DateTime.Now.AddYears(3), "ana", 12345638, "hola");
                    service.RegisterEmployee(DateTime.Now.AddYears(-25), "12341234A", "j@gmail.com", "Juan Gonzalez", 635289102, "ES6621000418401234567891", 1234, "manager", 1200);
                    service.RegisterEmployee(DateTime.Now.AddYears(-25), "11111111A", "ja@gmail.com", "Joaquin Gonzalez", 625289102, "ES6621033418401234567891", 1234, "manager", 1200);

                    MessageBox.Show(this, "Base de datos poblada con exito", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {
                MessageBox.Show(this, "Ya has poblado anteriormente la base de datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }



        }

        private void formInicioSesion_Load(object sender, EventArgs e)

        {
           
            cmdIniciarSesionTrab.Enabled = false;
            cmdIniciarSesionUs.Enabled = false;
        }

        private void validarDatosUsuario()
        {
            if (txtLoginUs.Text.Length == 0|| txtLoginUs.Text=="Usuario"|| txtPasswordUs.Text.Length == 0|| txtPasswordUs.Text=="Contraseña")
                cmdIniciarSesionUs.Enabled = false;
            else
                cmdIniciarSesionUs.Enabled = true;

        }

        private void validarDatosTrabajador()
        {
            if (txtLoginTrab.Text.Length == 0||txtLoginTrab.Text=="DNI"||  txtPasswordTrab.Text.Length == 0|| txtPasswordTrab.Text=="PIN")
                cmdIniciarSesionTrab.Enabled = false;
            else
                cmdIniciarSesionTrab.Enabled = true;
        }

        private void txtLoginUs_TextChanged(object sender, EventArgs e)
        {
            validarDatosUsuario();
        }

        private void txtPasswordUs_TextChanged(object sender, EventArgs e)
        {
            validarDatosUsuario();
            txtPasswordUs.PasswordChar = '*';
        }

        private void txtLoginTrab_TextChanged(object sender, EventArgs e)
        {
            validarDatosTrabajador();
        }

        private void txtPasswordTrab_TextChanged(object sender, EventArgs e)
        {
            validarDatosTrabajador();
            txtPasswordTrab.PasswordChar = '*';

        }

        private void MostrarPas2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }
    

