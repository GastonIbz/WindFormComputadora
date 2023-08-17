using Entidades.Base_de_Datos;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class AdministracionCompu : DatosdeConexion
    {
        // Método para realizar operaciones de alta, baja y modificación en la base de datos.
        public int abmComputadora(string accion, Computadora objComputadora)
        {
            int resultado = -1;
            string consulta = string.Empty;

            if (accion == "Agregar")
            {
                // Consulta para agregar una nueva computadora a la base de datos.
                consulta = "INSERT INTO computadoras (Aplicaciones, UltimaActualizacion, Modelo, Codigo, Cuil, Patente) VALUES (" +
              objComputadora.Paplicaciones + ",'" +
              objComputadora.PultimaActualizacion + "', '" +
              objComputadora.Pmodelo + "', " +
              objComputadora.Pcodigo + ", '" +
              objComputadora.Pcuil + "', '" +
              objComputadora.Ppatente + "')";
            
        }
            else if (accion == "Borrar")
            {
                // Consulta para borrar una computadora de la base de datos.
                consulta = "DELETE FROM Computadoras WHERE Codigo=" + objComputadora.Pcodigo + ";";
            }

            OleDbCommand cmd = new OleDbCommand(consulta, conexion);
            try
            {
                Abrirconexion();
                resultado = cmd.ExecuteNonQuery(); // Ejecuta el resultado y devuelve la cantidad de filas afectadas.
            }
            catch (Exception error)
            {
                throw new Exception("Error al tratar de agregar, modificar o borrar computadoras", error);
            }
            finally
            {
                Cerrarconexion();
                cmd.Dispose();
            }

            return resultado; // Devuelve el resultado de la operación.
        }

        // Obtiene un conjunto de datos de la computadora según el filtro especificado.
        public DataSet ListadoComputadoras(string cual) // para 1 o todos los datos según el código
        {
            string consulta = string.Empty;

            if (cual != "Todos")
                consulta = "SELECT * FROM Computadoras WHERE Codigo = " + int.Parse(cual) + ";";
            else
                consulta = "SELECT * FROM Computadoras;";

            OleDbCommand cmd = new OleDbCommand(consulta, conexion);
            DataSet ds = new DataSet();
            OleDbDataAdapter da = new OleDbDataAdapter();
            try
            {
                Abrirconexion();
                da.SelectCommand = cmd;
                da.Fill(ds); // Rellena el DataSet con los datos obtenidos.
            }
            catch (Exception error)
            {
                throw new Exception("Error al listar computadoras", error);
            }
            finally
            {
                Cerrarconexion();
                cmd.Dispose();
            }

            return ds; // Devuelve el conjunto de datos.
        }
    }
}
