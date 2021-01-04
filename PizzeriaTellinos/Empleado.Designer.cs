namespace PizzeriaTellinos
{
    partial class Empleado
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
            this.MenuTop = new System.Windows.Forms.Panel();
            this.Atras = new System.Windows.Forms.PictureBox();
            this.Cerrar = new System.Windows.Forms.PictureBox();
            this.Minimizar = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dgvPizzas = new System.Windows.Forms.DataGridView();
            this.dgvBebidas = new System.Windows.Forms.DataGridView();
            this.dgvExtras = new System.Windows.Forms.DataGridView();
            this.lblmensaje = new System.Windows.Forms.Label();
            this.txtcliente = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TXTNOMBRE = new System.Windows.Forms.TextBox();
            this.TXTPRECIO = new System.Windows.Forms.TextBox();
            this.TXTCANTIDAD = new System.Windows.Forms.TextBox();
            this.TXTTAMAÑO = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvde_ventas = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.txtnumero = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txttotal = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.txtfecha = new System.Windows.Forms.TextBox();
            this.txttotal_ventas = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.MenuTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Atras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPizzas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBebidas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExtras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvde_ventas)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuTop
            // 
            this.MenuTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.MenuTop.Controls.Add(this.Atras);
            this.MenuTop.Controls.Add(this.Cerrar);
            this.MenuTop.Controls.Add(this.Minimizar);
            this.MenuTop.Controls.Add(this.label1);
            this.MenuTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.MenuTop.Location = new System.Drawing.Point(0, 0);
            this.MenuTop.Name = "MenuTop";
            this.MenuTop.Size = new System.Drawing.Size(724, 55);
            this.MenuTop.TabIndex = 20;
            // 
            // Atras
            // 
            this.Atras.Image = global::PizzeriaTellinos.Properties.Resources.atras;
            this.Atras.Location = new System.Drawing.Point(12, 12);
            this.Atras.Name = "Atras";
            this.Atras.Size = new System.Drawing.Size(30, 30);
            this.Atras.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Atras.TabIndex = 18;
            this.Atras.TabStop = false;
            this.Atras.Click += new System.EventHandler(this.Atras_Click);
            // 
            // Cerrar
            // 
            this.Cerrar.Image = global::PizzeriaTellinos.Properties.Resources.Close_Window__2_48px;
            this.Cerrar.Location = new System.Drawing.Point(682, 12);
            this.Cerrar.Name = "Cerrar";
            this.Cerrar.Size = new System.Drawing.Size(30, 30);
            this.Cerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Cerrar.TabIndex = 2;
            this.Cerrar.TabStop = false;
            // 
            // Minimizar
            // 
            this.Minimizar.Image = global::PizzeriaTellinos.Properties.Resources.Minimize_Window_2_48px;
            this.Minimizar.Location = new System.Drawing.Point(646, 12);
            this.Minimizar.Name = "Minimizar";
            this.Minimizar.Size = new System.Drawing.Size(30, 30);
            this.Minimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Minimizar.TabIndex = 0;
            this.Minimizar.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(72, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 24);
            this.label1.TabIndex = 21;
            this.label1.Text = "APLICACION PARA VENTAS";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(150, 126);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 22;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // dgvPizzas
            // 
            this.dgvPizzas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPizzas.Location = new System.Drawing.Point(337, 83);
            this.dgvPizzas.Name = "dgvPizzas";
            this.dgvPizzas.ReadOnly = true;
            this.dgvPizzas.Size = new System.Drawing.Size(351, 221);
            this.dgvPizzas.TabIndex = 23;
            this.dgvPizzas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPizzas_CellClick);
            // 
            // dgvBebidas
            // 
            this.dgvBebidas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBebidas.Location = new System.Drawing.Point(337, 83);
            this.dgvBebidas.Name = "dgvBebidas";
            this.dgvBebidas.ReadOnly = true;
            this.dgvBebidas.Size = new System.Drawing.Size(351, 221);
            this.dgvBebidas.TabIndex = 24;
            this.dgvBebidas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBebidas_CellClick);
            // 
            // dgvExtras
            // 
            this.dgvExtras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExtras.Location = new System.Drawing.Point(337, 83);
            this.dgvExtras.Name = "dgvExtras";
            this.dgvExtras.ReadOnly = true;
            this.dgvExtras.Size = new System.Drawing.Size(351, 221);
            this.dgvExtras.TabIndex = 25;
            this.dgvExtras.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvExtras_CellClick);
            // 
            // lblmensaje
            // 
            this.lblmensaje.AutoSize = true;
            this.lblmensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmensaje.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblmensaje.Location = new System.Drawing.Point(171, 184);
            this.lblmensaje.Name = "lblmensaje";
            this.lblmensaje.Size = new System.Drawing.Size(359, 24);
            this.lblmensaje.TabIndex = 26;
            this.lblmensaje.Text = "SELECCIONE EL PRODUCTO A ELEGIR";
            // 
            // txtcliente
            // 
            this.txtcliente.Location = new System.Drawing.Point(150, 83);
            this.txtcliente.Name = "txtcliente";
            this.txtcliente.Size = new System.Drawing.Size(159, 20);
            this.txtcliente.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(27, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 15);
            this.label3.TabIndex = 28;
            this.label3.Text = "Nombre de Cliente:";
            // 
            // TXTNOMBRE
            // 
            this.TXTNOMBRE.Location = new System.Drawing.Point(107, 240);
            this.TXTNOMBRE.Name = "TXTNOMBRE";
            this.TXTNOMBRE.ReadOnly = true;
            this.TXTNOMBRE.Size = new System.Drawing.Size(109, 20);
            this.TXTNOMBRE.TabIndex = 29;
            // 
            // TXTPRECIO
            // 
            this.TXTPRECIO.Location = new System.Drawing.Point(107, 275);
            this.TXTPRECIO.Name = "TXTPRECIO";
            this.TXTPRECIO.ReadOnly = true;
            this.TXTPRECIO.Size = new System.Drawing.Size(109, 20);
            this.TXTPRECIO.TabIndex = 30;
            // 
            // TXTCANTIDAD
            // 
            this.TXTCANTIDAD.Location = new System.Drawing.Point(107, 348);
            this.TXTCANTIDAD.Name = "TXTCANTIDAD";
            this.TXTCANTIDAD.Size = new System.Drawing.Size(57, 20);
            this.TXTCANTIDAD.TabIndex = 32;
            this.TXTCANTIDAD.TextChanged += new System.EventHandler(this.TXTCANTIDAD_TextChanged);
            // 
            // TXTTAMAÑO
            // 
            this.TXTTAMAÑO.Location = new System.Drawing.Point(107, 312);
            this.TXTTAMAÑO.Name = "TXTTAMAÑO";
            this.TXTTAMAÑO.ReadOnly = true;
            this.TXTTAMAÑO.Size = new System.Drawing.Size(109, 20);
            this.TXTTAMAÑO.TabIndex = 33;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(27, 243);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 34;
            this.label2.Text = "Nombre:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(27, 278);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 35;
            this.label4.Text = "Precio unitario:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(27, 315);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 36;
            this.label5.Text = "Presentacion:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(27, 351);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 37;
            this.label6.Text = "Cantidad:";
            // 
            // dgvde_ventas
            // 
            this.dgvde_ventas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvde_ventas.Location = new System.Drawing.Point(56, 407);
            this.dgvde_ventas.Name = "dgvde_ventas";
            this.dgvde_ventas.Size = new System.Drawing.Size(532, 205);
            this.dgvde_ventas.TabIndex = 38;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(303, 351);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(79, 34);
            this.button1.TabIndex = 39;
            this.button1.Text = "&INSERTAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(406, 351);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(79, 34);
            this.button2.TabIndex = 40;
            this.button2.Text = "&EDITAR";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(509, 351);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(79, 34);
            this.button3.TabIndex = 41;
            this.button3.Text = "&QUITAR";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtnumero
            // 
            this.txtnumero.Location = new System.Drawing.Point(611, 61);
            this.txtnumero.Name = "txtnumero";
            this.txtnumero.ReadOnly = true;
            this.txtnumero.Size = new System.Drawing.Size(77, 20);
            this.txtnumero.TabIndex = 42;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(515, 64);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 13);
            this.label7.TabIndex = 43;
            this.label7.Text = "Numero de Venta";
            this.label7.UseWaitCursor = true;
            // 
            // txttotal
            // 
            this.txttotal.Location = new System.Drawing.Point(188, 348);
            this.txttotal.Name = "txttotal";
            this.txttotal.Size = new System.Drawing.Size(83, 20);
            this.txttotal.TabIndex = 44;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(616, 428);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(85, 53);
            this.button4.TabIndex = 45;
            this.button4.Text = "Terminar Pedido";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(616, 494);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(85, 53);
            this.button5.TabIndex = 46;
            this.button5.Text = "Cancelar";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(616, 559);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(85, 53);
            this.button6.TabIndex = 47;
            this.button6.Text = "Salir";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // txtfecha
            // 
            this.txtfecha.Location = new System.Drawing.Point(371, 61);
            this.txtfecha.Name = "txtfecha";
            this.txtfecha.Size = new System.Drawing.Size(138, 20);
            this.txtfecha.TabIndex = 48;
            // 
            // txttotal_ventas
            // 
            this.txttotal_ventas.Location = new System.Drawing.Point(505, 622);
            this.txttotal_ventas.Name = "txttotal_ventas";
            this.txttotal_ventas.Size = new System.Drawing.Size(83, 20);
            this.txttotal_ventas.TabIndex = 49;
            this.txttotal_ventas.TextChanged += new System.EventHandler(this.txttotal_ventas_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(451, 625);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 13);
            this.label8.TabIndex = 50;
            this.label8.Text = "Total:";
            // 
            // Empleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(724, 661);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txttotal_ventas);
            this.Controls.Add(this.txtfecha);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.txttotal);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtnumero);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvde_ventas);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TXTTAMAÑO);
            this.Controls.Add(this.TXTCANTIDAD);
            this.Controls.Add(this.TXTPRECIO);
            this.Controls.Add(this.TXTNOMBRE);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtcliente);
            this.Controls.Add(this.lblmensaje);
            this.Controls.Add(this.dgvExtras);
            this.Controls.Add(this.dgvBebidas);
            this.Controls.Add(this.dgvPizzas);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.MenuTop);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Empleado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Empleado";
            this.Load += new System.EventHandler(this.Empleado_Load);
            this.MenuTop.ResumeLayout(false);
            this.MenuTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Atras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPizzas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBebidas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExtras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvde_ventas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel MenuTop;
        private System.Windows.Forms.PictureBox Atras;
        private System.Windows.Forms.PictureBox Cerrar;
        private System.Windows.Forms.PictureBox Minimizar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView dgvPizzas;
        private System.Windows.Forms.DataGridView dgvBebidas;
        private System.Windows.Forms.DataGridView dgvExtras;
        private System.Windows.Forms.Label lblmensaje;
        private System.Windows.Forms.TextBox txtcliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TXTNOMBRE;
        private System.Windows.Forms.TextBox TXTPRECIO;
        private System.Windows.Forms.TextBox TXTCANTIDAD;
        private System.Windows.Forms.TextBox TXTTAMAÑO;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvde_ventas;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txtnumero;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txttotal;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox txtfecha;
        private System.Windows.Forms.TextBox txttotal_ventas;
        private System.Windows.Forms.Label label8;
    }
}