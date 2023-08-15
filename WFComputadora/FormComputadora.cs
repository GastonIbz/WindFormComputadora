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
                    Dgv_computadora.Rows.Add(dr[4], dr[3], dr[1], dr[2], dr[5]);
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
        }

        private bool ValidarFormatoCuil(string cuil)
        {
            string patron = @"\d{2}-\d{8}-\d{1}";
            return System.Text.RegularExpressions.Regex.IsMatch(cuil, patron);
        }

        private void Btn_cargar_Click(object sender, EventArgs e)
        {
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

            if (!ValidarFormatoCuil(Txtb_cuil.Text))
            {
                MessageBox.Show("Ingrese un CUIL válido en el formato 11-12345678-1.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Computadora NuevaCompu;
            NuevaCompu = new Computadora(
                int.Parse(Txtb_codigo.Text),
                Txtb_modelo.Text,
                int.Parse(Txtb_aplicaciones.Text),
                Txtb_cuil.Text
            );

            DateTime fechaSeleccionada = Datetime_actualizacion.Value;
            NuevaCompu.ActualizarUltimaActualizacion(fechaSeleccionada);

            Lbl_codigomov.Text = "Código: " + NuevaCompu.Pcodigo.ToString();
            Lbl_modelomov.Text = "Modelo: " + NuevaCompu.Pmodelo;
            Lbl_actualizacionmov.Text = "Última actualización: " + NuevaCompu.PultimaActualizacion.ToString("dd/MM/yyyy HH:mm:ss");
            Lbl_cuilmov.Text = "CUIL: " + NuevaCompu.PCuil;
            Lbl_aplicacionesmov.Text = "Hay " + NuevaCompu.Paplicaciones.ToString() + " aplicaciones ejecutándose en este momento";

            Tab_computadorac.SelectedTab = Tab_movimientoc;

            MessageBox.Show("Datos de la computadora cargados", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Dgv_computadora.Rows.Add(
                NuevaCompu.Pcodigo.ToString(),
                NuevaCompu.Pmodelo,
                NuevaCompu.Paplicaciones.ToString(),
                NuevaCompu.PultimaActualizacion.ToString("dd/MM/yyyy HH:mm:ss"),
                NuevaCompu.PCuil
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