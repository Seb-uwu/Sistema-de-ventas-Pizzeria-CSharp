namespace PizzeriaTellinos
{
    partial class Mantemiento
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
            this.MenuTop2 = new System.Windows.Forms.Panel();
            this.btnAtras = new System.Windows.Forms.PictureBox();
            this.Cerrar = new System.Windows.Forms.PictureBox();
            this.Minimizar = new System.Windows.Forms.PictureBox();
            this.btnPizzas = new System.Windows.Forms.Button();
            this.btnBebidas = new System.Windows.Forms.Button();
            this.btnExtras = new System.Windows.Forms.Button();
            this.btnUsuarios = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.MenuTop2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnAtras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minimizar)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuTop2
            // 
            this.MenuTop2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.MenuTop2.Controls.Add(this.btnAtras);
            this.MenuTop2.Controls.Add(this.Cerrar);
            this.MenuTop2.Controls.Add(this.Minimizar);
            this.MenuTop2.Dock = System.Windows.Forms.DockStyle.Top;
            this.MenuTop2.Location = new System.Drawing.Point(0, 0);
            this.MenuTop2.Name = "MenuTop2";
            this.MenuTop2.Size = new System.Drawing.Size(452, 55);
            this.MenuTop2.TabIndex = 33;
            this.MenuTop2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.MenuTop2_MouseClick);
            // 
            // btnAtras
            // 
            this.btnAtras.Image = global::PizzeriaTellinos.Properties.Resources.atras;
            this.btnAtras.Location = new System.Drawing.Point(12, 12);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(30, 30);
            this.btnAtras.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnAtras.TabIndex = 18;
            this.btnAtras.TabStop = false;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // Cerrar
            // 
            this.Cerrar.Image = global::PizzeriaTellinos.Properties.Resources.Close_Window__2_48px;
            this.Cerrar.Location = new System.Drawing.Point(410, 12);
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
            this.Minimizar.Location = new System.Drawing.Point(374, 12);
            this.Minimizar.Name = "Minimizar";
            this.Minimizar.Size = new System.Drawing.Size(30, 30);
            this.Minimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Minimizar.TabIndex = 0;
            this.Minimizar.TabStop = false;
            this.Minimizar.Click += new System.EventHandler(this.Minimizar_Click);
            // 
            // btnPizzas
            // 
            this.btnPizzas.BackColor = System.Drawing.Color.Transparent;
            this.btnPizzas.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPizzas.Image = global::PizzeriaTellinos.Properties.Resources.Pizza1;
            this.btnPizzas.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPizzas.Location = new System.Drawing.Point(56, 136);
            this.btnPizzas.Name = "btnPizzas";
            this.btnPizzas.Size = new System.Drawing.Size(162, 91);
            this.btnPizzas.TabIndex = 27;
            this.btnPizzas.Text = "Pizzas";
            this.btnPizzas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPizzas.UseVisualStyleBackColor = false;
            this.btnPizzas.Click += new System.EventHandler(this.btnPizzas_Click);
            // 
            // btnBebidas
            // 
            this.btnBebidas.BackColor = System.Drawing.Color.Transparent;
            this.btnBebidas.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBebidas.Image = global::PizzeriaTellinos.Properties.Resources.cafe1;
            this.btnBebidas.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBebidas.Location = new System.Drawing.Point(243, 136);
            this.btnBebidas.Name = "btnBebidas";
            this.btnBebidas.Size = new System.Drawing.Size(151, 91);
            this.btnBebidas.TabIndex = 28;
            this.btnBebidas.Text = "Bebidas";
            this.btnBebidas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBebidas.UseVisualStyleBackColor = false;
            this.btnBebidas.Click += new System.EventHandler(this.btnBebidas_Click);
            // 
            // btnExtras
            // 
            this.btnExtras.BackColor = System.Drawing.Color.Transparent;
            this.btnExtras.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExtras.Image = global::PizzeriaTellinos.Properties.Resources.papas;
            this.btnExtras.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnExtras.Location = new System.Drawing.Point(56, 244);
            this.btnExtras.Name = "btnExtras";
            this.btnExtras.Size = new System.Drawing.Size(162, 91);
            this.btnExtras.TabIndex = 29;
            this.btnExtras.Text = "Extras";
            this.btnExtras.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExtras.UseVisualStyleBackColor = false;
            this.btnExtras.Click += new System.EventHandler(this.btnExtras_Click);
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.BackColor = System.Drawing.Color.Transparent;
            this.btnUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsuarios.Image = global::PizzeriaTellinos.Properties.Resources.usuarios1;
            this.btnUsuarios.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnUsuarios.Location = new System.Drawing.Point(243, 244);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(151, 91);
            this.btnUsuarios.TabIndex = 30;
            this.btnUsuarios.Text = "Usuarios";
            this.btnUsuarios.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnUsuarios.UseVisualStyleBackColor = false;
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(123, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 30);
            this.label2.TabIndex = 31;
            this.label2.Text = "MANTENIMIENTO";
            // 
            // Mantemiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(452, 402);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnUsuarios);
            this.Controls.Add(this.btnExtras);
            this.Controls.Add(this.MenuTop2);
            this.Controls.Add(this.btnBebidas);
            this.Controls.Add(this.btnPizzas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Mantemiento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mantemiento";
            this.MenuTop2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnAtras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minimizar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel MenuTop2;
        private System.Windows.Forms.PictureBox btnAtras;
        private System.Windows.Forms.PictureBox Cerrar;
        private System.Windows.Forms.PictureBox Minimizar;
        private System.Windows.Forms.Button btnPizzas;
        private System.Windows.Forms.Button btnBebidas;
        private System.Windows.Forms.Button btnExtras;
        private System.Windows.Forms.Button btnUsuarios;
        private System.Windows.Forms.Label label2;
    }
}