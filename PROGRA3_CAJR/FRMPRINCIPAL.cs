using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PROGRA3_CAJR.TEMAS;
using FontAwesome.Sharp;
using HTMLHelpUtils;
using PROGRA3_CAJR.Idioma;
using System.Threading;
using Comun.Cache;

namespace PROGRA3_CAJR
{
  

    public partial class FRMPRINCIPAL : Form
    {
        public static MyUserSettings mus;
        public static IconButton currentBtn;
        private static Panel leftBorderBtn;

        private static String TOOLINICIO;
        private static String TOOLAYUDA;
        private static String TOOLINFO;
        private static String MENSALIR;

        private static String TOOLCERRAR;

        private ToolTip toolTip1 = new ToolTip();

        public FRMPRINCIPAL()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(8, 50);
            pnl_menu.Controls.Add(leftBorderBtn);
        }

        private void btn_informacion_Click(object sender, EventArgs e)
        {
            FRMACERCADE myF = new FRMACERCADE();
            myF.ShowDialog();
        }

        private void fecha_hora_Tick(object sender, EventArgs e)
        {
            lbl_hora.Text = DateTime.Now.ToString("HH:mm:ss");
            lbl_fecha.Text = DateTime.Now.ToLongDateString();
        }
        private void FRMPRINCIPAL_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult resp = MessageBox.Show(MENSALIR,
            this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //Funcion ternaria
            e.Cancel = (resp == DialogResult.Yes) ? false : true;

        }
        private void limpia_escritorio()
        {
            if (this.pnl_escritorio.Controls.Count > 0)
            {
                this.pnl_escritorio.Controls.RemoveAt(0);
            }
        }

        private void FRMPRINCIPAL_Load(object sender, EventArgs e)
        {
            mus = new MyUserSettings();
            ENLAZA_CONF();
            ToolTips();
            cbo_Idioma.SelectedIndex = mus.Idioma;
            ToolTips();
            Permisos();
            LoadUserData();
        }

        #region METODOS
        public void Idioma(int indice)
        {
            limpia_escritorio();
            Reset();
            if (indice == 0)
            {
               Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("es-mx");
            }
            else
            {
               Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en-us");
            }
            GetText();
            Est_ToolTips();
        }
        private void Est_ToolTips()
        {
            //ESTABLECE EL TTT DE CADDA BUTTON
            toolTip1.SetToolTip(this.ibtn_inicio, TOOLINICIO);
            toolTip1.SetToolTip(this.ibtn_acerca, TOOLINFO);
            toolTip1.SetToolTip(this.ibtn_ayuda, TOOLAYUDA);
            toolTip1.SetToolTip(this.ibtn_Cerrar, TOOLCERRAR);
        }

        private void GetText()
        {
            ibtn_ventas.Text = Res.BTNVENTAS;
            ibtn_clientes.Text = Res.BTNCLIENTES;
            ibtn_productos.Text = Res.BTNPRODUCTOS;
            ibtn_empleados.Text = Res.BTNEMPLEADOS;
            ibtn_configuraciones.Text = Res.BTNCONFUGURACION;
            TOOLINICIO= Res.TOOLINICIO;
            TOOLINFO= Res.TOOLINFO;
            TOOLAYUDA= Res.TOOLAYUDA;
            MENSALIR  = Res.MENSAJESALIR;
            TOOLCERRAR = Res.TOOLCERRAR;
        }
        private void Abrir(object ventana, object sender)
        {
            if (this.pnl_escritorio.Controls.Count > 0)
                this.pnl_escritorio.Controls.RemoveAt(0);

            ActivatedButton(sender, mus.FButtonSel);

            Form myForm = ventana as Form;
            myForm.TopLevel = false;
            myForm.Dock = DockStyle.Fill;
            this.pnl_escritorio.Controls.Add(myForm);
            this.pnl_escritorio.Tag = myForm;
            myForm.Show();
        }
        public void ENLAZA_CONF()
        {
            pnl_menu.DataBindings.Add(new Binding("BackColor", mus, "PanelMenu"));
            pnl_titulo.DataBindings.Add(new Binding("BackColor", mus, "PanelTitulo"));
        }
        public static void AplicarTema(string tema)
        {
            TemasColores.aplicarTema(tema);
            mus.PanelMenu = TemasColores.PanelMenu;
            mus.PanelTitulo = TemasColores.PanelTitulo;
            mus.FButtonSel = TemasColores.FButtonSel;
        }
        private void LoadUserData()
        {
            lbl_Name.Text = UserLoginCache.FirstName + " "+UserLoginCache.LastName;
            lbl_Position.Text = UserLoginCache.Position;
            lbl_Email.Text = UserLoginCache.Email;
        }
        private void Permisos()
        {
            if (UserLoginCache.Position == Positions.Mecanico)
            {
                ibtn_clientes.Enabled = false;
                ibtn_productos.Enabled = false;
                ibtn_empleados.Enabled = true;
                ibtn_ventas.Enabled = true;

            }
            if (UserLoginCache.Position == Positions.CEO)
            {
                ibtn_clientes.Enabled = true;
                ibtn_productos.Enabled = true;
                ibtn_empleados.Enabled = true;
                ibtn_ventas.Enabled = true;
            }
            if (UserLoginCache.Position == Positions.Administrador)
            {
                ibtn_clientes.Enabled = true;
                ibtn_productos.Enabled = false;
                ibtn_empleados.Enabled = true;
                ibtn_ventas.Enabled = true;
            }
        }
        #endregion

        private void FRMPRINCIPAL_FormClosed(object sender, FormClosedEventArgs e)
        {
            mus.Save();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            Abrir(new FRMTRABAJOS(),sender);
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            Abrir(new FRMCLIENTES(), sender);
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            Abrir(new Empleados(), sender);
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            Abrir(new FRMINVENTARIO(), sender);
        }

        private void iconButton5_Click(object sender, EventArgs e)
        {
            Abrir(new FRMCONFIG(mus.Tema),sender);
        }

        private void iconButton1_Click_1(object sender, EventArgs e)
        {
            limpia_escritorio();
        }

        private void btn_ayuda_Click(object sender, EventArgs e)
        {

        }

        private void iconButton3_Click_1(object sender, EventArgs e)
        {
            HTMLHelpClass.HelpNamespace = HTMLHelpClass.GetLocalHelpFileName("Ayuda\\Ayuda.chm");

            Help.ShowHelp(this,HTMLHelpClass.HelpNamespace,HelpNavigator.TableOfContents);
        }

        private void iconButton2_Click_1(object sender, EventArgs e)
        {
            FRMACERCADE myF = new FRMACERCADE();
            myF.ShowDialog();
        }
        private void ToolTips()
        {
            //CREA EL TTT Y LO ASOCIA CON EL FORMULARIO CONTENEDDOR 
            //ToolTip toolTip1 = new ToolTip();

            //ESTABLECE LOS DELAY PARA EL TTT
            toolTip1.AutoPopDelay = 5000;
            toolTip1.InitialDelay = 1000;
            toolTip1.ReshowDelay = 500;

            //FORZA A QUESE DESPLIEGUE EL TEXT DE EL TTT
            toolTip1.ShowAlways = true;

            Est_ToolTips();

        }
        public static void ActivatedButton(object sender, Color color)
        {
            if (sender != null)
            {
                DisableButton();
                currentBtn = (IconButton)sender;
                currentBtn.IconColor = currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleRight;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;

                //LEFT BORDER BUTTON 
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(1, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();

            }
        }
        public static void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.IconColor = currentBtn.ForeColor = Color.Black;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.TextImageRelation = TextImageRelation.Overlay;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
            }
        }
        public static void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
        }

        private void FRMPRINCIPAL_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                ibtn_ayuda.PerformClick();
            }
            if (e.KeyCode == Keys.F2)
            {
                ibtn_acerca.PerformClick();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void cbo_Idioma_SelectedIndexChanged(object sender, EventArgs e)
        {
            mus.Idioma = cbo_Idioma.SelectedIndex;
            Idioma(mus.Idioma);
        }

        private void lbl_Position_Click(object sender, EventArgs e)
        {

        }

        private void ibtn_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pnl_escritorio_Paint(object sender, PaintEventArgs e)
        {

        }
    }//class
}//namespace

