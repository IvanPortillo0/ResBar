namespace ResBarV0._1.Emergentes
{
    partial class FrmDetalleOrden
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDetalleOrden));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.barra_superior = new System.Windows.Forms.Panel();
            this.pbDetalleOrden = new System.Windows.Forms.PictureBox();
            this.lblDetalleOrden = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btn_cerrar = new Bunifu.Framework.UI.BunifuImageButton();
            this.bnt_Minimizar = new Bunifu.Framework.UI.BunifuImageButton();
            this.barra_inferior = new System.Windows.Forms.Panel();
            this.barra_izquierda = new System.Windows.Forms.Panel();
            this.barra_derecha = new System.Windows.Forms.Panel();
            this.btnAceptar = new Bunifu.Framework.UI.BunifuImageButton();
            this.usDetalleOrden = new ResBarV0._1.Controles.usDetalleOrden();
            this.barra_superior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDetalleOrden)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_cerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bnt_Minimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAceptar)).BeginInit();
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
            this.barra_superior.Controls.Add(this.pbDetalleOrden);
            this.barra_superior.Controls.Add(this.lblDetalleOrden);
            this.barra_superior.Controls.Add(this.btn_cerrar);
            this.barra_superior.Controls.Add(this.bnt_Minimizar);
            this.barra_superior.Dock = System.Windows.Forms.DockStyle.Top;
            this.barra_superior.Location = new System.Drawing.Point(0, 0);
            this.barra_superior.Name = "barra_superior";
            this.barra_superior.Size = new System.Drawing.Size(920, 60);
            this.barra_superior.TabIndex = 9;
            // 
            // pbDetalleOrden
            // 
            this.pbDetalleOrden.Image = global::ResBarV0._1.Properties.Resources.archivo_listo;
            this.pbDetalleOrden.Location = new System.Drawing.Point(343, 1);
            this.pbDetalleOrden.Name = "pbDetalleOrden";
            this.pbDetalleOrden.Size = new System.Drawing.Size(58, 58);
            this.pbDetalleOrden.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbDetalleOrden.TabIndex = 60;
            this.pbDetalleOrden.TabStop = false;
            // 
            // lblDetalleOrden
            // 
            this.lblDetalleOrden.AutoSize = true;
            this.lblDetalleOrden.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetalleOrden.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(233)))), ((int)(((byte)(198)))));
            this.lblDetalleOrden.Location = new System.Drawing.Point(421, 16);
            this.lblDetalleOrden.Name = "lblDetalleOrden";
            this.lblDetalleOrden.Size = new System.Drawing.Size(212, 28);
            this.lblDetalleOrden.TabIndex = 25;
            this.lblDetalleOrden.Text = "Detalle de Orden";
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
            this.barra_inferior.Location = new System.Drawing.Point(0, 635);
            this.barra_inferior.Name = "barra_inferior";
            this.barra_inferior.Size = new System.Drawing.Size(920, 10);
            this.barra_inferior.TabIndex = 10;
            // 
            // barra_izquierda
            // 
            this.barra_izquierda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(1)))), ((int)(((byte)(42)))));
            this.barra_izquierda.Location = new System.Drawing.Point(0, 60);
            this.barra_izquierda.Name = "barra_izquierda";
            this.barra_izquierda.Size = new System.Drawing.Size(10, 575);
            this.barra_izquierda.TabIndex = 11;
            // 
            // barra_derecha
            // 
            this.barra_derecha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(1)))), ((int)(((byte)(42)))));
            this.barra_derecha.Location = new System.Drawing.Point(910, 60);
            this.barra_derecha.Name = "barra_derecha";
            this.barra_derecha.Size = new System.Drawing.Size(10, 575);
            this.barra_derecha.TabIndex = 12;
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.Transparent;
            this.btnAceptar.Image = global::ResBarV0._1.Properties.Resources.Aceptar;
            this.btnAceptar.ImageActive = null;
            this.btnAceptar.Location = new System.Drawing.Point(426, 573);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(71, 56);
            this.btnAceptar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnAceptar.TabIndex = 77;
            this.btnAceptar.TabStop = false;
            this.btnAceptar.Zoom = 10;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // usDetalleOrden
            // 
            this.usDetalleOrden.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(233)))), ((int)(((byte)(198)))));
            this.usDetalleOrden.Location = new System.Drawing.Point(10, 60);
            this.usDetalleOrden.Name = "usDetalleOrden";
            this.usDetalleOrden.Size = new System.Drawing.Size(900, 575);
            this.usDetalleOrden.TabIndex = 78;
            // 
            // FrmDetalleOrden
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(233)))), ((int)(((byte)(198)))));
            this.ClientSize = new System.Drawing.Size(920, 645);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.barra_derecha);
            this.Controls.Add(this.barra_izquierda);
            this.Controls.Add(this.barra_inferior);
            this.Controls.Add(this.barra_superior);
            this.Controls.Add(this.usDetalleOrden);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmDetalleOrden";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmDetalleOrden";
            this.barra_superior.ResumeLayout(false);
            this.barra_superior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDetalleOrden)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_cerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bnt_Minimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAceptar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel barra_superior;
        private System.Windows.Forms.PictureBox pbDetalleOrden;
        private Bunifu.Framework.UI.BunifuCustomLabel lblDetalleOrden;
        private Bunifu.Framework.UI.BunifuImageButton btn_cerrar;
        private Bunifu.Framework.UI.BunifuImageButton bnt_Minimizar;
        private System.Windows.Forms.Panel barra_inferior;
        private System.Windows.Forms.Panel barra_izquierda;
        private System.Windows.Forms.Panel barra_derecha;
        private Bunifu.Framework.UI.BunifuImageButton btnAceptar;
        private Controles.usDetalleOrden usDetalleOrden;
    }
}