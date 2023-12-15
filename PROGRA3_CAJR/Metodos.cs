using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;
using AccesoDatos;


namespace PROGRA3_CAJR
{
    public class Metodos: Conexion
    {

        public void CargarClientes(DataGridView Tabla)
        {
            using (var conexion = GetConnection())
            {
                SqlDataAdapter datos = new SqlDataAdapter("SELECT * FROM Clientes", conexion);
                DataSet tabla = new DataSet();
                datos.Fill(tabla, "Clientes");
                Tabla.DataSource = tabla.Tables["Clientes"];
            }
        }
        public void CargarAutos(DataGridView Tabla)
        {
            using (var conexion = GetConnection())
            {
                SqlDataAdapter datos = new SqlDataAdapter("SELECT * FROM Autos", conexion);
                DataSet tabla = new DataSet();
                datos.Fill(tabla, "Autos");
                Tabla.DataSource = tabla.Tables["Autos"];
            }
        }
        public void CargarEmpleados(DataGridView Tabla)
        {
            using (var conexion = GetConnection())
            {
                SqlDataAdapter datos = new SqlDataAdapter("SELECT * FROM Empleados", conexion);
                DataSet tabla = new DataSet();
                datos.Fill(tabla, "Empleados");
                Tabla.DataSource = tabla.Tables["Empleados"];
            }
        }
        public void CargarInventario(DataGridView Tabla)
        {
            using (var conexion = GetConnection())
            {
                SqlDataAdapter datos = new SqlDataAdapter("SELECT * FROM Inventarios", conexion);
                DataSet tabla = new DataSet();
                datos.Fill(tabla, "Inventarios");
                Tabla.DataSource = tabla.Tables["Inventarios"];
            }
        }

        public void CargarTrabajos(DataGridView Tabla)
        {
            using (var conexion = GetConnection())
            {
                SqlDataAdapter datos = new SqlDataAdapter("SELECT * FROM Trabajos", conexion);
                DataSet tabla = new DataSet();
                datos.Fill(tabla, "Trabajos");
                Tabla.DataSource = tabla.Tables["Trabajos"];
            }
        }
        public DataTable cargarCboAutos(string id_cliente)
        {
            using (var conexion = GetConnection())
            {
                SqlDataAdapter adaptador = new SqlDataAdapter("SELECT *  FROM autos where dueño='" + id_cliente + "'", conexion);
                DataTable datos = new DataTable();
                adaptador.Fill(datos);
                return datos;
            }
        }
        public DataTable cargarCboEmpleados()
        {
            using (var conexion = GetConnection())
            {
                SqlDataAdapter adaptador = new SqlDataAdapter("SELECT * From Empleados where estado='Contrato Activo'", conexion);
                DataTable datos = new DataTable();
                adaptador.Fill(datos);
                return datos;
            }
        }
        public void guardarTrabajo(string id_cliente, string id_empleado, string automovil, string Descripcion)
        {
            using (var conexion = GetConnection())
            {
                SqlCommand comando, comando2;
                string insercion = $"insert into Trabajos(	descripcion_trabajo,	fecha_entrada,	fecha_salida,	id_cliente,	id_empleado,	estatus_trabajo,	id_auto, costo)" +
                    $" values('" + Descripcion + "',GETDATE(),null,'" + id_cliente + "','" + id_empleado + "','En Proceso','" + automovil + "',null)";
                string actualizacion = $"update Clientes SET No_trabajos_solicitados = No_trabajos_solicitados+1";

                conexion.Open();
                comando = new SqlCommand(insercion, conexion);
                comando2 = new SqlCommand(actualizacion, conexion);
                comando.ExecuteNonQuery();
                comando2.ExecuteNonQuery();
            }
        }
        public void ingresarInventarios(string nombreObjeto, string Cantidad, string costoUnidad)
        {
            using (var conexion = GetConnection())
            {
                SqlCommand comando;
                string insercion = $"insert into Inventarios(	nombre_objeto,	cantidad, costo_unidad, fecha_ingreso, fecha_ultima_actualizacion) values('" + nombreObjeto + "','" + Cantidad + "','" + costoUnidad + "',GETDATE(),GETDATE())";

                conexion.Open();
                comando = new SqlCommand(insercion, conexion);
                comando.ExecuteNonQuery();
            }
        }
        public void actualizarInventariosNombreObjeto(string Id_inventarios,string nombreObjeto)
        {
            using (var conexion = GetConnection())
            {
                SqlCommand comando;
                string actualizacion = $"UPDATE Inventarios SET nombre_objeto='" + nombreObjeto + "',fecha_ultima_actualizacion=GETDATE() where id_objeto='" + Id_inventarios + "'";

                conexion.Open();
                comando = new SqlCommand(actualizacion, conexion);
                comando.ExecuteNonQuery();
            }
        }
        public void actualizarInventariosCantidadObjeto(string Id_inventarios, string Cantidad)
        {
            using (var conexion = GetConnection())
            {
                SqlCommand comando;
                string actualizacion = $"UPDATE Inventarios SET cantidad='" + Cantidad + "',fecha_ultima_actualizacion=GETDATE() where id_objeto='" + Id_inventarios + "'";

                conexion.Open();
                comando = new SqlCommand(actualizacion, conexion);
                comando.ExecuteNonQuery();
            }
        }
        public void actualizarInventariosCostoUnidad(string Id_inventarios, string costoUnidad)
        {
            using (var conexion = GetConnection())
            {
                SqlCommand comando;
                string actualizacion = $"UPDATE Inventarios SET costo_unidad='" + costoUnidad + "',fecha_ultima_actualizacion=GETDATE() where id_objeto='" + Id_inventarios + "'";

                conexion.Open();
                comando = new SqlCommand(actualizacion, conexion);
                comando.ExecuteNonQuery();
            }
        }



        public void terminarTrabajo(float costo, string id_trabajo)
        {
            using (var conexion = GetConnection())
            {
                SqlCommand comando;
                string actualizacion = $"update Trabajos SET fecha_salida=GETDATE(),estatus_trabajo='Terminado',costo='" + costo + "' where id_trabajo='" + id_trabajo + "' and estatus_trabajo='En Proceso'";

                conexion.Open();
                comando = new SqlCommand(actualizacion, conexion);
                comando.ExecuteNonQuery();
            }

        }
        public void ingresarCliente(string primerApellido, string segundoApellido, string primerNombre, string segundoNombre, string edad, string telefono, string email)
        {
            using (var conexion = GetConnection())
            {
                SqlCommand comando;
                string insercion = $"insert into Clientes(primer_nombre,	segundo_nombre,	primer_apellido,	segundo_apellido,	edad,	numero_telefono,	email,	No_trabajos_solicitados,fecha_registro)" +
                    $" values('" + primerNombre + "','" + segundoNombre + "','" + primerApellido + "','" + segundoApellido + "','" + edad + "','" + telefono + "','" + email + "',0,GETDATE())";

                conexion.Open();
                comando = new SqlCommand(insercion, conexion);
                comando.ExecuteNonQuery();
            }
        }
        public void ingresarAuto(string matricula, string modelo, string marca, string idCliente)
        {
            using (var conexion = GetConnection())
            {
                SqlCommand comando;
                string insercion = $"insert into autos(matricula,	modelo,	marca,	dueño,fecha_registro)" +
                    $" values('" + matricula + "','" + modelo + "','" + marca + "','" + idCliente + "',GETDATE())";

                conexion.Open();
                comando = new SqlCommand(insercion, conexion);
                comando.ExecuteNonQuery();
            }
        }
        public void ingresarEmpleado(string primerApellido, string segundoApellido, string primerNombre, string segundoNombre, string edad, string telefono, string email, string puesto)
        {
            using (var conexion = GetConnection())
            {
                SqlCommand comando;
                string insercion = $"insert into Empleados(primer_nombre,	segundo_nombre,	primer_apellido,	segundo_apellido,	edad,	numero_telefono,	email,	No_trabajos_realizados,puesto,fecha_registro,estado)" +
                    $" values('" + primerNombre + "','" + segundoNombre + "','" + primerApellido + "','" + segundoApellido + "','" + edad + "','" + telefono + "','" + email + "',0,'" + puesto + "',GETDATE(),'Contrato Activo')";

                conexion.Open();
                comando = new SqlCommand(insercion, conexion);
                try
                {
                    comando.ExecuteNonQuery();
                }
                catch (Exception a)
                {
                    DialogResult result = MessageBox.Show("Ocurrio Un Problema Porfavor Rebice Bien Los Campos!!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }
        public void eliminarEmpleado(string id_empleado, string primer_nombre, string primer_apellido)
        {
            using (var conexion = GetConnection())
            {
                SqlCommand comando;
                string insercion = $"update Empleados Set estado = 'Contrato Finalizado' WHERE id_empleado='" + id_empleado + "' AND primer_nombre='" + primer_nombre + "' AND primer_apellido='" + primer_apellido + "'";

                conexion.Open();
                comando = new SqlCommand(insercion, conexion);
                comando.ExecuteNonQuery();
            }
        }
        public void FiltrarClientes(DataGridView Tabla,string VencejoPIN, string PrimerApellido, string PrimerNombre)
        {
            using (var conexion = GetConnection())
            {
                SqlDataAdapter datos = new SqlDataAdapter("SELECT * FROM Clientes where ( primer_apellido='" + PrimerApellido + "' or primer_nombre='" + PrimerNombre + "') or id_cliente='" + VencejoPIN + "'", conexion);
                DataSet tabla = new DataSet();
                datos.Fill(tabla, "Clientes");
                Tabla.DataSource = tabla.Tables["Clientes"];
            }
        }
        public void FiltrarAuto(DataGridView Tabla, string Modelo, string Matricula)
        {
            using (var conexion = GetConnection())
            {
                SqlDataAdapter datos = new SqlDataAdapter("SELECT * FROM autos where ( modelo='" + Modelo + "' or matricula='" + Matricula + "') ", conexion);
                DataSet tabla = new DataSet();
                datos.Fill(tabla, "autos");
                Tabla.DataSource = tabla.Tables["autos"];
            }
        }
        public void FiltrarEmpleados(DataGridView Tabla, string ID_Empleado, string PrimerApellido, string PrimerNombre, string puesto)
        {
            using (var conexion = GetConnection())
            {
                SqlDataAdapter datos = new SqlDataAdapter("SELECT * FROM Empleados where ( primer_apellido='" + PrimerApellido + "' or primer_nombre='" + PrimerNombre + "')" +
                " or (id_empleado='" + ID_Empleado + "' or puesto='" + puesto + "')", conexion);
                DataSet tabla = new DataSet();
                datos.Fill(tabla, "Empleados");
                Tabla.DataSource = tabla.Tables["Empleados"];
            }
        }
        public void FiltrarInventarios(DataGridView Tabla, string IdObjeto, string NombreObjeto)
        {
            using (var conexion = GetConnection())
            {
                SqlDataAdapter datos = new SqlDataAdapter("SELECT * FROM Inventarios where ( id_objeto='" + IdObjeto + "' or nombre_objeto='" + NombreObjeto + "')  ", conexion);
                DataSet tabla = new DataSet();
                datos.Fill(tabla, "Inventarios");
                Tabla.DataSource = tabla.Tables["Inventarios"];
            }
        }
        public void EliminarInventarios(string IdObjeto, string NombreObjeto)
        {
            using (var conexion = GetConnection())
            {
                SqlCommand comando;
                string eliminar = $"DELETE FROM Inventarios WHERE id_objeto='" + IdObjeto + "' AND nombre_objeto='" + NombreObjeto + "'";

                conexion.Open();
                comando = new SqlCommand(eliminar, conexion);
                comando.ExecuteNonQuery();
            }
        }
      }
    }
