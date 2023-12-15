using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROGRA3_CAJR
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new FRMBIENVENIDO());
            Application.Run(new FRMLOGIN());
            //Application.Run(new FRMACERCADE());
            //Application.Run(new FRMPRINCIPAL());
            // Application.Run(new FRMRECUPERAR());
        }
    }
}
