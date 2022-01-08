
namespace CapaPresentacion
{
    partial class FMenuPrincipal
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
            this.dgv_platillos_activos = new System.Windows.Forms.DataGridView();
            this.dgv_platillo = new System.Windows.Forms.DataGridView();
            this.dgv_bebida = new System.Windows.Forms.DataGridView();
            this.dgv_alimentos = new System.Windows.Forms.DataGridView();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_platillo = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_activas = new System.Windows.Forms.Label();
            this.lbl_orden = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_bebida = new System.Windows.Forms.Label();
            this.lbl_totalCaja = new System.Windows.Forms.Label();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.dgv_orden_bebidas = new System.Windows.Forms.DataGridView();
            this.lblNumeroVenta = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_platillos_activos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_platillo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_bebida)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_alimentos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_orden_bebidas)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_platillos_activos
            // 
            this.dgv_platillos_activos.AllowUserToAddRows = false;
            this.dgv_platillos_activos.AllowUserToDeleteRows = false;
            this.dgv_platillos_activos.AllowUserToResizeRows = false;
            this.dgv_platillos_activos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_platillos_activos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_platillos_activos.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dgv_platillos_activos.Location = new System.Drawing.Point(36, 81);
            this.dgv_platillos_activos.Name = "dgv_platillos_activos";
            this.dgv_platillos_activos.ReadOnly = true;
            this.dgv_platillos_activos.RowHeadersVisible = false;
            this.dgv_platillos_activos.Size = new System.Drawing.Size(203, 211);
            this.dgv_platillos_activos.TabIndex = 0;
            this.dgv_platillos_activos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_platillos_activos_CellContentClick);
            // 
            // dgv_platillo
            // 
            this.dgv_platillo.AllowUserToAddRows = false;
            this.dgv_platillo.AllowUserToDeleteRows = false;
            this.dgv_platillo.AllowUserToResizeRows = false;
            this.dgv_platillo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_platillo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_platillo.ColumnHeadersVisible = false;
            this.dgv_platillo.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dgv_platillo.Location = new System.Drawing.Point(31, 93);
            this.dgv_platillo.Name = "dgv_platillo";
            this.dgv_platillo.ReadOnly = true;
            this.dgv_platillo.RowHeadersVisible = false;
            this.dgv_platillo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgv_platillo.Size = new System.Drawing.Size(230, 211);
            this.dgv_platillo.TabIndex = 1;
            this.dgv_platillo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_platillo_CellContentClick);
            // 
            // dgv_bebida
            // 
            this.dgv_bebida.AllowUserToAddRows = false;
            this.dgv_bebida.AllowUserToDeleteRows = false;
            this.dgv_bebida.AllowUserToResizeRows = false;
            this.dgv_bebida.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_bebida.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_bebida.ColumnHeadersVisible = false;
            this.dgv_bebida.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dgv_bebida.Location = new System.Drawing.Point(406, 93);
            this.dgv_bebida.Name = "dgv_bebida";
            this.dgv_bebida.ReadOnly = true;
            this.dgv_bebida.RowHeadersVisible = false;
            this.dgv_bebida.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgv_bebida.Size = new System.Drawing.Size(239, 211);
            this.dgv_bebida.TabIndex = 3;
            this.dgv_bebida.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_bebida_CellContentClick);
            // 
            // dgv_alimentos
            // 
            this.dgv_alimentos.AllowUserToAddRows = false;
            this.dgv_alimentos.AllowUserToDeleteRows = false;
            this.dgv_alimentos.AllowUserToResizeRows = false;
            this.dgv_alimentos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_alimentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_alimentos.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dgv_alimentos.Location = new System.Drawing.Point(31, 328);
            this.dgv_alimentos.Name = "dgv_alimentos";
            this.dgv_alimentos.ReadOnly = true;
            this.dgv_alimentos.RowHeadersVisible = false;
            this.dgv_alimentos.Size = new System.Drawing.Size(300, 128);
            this.dgv_alimentos.TabIndex = 4;
            this.dgv_alimentos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_alimentos_CellDoubleClick);
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(284, 189);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(100, 29);
            this.txtCantidad.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(172)))), ((int)(((byte)(172)))));
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(294, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "Cantidad";
            // 
            // lbl_platillo
            // 
            this.lbl_platillo.AutoSize = true;
            this.lbl_platillo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(172)))), ((int)(((byte)(172)))));
            this.lbl_platillo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_platillo.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_platillo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.lbl_platillo.Location = new System.Drawing.Point(115, 66);
            this.lbl_platillo.Name = "lbl_platillo";
            this.lbl_platillo.Size = new System.Drawing.Size(63, 24);
            this.lbl_platillo.TabIndex = 7;
            this.lbl_platillo.Text = "Platillo";
            this.lbl_platillo.DoubleClick += new System.EventHandler(this.lbl_platillo_DoubleClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Orbitron", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(106)))), ((int)(((byte)(123)))));
            this.label4.Location = new System.Drawing.Point(230, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(220, 35);
            this.label4.TabIndex = 9;
            this.label4.Text = "Punto Venta";
            // 
            // lbl_activas
            // 
            this.lbl_activas.AutoSize = true;
            this.lbl_activas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(172)))), ((int)(((byte)(172)))));
            this.lbl_activas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_activas.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_activas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.lbl_activas.Location = new System.Drawing.Point(105, 54);
            this.lbl_activas.Name = "lbl_activas";
            this.lbl_activas.Size = new System.Drawing.Size(65, 24);
            this.lbl_activas.TabIndex = 10;
            this.lbl_activas.Text = "Activas";
            this.lbl_activas.DoubleClick += new System.EventHandler(this.lbl_activas_DoubleClick);
            // 
            // lbl_orden
            // 
            this.lbl_orden.AutoSize = true;
            this.lbl_orden.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(172)))), ((int)(((byte)(172)))));
            this.lbl_orden.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_orden.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_orden.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.lbl_orden.Location = new System.Drawing.Point(304, 291);
            this.lbl_orden.Name = "lbl_orden";
            this.lbl_orden.Size = new System.Drawing.Size(60, 24);
            this.lbl_orden.TabIndex = 11;
            this.lbl_orden.Text = "Orden";
            this.lbl_orden.DoubleClick += new System.EventHandler(this.lbl_orden_DoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(172)))), ((int)(((byte)(172)))));
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.label2.Location = new System.Drawing.Point(82, 316);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 24);
            this.label2.TabIndex = 12;
            this.label2.Text = "Total en caja:";
            this.label2.DoubleClick += new System.EventHandler(this.label2_DoubleClick);
            // 
            // lbl_bebida
            // 
            this.lbl_bebida.AutoSize = true;
            this.lbl_bebida.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(172)))), ((int)(((byte)(172)))));
            this.lbl_bebida.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_bebida.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_bebida.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.lbl_bebida.Location = new System.Drawing.Point(493, 66);
            this.lbl_bebida.Name = "lbl_bebida";
            this.lbl_bebida.Size = new System.Drawing.Size(64, 24);
            this.lbl_bebida.TabIndex = 8;
            this.lbl_bebida.Text = "Bebida";
            this.lbl_bebida.DoubleClick += new System.EventHandler(this.lbl_bebida_DoubleClick);
            // 
            // lbl_totalCaja
            // 
            this.lbl_totalCaja.AutoSize = true;
            this.lbl_totalCaja.BackColor = System.Drawing.Color.White;
            this.lbl_totalCaja.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_totalCaja.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_totalCaja.ForeColor = System.Drawing.Color.Black;
            this.lbl_totalCaja.Location = new System.Drawing.Point(82, 355);
            this.lbl_totalCaja.Name = "lbl_totalCaja";
            this.lbl_totalCaja.Size = new System.Drawing.Size(26, 24);
            this.lbl_totalCaja.TabIndex = 13;
            this.lbl_totalCaja.Text = "$-";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(172)))), ((int)(((byte)(172)))));
            this.btnRegistrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.btnRegistrar.Location = new System.Drawing.Point(78, 412);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(119, 32);
            this.btnRegistrar.TabIndex = 14;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // dgv_orden_bebidas
            // 
            this.dgv_orden_bebidas.AllowUserToAddRows = false;
            this.dgv_orden_bebidas.AllowUserToDeleteRows = false;
            this.dgv_orden_bebidas.AllowUserToResizeRows = false;
            this.dgv_orden_bebidas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_orden_bebidas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_orden_bebidas.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dgv_orden_bebidas.Location = new System.Drawing.Point(345, 328);
            this.dgv_orden_bebidas.Name = "dgv_orden_bebidas";
            this.dgv_orden_bebidas.ReadOnly = true;
            this.dgv_orden_bebidas.RowHeadersVisible = false;
            this.dgv_orden_bebidas.Size = new System.Drawing.Size(300, 128);
            this.dgv_orden_bebidas.TabIndex = 15;
            this.dgv_orden_bebidas.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_orden_bebidas_CellDoubleClick);
            // 
            // lblNumeroVenta
            // 
            this.lblNumeroVenta.AutoSize = true;
            this.lblNumeroVenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(172)))), ((int)(((byte)(172)))));
            this.lblNumeroVenta.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNumeroVenta.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroVenta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.lblNumeroVenta.Location = new System.Drawing.Point(316, 257);
            this.lblNumeroVenta.Name = "lblNumeroVenta";
            this.lblNumeroVenta.Size = new System.Drawing.Size(22, 24);
            this.lblNumeroVenta.TabIndex = 16;
            this.lblNumeroVenta.Text = "#";
            this.lblNumeroVenta.Click += new System.EventHandler(this.lblNumeroVenta_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(126)))), ((int)(((byte)(141)))));
            this.panel1.Controls.Add(this.btnRegistrar);
            this.panel1.Controls.Add(this.lbl_totalCaja);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lbl_activas);
            this.panel1.Controls.Add(this.dgv_platillos_activos);
            this.panel1.Location = new System.Drawing.Point(670, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(267, 465);
            this.panel1.TabIndex = 17;
            // 
            // FMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(197)))), ((int)(((byte)(185)))));
            this.ClientSize = new System.Drawing.Size(951, 489);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblNumeroVenta);
            this.Controls.Add(this.dgv_orden_bebidas);
            this.Controls.Add(this.lbl_orden);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbl_bebida);
            this.Controls.Add(this.lbl_platillo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.dgv_alimentos);
            this.Controls.Add(this.dgv_bebida);
            this.Controls.Add(this.dgv_platillo);
            this.Font = new System.Drawing.Font("Open Sans SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FMenuPrincipal";
            this.Text = "Punto de venta";
            this.Load += new System.EventHandler(this.FMenuPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_platillos_activos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_platillo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_bebida)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_alimentos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_orden_bebidas)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_platillo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_activas;
        private System.Windows.Forms.Label lbl_orden;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_bebida;
        private System.Windows.Forms.Label lbl_totalCaja;
        public System.Windows.Forms.DataGridView dgv_platillos_activos;
        public System.Windows.Forms.DataGridView dgv_platillo;
        public System.Windows.Forms.DataGridView dgv_bebida;
        public System.Windows.Forms.DataGridView dgv_alimentos;
        private System.Windows.Forms.Button btnRegistrar;
        public System.Windows.Forms.DataGridView dgv_orden_bebidas;
        private System.Windows.Forms.Label lblNumeroVenta;
        private System.Windows.Forms.Panel panel1;
    }
}