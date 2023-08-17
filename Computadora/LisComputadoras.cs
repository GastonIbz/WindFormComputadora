using CapaDatos;
using Entidades.Base_de_Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaComputadora
{
    public class LisComputadoras
    {
        AdministracionCompu DatosObjComputadora = new AdministracionCompu();

        // Realiza operaciones de alta, baja y modificación en la base de datos.
        public int abmComputadora(string accion, Computadora objComputadora)
        {
            // Llama al método abmComputadora de la clase AdministracionCompu y devuelve su resultado.
            return DatosObjComputadora.abmComputadora(accion, objComputadora);
        }

        // Obtiene un conjunto de datos de las computadoras según el filtro especificado.
        public DataSet ListadoComputadoras(string cual)
        {
            // Llama al método ListadoComputadoras de la clase AdministracionCompu y devuelve su resultado.
            return DatosObjComputadora.ListadoComputadoras(cual);
        }
    }
}