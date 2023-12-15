using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaVencejo;

namespace PROGRA3_CAJR
{
    public partial class FRMRECUPERAR : Form
    {
        
        public FRMRECUPERAR()
        {
            InitializeComponent();
        }

        private void lbl_CorreoUsuario_Click(object sender, EventArgs e)
        {

        }

        private void iconPictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void ibtn_Close_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ibtn_Minimizar_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_Enviar_Click(object sender, EventArgs e)
        {
            var user = new UserModel();
            var result = user.recoverPassword(txt_CorreoUsuario.Text);
            MessageBox.Show(result,this.Text,MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
        }
    }
}
