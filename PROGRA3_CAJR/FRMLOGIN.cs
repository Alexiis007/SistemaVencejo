using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaVencejo;
using System.Runtime.InteropServices;
using Comun.Cache;

namespace PROGRA3_CAJR
{
    public partial class FRMLOGIN : Form
    {
        public FRMLOGIN()
        {
            InitializeComponent();
        }
        //AGREGAMOS PARA MOVER EL FORMULARIO
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void FRMLOGIN_Load(object sender, EventArgs e)
        {

        }
        private void ibtn_Minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void txt_Usuario_Enter(object sender, EventArgs e)
        {
            TextBox caja = sender as TextBox;
            if (caja.Text=="USUARIO" || caja.Text=="CONTRASEÑA")
            {
                caja.Clear();
                caja.ForeColor = Color.Black;
                caja.UseSystemPasswordChar = (caja.Name == "txt_Contraseña");
            }
        }
        private void ibtn_Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txt_Usuario_Leave(object sender, EventArgs e)
        {
            TextBox caja = sender as TextBox;
            if (caja.Text == "")
            {
                caja.Text = (caja.Name == "txt_Usuario") ? "USUARIO" : "CONTRASEÑA";
                caja.ForeColor = Color.Black;
                caja.UseSystemPasswordChar = false;
            }
        }
        private void FRMLOGIN_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            VerificaDatos();
        }
        private void VerificaDatos()
        {
            //throw new NotImplementedException();
            errorProvider1.Clear();
            if (txt_Usuario.Text != "USUARIO" && txt_Contraseña.Text != "CONTRASEÑA")
            {
                UserModel user = new UserModel();
                var validLogin = user.LoginUser(txt_Usuario.Text, txt_Contraseña.Text);
                if (validLogin)
                {
                    this.Hide();
                    FRMBIENVENIDO welcome = new FRMBIENVENIDO();
                    welcome.ShowDialog();
                    FRMPRINCIPAL mainMenu = new FRMPRINCIPAL();
                    MessageBox.Show("¡Bienvenido!" + Environment.NewLine + UserLoginCache.FirstName + " " + UserLoginCache.LastName, this.Text, MessageBoxButtons.OK);
                    mainMenu.Show();
                    mainMenu.FormClosed += CerrarSesion;
                    
                }
                else
                {
                    MessageBox.Show("Nombre de usuario o contraseña incorrecto", this.Text,
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Limpia_Controles();
                }
            }
            /* else if (txt_Usuario.Text == "Usuario" && txt_Contraseña.Text == "Contraseña")
                 errorProvider1.SetError(txt_Usuario, "Escribe el nombre del usuario");
             else if ()
                 errorProvider1.SetError(txt_Contraseña, "Escribe la contraseña");*/
            else if (txt_Usuario.Text == "USUARIO" && txt_Contraseña.Text == "CONTRASEÑA")
                errorProvider1.SetError(txt_Usuario, "Escribe el nombre del usuario");
                errorProvider1.SetError(txt_Contraseña, "Escribe la contraseña");

        }

        private void CerrarSesion(object sender, FormClosedEventArgs e)
        {
            Limpia_Controles();
            this.Show();
        }

        private void Limpia_Controles()
        {
            txt_Usuario.Text = "USUARIO";
            txt_Contraseña.Text = "CONTRASEÑA";
            txt_Contraseña.UseSystemPasswordChar = false;
            txt_Usuario.ForeColor = txt_Contraseña.ForeColor = Color.Gray;
            errorProvider1.Clear();
        }

        private void txt_Contraseña_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var recoverPassword = new FRMRECUPERAR();
            recoverPassword.ShowDialog();
        }
    }
}
