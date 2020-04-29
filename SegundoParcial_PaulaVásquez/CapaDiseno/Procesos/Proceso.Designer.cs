namespace CapaDiseno.Procesos
{
    partial class Proceso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Proceso));
            this.Pnl_nombreForm = new System.Windows.Forms.Panel();
            this.btn_minimizar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_cerrar = new System.Windows.Forms.Button();
            this.gpb_datos = new System.Windows.Forms.GroupBox();
            this.Cbo_estado = new System.Windows.Forms.ComboBox();
            this.Txt_2 = new System.Windows.Forms.TextBox();
            this.Txt_1 = new System.Windows.Forms.TextBox();
            this.Lbl_estado = new System.Windows.Forms.Label();
            this.Lbl_placa = new System.Windows.Forms.Label();
            this.Lbl_codigotransporte = new System.Windows.Forms.Label();
            this.Btn_consultar = new System.Windows.Forms.Button();
            this.Btn_borrar = new System.Windows.Forms.Button();
            this.Btn_guardar = new System.Windows.Forms.Button();
            this.Btn_editar = new System.Windows.Forms.Button();
            this.Btn_ingresar = new System.Windows.Forms.Button();
            this.Txt_3 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Btn_consultaRuta = new System.Windows.Forms.Button();
            this.Pnl_nombreForm.SuspendLayout();
            this.gpb_datos.SuspendLayout();
            this.SuspendLayout();
            // 
            // Pnl_nombreForm
            // 
            this.Pnl_nombreForm.BackColor = System.Drawing.Color.Teal;
            this.Pnl_nombreForm.Controls.Add(this.btn_minimizar);
            this.Pnl_nombreForm.Controls.Add(this.label1);
            this.Pnl_nombreForm.Controls.Add(this.btn_cerrar);
            this.Pnl_nombreForm.Location = new System.Drawing.Point(-2, 0);
            this.Pnl_nombreForm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Pnl_nombreForm.Name = "Pnl_nombreForm";
            this.Pnl_nombreForm.Size = new System.Drawing.Size(1303, 63);
            this.Pnl_nombreForm.TabIndex = 91;
            // 
            // btn_minimizar
            // 
            this.btn_minimizar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_minimizar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_minimizar.Image = ((System.Drawing.Image)(resources.GetObject("btn_minimizar.Image")));
            this.btn_minimizar.Location = new System.Drawing.Point(1183, 15);
            this.btn_minimizar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_minimizar.Name = "btn_minimizar";
            this.btn_minimizar.Size = new System.Drawing.Size(44, 38);
            this.btn_minimizar.TabIndex = 5;
            this.btn_minimizar.UseVisualStyleBackColor = true;
            this.btn_minimizar.Click += new System.EventHandler(this.btn_minimizar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(27, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "CREACION CARRERAS";
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_cerrar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_cerrar.Image = ((System.Drawing.Image)(resources.GetObject("btn_cerrar.Image")));
            this.btn_cerrar.Location = new System.Drawing.Point(1233, 15);
            this.btn_cerrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(44, 38);
            this.btn_cerrar.TabIndex = 4;
            this.btn_cerrar.UseVisualStyleBackColor = true;
            this.btn_cerrar.Click += new System.EventHandler(this.btn_cerrar_Click);
            // 
            // gpb_datos
            // 
            this.gpb_datos.Controls.Add(this.Btn_consultaRuta);
            this.gpb_datos.Controls.Add(this.Txt_3);
            this.gpb_datos.Controls.Add(this.label2);
            this.gpb_datos.Controls.Add(this.Cbo_estado);
            this.gpb_datos.Controls.Add(this.Txt_2);
            this.gpb_datos.Controls.Add(this.Txt_1);
            this.gpb_datos.Controls.Add(this.Lbl_estado);
            this.gpb_datos.Controls.Add(this.Lbl_placa);
            this.gpb_datos.Controls.Add(this.Lbl_codigotransporte);
            this.gpb_datos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpb_datos.Location = new System.Drawing.Point(28, 240);
            this.gpb_datos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gpb_datos.Name = "gpb_datos";
            this.gpb_datos.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gpb_datos.Size = new System.Drawing.Size(1221, 206);
            this.gpb_datos.TabIndex = 114;
            this.gpb_datos.TabStop = false;
            this.gpb_datos.Text = "Datos";
            // 
            // Cbo_estado
            // 
            this.Cbo_estado.FormattingEnabled = true;
            this.Cbo_estado.Items.AddRange(new object[] {
            "Inactivo",
            "Activo"});
            this.Cbo_estado.Location = new System.Drawing.Point(869, 122);
            this.Cbo_estado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Cbo_estado.Name = "Cbo_estado";
            this.Cbo_estado.Size = new System.Drawing.Size(224, 28);
            this.Cbo_estado.TabIndex = 15;
            // 
            // Txt_2
            // 
            this.Txt_2.Location = new System.Drawing.Point(298, 119);
            this.Txt_2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Txt_2.Name = "Txt_2";
            this.Txt_2.Size = new System.Drawing.Size(224, 27);
            this.Txt_2.TabIndex = 9;
            // 
            // Txt_1
            // 
            this.Txt_1.Location = new System.Drawing.Point(298, 51);
            this.Txt_1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Txt_1.Name = "Txt_1";
            this.Txt_1.Size = new System.Drawing.Size(224, 27);
            this.Txt_1.TabIndex = 8;
            // 
            // Lbl_estado
            // 
            this.Lbl_estado.AutoSize = true;
            this.Lbl_estado.Location = new System.Drawing.Point(675, 122);
            this.Lbl_estado.Name = "Lbl_estado";
            this.Lbl_estado.Size = new System.Drawing.Size(61, 20);
            this.Lbl_estado.TabIndex = 7;
            this.Lbl_estado.Text = "Estado";
            // 
            // Lbl_placa
            // 
            this.Lbl_placa.AutoSize = true;
            this.Lbl_placa.Location = new System.Drawing.Point(98, 127);
            this.Lbl_placa.Name = "Lbl_placa";
            this.Lbl_placa.Size = new System.Drawing.Size(68, 20);
            this.Lbl_placa.TabIndex = 1;
            this.Lbl_placa.Text = "Nombre";
            // 
            // Lbl_codigotransporte
            // 
            this.Lbl_codigotransporte.AutoSize = true;
            this.Lbl_codigotransporte.Location = new System.Drawing.Point(98, 58);
            this.Lbl_codigotransporte.Name = "Lbl_codigotransporte";
            this.Lbl_codigotransporte.Size = new System.Drawing.Size(66, 20);
            this.Lbl_codigotransporte.TabIndex = 0;
            this.Lbl_codigotransporte.Text = "Codigo ";
            // 
            // Btn_consultar
            // 
            this.Btn_consultar.BackColor = System.Drawing.Color.Teal;
            this.Btn_consultar.FlatAppearance.BorderSize = 3;
            this.Btn_consultar.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.Btn_consultar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.Btn_consultar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.Btn_consultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_consultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_consultar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_consultar.Image")));
            this.Btn_consultar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_consultar.Location = new System.Drawing.Point(816, 99);
            this.Btn_consultar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_consultar.Name = "Btn_consultar";
            this.Btn_consultar.Size = new System.Drawing.Size(187, 110);
            this.Btn_consultar.TabIndex = 113;
            this.Btn_consultar.Text = "Consultar";
            this.Btn_consultar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_consultar.UseVisualStyleBackColor = false;
            this.Btn_consultar.Click += new System.EventHandler(this.Btn_consultar_Click);
            // 
            // Btn_borrar
            // 
            this.Btn_borrar.BackColor = System.Drawing.Color.Teal;
            this.Btn_borrar.FlatAppearance.BorderSize = 3;
            this.Btn_borrar.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.Btn_borrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.Btn_borrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.Btn_borrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_borrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_borrar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_borrar.Image")));
            this.Btn_borrar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_borrar.Location = new System.Drawing.Point(704, 99);
            this.Btn_borrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_borrar.Name = "Btn_borrar";
            this.Btn_borrar.Size = new System.Drawing.Size(115, 110);
            this.Btn_borrar.TabIndex = 112;
            this.Btn_borrar.Text = "Borrar";
            this.Btn_borrar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_borrar.UseVisualStyleBackColor = false;
            this.Btn_borrar.Click += new System.EventHandler(this.Btn_borrar_Click);
            // 
            // Btn_guardar
            // 
            this.Btn_guardar.BackColor = System.Drawing.Color.Teal;
            this.Btn_guardar.FlatAppearance.BorderSize = 3;
            this.Btn_guardar.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.Btn_guardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.Btn_guardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.Btn_guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_guardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_guardar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_guardar.Image")));
            this.Btn_guardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_guardar.Location = new System.Drawing.Point(592, 99);
            this.Btn_guardar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_guardar.Name = "Btn_guardar";
            this.Btn_guardar.Size = new System.Drawing.Size(115, 110);
            this.Btn_guardar.TabIndex = 111;
            this.Btn_guardar.Text = "Guardar";
            this.Btn_guardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_guardar.UseVisualStyleBackColor = false;
            this.Btn_guardar.Click += new System.EventHandler(this.Btn_guardar_Click);
            // 
            // Btn_editar
            // 
            this.Btn_editar.BackColor = System.Drawing.Color.Teal;
            this.Btn_editar.FlatAppearance.BorderSize = 3;
            this.Btn_editar.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.Btn_editar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.Btn_editar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.Btn_editar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_editar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_editar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_editar.Image")));
            this.Btn_editar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_editar.Location = new System.Drawing.Point(480, 99);
            this.Btn_editar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_editar.Name = "Btn_editar";
            this.Btn_editar.Size = new System.Drawing.Size(115, 110);
            this.Btn_editar.TabIndex = 110;
            this.Btn_editar.Text = "Editar";
            this.Btn_editar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_editar.UseVisualStyleBackColor = false;
            this.Btn_editar.Click += new System.EventHandler(this.Btn_editar_Click);
            // 
            // Btn_ingresar
            // 
            this.Btn_ingresar.BackColor = System.Drawing.Color.Teal;
            this.Btn_ingresar.FlatAppearance.BorderSize = 3;
            this.Btn_ingresar.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.Btn_ingresar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.Btn_ingresar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.Btn_ingresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_ingresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_ingresar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_ingresar.Image")));
            this.Btn_ingresar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_ingresar.Location = new System.Drawing.Point(368, 99);
            this.Btn_ingresar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_ingresar.Name = "Btn_ingresar";
            this.Btn_ingresar.Size = new System.Drawing.Size(115, 110);
            this.Btn_ingresar.TabIndex = 109;
            this.Btn_ingresar.Text = "Ingresar";
            this.Btn_ingresar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_ingresar.UseVisualStyleBackColor = false;
            this.Btn_ingresar.Click += new System.EventHandler(this.Btn_ingresar_Click);
            // 
            // Txt_3
            // 
            this.Txt_3.Location = new System.Drawing.Point(869, 39);
            this.Txt_3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Txt_3.Name = "Txt_3";
            this.Txt_3.Size = new System.Drawing.Size(224, 27);
            this.Txt_3.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(669, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "Facultad";
            // 
            // Btn_consultaRuta
            // 
            this.Btn_consultaRuta.Image = ((System.Drawing.Image)(resources.GetObject("Btn_consultaRuta.Image")));
            this.Btn_consultaRuta.Location = new System.Drawing.Point(1112, 26);
            this.Btn_consultaRuta.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_consultaRuta.Name = "Btn_consultaRuta";
            this.Btn_consultaRuta.Size = new System.Drawing.Size(72, 52);
            this.Btn_consultaRuta.TabIndex = 35;
            this.Btn_consultaRuta.UseVisualStyleBackColor = true;
            this.Btn_consultaRuta.Click += new System.EventHandler(this.Btn_consultaRuta_Click);
            // 
            // Proceso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1293, 645);
            this.Controls.Add(this.gpb_datos);
            this.Controls.Add(this.Btn_consultar);
            this.Controls.Add(this.Btn_borrar);
            this.Controls.Add(this.Btn_guardar);
            this.Controls.Add(this.Btn_editar);
            this.Controls.Add(this.Btn_ingresar);
            this.Controls.Add(this.Pnl_nombreForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Proceso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Proceso";
            this.Pnl_nombreForm.ResumeLayout(false);
            this.Pnl_nombreForm.PerformLayout();
            this.gpb_datos.ResumeLayout(false);
            this.gpb_datos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Pnl_nombreForm;
        private System.Windows.Forms.Button btn_minimizar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_cerrar;
        private System.Windows.Forms.GroupBox gpb_datos;
        private System.Windows.Forms.ComboBox Cbo_estado;
        private System.Windows.Forms.TextBox Txt_2;
        private System.Windows.Forms.TextBox Txt_1;
        private System.Windows.Forms.Label Lbl_estado;
        private System.Windows.Forms.Label Lbl_placa;
        private System.Windows.Forms.Label Lbl_codigotransporte;
        private System.Windows.Forms.Button Btn_consultar;
        private System.Windows.Forms.Button Btn_borrar;
        private System.Windows.Forms.Button Btn_guardar;
        private System.Windows.Forms.Button Btn_editar;
        private System.Windows.Forms.Button Btn_ingresar;
        private System.Windows.Forms.Button Btn_consultaRuta;
        private System.Windows.Forms.TextBox Txt_3;
        private System.Windows.Forms.Label label2;
    }
}