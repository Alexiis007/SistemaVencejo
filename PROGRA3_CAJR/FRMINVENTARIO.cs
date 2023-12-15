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
    public partial class FRMINVENTARIO : Form
    {
        public FRMINVENTARIO()
        {
            InitializeComponent();
        }

        private void FRMINVENTARIO_Load(object sender, EventArgs e)
        {
            Metodos metodo = new Metodos();
            metodo.CargarInventario(dgv_Objetos);
            GetText();
        }

        private void btn_IngresarObjeto_Click(object sender, EventArgs e)
        {
            string nombreObjeto = txt_NombreObjeto.Text;
            string Cantidad = txt_Cantidad.Text;
            string costoUnidad = txt_CostoUnidad.Text;
            if ((nombreObjeto == "" || Cantidad == "") || costoUnidad == "")
            {
                DialogResult result = MessageBox.Show("Ocurrio Un Problema Porfavor Rebice Bien Los Campos!!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                Metodos metodo = new Metodos();
                metodo.ingresarInventarios(nombreObjeto, Cantidad, costoUnidad);
                metodo.CargarInventario(dgv_Objetos);
                DialogResult result = MessageBox.Show("Objeto Ingresado", "Atencion", MessageBoxButtons.OK);
            }
            txt_NombreObjeto.Text="";
            txt_Cantidad.Text="";
            txt_CostoUnidad.Text="";

        }

        private void btn_Actualizar_Click(object sender, EventArgs e)
        {
            string Id_Objeto = txt_ActualizarIdObjeto.Text;
            string nombreObjeto;
            string Cantidad;
            string costoUnidad;
            if (Id_Objeto == "")
            {
                DialogResult result = MessageBox.Show("Ocurrio Un Problema Porfavor Revice Que Esta Ingresando El ID Del Objeto A Actualizar!!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                Metodos metodo = new Metodos();

                if (txt_ActualizarNombreObjeto.Text.Length != 0)
                {
                    nombreObjeto = txt_ActualizarNombreObjeto.Text;
                    metodo.actualizarInventariosNombreObjeto(Id_Objeto, nombreObjeto);

                }
                if (txt_ActualizarCantidad.Text.Length != 0)
                {
                    Cantidad = txt_ActualizarCantidad.Text;
                    metodo.actualizarInventariosCantidadObjeto(Id_Objeto, Cantidad);
                }
                if (txt_ActualizarCostoUnidad.Text.Length != 0)
                {
                    costoUnidad = txt_ActualizarCostoUnidad.Text;
                    metodo.actualizarInventariosCostoUnidad(Id_Objeto, costoUnidad);
                }
                metodo.CargarInventario(dgv_Objetos);
                DialogResult result = MessageBox.Show("Objeto Ingresado", "Atencion", MessageBoxButtons.OK);
            }
        }

        private void btn_FiltrarObjeto_Click(object sender, EventArgs e)
        {
            string IdObjeto = " ";
            string NombreObjeto = " ";

            Metodos metodo = new Metodos();
            if (txt_FiltrarIdObjeto.Text.Length == 0 && txt_FiltrarNombreObjeto.Text.Length == 0)
            {
                metodo.CargarInventario(dgv_Objetos);
            }
            else
            {
                if (txt_FiltrarIdObjeto.Text.Length == 0)
                {
                    IdObjeto = "00";
                }
                else { IdObjeto = txt_FiltrarIdObjeto.Text; }
                if (txt_FiltrarNombreObjeto.Text.Length == 0)
                {
                    NombreObjeto = "vacio";
                }
                else { NombreObjeto = txt_FiltrarNombreObjeto.Text; }
                metodo.FiltrarInventarios(dgv_Objetos, IdObjeto, NombreObjeto);
            }
                txt_FiltrarIdObjeto.Text = "";
                txt_FiltrarNombreObjeto.Text = "";
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            string IdObjeto = txt_EliminarIdObjeto.Text;
            string NombreObjeto = txt_EliminarNombreObjeto.Text;
            Metodos metodo = new Metodos();
            if (IdObjeto == "" || NombreObjeto == "")
            {
                DialogResult result = MessageBox.Show("Ocurrio Un Problema Porfavor Rebice Bien Los Campos!!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                metodo.EliminarInventarios(IdObjeto,NombreObjeto);
                DialogResult result = MessageBox.Show("Objeto Eliminado Con Exito", "Atencion", MessageBoxButtons.OK);
                metodo.CargarInventario(dgv_Objetos);
            }
            txt_EliminarIdObjeto.Text="";
            txt_EliminarNombreObjeto.Text="";

        }
        private void GetText()
        {
            lbl_TituloInventarios.Text = Res.lbl_TituloInventarios;
            GB_IngresoObjetos.Text = Res.GB_IngresoObjetos;
            GB_FiltrarObjeto.Text = Res.GB_FiltrarObjeto;
            GB_EliminarObjeto.Text = Res.GB_EliminarObjeto;
            GB_ActualizarObjeto.Text = Res.GB_ActualizarObjeto;
            btn_IngresarObjeto.Text = Res.btn_IngresarObjeto;
            btn_FiltrarObjeto.Text = Res.btn_FiltrarObjeto;
            btn_Eliminar.Text = Res.btn_Eliminar;
            btn_Actualizar.Text = Res.btn_Actualizar;


            lbl_ActualizarCantidad.Text = Res.lbl_ActualizarCantidad;
            lbl_ActualizarCostoUnidad.Text = Res.lbl_ActualizarCostoUnidad;
            lbl_ActualizarIdObjeto.Text = Res.lbl_ActualizarIdObjeto;
            lbl_ActualizarNombreObjeto.Text = Res.lbl_ActualizarNombreObjeto;
            lbl_Cantidad.Text = Res.lbl_Cantidad;
            lbl_CostoUnidad.Text = Res.lbl_CostoUnidad;
            lbl_EliminarIdObjeto.Text = Res.lbl_EliminarIdObjeto;
            lbl_EliminarNombreObjeto.Text = Res.lbl_EliminarNombreObjeto;
            lbl_FiltrarIdObjeto.Text = Res.lbl_FiltrarIdObjeto;
            lbl_FiltrarNombreObjeto.Text = Res.lbl_FiltrarNombreObjeto;
            lbl_NombreObjeto.Text = Res.lbl_NombreObjeto;
        }
    }
}
