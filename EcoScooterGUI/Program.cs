using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using EcoScooter.Persistence;
using EcoScooter.Services;

namespace EcoScooterGUI
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            IEcoScooterService service = new EcoScooterService(new EntityFrameworkDAL(new EcoScooterDbContext())); 
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new formInicioSesion(service));
        }
    }
}
