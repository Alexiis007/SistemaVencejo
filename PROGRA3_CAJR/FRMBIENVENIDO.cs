using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Comun.Cache;
using System.Runtime.InteropServices;
using PROGRA3_CAJR.Idioma;

namespace PROGRA3_CAJR
{
    public partial class FRMBIENVENIDO : Form
    {
        /*AGREGAMOS PARA MOVER EL FORMULARIO
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        private void FRMBIENVENIDO_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }*/
        public FRMBIENVENIDO()
        {
            InitializeComponent();
        }
        //int cont = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.Opacity < 1) this.Opacity += 0.05;
            progressBar1.Value += 1;
            if (progressBar1.Value == 100)
            {
                timer1.Stop();
                timer2.Start();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            this.Opacity -= 0.1;
            if (this.Opacity == 0)
            {
                timer2.Stop();
                this.Close();
            }
        }

        private void FRMBIENVENIDO_Load(object sender, EventArgs e)
        {
            this.Opacity = 0.0;
            timer1.Start();
            lbl_usuario.Text = "Usuario: "+UserLoginCache.FirstName + ", " + UserLoginCache.LastName;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }


    }
}
