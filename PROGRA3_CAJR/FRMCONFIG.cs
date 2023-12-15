using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PROGRA3_CAJR.Idioma;
using System.Threading;
using global::PROGRA3_CAJR.Properties;

namespace PROGRA3_CAJR
{
    public partial class FRMCONFIG : Form
    {
        #region Constructoeres
        public FRMCONFIG()
        {
            InitializeComponent();
        }
        public FRMCONFIG(int ntema)
        {
            InitializeComponent();
            CboTemas.SelectedIndex = ntema;
            GetText();
        }
        #endregion
        #region Metodos_Objetos
        private void ApliTema_Click(object sender, EventArgs e)
        {
            string tema = CboTemas.SelectedItem.ToString();
            FRMPRINCIPAL.mus.Tema = CboTemas.SelectedIndex;
            FRMPRINCIPAL.AplicarTema(tema);
            Close();
        }
        private void GetText()
        {
            ApliTema.Text = Res.BTNTEMA;
            lblPrevisualizacion.Text = Res.CONFSEL;
            lblSelecciona.Text = Res.CONFPREV;
        }
        #endregion Metodos_Objetos

        private void CboTemas_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            int tema = CboTemas.SelectedIndex;
            switch (CboTemas.SelectedIndex)
            {
                case 0: //Primera
                    picPrimera.Image = Resources._11;
                    //picSegunda.Visible = picTercera.Visible = false;
                    
                    break;

                case 1: //Segunda
                    picPrimera.Image = Resources._21;
                    //picPrimera.Visible = picTercera.Visible = false;
                    
                    break;

                case 2://Tercera
                    picPrimera.Image = Resources._31;
                    //picPrimera.Visible = picSegunda.Visible = false;
                    
                    break;
            }
        }

        private void FRMCONFIG_FormClosed(object sender, FormClosedEventArgs e)
        {
            FRMPRINCIPAL.Reset();
        }

        private void FRMCONFIG_Load(object sender, EventArgs e)
        {
            GetText();
        }

        private void lblTemas_Click(object sender, EventArgs e)
        {

        }

        private void picPrimera_Click(object sender, EventArgs e)
        {

        }
    }
}
