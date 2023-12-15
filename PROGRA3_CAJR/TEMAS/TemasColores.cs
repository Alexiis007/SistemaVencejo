using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace PROGRA3_CAJR.TEMAS
{
    public class TemasColores
    {
        public static Color PanelMenu;
        public static Color PanelTitulo;
        public static Color FButtonSel;
        //Primera
        private static readonly Color PanelMenuD = Color.FromArgb(214, 228, 170);
        private static readonly Color PanelTituloD = Color.FromArgb(131, 181, 130);
        private static readonly Color FButtonSelD = Color.FromArgb(115, 0, 104);
        //Segunda
        private static readonly Color PanelMenuV = Color.FromArgb(91, 192, 248);
        private static readonly Color PanelTituloV = Color.FromArgb(0, 129, 201);
        private static readonly Color FButtonSelV = Color.FromArgb(118, 41, 233);
        //Tercera
        private static readonly Color PanelMenuM = Color.FromArgb(255, 178, 107);
        private static readonly Color PanelTituloM = Color.FromArgb(255, 123, 84);
        private static readonly Color FButtonSelM = Color.FromArgb(115, 0, 104);
        /*//Cuarta
        private static readonly Color PanelMenuC = Color.FromArgb(25, 24, 37);
        private static readonly Color PanelTituloC = Color.FromArgb(6, 0, 71);
        private static readonly Color FButtonSelC = Color.FromArgb(134, 93, 255);*/

        #region -> Metodos

        public static void aplicarTema(String Tema)
        {
            if (Tema == "Primero")           
            {
                PanelMenu = PanelMenuD;
                PanelTitulo = PanelTituloD;
                FButtonSel = FButtonSelD;
            }

            if (Tema == "Segundo")
            {
                PanelMenu = PanelMenuV;
                PanelTitulo = PanelTituloV;
                FButtonSel = FButtonSelV;
            }
            if (Tema == "Tercero")
            {
                PanelMenu = PanelMenuM;
                PanelTitulo = PanelTituloM;
                FButtonSel = FButtonSelM;
            }
           /* if (Tema == "Cuarta")
            {
                PanelMenu = PanelMenuC;
                PanelTitulo = PanelTituloC;
                FButtonSel = FButtonSelC;
            }*/

        }
        #endregion


    }
}
