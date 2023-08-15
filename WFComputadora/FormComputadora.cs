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
using CapaComputadora;


namespace WFComputadora
{
    public partial class FormComputadora : Form
    {
        int Fila;
        LisComputadoras objCapaComputadora = new LisComputadoras();

        public FormComputadora()
        {
            InitializeComponent();
            Dgv_iniciar();
            LLenarDGV();
        }

        private void LLenarDGV()
        {
            Dgv_computadora.Rows.Clear();
            DataSet ds = new DataSet();
            ds = objCapaComputadora.ListadoComputadoras("Todos");
            if (ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    Dgv_computadora.Rows.Add(
                        dr[4], // Codigo
                        dr[3], // Modelo
                        dr[1], // Aplicaciones
                        dr[2], // Última Actualización
                        dr[5]  // CUIL
                    );
                }
            }
            else
                MessageBox.Show("No existe la computadora");
        }


        // Inicializa las columnas del DataGridView
        private void Dgv_iniciar()
        {
            Dgv_computadora.Columns.Add("0", "Codigo"); // Crea columna de Codigo
            Dgv_computadora.Columns.Add("1", "Modelo"); // Crea columna de Modelo
            Dgv_computadora.Columns.Add("2", "Aplicaciones"); // Crea columna de Aplicaciones
            Dgv_computadora.Columns.Add("3", "Ultima Actualización"); // Crea columna Ultima actualización
            Dgv_computadora.Columns.Add("4", "CUIL"); // Crea columna Cuil.

        }
        private bool ValidarFormatoCuil(string cuil)
        {
            // El patrón de expresión regular para el formato XX-XXXXXXXX-X
            string patron = @"\d{2}-\d{8}-\d{1}";

            // Verificar si el cuil coincide con el patrón
            return System.Text.RegularExpressions.Regex.IsMatch(cuil, patron);
        }
        private void Btn_cargar_Click(object sender, EventArgs e)
        {
            {
                // Validaciones

                // Valida si algún campo está vacío
                if (string.IsNullOrEmpty(Txtb_codigo.Text) || string.IsNullOrEmpty(Txtb_modelo.Text))
                {
                    MessageBox.Show("Debe completar todos los campos obligatorios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                // Validar valor del TextBox de Código - debe contener un número entero
                if (!int.TryParse(Txtb_codigo.Text, out int codigo))
                {
                    MessageBox.Show("Ingrese un valor válido para el código, solo debe contener números.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Validar valor del TextBox de Aplicaciones - debe contener un número entero.
                if (!int.TryParse(Txtb_aplicaciones.Text, out int aplicaciones))
                {
                    MessageBox.Show("Ingrese un valor válido para las aplicaciones, solo debe contener números.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                // Validar valor del TextBox de CUIL
                if (string.IsNullOrEmpty(Txtb_cuil.Text))
                {
                    MessageBox.Show("Debe ingresar un valor para el CUIL.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


                // Valida que el valor del Txtb_aplicaciones deba contener un número entero que esté entre 0 y 15.
                if (!int.TryParse(Txtb_aplicaciones.Text, out int cantidadAplicaciones) || cantidadAplicaciones < 0 || cantidadAplicaciones > 15)
                {
                    if (cantidadAplicaciones > 15)
                    {
                        MessageBox.Show("No pueden haber más de 15 aplicaciones ejecutadas.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Ingrese una cantidad válida de aplicaciones.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    return;
                }

                if (!ValidarFormatoCuil(Txtb_cuil.Text))
                {
                    MessageBox.Show("Ingrese un CUIL válido en el formato 11-12345678-1.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Variable para almacenar nuevos datos de computadora
                Computadora NuevaCompu;

                // Instancia una nueva computadora utilizando los valores escritos en los textos
                NuevaCompu = new Computadora(
         int.Parse(Txtb_codigo.Text),
         Txtb_modelo.Text,
         int.Parse(Txtb_aplicaciones.Text),
         Txtb_cuil.Text // Asignar el valor del CUIL
     );

                // Obtiene la fecha seleccionada del Date Time
                DateTime fechaSeleccionada = Datetime_actualizacion.Value;

                // Actualiza la propiedad de Ultima Actualización con la fecha seleccionada
                NuevaCompu.ActualizarUltimaActualizacion(fechaSeleccionada);

                // Valores de los Label
                {
                    Lbl_codigomov.Text = "Código: " + NuevaCompu.Pcodigo.ToString(); // Asigna el valor del código al label
                    Lbl_modelomov.Text = "Modelo: " + NuevaCompu.Pmodelo; // Asigna el valor del modelo al label
                    Lbl_actualizacionmov.Text = "Última actualización: " + NuevaCompu.PultimaActualizacion.ToString("dd/MM/yyyy HH:mm:ss"); // Se asigna el valor y texto al label para mostrar la ultima actualización
                    Lbl_cuilmov.Text = "CUIL: " + NuevaCompu.PCuil; // Mostrar el CUIL en el label
                    Lbl_aplicacionesmov.Text = "Hay " + NuevaCompu.Paplicaciones.ToString() + " aplicaciones ejecutándose en este momento"; // Se asigna el valor y texto al label ostrar la cantidad de aplicaciones
                }
                // Selecciona una pestaña específica del Tab para que al cargar los datos se mueva de pestaña
                Tab_computadorac.SelectedTab = Tab_movimientoc;

                MessageBox.Show("Datos de la computadora cargados", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information); // Mensaje modal

                // Agrega una nueva fila al DataGridView con los datos de la computadora
                Dgv_computadora.Rows.Add(
       NuevaCompu.Pcodigo.ToString(),
       NuevaCompu.Pmodelo,
       NuevaCompu.Paplicaciones.ToString(),
       NuevaCompu.PultimaActualizacion.ToString("dd/MM/yyyy HH:mm:ss"),
       NuevaCompu.PCuil // Agrega el CUIL a la fila del DataGridView
   );

                Fila = Dgv_computadora.Rows.Count - 1; // Actualiza el valor de la variable Fila

            }

        }

        private void Btn_salir_Click(object sender, EventArgs e)
        {
            // Cerrar la aplicación
            DialogResult salir = MessageBox.Show("¿Está seguro que desea salir?", "Confirme si desea salir.", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (salir == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void Btn_salir2_Click(object sender, EventArgs e)
        {
            DialogResult salir = MessageBox.Show("¿Está seguro que desea salir?", "Confirme si desea salir.", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (salir == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void Btn_borrar_Click(object sender, EventArgs e)
        {
            // Verificar si hay al menos una fila en el DataGridView
            if (Dgv_computadora.Rows.Count > 0)
            {
                // Verificar si se ha seleccionado una fila completa
                if (Dgv_computadora.SelectedRows.Count > 0)
                {
                    // Mostrar un MessageBox de confirmación
                    DialogResult resultado = MessageBox.Show("¿Está seguro que desea eliminar la fila seleccionada?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (resultado == DialogResult.Yes)
                    {
                        // Obtener la fila seleccionada
                        DataGridViewRow filaSeleccionada = Dgv_computadora.SelectedRows[0];

                        // Verificar si la fila no está vacía
                        if (filaSeleccionada != null && !filaSeleccionada.IsNewRow)
                        {
                            // Eliminar la fila seleccionada
                            Dgv_computadora.Rows.Remove(filaSeleccionada);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("No se ha seleccionado una fila para borrar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("No hay filas para borrar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }
    }
}





