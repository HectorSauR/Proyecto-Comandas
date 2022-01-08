
namespace CapaPresentacion.Venta
{
    partial class FVerOrdenActiva
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
            this.dgv_orden = new System.Windows.Forms.DataGridView();
            this.lbl_orden = new System.Windows.Forms.Label();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_orden)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_orden
            // 
            this.dgv_orden.AllowUserToAddRows = false;
            this.dgv_orden.AllowUserToDeleteRows = false;
            this.dgv_orden.AllowUserToResizeRows = false;
            this.dgv_orden.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_orden.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_orden.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dgv_orden.Location = new System.Drawing.Point(92, 121);
            this.dgv_orden.Name = "dgv_orden";
            this.dgv_orden.ReadOnly = true;
            this.dgv_orden.RowHeadersVisible = false;
            this.dgv_orden.Size = new System.Drawing.Size(621, 158);
            this.dgv_orden.TabIndex = 16;
            // 
            // lbl_orden
            // 
            this.lbl_orden.AutoSize = true;
            this.lbl_orden.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(172)))), ((int)(((byte)(172)))));
            this.lbl_orden.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_orden.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_orden.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.lbl_orden.Location = new System.Drawing.Point(367, 82);
            this.lbl_orden.Name = "lbl_orden";
            this.lbl_orden.Size = new System.Drawing.Size(60, 24);
            this.lbl_orden.TabIndex = 18;
            this.lbl_orden.Text = "Orden";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(172)))), ((int)(((byte)(172)))));
            this.btnRegistrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.btnRegistrar.Location = new System.Drawing.Point(337, 349);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(119, 32);
            this.btnRegistrar.TabIndex = 19;
            this.btnRegistrar.Text = "Confirmar";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(172)))), ((int)(((byte)(172)))));
            this.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotal.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.lblTotal.Location = new System.Drawing.Point(367, 303);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(21, 24);
            this.lblTotal.TabIndex = 20;
            this.lblTotal.Text = "$";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FVerOrdenActiva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(197)))), ((int)(((byte)(185)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.lbl_orden);
            this.Controls.Add(this.dgv_orden);
            this.Name = "FVerOrdenActiva";
            this.Text = "FVerOrdenActiva";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FVerOrdenActiva_FormClosed);
            this.Load += new System.EventHandler(this.FVerOrdenActiva_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_orden)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.DataGridView dgv_orden;
        public System.Windows.Forms.Label lblTotal;
        public System.Windows.Forms.Label lbl_orden;
        public System.Windows.Forms.Button btnRegistrar;
    }
}