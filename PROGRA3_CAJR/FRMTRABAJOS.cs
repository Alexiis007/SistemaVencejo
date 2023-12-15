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

namespace PROGRA3_CAJR
{
    public partial class FRMTRABAJOS : Form
    {
        public FRMTRABAJOS()
        {
            InitializeComponent();
        }

        private void FRMVENTAS_Load(object sender, EventArgs e)
        {
            //Se instancia la clase Metodos
            Metodos metodos = new Metodos();
            //Se usa el metodo conectar
            //metodos.conectar();
            //Se carga la tabla trabajos com en metodo cargarTrabajos
            metodos.CargarTrabajos(dgv_Trabajos);
            //Ingresamos datos en el combo box de empleados por medio del metodo cargarcboEmpleados
            //el cual retorna una variable de tipo dataTable
            cbo_EmpleadoEncargado.DataSource = metodos.cargarCboEmpleados();
            //Se ingresa lo que quiero mostrar que sera el Puesto y a la vez el dato que distingue a ese puesto
            //el cual es el ID del empleado
            cbo_EmpleadoEncargado.DisplayMember = "puesto";
            cbo_EmpleadoEncargado.ValueMember = "id_empleado";
            //Se bloquean los ComboBox para no dejar ingresar datos y solo seleccionar de la lista.
            cbo_AutosClientes.DropDownStyle = ComboBoxStyle.DropDownList;
            cbo_EmpleadoEncargado.DropDownStyle = ComboBoxStyle.DropDownList;
            GetText();
        }

        private void btn_IngresarTrabajo_Click(object sender, EventArgs e)
        {
            //Se instancia la clase metodos
            Metodos metodo = new Metodos();
            //Se obtienen los datos de las cajas de texto y los combo box
            string id_cliente = txt_IdCliente.Text;
            string id_empleado = cbo_EmpleadoEncargado.SelectedValue.ToString();
            string Descripcion = txt_Descripcion.Text;
            string automovil;
            //Como el consulta que llena el combo box de autos depende del cliente si este esta vacio o no existe
            //el dato quedara como nulo entonces lo que se hace aqui simplemente es preguntar que si es null establecer el
            //texto como null basicamente es lo mismo pero en texto y en caso de que si exista el cliente arojara datos de autos
            //reales y no se activara el if y se activara el else y consigo no se activara el catch.
            //Asi si en la consulta se detectara un error se activara el catch.
            if (cbo_AutosClientes.SelectedValue == null)
            {
                automovil = "null";
            }
            else
            {
                automovil = cbo_AutosClientes.SelectedValue.ToString();
            }
            if ((id_cliente == "" || id_empleado == "") || (Descripcion == "" || automovil == ""))
            {
                DialogResult result = MessageBox.Show("Ocurrio Un Problema Porfavor Rebice Bien Los Campos!!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {

                    metodo.guardarTrabajo(id_cliente, id_empleado, automovil, Descripcion);
                    metodo.CargarTrabajos(dgv_Trabajos);
                }
                catch (Exception exepcion)
                {
                    MessageBoxButtons botones = MessageBoxButtons.YesNo;
                    DialogResult result = MessageBox.Show("El cliente que ingreso no existe. Desea Crear Un Nuevo Cliente?", "Advertencia", botones, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        Abrir(new FRMCLIENTES());
                    }
                    else
                    {

                    }
                }

            }
            txt_IdCliente.Text=" ";
            txt_Descripcion.Text=" ";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Metodos metodo = new Metodos();
            string id_trabajo = txt_IDTrabajo.Text;

            if ((txt_Costo.Text == "" || id_trabajo == ""))
            {
                DialogResult result = MessageBox.Show("Ocurrio Un Problema Porfavor Rebice Bien Los Campos!!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                float costo = float.Parse(txt_Costo.Text);
                try
                {

                    metodo.terminarTrabajo(costo, id_trabajo);
                    metodo.CargarTrabajos(dgv_Trabajos);
                    DialogResult result = MessageBox.Show("Trabajo Ingresado", "Atencion", MessageBoxButtons.OK);
                }
                catch (Exception A)
                {
                    DialogResult result = MessageBox.Show("Ocurrio Un Problema Porfavor Rebice Bien Los Campos!!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            txt_Costo.Text = "";
            txt_IDTrabajo.Text = "";
        }

        private void txt_IdCliente_TextChanged(object sender, EventArgs e)
        {

            //Ingrese el proceso de cargar el combobox de autos aqui porque este se activa
            //cuando el txt de clientes cambia para que se actualize constantemente
            //dependiendo de que dato contenga y la consulta solo muestra datos en el combo box si
            //el dato del cliente exista en caso de que no no muestra nada.
            //Se instancia la clase metodos
            Metodos metodos = new Metodos();
            //se carga el cbo de autos por medio del metodo cargarCboAutos al cual le mandamos el dato 
            //del Id del cliente para la consulta personalizada
            cbo_AutosClientes.DataSource = metodos.cargarCboAutos(txt_IdCliente.Text);
            //Pedimos el dato de la matricula con el identificador que al igual es la matricula
            cbo_AutosClientes.DisplayMember = "matricula";
            cbo_AutosClientes.ValueMember = "matricula";
        }

        private void txt_Costo_KeyPress(object sender, KeyPressEventArgs e)
        {

            //Ingresare un codigo para que solo se puedan ingresar numeros lo ingrese en este evento del
            //txt costo porque se activa al presionar una tecla y verifica que tecla fue.
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                MessageBox.Show("Solo se permiten datos numericos!!!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
        private void Abrir(object ventana)
        {
            if (this.Controls.Count > 0)
                this.Controls.RemoveAt(0);

            Form myForm = ventana as Form;
            myForm.TopLevel = false;
            myForm.Dock = DockStyle.Fill;
            this.Controls.Add(myForm);
            this.Tag = myForm;
            myForm.Show();
        }
        private void GetText()
        {
            
            lbl_TituloTrabajos.Text = Res.lbl_TituloTrabajos;
            GB_GenerarTrabajo.Text = Res.GB_GenerarTrabajo;
            GB_TerminarTrabajo.Text = Res.GB_TerminarTrabajo;
            lbl_AutoDelCliente.Text = Res.lbl_AutoDelCliente;
            lbl_CostoDelTrabajo.Text = Res.lbl_CostoDelTrabajo;
            lbl_DescripcionDelTrabajo.Text = Res.lbl_DescripcionDelTrabajo;
            lbl_EmpleadoEncargado.Text = Res.lbl_EmpleadoEncargado;
            lbl_Idtrabajo.Text = Res.lbl_Idtrabajo;
            lbl_VencejoPIN.Text = Res.lbl_VencejoPIN;
            btn_FinalizarTrabajo.Text = Res.btn_FinalizarTrabajo;
            btn_GenerarTrabajo.Text = Res.btn_GenerarTrabajo;
        }



    }
}
