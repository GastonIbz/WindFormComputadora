﻿namespace WFComputadora
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
            this.Txtb_patente = new System.Windows.Forms.TextBox();
            this.Txtb_cuil = new System.Windows.Forms.TextBox();
            this.Lbl_cuil = new System.Windows.Forms.Label();
            this.Lbl_patente = new System.Windows.Forms.Label();
            this.Btn_salir = new System.Windows.Forms.Button();
            this.Txtb_codigo = new System.Windows.Forms.TextBox();
            this.Lbl_codigo = new System.Windows.Forms.Label();
            this.Datetime_actualizacion = new System.Windows.Forms.DateTimePicker();
            this.Lbl_actualizacion = new System.Windows.Forms.Label();
            this.Txtb_aplicaciones = new System.Windows.Forms.TextBox();
            this.Lbl_aplicaciones = new System.Windows.Forms.Label();
            this.Txtb_modelo = new System.Windows.Forms.TextBox();
            this.Btn_cargar = new System.Windows.Forms.Button();
            this.Lbl_modelo = new System.Windows.Forms.Label();
            this.Tab_movimientoc = new System.Windows.Forms.TabPage();
            this.Lbl_patentemov = new System.Windows.Forms.Label();
            this.Lbl_cuilmov = new System.Windows.Forms.Label();
            this.Lbl_actualizacionmov = new System.Windows.Forms.Label();
            this.Lbl_modelomov = new System.Windows.Forms.Label();
            this.Lbl_codigomov = new System.Windows.Forms.Label();
            this.Btn_salir2 = new System.Windows.Forms.Button();
            this.Lbl_titulo = new System.Windows.Forms.Label();
            this.Lbl_aplicacionesmov = new System.Windows.Forms.Label();
            this.Btn_borrar = new System.Windows.Forms.Button();
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
            this.Dgv_computadora.Size = new System.Drawing.Size(641, 367);
            this.Dgv_computadora.TabIndex = 14;
            // 
            // Tab_computadorac
            // 
            this.Tab_computadorac.Controls.Add(this.SelectTab);
            this.Tab_computadorac.Controls.Add(this.Tab_movimientoc);
            this.Tab_computadorac.Location = new System.Drawing.Point(125, 22);
            this.Tab_computadorac.Name = "Tab_computadorac";
            this.Tab_computadorac.SelectedIndex = 0;
            this.Tab_computadorac.Size = new System.Drawing.Size(641, 250);
            this.Tab_computadorac.TabIndex = 13;
            // 
            // SelectTab
            // 
            this.SelectTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.SelectTab.Controls.Add(this.Txtb_patente);
            this.SelectTab.Controls.Add(this.Txtb_cuil);
            this.SelectTab.Controls.Add(this.Lbl_cuil);
            this.SelectTab.Controls.Add(this.Lbl_patente);
            this.SelectTab.Controls.Add(this.Btn_salir);
            this.SelectTab.Controls.Add(this.Txtb_codigo);
            this.SelectTab.Controls.Add(this.Lbl_codigo);
            this.SelectTab.Controls.Add(this.Datetime_actualizacion);
            this.SelectTab.Controls.Add(this.Lbl_actualizacion);
            this.SelectTab.Controls.Add(this.Txtb_aplicaciones);
            this.SelectTab.Controls.Add(this.Lbl_aplicaciones);
            this.SelectTab.Controls.Add(this.Txtb_modelo);
            this.SelectTab.Controls.Add(this.Btn_cargar);
            this.SelectTab.Controls.Add(this.Lbl_modelo);
            this.SelectTab.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SelectTab.Location = new System.Drawing.Point(4, 22);
            this.SelectTab.Name = "SelectTab";
            this.SelectTab.Padding = new System.Windows.Forms.Padding(3);
            this.SelectTab.Size = new System.Drawing.Size(633, 224);
            this.SelectTab.TabIndex = 0;
            this.SelectTab.Text = "Carga de Productos";
            // 
            // Txtb_patente
            // 
            this.Txtb_patente.ForeColor = System.Drawing.SystemColors.InfoText;
            this.Txtb_patente.Location = new System.Drawing.Point(191, 161);
            this.Txtb_patente.Name = "Txtb_patente";
            this.Txtb_patente.Size = new System.Drawing.Size(130, 20);
            this.Txtb_patente.TabIndex = 19;
            // 
            // Txtb_cuil
            // 
            this.Txtb_cuil.ForeColor = System.Drawing.SystemColors.InfoText;
            this.Txtb_cuil.Location = new System.Drawing.Point(191, 130);
            this.Txtb_cuil.Name = "Txtb_cuil";
            this.Txtb_cuil.Size = new System.Drawing.Size(130, 20);
            this.Txtb_cuil.TabIndex = 18;
            // 
            // Lbl_cuil
            // 
            this.Lbl_cuil.AutoSize = true;
            this.Lbl_cuil.Font = new System.Drawing.Font("Bookman Old Style", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_cuil.Location = new System.Drawing.Point(140, 131);
            this.Lbl_cuil.Name = "Lbl_cuil";
            this.Lbl_cuil.Size = new System.Drawing.Size(45, 19);
            this.Lbl_cuil.TabIndex = 17;
            this.Lbl_cuil.Text = "Cuil:";
            // 
            // Lbl_patente
            // 
            this.Lbl_patente.AutoSize = true;
            this.Lbl_patente.Font = new System.Drawing.Font("Bookman Old Style", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_patente.Location = new System.Drawing.Point(113, 162);
            this.Lbl_patente.Name = "Lbl_patente";
            this.Lbl_patente.Size = new System.Drawing.Size(72, 19);
            this.Lbl_patente.TabIndex = 16;
            this.Lbl_patente.Text = "Patente:";
            // 
            // Btn_salir
            // 
            this.Btn_salir.BackColor = System.Drawing.Color.White;
            this.Btn_salir.Location = new System.Drawing.Point(518, 186);
            this.Btn_salir.Name = "Btn_salir";
            this.Btn_salir.Size = new System.Drawing.Size(101, 26);
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
            // Datetime_actualizacion
            // 
            this.Datetime_actualizacion.Location = new System.Drawing.Point(191, 192);
            this.Datetime_actualizacion.Name = "Datetime_actualizacion";
            this.Datetime_actualizacion.Size = new System.Drawing.Size(200, 20);
            this.Datetime_actualizacion.TabIndex = 12;
            // 
            // Lbl_actualizacion
            // 
            this.Lbl_actualizacion.AutoSize = true;
            this.Lbl_actualizacion.Font = new System.Drawing.Font("Bookman Old Style", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_actualizacion.Location = new System.Drawing.Point(16, 193);
            this.Lbl_actualizacion.Name = "Lbl_actualizacion";
            this.Lbl_actualizacion.Size = new System.Drawing.Size(169, 19);
            this.Lbl_actualizacion.TabIndex = 11;
            this.Lbl_actualizacion.Text = "Ultima actualización:";
            // 
            // Txtb_aplicaciones
            // 
            this.Txtb_aplicaciones.ForeColor = System.Drawing.SystemColors.InfoText;
            this.Txtb_aplicaciones.Location = new System.Drawing.Point(191, 94);
            this.Txtb_aplicaciones.Name = "Txtb_aplicaciones";
            this.Txtb_aplicaciones.Size = new System.Drawing.Size(130, 20);
            this.Txtb_aplicaciones.TabIndex = 10;
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
            this.Btn_cargar.Location = new System.Drawing.Point(518, 44);
            this.Btn_cargar.Name = "Btn_cargar";
            this.Btn_cargar.Size = new System.Drawing.Size(101, 49);
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
            this.Tab_movimientoc.Controls.Add(this.Lbl_patentemov);
            this.Tab_movimientoc.Controls.Add(this.Lbl_cuilmov);
            this.Tab_movimientoc.Controls.Add(this.Lbl_actualizacionmov);
            this.Tab_movimientoc.Controls.Add(this.Lbl_modelomov);
            this.Tab_movimientoc.Controls.Add(this.Lbl_codigomov);
            this.Tab_movimientoc.Controls.Add(this.Btn_salir2);
            this.Tab_movimientoc.Controls.Add(this.Lbl_titulo);
            this.Tab_movimientoc.Controls.Add(this.Lbl_aplicacionesmov);
            this.Tab_movimientoc.Controls.Add(this.Btn_borrar);
            this.Tab_movimientoc.Location = new System.Drawing.Point(4, 22);
            this.Tab_movimientoc.Name = "Tab_movimientoc";
            this.Tab_movimientoc.Padding = new System.Windows.Forms.Padding(3);
            this.Tab_movimientoc.Size = new System.Drawing.Size(633, 224);
            this.Tab_movimientoc.TabIndex = 1;
            this.Tab_movimientoc.Text = "Movimiento de Productos";
            // 
            // Lbl_patentemov
            // 
            this.Lbl_patentemov.AutoSize = true;
            this.Lbl_patentemov.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_patentemov.Location = new System.Drawing.Point(16, 156);
            this.Lbl_patentemov.Name = "Lbl_patentemov";
            this.Lbl_patentemov.Size = new System.Drawing.Size(50, 16);
            this.Lbl_patentemov.TabIndex = 18;
            this.Lbl_patentemov.Text = "label1";
            // 
            // Lbl_cuilmov
            // 
            this.Lbl_cuilmov.AutoSize = true;
            this.Lbl_cuilmov.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_cuilmov.Location = new System.Drawing.Point(16, 123);
            this.Lbl_cuilmov.Name = "Lbl_cuilmov";
            this.Lbl_cuilmov.Size = new System.Drawing.Size(50, 16);
            this.Lbl_cuilmov.TabIndex = 17;
            this.Lbl_cuilmov.Text = "label1";
            // 
            // Lbl_actualizacionmov
            // 
            this.Lbl_actualizacionmov.AutoSize = true;
            this.Lbl_actualizacionmov.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_actualizacionmov.Location = new System.Drawing.Point(16, 95);
            this.Lbl_actualizacionmov.Name = "Lbl_actualizacionmov";
            this.Lbl_actualizacionmov.Size = new System.Drawing.Size(50, 16);
            this.Lbl_actualizacionmov.TabIndex = 16;
            this.Lbl_actualizacionmov.Text = "label2";
            // 
            // Lbl_modelomov
            // 
            this.Lbl_modelomov.AutoSize = true;
            this.Lbl_modelomov.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_modelomov.Location = new System.Drawing.Point(16, 68);
            this.Lbl_modelomov.Name = "Lbl_modelomov";
            this.Lbl_modelomov.Size = new System.Drawing.Size(50, 16);
            this.Lbl_modelomov.TabIndex = 15;
            this.Lbl_modelomov.Text = "label2";
            // 
            // Lbl_codigomov
            // 
            this.Lbl_codigomov.AutoSize = true;
            this.Lbl_codigomov.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_codigomov.Location = new System.Drawing.Point(16, 41);
            this.Lbl_codigomov.Name = "Lbl_codigomov";
            this.Lbl_codigomov.Size = new System.Drawing.Size(50, 16);
            this.Lbl_codigomov.TabIndex = 14;
            this.Lbl_codigomov.Text = "label2";
            // 
            // Btn_salir2
            // 
            this.Btn_salir2.BackColor = System.Drawing.Color.White;
            this.Btn_salir2.Location = new System.Drawing.Point(503, 184);
            this.Btn_salir2.Name = "Btn_salir2";
            this.Btn_salir2.Size = new System.Drawing.Size(104, 25);
            this.Btn_salir2.TabIndex = 11;
            this.Btn_salir2.Text = "Salir";
            this.Btn_salir2.UseVisualStyleBackColor = false;
            this.Btn_salir2.Click += new System.EventHandler(this.Btn_salir2_Click);
            // 
            // Lbl_titulo
            // 
            this.Lbl_titulo.AutoSize = true;
            this.Lbl_titulo.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_titulo.Location = new System.Drawing.Point(15, 13);
            this.Lbl_titulo.Name = "Lbl_titulo";
            this.Lbl_titulo.Size = new System.Drawing.Size(216, 19);
            this.Lbl_titulo.TabIndex = 9;
            this.Lbl_titulo.Text = "Datos de la computadora:";
            // 
            // Lbl_aplicacionesmov
            // 
            this.Lbl_aplicacionesmov.AutoSize = true;
            this.Lbl_aplicacionesmov.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_aplicacionesmov.Location = new System.Drawing.Point(16, 193);
            this.Lbl_aplicacionesmov.Name = "Lbl_aplicacionesmov";
            this.Lbl_aplicacionesmov.Size = new System.Drawing.Size(50, 16);
            this.Lbl_aplicacionesmov.TabIndex = 7;
            this.Lbl_aplicacionesmov.Text = "label1";
            // 
            // Btn_borrar
            // 
            this.Btn_borrar.BackColor = System.Drawing.Color.White;
            this.Btn_borrar.Location = new System.Drawing.Point(503, 41);
            this.Btn_borrar.Name = "Btn_borrar";
            this.Btn_borrar.Size = new System.Drawing.Size(104, 59);
            this.Btn_borrar.TabIndex = 6;
            this.Btn_borrar.Text = "Borrar datos";
            this.Btn_borrar.UseVisualStyleBackColor = false;
            this.Btn_borrar.Click += new System.EventHandler(this.Btn_borrar_Click);
            // 
            // FormComputadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 669);
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
        private System.Windows.Forms.TextBox Txtb_aplicaciones;
        private System.Windows.Forms.Label Lbl_aplicaciones;
        private System.Windows.Forms.TextBox Txtb_modelo;
        private System.Windows.Forms.Button Btn_cargar;
        private System.Windows.Forms.Label Lbl_modelo;
        private System.Windows.Forms.TabPage Tab_movimientoc;
        private System.Windows.Forms.Button Btn_salir2;
        private System.Windows.Forms.Label Lbl_titulo;
        private System.Windows.Forms.Label Lbl_aplicacionesmov;
        private System.Windows.Forms.Button Btn_borrar;
        private System.Windows.Forms.Label Lbl_actualizacion;
        private System.Windows.Forms.DateTimePicker Datetime_actualizacion;
        private System.Windows.Forms.Label Lbl_codigomov;
        private System.Windows.Forms.TextBox Txtb_codigo;
        private System.Windows.Forms.Label Lbl_codigo;
        private System.Windows.Forms.Label Lbl_modelomov;
        private System.Windows.Forms.Button Btn_salir;
        private System.Windows.Forms.Label Lbl_actualizacionmov;
        private System.Windows.Forms.TextBox Txtb_patente;
        private System.Windows.Forms.TextBox Txtb_cuil;
        private System.Windows.Forms.Label Lbl_cuil;
        private System.Windows.Forms.Label Lbl_patente;
        private System.Windows.Forms.Label Lbl_cuilmov;
        private System.Windows.Forms.Label Lbl_patentemov;
    }
}