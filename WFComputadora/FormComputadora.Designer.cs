namespace WFComputadora
{
    partial class FormComputadora
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Dgv_computadora = new System.Windows.Forms.DataGridView();
            this.Tab_computadorac = new System.Windows.Forms.TabControl();
            this.SelectTab = new System.Windows.Forms.TabPage();
            this.Btn_salir = new System.Windows.Forms.Button();
            this.Txtb_codigo = new System.Windows.Forms.TextBox();
            this.Lbl_codigo = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.Lbl_actualizacion = new System.Windows.Forms.Label();
            this.Txtb_memoria = new System.Windows.Forms.TextBox();
            this.Lbl_aplicaciones = new System.Windows.Forms.Label();
            this.Txtb_modelo = new System.Windows.Forms.TextBox();
            this.Btn_cargar = new System.Windows.Forms.Button();
            this.Lbl_modelo = new System.Windows.Forms.Label();
            this.Tab_movimientoc = new System.Windows.Forms.TabPage();
            this.Lbl_modelomov = new System.Windows.Forms.Label();
            this.Lbl_codigomov = new System.Windows.Forms.Label();
            this.Rbegreso = new System.Windows.Forms.RadioButton();
            this.Rbingreso = new System.Windows.Forms.RadioButton();
            this.Btn_salir2 = new System.Windows.Forms.Button();
            this.Lbl_titulo = new System.Windows.Forms.Label();
            this.Lbl_aplicacionesmov = new System.Windows.Forms.Label();
            this.Btn_aceptar = new System.Windows.Forms.Button();
            this.Textb_mov = new System.Windows.Forms.TextBox();
            this.Label_cant = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_computadora)).BeginInit();
            this.Tab_computadorac.SuspendLayout();
            this.SelectTab.SuspendLayout();
            this.Tab_movimientoc.SuspendLayout();
            this.SuspendLayout();
            // 
            // Dgv_computadora
            // 
            this.Dgv_computadora.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_computadora.Location = new System.Drawing.Point(125, 278);
            this.Dgv_computadora.Name = "Dgv_computadora";
            this.Dgv_computadora.Size = new System.Drawing.Size(594, 150);
            this.Dgv_computadora.TabIndex = 14;
            // 
            // Tab_computadorac
            // 
            this.Tab_computadorac.Controls.Add(this.SelectTab);
            this.Tab_computadorac.Controls.Add(this.Tab_movimientoc);
            this.Tab_computadorac.Location = new System.Drawing.Point(125, 22);
            this.Tab_computadorac.Name = "Tab_computadorac";
            this.Tab_computadorac.SelectedIndex = 0;
            this.Tab_computadorac.Size = new System.Drawing.Size(598, 250);
            this.Tab_computadorac.TabIndex = 13;
            // 
            // SelectTab
            // 
            this.SelectTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.SelectTab.Controls.Add(this.Btn_salir);
            this.SelectTab.Controls.Add(this.Txtb_codigo);
            this.SelectTab.Controls.Add(this.Lbl_codigo);
            this.SelectTab.Controls.Add(this.dateTimePicker1);
            this.SelectTab.Controls.Add(this.Lbl_actualizacion);
            this.SelectTab.Controls.Add(this.Txtb_memoria);
            this.SelectTab.Controls.Add(this.Lbl_aplicaciones);
            this.SelectTab.Controls.Add(this.Txtb_modelo);
            this.SelectTab.Controls.Add(this.Btn_cargar);
            this.SelectTab.Controls.Add(this.Lbl_modelo);
            this.SelectTab.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SelectTab.Location = new System.Drawing.Point(4, 22);
            this.SelectTab.Name = "SelectTab";
            this.SelectTab.Padding = new System.Windows.Forms.Padding(3);
            this.SelectTab.Size = new System.Drawing.Size(590, 224);
            this.SelectTab.TabIndex = 0;
            this.SelectTab.Text = "Carga de Productos";
            // 
            // Btn_salir
            // 
            this.Btn_salir.BackColor = System.Drawing.Color.White;
            this.Btn_salir.Location = new System.Drawing.Point(478, 178);
            this.Btn_salir.Name = "Btn_salir";
            this.Btn_salir.Size = new System.Drawing.Size(76, 25);
            this.Btn_salir.TabIndex = 15;
            this.Btn_salir.Text = "Salir";
            this.Btn_salir.UseVisualStyleBackColor = false;
            this.Btn_salir.Click += new System.EventHandler(this.Btn_salir_Click);
            // 
            // Txtb_codigo
            // 
            this.Txtb_codigo.ForeColor = System.Drawing.SystemColors.InfoText;
            this.Txtb_codigo.Location = new System.Drawing.Point(191, 22);
            this.Txtb_codigo.Name = "Txtb_codigo";
            this.Txtb_codigo.Size = new System.Drawing.Size(130, 20);
            this.Txtb_codigo.TabIndex = 14;
            // 
            // Lbl_codigo
            // 
            this.Lbl_codigo.AutoSize = true;
            this.Lbl_codigo.Font = new System.Drawing.Font("Bookman Old Style", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_codigo.Location = new System.Drawing.Point(125, 21);
            this.Lbl_codigo.Name = "Lbl_codigo";
            this.Lbl_codigo.Size = new System.Drawing.Size(63, 19);
            this.Lbl_codigo.TabIndex = 13;
            this.Lbl_codigo.Text = "Codigo:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(191, 125);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 12;
            // 
            // Lbl_actualizacion
            // 
            this.Lbl_actualizacion.AutoSize = true;
            this.Lbl_actualizacion.Font = new System.Drawing.Font("Bookman Old Style", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_actualizacion.Location = new System.Drawing.Point(16, 125);
            this.Lbl_actualizacion.Name = "Lbl_actualizacion";
            this.Lbl_actualizacion.Size = new System.Drawing.Size(169, 19);
            this.Lbl_actualizacion.TabIndex = 11;
            this.Lbl_actualizacion.Text = "Ultima actualización:";
            // 
            // Txtb_memoria
            // 
            this.Txtb_memoria.ForeColor = System.Drawing.SystemColors.InfoText;
            this.Txtb_memoria.Location = new System.Drawing.Point(191, 94);
            this.Txtb_memoria.Name = "Txtb_memoria";
            this.Txtb_memoria.Size = new System.Drawing.Size(130, 20);
            this.Txtb_memoria.TabIndex = 10;
            // 
            // Lbl_aplicaciones
            // 
            this.Lbl_aplicaciones.AutoSize = true;
            this.Lbl_aplicaciones.Font = new System.Drawing.Font("Bookman Old Style", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_aplicaciones.Location = new System.Drawing.Point(78, 93);
            this.Lbl_aplicaciones.Name = "Lbl_aplicaciones";
            this.Lbl_aplicaciones.Size = new System.Drawing.Size(107, 19);
            this.Lbl_aplicaciones.TabIndex = 9;
            this.Lbl_aplicaciones.Text = "Aplicaciones:";
            // 
            // Txtb_modelo
            // 
            this.Txtb_modelo.BackColor = System.Drawing.Color.White;
            this.Txtb_modelo.ForeColor = System.Drawing.SystemColors.InfoText;
            this.Txtb_modelo.Location = new System.Drawing.Point(191, 59);
            this.Txtb_modelo.Name = "Txtb_modelo";
            this.Txtb_modelo.Size = new System.Drawing.Size(130, 20);
            this.Txtb_modelo.TabIndex = 4;
            // 
            // Btn_cargar
            // 
            this.Btn_cargar.BackColor = System.Drawing.SystemColors.Window;
            this.Btn_cargar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Btn_cargar.Location = new System.Drawing.Point(478, 36);
            this.Btn_cargar.Name = "Btn_cargar";
            this.Btn_cargar.Size = new System.Drawing.Size(76, 43);
            this.Btn_cargar.TabIndex = 3;
            this.Btn_cargar.Text = "Cargar";
            this.Btn_cargar.UseVisualStyleBackColor = false;
            this.Btn_cargar.Click += new System.EventHandler(this.Btn_cargar_Click);
            // 
            // Lbl_modelo
            // 
            this.Lbl_modelo.AutoSize = true;
            this.Lbl_modelo.Font = new System.Drawing.Font("Bookman Old Style", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_modelo.Location = new System.Drawing.Point(119, 60);
            this.Lbl_modelo.Name = "Lbl_modelo";
            this.Lbl_modelo.Size = new System.Drawing.Size(66, 19);
            this.Lbl_modelo.TabIndex = 0;
            this.Lbl_modelo.Text = "Modelo:";
            // 
            // Tab_movimientoc
            // 
            this.Tab_movimientoc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.Tab_movimientoc.Controls.Add(this.Lbl_modelomov);
            this.Tab_movimientoc.Controls.Add(this.Lbl_codigomov);
            this.Tab_movimientoc.Controls.Add(this.Rbegreso);
            this.Tab_movimientoc.Controls.Add(this.Rbingreso);
            this.Tab_movimientoc.Controls.Add(this.Btn_salir2);
            this.Tab_movimientoc.Controls.Add(this.Lbl_titulo);
            this.Tab_movimientoc.Controls.Add(this.Lbl_aplicacionesmov);
            this.Tab_movimientoc.Controls.Add(this.Btn_aceptar);
            this.Tab_movimientoc.Controls.Add(this.Textb_mov);
            this.Tab_movimientoc.Controls.Add(this.Label_cant);
            this.Tab_movimientoc.Location = new System.Drawing.Point(4, 22);
            this.Tab_movimientoc.Name = "Tab_movimientoc";
            this.Tab_movimientoc.Padding = new System.Windows.Forms.Padding(3);
            this.Tab_movimientoc.Size = new System.Drawing.Size(590, 224);
            this.Tab_movimientoc.TabIndex = 1;
            this.Tab_movimientoc.Text = "Movimiento de Productos";
            // 
            // Lbl_modelomov
            // 
            this.Lbl_modelomov.AutoSize = true;
            this.Lbl_modelomov.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_modelomov.Location = new System.Drawing.Point(16, 125);
            this.Lbl_modelomov.Name = "Lbl_modelomov";
            this.Lbl_modelomov.Size = new System.Drawing.Size(50, 16);
            this.Lbl_modelomov.TabIndex = 15;
            this.Lbl_modelomov.Text = "label2";
            // 
            // Lbl_codigomov
            // 
            this.Lbl_codigomov.AutoSize = true;
            this.Lbl_codigomov.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_codigomov.Location = new System.Drawing.Point(16, 88);
            this.Lbl_codigomov.Name = "Lbl_codigomov";
            this.Lbl_codigomov.Size = new System.Drawing.Size(50, 16);
            this.Lbl_codigomov.TabIndex = 14;
            this.Lbl_codigomov.Text = "label2";
            // 
            // Rbegreso
            // 
            this.Rbegreso.AutoSize = true;
            this.Rbegreso.Location = new System.Drawing.Point(311, 104);
            this.Rbegreso.Name = "Rbegreso";
            this.Rbegreso.Size = new System.Drawing.Size(58, 17);
            this.Rbegreso.TabIndex = 13;
            this.Rbegreso.TabStop = true;
            this.Rbegreso.Text = "Egreso";
            this.Rbegreso.UseVisualStyleBackColor = true;
            // 
            // Rbingreso
            // 
            this.Rbingreso.AutoSize = true;
            this.Rbingreso.Location = new System.Drawing.Point(311, 67);
            this.Rbingreso.Name = "Rbingreso";
            this.Rbingreso.Size = new System.Drawing.Size(60, 17);
            this.Rbingreso.TabIndex = 12;
            this.Rbingreso.TabStop = true;
            this.Rbingreso.Text = "Ingreso";
            this.Rbingreso.UseVisualStyleBackColor = true;
            // 
            // Btn_salir2
            // 
            this.Btn_salir2.BackColor = System.Drawing.Color.White;
            this.Btn_salir2.Location = new System.Drawing.Point(466, 193);
            this.Btn_salir2.Name = "Btn_salir2";
            this.Btn_salir2.Size = new System.Drawing.Size(84, 25);
            this.Btn_salir2.TabIndex = 11;
            this.Btn_salir2.Text = "Salir";
            this.Btn_salir2.UseVisualStyleBackColor = false;
            this.Btn_salir2.Click += new System.EventHandler(this.Btn_salir2_Click);
            // 
            // Lbl_titulo
            // 
            this.Lbl_titulo.AutoSize = true;
            this.Lbl_titulo.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_titulo.Location = new System.Drawing.Point(15, 59);
            this.Lbl_titulo.Name = "Lbl_titulo";
            this.Lbl_titulo.Size = new System.Drawing.Size(216, 19);
            this.Lbl_titulo.TabIndex = 9;
            this.Lbl_titulo.Text = "Datos de la computadora:";
            // 
            // Lbl_aplicacionesmov
            // 
            this.Lbl_aplicacionesmov.AutoSize = true;
            this.Lbl_aplicacionesmov.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_aplicacionesmov.Location = new System.Drawing.Point(16, 156);
            this.Lbl_aplicacionesmov.Name = "Lbl_aplicacionesmov";
            this.Lbl_aplicacionesmov.Size = new System.Drawing.Size(50, 16);
            this.Lbl_aplicacionesmov.TabIndex = 7;
            this.Lbl_aplicacionesmov.Text = "label1";
            // 
            // Btn_aceptar
            // 
            this.Btn_aceptar.BackColor = System.Drawing.Color.White;
            this.Btn_aceptar.Location = new System.Drawing.Point(466, 72);
            this.Btn_aceptar.Name = "Btn_aceptar";
            this.Btn_aceptar.Size = new System.Drawing.Size(84, 49);
            this.Btn_aceptar.TabIndex = 6;
            this.Btn_aceptar.Text = "Aceptar";
            this.Btn_aceptar.UseVisualStyleBackColor = false;
            // 
            // Textb_mov
            // 
            this.Textb_mov.Location = new System.Drawing.Point(257, 30);
            this.Textb_mov.Name = "Textb_mov";
            this.Textb_mov.Size = new System.Drawing.Size(130, 20);
            this.Textb_mov.TabIndex = 5;
            // 
            // Label_cant
            // 
            this.Label_cant.AutoSize = true;
            this.Label_cant.Font = new System.Drawing.Font("Bookman Old Style", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_cant.Location = new System.Drawing.Point(13, 27);
            this.Label_cant.Name = "Label_cant";
            this.Label_cant.Size = new System.Drawing.Size(238, 21);
            this.Label_cant.TabIndex = 0;
            this.Label_cant.Text = "Aplicaciones para ejecutar:";
            // 
            // FormComputadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Dgv_computadora);
            this.Controls.Add(this.Tab_computadorac);
            this.Name = "FormComputadora";
            this.Text = "FormComputadora";
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_computadora)).EndInit();
            this.Tab_computadorac.ResumeLayout(false);
            this.SelectTab.ResumeLayout(false);
            this.SelectTab.PerformLayout();
            this.Tab_movimientoc.ResumeLayout(false);
            this.Tab_movimientoc.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Dgv_computadora;
        private System.Windows.Forms.TabControl Tab_computadorac;
        private System.Windows.Forms.TabPage SelectTab;
        private System.Windows.Forms.TextBox Txtb_memoria;
        private System.Windows.Forms.Label Lbl_aplicaciones;
        private System.Windows.Forms.TextBox Txtb_modelo;
        private System.Windows.Forms.Button Btn_cargar;
        private System.Windows.Forms.Label Lbl_modelo;
        private System.Windows.Forms.TabPage Tab_movimientoc;
        private System.Windows.Forms.Button Btn_salir2;
        private System.Windows.Forms.Label Lbl_titulo;
        private System.Windows.Forms.Label Lbl_aplicacionesmov;
        private System.Windows.Forms.Button Btn_aceptar;
        private System.Windows.Forms.Label Lbl_actualizacion;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label Lbl_codigomov;
        private System.Windows.Forms.RadioButton Rbegreso;
        private System.Windows.Forms.RadioButton Rbingreso;
        private System.Windows.Forms.TextBox Txtb_codigo;
        private System.Windows.Forms.Label Lbl_codigo;
        private System.Windows.Forms.Label Lbl_modelomov;
        private System.Windows.Forms.TextBox Textb_mov;
        private System.Windows.Forms.Button Btn_salir;
        private System.Windows.Forms.Label Label_cant;
    }
}