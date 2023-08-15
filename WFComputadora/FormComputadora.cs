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
            Dgv_computadora.Columns.Add("0", "Codigo");
            Dgv_computadora.Columns.Add("1", "Modelo");
            Dgv_computadora.Columns.Add("2", "Aplicaciones");
            Dgv_computadora.Columns.Add("3", "Ultima Actualización");
            Dgv_computadora.Columns.Add("4", "CUIL");
            Dgv_computadora.Columns.Add("5", "Patente");
        }

        private bool ValidarFormatoCuil(string cuil)
        {
            string patron = @"\d{2}-\d{8}-\d{1}";
            return System.Text.RegularExpressions.Regex.IsMatch(cuil, patron);
        }
        private bool ValidarFormatoPatente(string patente)
        {
            // El patrón de expresión regular para el formato XXX999
            string patron = @"^[A-Z]{3}\d{3}$";

            // Verificar si la patente coincide con el patrón
            return System.Text.RegularExpressions.Regex.IsMatch(patente, patron);
        }
        private bool ValidarCodigoUnico(int codigo)
        {
            foreach (DataGridViewRow row in Dgv_computadora.Rows)
            {
                if (row.Cells[0].Value != null && row.Cells[0].Value.ToString() == codigo.ToString())
                {
                    return false; // El código ya existe en una fila
                }
            }
            return true; // El código es único
        }

        private bool ValidarCuilUnico(string cuil)
        {
            foreach (DataGridViewRow row in Dgv_computadora.Rows)
            {
                if (row.Cells[4].Value != null && row.Cells[4].Value.ToString() == cuil)
                {
                    return false; // El CUIL ya existe en una fila
                }
            }
            return true; // El CUIL es único
        }

        private bool ValidarPatenteUnica(string patente)
        {
            foreach (DataGridViewRow row in Dgv_computadora.Rows)
            {
                if (row.Cells[5].Value != null && row.Cells[5].Value.ToString() == patente)
                {
                    return false; // La patente ya existe en una fila
                }
            }
            return true; // La patente es única
        }

        private void Btn_cargar_Click(object sender, EventArgs e)
        {
            string cuil = Txtb_cuil.Text;
            string patente = Txtb_patente.Text;

            if (string.IsNullOrEmpty(Txtb_codigo.Text) || string.IsNullOrEmpty(Txtb_modelo.Text))
            {
                MessageBox.Show("Debe completar todos los campos obligatorios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(Txtb_codigo.Text, out int codigo))
            {
                MessageBox.Show("Ingrese un valor válido para el código, solo debe contener números.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(Txtb_aplicaciones.Text, out int aplicaciones))
            {
                MessageBox.Show("Ingrese un valor válido para las aplicaciones, solo debe contener números.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(Txtb_cuil.Text))
            {
                MessageBox.Show("Debe ingresar un valor para el CUIL.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

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
            if (string.IsNullOrEmpty(Txtb_patente.Text))
            {
                MessageBox.Show("Debe ingresar una patente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!ValidarFormatoPatente(Txtb_patente.Text))
            {
                MessageBox.Show("Ingrese una patente válida en el formato ASD123.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!ValidarFormatoCuil(Txtb_cuil.Text))
            {
                MessageBox.Show("Ingrese un CUIL válido en el formato 11-12345678-1.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!ValidarCodigoUnico(codigo))
            {
                MessageBox.Show("El código ingresado ya existe. Ingrese un código único.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!ValidarCuilUnico(cuil))
            {
                MessageBox.Show("El CUIL ingresado ya existe. Ingrese un CUIL único.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!ValidarPatenteUnica(patente))
            {
                MessageBox.Show("La patente ingresada ya existe. Ingrese una patente única.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Computadora NuevaCompu;
            NuevaCompu = new Computadora(
                codigo,
                Txtb_modelo.Text,
                int.Parse(Txtb_aplicaciones.Text),
                cuil,
                patente
            );

            DateTime fechaSeleccionada = Datetime_actualizacion.Value;
            NuevaCompu.ActualizarUltimaActualizacion(fechaSeleccionada);

            Lbl_codigomov.Text = "Código: " + NuevaCompu.Pcodigo.ToString();
            Lbl_modelomov.Text = "Modelo: " + NuevaCompu.Pmodelo;
            Lbl_actualizacionmov.Text = "Última actualización: " + NuevaCompu.PultimaActualizacion.ToString("dd/MM/yyyy HH:mm:ss");
            Lbl_cuilmov.Text = "CUIL: " + NuevaCompu.Pcuil;
            Lbl_aplicacionesmov.Text = "Hay " + NuevaCompu.Paplicaciones.ToString() + " aplicaciones ejecutándose en este momento";
            Lbl_patentemov.Text = "Patente: " + NuevaCompu.Ppatente;

            Tab_computadorac.SelectedTab = Tab_movimientoc;

            MessageBox.Show("Datos de la computadora cargados", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Dgv_computadora.Rows.Add(
                NuevaCompu.Pcodigo.ToString(),
                NuevaCompu.Pmodelo,
                NuevaCompu.Paplicaciones.ToString(),
                NuevaCompu.PultimaActualizacion.ToString("dd/MM/yyyy HH:mm:ss"),
                NuevaCompu.Pcuil,
                NuevaCompu.Ppatente
            );

            Fila = Dgv_computadora.Rows.Count - 1;
        }

        private void Btn_salir_Click(object sender, EventArgs e)
        {
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