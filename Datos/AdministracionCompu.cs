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
        public int abmComputadora(string accion, Computadora objComputadora)
        {
            int resultado = -1;
            string consulta = string.Empty;

            if (accion == "Agregar")
            {
                consulta = "INSERT INTO Computadoras (Codigo, Modelo, Aplicaciones, UltimaActualizacion) VALUES (" + objComputadora.Pcodigo + ",'" + objComputadora.Pmodelo + "', '" + objComputadora.Paplicaciones + "', '" + objComputadora.PultimaActualizacion + "');";
            }
            // else if (accion == "Modificar") // Hace falta poner el boton modificar - se puede modificar de forma manual.
            // {
            //    consulta = "UPDATE Computadoras SET Modelo='" + objComputadora.Pmodelo + "', Aplicaciones='" + objComputadora.Paplicaciones + "' WHERE Codigo=" + objComputadora.Pcodigo + ";";
            // } 
            else if (accion == "Borrar")
            {
                consulta = "DELETE FROM Computadoras WHERE Codigo=" + objComputadora.Pcodigo + ";";
            }

            OleDbCommand cmd = new OleDbCommand(consulta, conexion);
            try
            {
                Abrirconexion();
                resultado = cmd.ExecuteNonQuery();
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

            return resultado;
        }

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
                da.Fill(ds);
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

            return ds;
        }
    }
}
