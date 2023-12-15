using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HTMLHelpUtils;
using PROGRA3_CAJR.Idioma;


namespace PROGRA3_CAJR
{
    public partial class FRMCLIENTES : Form
    {
        public FRMCLIENTES()
        {
            InitializeComponent();
        }

        private void FRMCLIENTES_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            HTMLHelpClass.HelpNamespace = HTMLHelpClass.GetLocalHelpFileName("Ayuda\\Ayuda.chm");

            Help.ShowHelp(this, HTMLHelpClass.HelpNamespace, HelpNavigator.TableOfContents,"Clientes");
        }

        private void FRMCLIENTES_Load(object sender, EventArgs e)
        {
            Metodos metodos = new Metodos();
            metodos.CargarClientes(dgv_Clientes);
            metodos.CargarAutos(dgv_Autos);
            GetText();
        }

        private void btn_ingresarCliente_Click(object sender, EventArgs e)
        {
            string primerNombre = txt_PrimerNombre.Text;
            string segundoNombre = txt_SegundoNombre.Text;
            string primerApellido = txt_PrimerApellido.Text;
            string segundoApellido = txt_SegundoApellido.Text;
            string edad = txt_edad.Text;
            string telefono = txt_telefono.Text;
            string email = txt_correo.Text;
            if ((primerApellido == "" || segundoApellido == "") || (primerNombre == "") || (edad == "" || telefono == ""))
            {
                DialogResult result = MessageBox.Show("Ocurrio Un Problema Porfavor Rebice Bien Los Campos!!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                Metodos metodo = new Metodos();
                metodo.ingresarCliente(primerApellido, segundoApellido, primerNombre, segundoNombre, edad, telefono, email);
                metodo.CargarClientes(dgv_Clientes);
                DialogResult result = MessageBox.Show("Cliente Ingresado", "Atencion", MessageBoxButtons.OK);
            }
            txt_PrimerNombre.Text="";
            txt_SegundoNombre.Text = "";
            txt_PrimerApellido.Text = "";
            txt_SegundoApellido.Text = "";
            txt_edad.Text = "";
            txt_telefono.Text = "";
            txt_correo.Text = "";
        }

        private void btn_IngresarAuto_Click(object sender, EventArgs e)
        {
            string IDCliente = txt_IDCliente.Text;
            string matricula = txt_IDMatricula.Text;
            string marca = txt_Marca.Text;
            string modelo = txt_Modelo.Text;
            Metodos metodo = new Metodos();

            if ((IDCliente == "" || matricula == "") || (modelo == "" || marca == ""))
            {
                DialogResult result = MessageBox.Show("Ocurrio Un Problema Porfavor Rebice Bien Los Campos!!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            else
            {
                metodo.ingresarAuto(matricula, modelo, marca, IDCliente);
                metodo.CargarAutos(dgv_Autos);
                DialogResult result = MessageBox.Show("Auto Ingresado", "Atencion", MessageBoxButtons.OK);

            }
            txt_IDCliente.Text="";
            txt_IDMatricula.Text="";
            txt_Marca.Text="";
            txt_Modelo.Text="";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string VencejoPIN = " ";
            string PrimerApillido = " ";
            string PrimerNombre = " ";
            Metodos metodo = new Metodos();
            if ((txt_FiltrarVencejoPIN.Text.Length == 0 && txt_FiltrarPrimerNombre.Text.Length == 0) && txt_FiltrarPrimerApellido.Text.Length == 0)
            {
                metodo.CargarClientes(dgv_Clientes);
            }
            else
            { 
                if (txt_FiltrarVencejoPIN.Text.Length == 0)
                {
                    VencejoPIN = "00";
                }
                else { VencejoPIN = txt_FiltrarVencejoPIN.Text; }
                if (txt_FiltrarPrimerApellido.Text.Length == 0)
                {
                    PrimerApillido = "vacio";
                }
                else { PrimerApillido = txt_FiltrarPrimerApellido.Text; }
                if (txt_FiltrarPrimerNombre.Text.Length == 0)
                {
                    PrimerNombre = "vacio";
                }
                else { PrimerNombre = txt_FiltrarPrimerNombre.Text; }
                metodo.FiltrarClientes(dgv_Clientes, VencejoPIN, PrimerApillido, PrimerNombre);
            }
            txt_FiltrarVencejoPIN.Text = "";
            txt_FiltrarPrimerApellido.Text = "";
            txt_FiltrarPrimerNombre.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string modelo = " ";
            string matricula = " ";
            Metodos metodo = new Metodos();
            if ((txt_FiltrarMatricula.Text.Length == 0 && txt_FiltrarModelo.Text.Length == 0))
            {
                metodo.CargarAutos(dgv_Autos);
            }
            else
            { 
                if (txt_FiltrarMatricula.Text.Length == 0)
                {
                    matricula = "00";
                }
                else { matricula = txt_FiltrarMatricula.Text; }
                if (txt_FiltrarModelo.Text.Length == 0)
                {
                    modelo = "vacio";
                }
                else { modelo = txt_FiltrarModelo.Text; }
                metodo.FiltrarAuto(dgv_Autos, modelo, matricula);
            }
            txt_FiltrarMatricula.Text = "";
            txt_FiltrarModelo.Text = "";
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_correo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_telefono_TextChanged(object sender, EventArgs e)
        {

        }
        private void GetText()
        {
            //EMpleados
            lbl_TituloClientes.Text = Res.lbl_TituloClientes;
            GB_IngresoClientes.Text = Res.GB_IngresoClientes;
            GB_FiltrarClientes.Text = Res.GB_FiltrarClientes;
            GB_IngresoAutos.Text = Res.GB_IngresoAutos;
            GB_FiltrarAutos.Text = Res.GB_FiltrarAutos;
            btn_ingresarCliente.Text = Res.btn_ingresarCliente;
            btn_FiltrarCliente.Text = Res.btn_FiltrarCliente;
            btn_IngresarAuto.Text = Res.btn_IngresarAuto;
            btn_FiltrarAuto.Text = Res.btn_FiltrarAuto;


            lbl_ApMaterno.Text = Res.lbl_ApMaterno;
            lbl_ApPaterno.Text = Res.lbl_ApPaterno;
            lbl_AutosVencejoPIN.Text = Res.lbl_AutosVencejoPIN;
            lbl_Correo.Text = Res.lbl_Correo;
            lbl_Edad.Text = Res.lbl_Edad;
            lbl_FiltrarApPaterno.Text = Res.lbl_FiltrarApPaterno;
            lbl_FiltrarMatricula.Text = Res.lbl_FiltrarMatricula;
            lbl_FiltrarModelo.Text = Res.lbl_FiltrarModelo;
            lbl_FiltrarPrimerNom.Text = Res.lbl_FiltrarPrimerNom;
            lbl_FiltrarVencejoPIN.Text = Res.lbl_FiltrarVencejoPIN;
            lbl_Marca.Text = Res.lbl_Marca;
            lbl_Matricula.Text = Res.lbl_Matricula;
            lbl_Modelo.Text = Res.lbl_Modelo;
            lbl_NumeroTelefonico.Text = Res.lbl_NumeroTelefonico;
            lbl_PrimerNom.Text = Res.lbl_PrimerNom;
            lbl_SegundoNom.Text = Res.lbl_SegundoNom;   
        }
    }
}
