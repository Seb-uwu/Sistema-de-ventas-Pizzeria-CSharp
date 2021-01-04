namespace PizzeriaTellinos
{
    partial class reporte_de_clientes
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.tabla_reporte_clientes = new System.Windows.Forms.DataGridView();
            this.numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metodo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iMPORTE1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FECHA1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.importetotalform = new System.Windows.Forms.Label();
            this.MenuTop = new System.Windows.Forms.Panel();
            this.Atras = new System.Windows.Forms.PictureBox();
            this.Cerrar = new System.Windows.Forms.PictureBox();
            this.Minimizar = new System.Windows.Forms.PictureBox();
            this.calculototal = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.numerototalform = new System.Windows.Forms.Label();
            this.regresar_reportes = new System.Windows.Forms.Button();
            this.limpia_registros = new System.Windows.Forms.Button();
            this.salida_registro = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tabla_reporte_clientes)).BeginInit();
            this.MenuTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Atras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minimizar)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(41, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(248, 30);
            this.label2.TabIndex = 27;
            this.label2.Text = "REPORTES DE CLIENTES";
            // 
            // tabla_reporte_clientes
            // 
            this.tabla_reporte_clientes.BackgroundColor = System.Drawing.SystemColors.Control;
            this.tabla_reporte_clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabla_reporte_clientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numero,
            this.nombre,
            this.metodo,
            this.iMPORTE1,
            this.FECHA1});
            this.tabla_reporte_clientes.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tabla_reporte_clientes.Location = new System.Drawing.Point(24, 127);
            this.tabla_reporte_clientes.Name = "tabla_reporte_clientes";
            this.tabla_reporte_clientes.Size = new System.Drawing.Size(643, 349);
            this.tabla_reporte_clientes.TabIndex = 21;
            // 
            // numero
            // 
            this.numero.HeaderText = "N° Cliente";
            this.numero.Name = "numero";
            this.numero.Width = 50;
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            this.nombre.Width = 240;
            // 
            // metodo
            // 
            this.metodo.HeaderText = "Metodo de pago";
            this.metodo.Name = "metodo";
            this.metodo.Width = 110;
            // 
            // iMPORTE1
            // 
            this.iMPORTE1.HeaderText = "Importes";
            this.iMPORTE1.Name = "iMPORTE1";
            // 
            // FECHA1
            // 
            this.FECHA1.HeaderText = "Fecha";
            this.FECHA1.Name = "FECHA1";
            // 
            // importetotalform
            // 
            this.importetotalform.AutoSize = true;
            this.importetotalform.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.importetotalform.ForeColor = System.Drawing.Color.White;
            this.importetotalform.Location = new System.Drawing.Point(399, 511);
            this.importetotalform.Name = "importetotalform";
            this.importetotalform.Size = new System.Drawing.Size(0, 17);
            this.importetotalform.TabIndex = 30;
            // 
            // MenuTop
            // 
            this.MenuTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.MenuTop.Controls.Add(this.Atras);
            this.MenuTop.Controls.Add(this.Cerrar);
            this.MenuTop.Controls.Add(this.Minimizar);
            this.MenuTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.MenuTop.Location = new System.Drawing.Point(0, 0);
            this.MenuTop.Name = "MenuTop";
            this.MenuTop.Size = new System.Drawing.Size(800, 55);
            this.MenuTop.TabIndex = 31;
            this.MenuTop.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MenuTop_MouseMove);
            // 
            // Atras
            // 
            this.Atras.Image = global::PizzeriaTellinos.Properties.Resources.atras;
            this.Atras.Location = new System.Drawing.Point(12, 12);
            this.Atras.Name = "Atras";
            this.Atras.Size = new System.Drawing.Size(30, 30);
            this.Atras.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Atras.TabIndex = 17;
            this.Atras.TabStop = false;
            this.Atras.Click += new System.EventHandler(this.Atras_Click);
            // 
            // Cerrar
            // 
            this.Cerrar.Image = global::PizzeriaTellinos.Properties.Resources.Close_Window__2_48px;
            this.Cerrar.Location = new System.Drawing.Point(759, 12);
            this.Cerrar.Name = "Cerrar";
            this.Cerrar.Size = new System.Drawing.Size(30, 30);
            this.Cerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Cerrar.TabIndex = 2;
            this.Cerrar.TabStop = false;
            this.Cerrar.Click += new System.EventHandler(this.Cerrar_Click);
            // 
            // Minimizar
            // 
            this.Minimizar.Image = global::PizzeriaTellinos.Properties.Resources.Minimize_Window_2_48px;
            this.Minimizar.Location = new System.Drawing.Point(723, 12);
            this.Minimizar.Name = "Minimizar";
            this.Minimizar.Size = new System.Drawing.Size(30, 30);
            this.Minimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Minimizar.TabIndex = 0;
            this.Minimizar.TabStop = false;
            this.Minimizar.Click += new System.EventHandler(this.Minimizar_Click);
            // 
            // calculototal
            // 
            this.calculototal.Location = new System.Drawing.Point(696, 193);
            this.calculototal.Name = "calculototal";
            this.calculototal.Size = new System.Drawing.Size(75, 53);
            this.calculototal.TabIndex = 22;
            this.calculototal.Text = "Calcular Totales";
            this.calculototal.UseVisualStyleBackColor = true;
            this.calculototal.Click += new System.EventHandler(this.calculototal_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(94, 511);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 17);
            this.label1.TabIndex = 26;
            this.label1.Text = "Numero de clientes:";
            // 
            // numerototalform
            // 
            this.numerototalform.AutoSize = true;
            this.numerototalform.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numerototalform.ForeColor = System.Drawing.Color.White;
            this.numerototalform.Location = new System.Drawing.Point(226, 511);
            this.numerototalform.Name = "numerototalform";
            this.numerototalform.Size = new System.Drawing.Size(0, 17);
            this.numerototalform.TabIndex = 29;
            // 
            // regresar_reportes
            // 
            this.regresar_reportes.Location = new System.Drawing.Point(696, 356);
            this.regresar_reportes.Name = "regresar_reportes";
            this.regresar_reportes.Size = new System.Drawing.Size(75, 38);
            this.regresar_reportes.TabIndex = 25;
            this.regresar_reportes.Text = "Regresar";
            this.regresar_reportes.UseVisualStyleBackColor = true;
            // 
            // limpia_registros
            // 
            this.limpia_registros.Location = new System.Drawing.Point(696, 252);
            this.limpia_registros.Name = "limpia_registros";
            this.limpia_registros.Size = new System.Drawing.Size(75, 54);
            this.limpia_registros.TabIndex = 23;
            this.limpia_registros.Text = "Limpiar Registros";
            this.limpia_registros.UseVisualStyleBackColor = true;
            this.limpia_registros.Click += new System.EventHandler(this.limpia_registros_Click);
            // 
            // salida_registro
            // 
            this.salida_registro.Location = new System.Drawing.Point(696, 312);
            this.salida_registro.Name = "salida_registro";
            this.salida_registro.Size = new System.Drawing.Size(75, 38);
            this.salida_registro.TabIndex = 24;
            this.salida_registro.Text = "Salir";
            this.salida_registro.UseVisualStyleBackColor = true;
            this.salida_registro.Click += new System.EventHandler(this.salida_registro_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(305, 511);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 17);
            this.label3.TabIndex = 28;
            this.label3.Text = "Importe total:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(696, 146);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 32;
            this.button1.Text = ".........";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(696, 438);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 38);
            this.button2.TabIndex = 33;
            this.button2.Text = "Registros Diarios";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // reporte_de_clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(800, 575);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tabla_reporte_clientes);
            this.Controls.Add(this.importetotalform);
            this.Controls.Add(this.MenuTop);
            this.Controls.Add(this.calculototal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numerototalform);
            this.Controls.Add(this.regresar_reportes);
            this.Controls.Add(this.limpia_registros);
            this.Controls.Add(this.salida_registro);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "reporte_de_clientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.reporte_de_clientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tabla_reporte_clientes)).EndInit();
            this.MenuTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Atras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minimizar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView tabla_reporte_clientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn metodo;
        private System.Windows.Forms.DataGridViewTextBoxColumn iMPORTE1;
        private System.Windows.Forms.DataGridViewTextBoxColumn FECHA1;
        private System.Windows.Forms.Label importetotalform;
        private System.Windows.Forms.Panel MenuTop;
        private System.Windows.Forms.PictureBox Cerrar;
        private System.Windows.Forms.PictureBox Minimizar;
        private System.Windows.Forms.Button calculototal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label numerototalform;
        private System.Windows.Forms.Button regresar_reportes;
        private System.Windows.Forms.Button limpia_registros;
        private System.Windows.Forms.Button salida_registro;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox Atras;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}