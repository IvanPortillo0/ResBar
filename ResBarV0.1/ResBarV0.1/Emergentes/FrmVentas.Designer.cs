namespace ResBarV0._1.Emergentes
{
    partial class FrmVentas
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVentas));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.barra_superior = new System.Windows.Forms.Panel();
            this.pbVentas = new System.Windows.Forms.PictureBox();
            this.lblVentas = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btn_cerrar = new Bunifu.Framework.UI.BunifuImageButton();
            this.bnt_Minimizar = new Bunifu.Framework.UI.BunifuImageButton();
            this.barra_inferior = new System.Windows.Forms.Panel();
            this.barra_izquierda = new System.Windows.Forms.Panel();
            this.barra_derecha = new System.Windows.Forms.Panel();
            this.btnCerrar = new Bunifu.Framework.UI.BunifuImageButton();
            this.usVentas1 = new ResBarV0._1.Controles.usVentas();
            this.barra_superior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbVentas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_cerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bnt_Minimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 18;
            this.bunifuElipse1.TargetControl = this;
            // 
            // barra_superior
            // 
            this.barra_superior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(1)))), ((int)(((byte)(37)))));
            this.barra_superior.Controls.Add(this.pbVentas);
            this.barra_superior.Controls.Add(this.lblVentas);
            this.barra_superior.Controls.Add(this.btn_cerrar);
            this.barra_superior.Controls.Add(this.bnt_Minimizar);
            this.barra_superior.Dock = System.Windows.Forms.DockStyle.Top;
            this.barra_superior.Location = new System.Drawing.Point(0, 0);
            this.barra_superior.Name = "barra_superior";
            this.barra_superior.Size = new System.Drawing.Size(771, 60);
            this.barra_superior.TabIndex = 10;
            // 
            // pbVentas
            // 
            this.pbVentas.Image = global::ResBarV0._1.Properties.Resources.recepcion;
            this.pbVentas.Location = new System.Drawing.Point(244, 1);
            this.pbVentas.Name = "pbVentas";
            this.pbVentas.Size = new System.Drawing.Size(58, 58);
            this.pbVentas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbVentas.TabIndex = 60;
            this.pbVentas.TabStop = false;
            // 
            // lblVentas
            // 
            this.lblVentas.AutoSize = true;
            this.lblVentas.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVentas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(233)))), ((int)(((byte)(198)))));
            this.lblVentas.Location = new System.Drawing.Point(322, 16);
            this.lblVentas.Name = "lblVentas";
            this.lblVentas.Size = new System.Drawing.Size(227, 28);
            this.lblVentas.TabIndex = 25;
            this.lblVentas.Text = "Reporte de Ventas";
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.BackColor = System.Drawing.Color.Transparent;
            this.btn_cerrar.Image = ((System.Drawing.Image)(resources.GetObject("btn_cerrar.Image")));
            this.btn_cerrar.ImageActive = null;
            this.btn_cerrar.Location = new System.Drawing.Point(1164, 5);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(30, 30);
            this.btn_cerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_cerrar.TabIndex = 1;
            this.btn_cerrar.TabStop = false;
            this.btn_cerrar.Zoom = 10;
            // 
            // bnt_Minimizar
            // 
            this.bnt_Minimizar.BackColor = System.Drawing.Color.Transparent;
            this.bnt_Minimizar.Image = ((System.Drawing.Image)(resources.GetObject("bnt_Minimizar.Image")));
            this.bnt_Minimizar.ImageActive = null;
            this.bnt_Minimizar.Location = new System.Drawing.Point(1126, 5);
            this.bnt_Minimizar.Name = "bnt_Minimizar";
            this.bnt_Minimizar.Size = new System.Drawing.Size(30, 30);
            this.bnt_Minimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bnt_Minimizar.TabIndex = 0;
            this.bnt_Minimizar.TabStop = false;
            this.bnt_Minimizar.Zoom = 10;
            // 
            // barra_inferior
            // 
            this.barra_inferior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(1)))), ((int)(((byte)(42)))));
            this.barra_inferior.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barra_inferior.Location = new System.Drawing.Point(0, 663);
            this.barra_inferior.Name = "barra_inferior";
            this.barra_inferior.Size = new System.Drawing.Size(771, 10);
            this.barra_inferior.TabIndex = 11;
            // 
            // barra_izquierda
            // 
            this.barra_izquierda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(1)))), ((int)(((byte)(42)))));
            this.barra_izquierda.Location = new System.Drawing.Point(0, 60);
            this.barra_izquierda.Name = "barra_izquierda";
            this.barra_izquierda.Size = new System.Drawing.Size(10, 603);
            this.barra_izquierda.TabIndex = 87;
            // 
            // barra_derecha
            // 
            this.barra_derecha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(1)))), ((int)(((byte)(42)))));
            this.barra_derecha.Location = new System.Drawing.Point(761, 60);
            this.barra_derecha.Name = "barra_derecha";
            this.barra_derecha.Size = new System.Drawing.Size(10, 603);
            this.barra_derecha.TabIndex = 88;
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.Transparent;
            this.btnCerrar.Image = global::ResBarV0._1.Properties.Resources.cerrar;
            this.btnCerrar.ImageActive = null;
            this.btnCerrar.Location = new System.Drawing.Point(357, 590);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(71, 56);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 89;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Zoom = 10;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // usVentas1
            // 
            this.usVentas1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(233)))), ((int)(((byte)(198)))));
            this.usVentas1.Location = new System.Drawing.Point(10, 60);
            this.usVentas1.Name = "usVentas1";
            this.usVentas1.Size = new System.Drawing.Size(751, 603);
            this.usVentas1.TabIndex = 12;
            // 
            // FrmVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(233)))), ((int)(((byte)(198)))));
            this.ClientSize = new System.Drawing.Size(771, 673);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.barra_derecha);
            this.Controls.Add(this.barra_izquierda);
            this.Controls.Add(this.usVentas1);
            this.Controls.Add(this.barra_inferior);
            this.Controls.Add(this.barra_superior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmVentas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmVentas";
            this.barra_superior.ResumeLayout(false);
            this.barra_superior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbVentas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_cerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bnt_Minimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel barra_superior;
        private System.Windows.Forms.PictureBox pbVentas;
        private Bunifu.Framework.UI.BunifuCustomLabel lblVentas;
        private Bunifu.Framework.UI.BunifuImageButton btn_cerrar;
        private Bunifu.Framework.UI.BunifuImageButton bnt_Minimizar;
        private System.Windows.Forms.Panel barra_inferior;
        private Controles.usVentas usVentas1;
        private System.Windows.Forms.Panel barra_izquierda;
        private System.Windows.Forms.Panel barra_derecha;
        private Bunifu.Framework.UI.BunifuImageButton btnCerrar;
    }
}