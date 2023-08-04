using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Base_de_Datos
{
    public class Computadora
    {
        #region Atributos
        private int aplicaciones;
        private bool prendida;
        private DateTime ultimaActualizacion;
        private int codigo;
        private string modelo;
        #endregion

        #region Propiedades
        public string Pmodelo
        {
            set { modelo = value; }
            get { return modelo; }
        }

        public int Pcodigo
        {
            set { codigo = value; }
            get { return codigo; }
        }

        public int Paplicaciones
        {
            get { return aplicaciones; }
        }
        public bool Pprendida
        {
            set { prendida = value; }
            get { return prendida; }
        }

        public DateTime PultimaActualizacion
        {
            get { return ultimaActualizacion; }
        }

        #endregion

        #region Constructores

        public Computadora()
        {
            prendida = false;
            ultimaActualizacion = DateTime.MinValue;
        }

        public Computadora(int cod, string modelo, int app)
        {
            this.modelo = modelo;
            aplicaciones = app;
            prendida = true;
            ultimaActualizacion = DateTime.MinValue;
            this.codigo = cod;
        }
        #endregion

        #region Metodos
        public void Ingreso(int cant)
        {
            aplicaciones = aplicaciones + cant;
        }

        public void Salida(int cant)
        {
            aplicaciones = aplicaciones - cant;
        }
        public void Prender()
        {
            if (!prendida)
            {
                prendida = true;

            }
        }

        public void Apagar()
        {
            if (prendida)
            {
                prendida = false;

            }
        }
        public void ActualizarUltimaActualizacion(DateTime nuevaFecha)
        {
            ultimaActualizacion = nuevaFecha;
        }
        #endregion

    }
}
