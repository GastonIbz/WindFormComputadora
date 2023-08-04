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

        public int abmComputadora(string accion, Computadora objComputadora)
        {
            return DatosObjComputadora.abmComputadora(accion, objComputadora);
        }

        public DataSet ListadoComputadoras(string cual)
        {
            return DatosObjComputadora.ListadoComputadoras(cual);
        }
    }
}