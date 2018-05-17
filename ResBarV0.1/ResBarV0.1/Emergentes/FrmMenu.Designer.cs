namespace ResBarV0._1.Emergentes
{
    partial class FrmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenu));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.barra_derecha = new System.Windows.Forms.Panel();
            this.barra_superior = new System.Windows.Forms.Panel();
            this.lblMenu = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btn_cerrar = new Bunifu.Framework.UI.BunifuImageButton();
            this.bnt_Minimizar = new Bunifu.Framework.UI.BunifuImageButton();
            this.barra_izquierda = new System.Windows.Forms.Panel();
            this.barra_inferior = new System.Windows.Forms.Panel();
            this.btnCerrar = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnMostrarDetalleOrden = new Bunifu.Framework.UI.BunifuImageButton();
            this.usMenu = new ResBarV0._1.Controles.usMenu();
            this.pbMenu = new System.Windows.Forms.PictureBox();
            this.barra_superior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_cerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bnt_Minimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMostrarDetalleOrden)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 18;
            this.bunifuElipse1.TargetControl = this;
            // 
            // barra_derecha
            // 
            this.barra_derecha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(1)))), ((int)(((byte)(42)))));
            this.barra_derecha.Location = new System.Drawing.Point(922, 60);
            this.barra_derecha.Name = "barra_derecha";
            this.barra_derecha.Size = new System.Drawing.Size(10, 545);
            this.barra_derecha.TabIndex = 8;
            // 
            // barra_superior
            // 
            this.barra_superior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(1)))), ((int)(((byte)(37)))));
            this.barra_superior.Controls.Add(this.pbMenu);
            this.barra_superior.Controls.Add(this.lblMenu);
            this.barra_superior.Controls.Add(this.btn_cerrar);
            this.barra_superior.Controls.Add(this.bnt_Minimizar);
            this.barra_superior.Dock = System.Windows.Forms.DockStyle.Top;
            this.barra_superior.Location = new System.Drawing.Point(0, 0);
            this.barra_superior.Name = "barra_superior";
            this.barra_superior.Size = new System.Drawing.Size(932, 60);
            this.barra_superior.TabIndex = 7;
            // 
            // lblMenu
            // 
            this.lblMenu.AutoSize = true;
            this.lblMenu.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(233)))), ((int)(((byte)(198)))));
            this.lblMenu.Location = new System.Drawing.Point(473, 16);
            this.lblMenu.Name = "lblMenu";
            this.lblMenu.Size = new System.Drawing.Size(77, 28);
            this.lblMenu.TabIndex = 25;
            this.lblMenu.Text = "Menú";
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
            // barra_izquierda
            // 
            this.barra_izquierda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(1)))), ((int)(((byte)(42)))));
            this.barra_izquierda.Location = new System.Drawing.Point(0, 60);
            this.barra_izquierda.Name = "barra_izquierda";
            this.barra_izquierda.Size = new System.Drawing.Size(10, 545);
            this.barra_izquierda.TabIndex = 6;
            // 
            // barra_inferior
            // 
            this.barra_inferior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(1)))), ((int)(((byte)(42)))));
            this.barra_inferior.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barra_inferior.Location = new System.Drawing.Point(0, 605);
            this.barra_inferior.Name = "barra_inferior";
            this.barra_inferior.Size = new System.Drawing.Size(932, 10);
            this.barra_inferior.TabIndex = 5;
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.Transparent;
            this.btnCerrar.Image = global::ResBarV0._1.Properties.Resources.cerrar;
            this.btnCerrar.ImageActive = null;
            this.btnCerrar.Location = new System.Drawing.Point(537, 541);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(71, 56);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 58;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Zoom = 10;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnMostrarDetalleOrden
            // 
            this.btnMostrarDetalleOrden.BackColor = System.Drawing.Color.Transparent;
            this.btnMostrarDetalleOrden.Image = global::ResBarV0._1.Properties.Resources.Aceptar;
            this.btnMostrarDetalleOrden.ImageActive = null;
            this.btnMostrarDetalleOrden.Location = new System.Drawing.Point(412, 541);
            this.btnMostrarDetalleOrden.Name = "btnMostrarDetalleOrden";
            this.btnMostrarDetalleOrden.Size = new System.Drawing.Size(71, 56);
            this.btnMostrarDetalleOrden.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMostrarDetalleOrden.TabIndex = 57;
            this.btnMostrarDetalleOrden.TabStop = false;
            this.btnMostrarDetalleOrden.Zoom = 10;
            this.btnMostrarDetalleOrden.Click += new System.EventHandler(this.btnMostrarDetalleOrden_Click);
            // 
            // usMenu
            // 
            this.usMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(233)))), ((int)(((byte)(198)))));
            this.usMenu.Location = new System.Drawing.Point(10, 60);
            this.usMenu.Name = "usMenu";
            this.usMenu.Size = new System.Drawing.Size(912, 545);
            this.usMenu.TabIndex = 9;
            // 
            // pbMenu
            // 
            this.pbMenu.Image = global::ResBarV0._1.Properties.Resources.bandeja_de_comida_cubierta_en_una_mano_del_servicio_de_habitaciones_del_hotel;
            this.pbMenu.Location = new System.Drawing.Point(397, 1);
            this.pbMenu.Name = "pbMenu";
            this.pbMenu.Size = new System.Drawing.Size(58, 58);
            this.pbMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbMenu.TabIndex = 61;
            this.pbMenu.TabStop = false;
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(233)))), ((int)(((byte)(198)))));
            this.ClientSize = new System.Drawing.Size(932, 615);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnMostrarDetalleOrden);
            this.Controls.Add(this.barra_derecha);
            this.Controls.Add(this.barra_superior);
            this.Controls.Add(this.barra_izquierda);
            this.Controls.Add(this.barra_inferior);
            this.Controls.Add(this.usMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMenu";
            this.barra_superior.ResumeLayout(false);
            this.barra_superior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_cerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bnt_Minimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMostrarDetalleOrden)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMenu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel barra_derecha;
        private System.Windows.Forms.Panel barra_superior;
        private Bunifu.Framework.UI.BunifuImageButton btn_cerrar;
        private Bunifu.Framework.UI.BunifuImageButton bnt_Minimizar;
        private System.Windows.Forms.Panel barra_izquierda;
        private System.Windows.Forms.Panel barra_inferior;
        private Controles.usMenu usMenu;
        private Bunifu.Framework.UI.BunifuImageButton btnCerrar;
        private Bunifu.Framework.UI.BunifuImageButton btnMostrarDetalleOrden;
        private Bunifu.Framework.UI.BunifuCustomLabel lblMenu;
        private System.Windows.Forms.PictureBox pbMenu;
    }
}