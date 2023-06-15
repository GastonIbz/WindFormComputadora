using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades.Base_de_Datos;

namespace WFComputadora
{
    public partial class FormComputadora : Form
    {
        int Fila;
        bool nuevo = true;
        public FormComputadora()
        {
            InitializeComponent();
            Dgv_iniciar();
        }
        // Inicializa las columnas del DataGridView
        void Dgv_iniciar()
        {
            Dgv_computadora.Columns.Add("0", "Modelo"); // Crea columna de Modelo
            Dgv_computadora.Columns.Add("1", "Codigo"); // Crea columna de Codigo
            Dgv_computadora.Columns.Add("2", "Aplicaciones"); // Crea columna de Aplicaciones
            Dgv_computadora.Columns.Add("3", "Ultima Actualización"); // Crea columna Ultima actualización
   
        }
        private void Btn_cargar_Click(object sender, EventArgs e)
        {
            // Variable para almacenar nuevos datos de computadora
            Computadora NuevaCompu;

            // Instancia una nueva computadora utilizando los valores escritos en los textos

            NuevaCompu = new Computadora(int.Parse(Txtb_codigo.Text), Txtb_modelo.Text);

            Lbl_codigomov.Text = NuevaCompu.Pcodigo.ToString();
            Lbl_modelomov.Text = NuevaCompu.Pmodelo;
            Lbl_aplicacionesmov.Text = "Hay " + NuevaCompu.Paplicaciones.ToString() + " aplicaciones ejecuntadonse en este momento";


            // Selecciona una pestaña específica del Tab
            Tab_computadorac.SelectedTab = Tab_movimientoc;
            Textb_mov.Clear(); // Borra el contenido
            Textb_mov.Focus(); // Le da foco al cuado de texto e indica que debe ir a ese cuadro en específico.

            MessageBox.Show("Datos de la computadora cargados"); // Mensaje modal
                                                                 // Agrega una nueva fila al DataGridView con los datos del producto
            Dgv_computadora.Rows.Add(NuevaCompu.Pmodelo.ToString(), NuevaCompu.Pcodigo.ToString(), NuevaCompu.Paplicaciones.ToString(), NuevaCompu.PultimaActualizacion.Date);

            Fila = (Dgv_computadora.Rows.Count - 1); // Actualiza el valor de la variable Fila
            nuevo = true; // Indica que existe una nueva computadora




        }

        private void Btn_salir_Click(object sender, EventArgs e)
        {
            DialogResult salir = MessageBox.Show("¿Está seguro que desea salir?", "Confirmación de salida", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (salir == DialogResult.Yes)
            {
                // Código para cerrar la aplicación
                Application.Exit();
            }
        }

        private void Btn_salir2_Click(object sender, EventArgs e)
        {
            DialogResult salir = MessageBox.Show("¿Está seguro que desea salir?", "Confirmación de salida", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (salir == DialogResult.Yes)
            {
                // Código para cerrar la aplicación
                Application.Exit();
            }
        }

       
    }
}
