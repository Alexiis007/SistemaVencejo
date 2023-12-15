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


namespace PROGRA3_CAJR
{
    public partial class Empleados : Form
    {
        public Empleados()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_ingresarEmpleado_Click(object sender, EventArgs e)
        {
            string primerNombre = txt_PrimerNombre.Text;
            string segundoNombre = txt_SegundoNombre.Text;
            string primerApellido = txt_PrimerApellido.Text;
            string segundoApellido = txt_SegundoApellido.Text;
            string edad = txt_edad.Text;
            string telefono = txt_telefono.Text;
            string email = txt_correo.Text;
            string puesto = txt_Puesto.Text;
            if ((primerApellido == "" || segundoApellido == "") || (primerNombre == "") || (edad == "" || telefono == ""))
            {
                DialogResult result = MessageBox.Show("Ocurrio Un Problema Porfavor Rebice Bien Los Campos!!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                Metodos metodo = new Metodos();
                metodo.ingresarEmpleado(primerApellido, segundoApellido, primerNombre, segundoNombre, edad, telefono, email, puesto);
                metodo.CargarEmpleados(dgv_Empleados);
                DialogResult result = MessageBox.Show("Empleado Ingresado", "Atencion", MessageBoxButtons.OK);
            }

            txt_PrimerNombre.Text = "";
            txt_SegundoNombre.Text = "";
            txt_PrimerApellido.Text = "";
            txt_SegundoApellido.Text = "";
            txt_edad.Text = "";
            txt_telefono.Text = "";
            txt_correo.Text = "";
            txt_Puesto.Text = "";
        }
            

            private void FRMPRODUCTOS_Load(object sender, EventArgs e)
        {
            Metodos metodo = new Metodos();
            metodo.CargarEmpleados(dgv_Empleados);
            GetText();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string primerNombre = txt_PrimerNombre2.Text;
            string primerApellido = txt_PrimerApellido2.Text;
            string idEmpleado = txt_IdEmpleado.Text;
            if (((primerApellido == "" || primerNombre == "")) || (idEmpleado == ""))
            {
                DialogResult result = MessageBox.Show("Ocurrio Un Problema Porfavor Rebice Bien Los Campos!!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                Metodos metodo = new Metodos();
                metodo.eliminarEmpleado(idEmpleado, primerNombre, primerApellido);
                metodo.CargarEmpleados(dgv_Empleados);
                DialogResult result = MessageBox.Show("Empleado Dado De Baja", "Atencion", MessageBoxButtons.OK);
            }
            txt_PrimerNombre2.Text="";
            txt_PrimerApellido2.Text="";
            txt_IdEmpleado.Text="";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string ID_Empleado = " ";
            string PrimerApillido = " ";
            string PrimerNombre = " ";
            string Puesto = " ";
            Metodos metodo = new Metodos();

            if ((txt_FiltrarIdEmpleado.Text.Length == 0 && txt_FiltrarPrimerApellido.Text.Length == 0) && (txt_FiltrarPrimerNombre.Text.Length == 0 && txt_FiltrarPuesto.Text.Length == 0))
            {
                metodo.CargarEmpleados(dgv_Empleados);
            }
            else
            {
                if (txt_FiltrarIdEmpleado.Text.Length == 0)
                {
                    ID_Empleado = "00";
                }
                else { ID_Empleado = txt_FiltrarIdEmpleado.Text; }
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
                if (txt_FiltrarPuesto.Text.Length == 0)
                {
                    Puesto = "00";
                }
                else { Puesto = txt_FiltrarPuesto.Text; }
                metodo.FiltrarEmpleados(dgv_Empleados, ID_Empleado, PrimerApillido, PrimerNombre, Puesto);
            }
            txt_FiltrarIdEmpleado.Text = "";
            txt_FiltrarPrimerApellido.Text = "";
            txt_FiltrarPrimerNombre.Text = "";
            txt_FiltrarPuesto.Text = "";
        }

        private void lbl_TituloEmpleados_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void lbl_puesto_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void GetText()
        {
            //EMpleados
            lbl_TituloEmpleados.Text = Res.lbl_TituloEmpleados;
            GB_IngresoDeDatos.Text = Res.GB_IngresoDeDatos;
            GB_EliminarEmpleado.Text = Res.GB_EliminarEmpleado;
            GB_FiltrarEmpleado.Text = Res.GB_FiltrarEmpleado;
            btn_ingresarEmpleado.Text = Res.btn_ingresarEmpleado;
            btn_EliminarEmpleado.Text = Res.btn_EliminarEmpleado;
            btn_FiltrarEmpleado.Text = Res.btn_FiltrarEmpleado;

            lbl_Correo.Text = Res.lbl_Correo;
            lbl_Edad.Text = Res.lbl_Edad;
            lbl_EliminarIdEmpledo.Text = Res.lbl_EliminarIdEmpledo;
            lbl_EliminarPrimerAp.Text = Res.lbl_EliminarPrimerAp;
            lbl_EliminarPrimerNom.Text = Res.lbl_EliminarPrimerNom;
            lbl_FiltrarPrimerAp.Text = Res.lbl_FiltrarPrimerAp;
            lbl_FiltrarPrimerNom.Text = Res.lbl_FiltrarPrimerNom;
            lbl_FiltrarPuesto.Text = Res.lbl_FiltrarPuesto;
            lbl_FiltrarssIdEmpleado.Text = Res.lbl_FiltrarssIdEmpleado;
            lbl_PrimerAp.Text = Res.lbl_PrimerAp;
            lbl_PrimerNom.Text = Res.lbl_PrimerNom;
            lbl_Puesto.Text = Res.lbl_Puesto;
            lbl_SegundoAp.Text = Res.lbl_SegundoAp;
            lbl_SegundoNom.Text = Res.lbl_SegundoNom;
            lbl_Telefono.Text = Res.lbl_Telefono;

        }

    }
}
