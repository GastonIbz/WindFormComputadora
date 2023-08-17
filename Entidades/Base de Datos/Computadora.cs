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
        // Atributos de la clase computadora.
        // Número de aplicaciones, Última actualización, Código, Modelo, Número de CUIL y Patente.
        private int aplicaciones;
        private bool prendida;
        private DateTime ultimaActualizacion;
        private int codigo;
        private string modelo;
        private string cuil;
        private string patente;
        #endregion

        #region Propiedades
        // Propiedades que permiten obtener atributos relacionados con la información de la computadora.
        public string Pmodelo
        {
            set { modelo = value; }
            get { return modelo; }
        }
        public string Pcuil
        {
            set { cuil = value; }
            get { return cuil; }
        }
        public string Ppatente
        {
            set { patente = value; }
            get { return patente; }
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
        // Constructor de la clase Computadora.
        // Establece el modelo, la cantidad de aplicaciones, Última actualización, Código, Número de CUIL y patente de la computadora.
        public Computadora(int cod, string modelo, int app, string cuil, string patente)
        {
            this.modelo = modelo;
            aplicaciones = app;
            prendida = true;
            ultimaActualizacion = DateTime.MinValue;
            this.codigo = cod;
            this.cuil = cuil;
            this.patente = patente;
        }
        #endregion

        #region Metodos

        // Incrementa la cantidad de aplicaciones ejecutándose en la computadora.
        public void Ingreso(int cant)
        {
            aplicaciones = aplicaciones + cant;
        }
        // Decrementa la cantidad de aplicaciones ejecutándose en la computadora
        public void Salida(int cant)
        {
            aplicaciones = aplicaciones - cant;
        }

        // Enciende la computadora si no está prendida.
        public void Prender()
        {
            if (!prendida)
            {
                prendida = true;

            }
        }
        // Apaga la computadora si está prendida.
        public void Apagar()
        {
            if (prendida)
            {
                prendida = false;

            }
        }


        // Actualiza la fecha de la última actualización de la computadora.
        public void ActualizarUltimaActualizacion(DateTime nuevaFecha)
        {
            ultimaActualizacion = nuevaFecha;
        }

        // Verifica si un CUIL tiene el formato válido.
        private bool ValidarFormatoCuil(string cuil)
        {
            // El formato correcto es: 11-12345678-1.
            string pat = @"\d{2}-\d{8}-\d{1}";

            // Verificar si el cuil coincide con el patrón
            return System.Text.RegularExpressions.Regex.IsMatch(cuil, pat);
        }
        // Verifica si una patente tiene el formato válido .
        private bool ValidarFormatoPatente(string patente)
        {
            // El formato correcto es: ASD123.
            string pat = @"^[A-Z]{3}\d{3}$";
            return System.Text.RegularExpressions.Regex.IsMatch(patente, pat);
        }



        #endregion

    }

}
