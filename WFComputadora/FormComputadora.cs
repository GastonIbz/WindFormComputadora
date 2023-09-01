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
using System.Text.RegularExpressions;

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
            // Limpia y llena el DataGridView con los datos cargados en los TextBox que se guardan en la Base de datos.
            Dgv_computadora.Rows.Clear();
            DataSet ds = new DataSet();
            ds = objCapaComputadora.ListadoComputadoras("Todos");
            if (ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow dr in ds.Tables[0].Rows)
                {

                    Dgv_computadora.Rows.Add(dr[4], dr[3], dr[1], dr[2], dr[5], dr[6]);
                }
            }
            else
            {
                MessageBox.Show("No existe la computadora");
            }
        }

        private void Dgv_iniciar()
        {
            // Inicia las columnas del DataGridView.
            Dgv_computadora.Columns.Add("0", "Codigo");
            Dgv_computadora.Columns.Add("1", "Modelo");
            Dgv_computadora.Columns.Add("2", "Aplicaciones");
            Dgv_computadora.Columns.Add("3", "Ultima Actualización");
            Dgv_computadora.Columns.Add("4", "CUIL");
            Dgv_computadora.Columns.Add("5", "Patente");
        }

        private bool ValidarFormatoCuil(string cuil)
        {
            // Patrón de expresión regular para verificar el formato de CUIL (AAAAAAAAAA).
            string patronFormato = @"^\d{2}\d{8}\d{1}$";

            // Verifica si el CUIL cumple con el patrón de formato establecido.
            return Regex.IsMatch(cuil, patronFormato);
        }
        private bool ValidarFormatoPatente(string patente)
        {
            // Verifica si la patente tiene el formato correcto (LLNNNLL o LLLNNN).
            string pat = @"^[A-Z]{3}\d{3}$|^[A-Z]{2}\d{3}[A-Z]{2}$";

            // Verifica si la patente coincide con el patrón.
            return Regex.IsMatch(patente, pat);
        }
        private bool ValidarCodigoUnico(int codigo)
        {
            // Recorre todas las filas del DataGridView.
            foreach (DataGridViewRow row in Dgv_computadora.Rows)
            {
                // Verifica que la columna del código no sea nula y que coincida con el código que esta validando.
               
                if (row.Cells[0].Value != null && row.Cells[0].Value.ToString() == codigo.ToString())
                {
                    return false; // El código ya existe en una fila.
                }
            }
            return true; // El código es único.
        }

        private bool ValidarCuilUnico(string cuil)
        {
            // Recorre todas las filas del DataGridView.
            foreach (DataGridViewRow row in Dgv_computadora.Rows)
            {
                // Verifica que la columna del Cuil no sea nulo y que coincida con el cuil que esta validando.
                if (row.Cells[4].Value != null && row.Cells[4].Value.ToString() == cuil)
                {
                    return false; // El CUIL ya existe en una fila.
                }
            }
            return true; // El CUIL es único.
        }

        private bool ValidarPatenteUnica(string patente)
        {

            // Verifica que la columna de la patente no sea nula y que coincida con la patente que esta validando.
            foreach (DataGridViewRow row in Dgv_computadora.Rows)
            {
                if (row.Cells[5].Value != null && row.Cells[5].Value.ToString() == patente)
                {
                    return false; // La patente ya existe en una fila.
                }
            }
            return true; // La patente es única.
        }

        private void Btn_cargar_Click(object sender, EventArgs e)
        {
            // Obtener los valores de CUIL y patente desde los TextBox.
            string cuil = Txtb_cuil.Text;
            string patente = Txtb_patente.Text;


            // Valida que los campos obligatorios no estén vacíos.
            if (string.IsNullOrEmpty(Txtb_codigo.Text) || string.IsNullOrEmpty(Txtb_modelo.Text))
            {
                MessageBox.Show("Debe completar todos los campos obligatorios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Valida que el código sea un número válido.
            if (!int.TryParse(Txtb_codigo.Text, out int codigo))
            {
                MessageBox.Show("Ingrese un valor válido para el código, solo debe contener números.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Valida que las aplicaciones sean un número válido.

            if (!int.TryParse(Txtb_aplicaciones.Text, out int aplicaciones))
            {
                MessageBox.Show("Ingrese un valor válido para las aplicaciones, solo debe contener números.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Valida que se ingrese un valor para el CUIL
            if (string.IsNullOrEmpty(Txtb_cuil.Text))
            {
                MessageBox.Show("Debe ingresar un valor para el CUIL.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Valida que la cantidad de aplicaciones esté en el rango permitido, (Hasta 15 aplicaciones).
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
            // Valida que se ingrese una patente.

            if (string.IsNullOrEmpty(Txtb_patente.Text))
            {
                MessageBox.Show("Debe ingresar una patente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Valida que se ingrese correcamente el formato de la patente, (ASD123).
            if (!ValidarFormatoPatente(Txtb_patente.Text))
            {
                MessageBox.Show("Ingrese una patente válida en el formato ASD123.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Valida que se ingrese correcamente el formato del Cuil, (11-12345678-1).
            if (!ValidarFormatoCuil(Txtb_cuil.Text))
            {
                MessageBox.Show("Ingrese un CUIL válido en el formato 11-12345678-1.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Valida que el Código sea único.
            if (!ValidarCodigoUnico(codigo))
            {
                MessageBox.Show("El código ingresado ya existe. Ingrese un código único.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Valida que el Cuil sea único.
            if (!ValidarCuilUnico(cuil))
            {
                MessageBox.Show("El CUIL ingresado ya existe. Ingrese un CUIL único.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Valida que la patente sea única.
            if (!ValidarPatenteUnica(patente))
            {
                MessageBox.Show("La patente ingresada ya existe. Ingrese una patente única.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            // Crea una instancia de la clase Computadora y carga los datos ingresados en los TextBox.
            Computadora NuevaCompu;
            NuevaCompu = new Computadora(
                codigo,
                Txtb_modelo.Text,
                int.Parse(Txtb_aplicaciones.Text),
                cuil,
                patente
            );


            DateTime fechaSeleccionada = Datetime_actualizacion.Value; // Obtener la fecha seleccionada en el DateTimePicker
            NuevaCompu.ActualizarUltimaActualizacion(fechaSeleccionada); // Actualizar la última fecha de actualización de la computadora

            objCapaComputadora.abmComputadora("Agregar", NuevaCompu);
            objCapaComputadora.abmComputadora("Borrar", NuevaCompu);

            // Muestra los datos cargados en el Datagridview en los Label del TabMovimiento.

            Lbl_codigomov.Text = "Código: " + NuevaCompu.Pcodigo.ToString();
            Lbl_modelomov.Text = "Modelo: " + NuevaCompu.Pmodelo;
            Lbl_actualizacionmov.Text = "Última actualización: " + NuevaCompu.PultimaActualizacion.ToString("dd/MM/yyyy HH:mm:ss");
            Lbl_cuilmov.Text = "CUIL: " + NuevaCompu.Pcuil;
            Lbl_aplicacionesmov.Text = "Hay " + NuevaCompu.Paplicaciones.ToString() + " aplicaciones ejecutándose en este momento";
            Lbl_patentemov.Text = "Patente: " + NuevaCompu.Ppatente;

            // Cambia a la pestaña de Tab Moviemiento.
            Tab_computadorac.SelectedTab = Tab_movimientoc;

            // Muestra un modal si todos los datos estan cargados correctamente.
            MessageBox.Show("Datos de la computadora cargados", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Agrega los datos de la computadora al DataGridView.
            string cuilConGuiones = NuevaCompu.Pcuil.Insert(2, "-").Insert(11, "-");
            Dgv_computadora.Rows.Add(NuevaCompu.Pcodigo, NuevaCompu.Pmodelo, NuevaCompu.Paplicaciones, NuevaCompu.PultimaActualizacion.ToString("dd/MM/yyyy HH:mm:ss"), cuilConGuiones, NuevaCompu.Ppatente);


            // Actualiza la variable de fila.
            Fila = Dgv_computadora.Rows.Count - 1;
        }


        // Maneja el botón "Salir" del formulario de la pestaña Select Tab.
        private void Btn_salir_Click(object sender, EventArgs e)
        {
            // Muestra un modal de confirmación de salida.
            DialogResult salir = MessageBox.Show("¿Está seguro que desea salir?", "Confirme si desea salir.", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Si el usuario confirma la salida
            if (salir == DialogResult.Yes)
            {
                // Cierra la aplicación
                Application.Exit();
            }
        }

        // Maneja el botón "Salir" del formulario de la pestaña del TabMovimiento.
        private void Btn_salir2_Click(object sender, EventArgs e)
        {
            DialogResult salir = MessageBox.Show("¿Está seguro que desea salir?", "Confirme si desea salir.", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (salir == DialogResult.Yes)
            {
                Application.Exit();
            }
        }


        // Maneja el botón "Borrar" del formulario
        private void Btn_borrar_Click(object sender, EventArgs e)
        {
            // Verifica si hay al menos una fila en el DataGridView
            if (Dgv_computadora.Rows.Count > 0)
            {
                // Verifica si se ha seleccionado una fila completa
                if (Dgv_computadora.SelectedRows.Count > 0)
                {
                    // Muestra un modal de confirmación.
                    DialogResult resultado = MessageBox.Show("¿Está seguro que desea eliminar la fila seleccionada?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (resultado == DialogResult.Yes)
                    {
                        // Obtiene una fila seleccionada.
                        DataGridViewRow filaSeleccionada = Dgv_computadora.SelectedRows[0];

                        // Verifica si la fila no está vacía.
                        if (filaSeleccionada != null && !filaSeleccionada.IsNewRow)
                        {
                            // Elimina la fila seleccionada.
                            Dgv_computadora.Rows.Remove(filaSeleccionada);
                        }
                    }
                }
                else
                { 
                    // Modal de error si no se selecciono una fila para borrar
                    MessageBox.Show("No se ha seleccionado una fila para borrar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // Modal de error si no hay filas para borrar.
                MessageBox.Show("No hay filas para borrar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}