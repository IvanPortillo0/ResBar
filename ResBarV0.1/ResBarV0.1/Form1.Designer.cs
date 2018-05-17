namespace ResBarV0._1
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.barra_inferior = new System.Windows.Forms.Panel();
            this.barra_izquierda = new System.Windows.Forms.Panel();
            this.barra_superior = new System.Windows.Forms.Panel();
            this.BtnSalir = new Bunifu.Framework.UI.BunifuImageButton();
            this.BtnMinimizar = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_cerrar = new Bunifu.Framework.UI.BunifuImageButton();
            this.bnt_Minimizar = new Bunifu.Framework.UI.BunifuImageButton();
            this.barra_menu = new System.Windows.Forms.Panel();
            this.btnMostrarVentas = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnAdminMenu = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuDragControl2 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.barra_derecha = new System.Windows.Forms.Panel();
            this.panel_central = new System.Windows.Forms.Panel();
            this.usOrdenesActivas1 = new ResBarV0._1.Controles.usOrdenesActivas();
            this.barra_superior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnSalir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_cerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bnt_Minimizar)).BeginInit();
            this.barra_menu.SuspendLayout();
            this.panel_central.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 18;
            this.bunifuElipse1.TargetControl = this;
            // 
            // barra_inferior
            // 
            this.barra_inferior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(1)))), ((int)(((byte)(42)))));
            this.barra_inferior.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barra_inferior.Location = new System.Drawing.Point(0, 720);
            this.barra_inferior.Name = "barra_inferior";
            this.barra_inferior.Size = new System.Drawing.Size(1024, 10);
            this.barra_inferior.TabIndex = 0;
            // 
            // barra_izquierda
            // 
            this.barra_izquierda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(1)))), ((int)(((byte)(42)))));
            this.barra_izquierda.Location = new System.Drawing.Point(0, 114);
            this.barra_izquierda.Name = "barra_izquierda";
            this.barra_izquierda.Size = new System.Drawing.Size(10, 643);
            this.barra_izquierda.TabIndex = 1;
            // 
            // barra_superior
            // 
            this.barra_superior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(1)))), ((int)(((byte)(37)))));
            this.barra_superior.Controls.Add(this.BtnSalir);
            this.barra_superior.Controls.Add(this.BtnMinimizar);
            this.barra_superior.Controls.Add(this.btn_cerrar);
            this.barra_superior.Controls.Add(this.bnt_Minimizar);
            this.barra_superior.Dock = System.Windows.Forms.DockStyle.Top;
            this.barra_superior.Location = new System.Drawing.Point(0, 0);
            this.barra_superior.Name = "barra_superior";
            this.barra_superior.Size = new System.Drawing.Size(1024, 46);
            this.barra_superior.TabIndex = 2;
            // 
            // BtnSalir
            // 
            this.BtnSalir.BackColor = System.Drawing.Color.Transparent;
            this.BtnSalir.Image = global::ResBarV0._1.Properties.Resources.Salir1;
            this.BtnSalir.ImageActive = null;
            this.BtnSalir.Location = new System.Drawing.Point(928, 10);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(30, 30);
            this.BtnSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnSalir.TabIndex = 3;
            this.BtnSalir.TabStop = false;
            this.BtnSalir.Zoom = 10;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // BtnMinimizar
            // 
            this.BtnMinimizar.BackColor = System.Drawing.Color.Transparent;
            this.BtnMinimizar.Image = global::ResBarV0._1.Properties.Resources.menos;
            this.BtnMinimizar.ImageActive = null;
            this.BtnMinimizar.Location = new System.Drawing.Point(890, 10);
            this.BtnMinimizar.Name = "BtnMinimizar";
            this.BtnMinimizar.Size = new System.Drawing.Size(30, 30);
            this.BtnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnMinimizar.TabIndex = 2;
            this.BtnMinimizar.TabStop = false;
            this.BtnMinimizar.Zoom = 10;
            this.BtnMinimizar.Click += new System.EventHandler(this.BtnMinimizar_Click);
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
            // barra_menu
            // 
            this.barra_menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(1)))), ((int)(((byte)(42)))));
            this.barra_menu.Controls.Add(this.btnMostrarVentas);
            this.barra_menu.Controls.Add(this.btnAdminMenu);
            this.barra_menu.Dock = System.Windows.Forms.DockStyle.Top;
            this.barra_menu.Location = new System.Drawing.Point(0, 46);
            this.barra_menu.Name = "barra_menu";
            this.barra_menu.Size = new System.Drawing.Size(1024, 70);
            this.barra_menu.TabIndex = 3;
            // 
            // btnMostrarVentas
            // 
            this.btnMostrarVentas.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(1)))), ((int)(((byte)(37)))));
            this.btnMostrarVentas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(1)))), ((int)(((byte)(37)))));
            this.btnMostrarVentas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMostrarVentas.BorderRadius = 5;
            this.btnMostrarVentas.ButtonText = "Ventas";
            this.btnMostrarVentas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMostrarVentas.DisabledColor = System.Drawing.Color.Gray;
            this.btnMostrarVentas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(233)))), ((int)(((byte)(198)))));
            this.btnMostrarVentas.Iconcolor = System.Drawing.Color.Transparent;
            this.btnMostrarVentas.Iconimage = global::ResBarV0._1.Properties.Resources.recepcion;
            this.btnMostrarVentas.Iconimage_right = null;
            this.btnMostrarVentas.Iconimage_right_Selected = null;
            this.btnMostrarVentas.Iconimage_Selected = null;
            this.btnMostrarVentas.IconMarginLeft = 0;
            this.btnMostrarVentas.IconMarginRight = 0;
            this.btnMostrarVentas.IconRightVisible = true;
            this.btnMostrarVentas.IconRightZoom = 0D;
            this.btnMostrarVentas.IconVisible = true;
            this.btnMostrarVentas.IconZoom = 80D;
            this.btnMostrarVentas.IsTab = false;
            this.btnMostrarVentas.Location = new System.Drawing.Point(527, 0);
            this.btnMostrarVentas.Name = "btnMostrarVentas";
            this.btnMostrarVentas.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(1)))), ((int)(((byte)(37)))));
            this.btnMostrarVentas.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(1)))), ((int)(((byte)(37)))));
            this.btnMostrarVentas.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(233)))), ((int)(((byte)(198)))));
            this.btnMostrarVentas.selected = false;
            this.btnMostrarVentas.Size = new System.Drawing.Size(164, 70);
            this.btnMostrarVentas.TabIndex = 10;
            this.btnMostrarVentas.Text = "Ventas";
            this.btnMostrarVentas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnMostrarVentas.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(233)))), ((int)(((byte)(198)))));
            this.btnMostrarVentas.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrarVentas.Click += new System.EventHandler(this.btnMostrarVentas_Click);
            // 
            // btnAdminMenu
            // 
            this.btnAdminMenu.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(1)))), ((int)(((byte)(37)))));
            this.btnAdminMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(1)))), ((int)(((byte)(37)))));
            this.btnAdminMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAdminMenu.BorderRadius = 5;
            this.btnAdminMenu.ButtonText = "     Admin Menú";
            this.btnAdminMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdminMenu.DisabledColor = System.Drawing.Color.Gray;
            this.btnAdminMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(233)))), ((int)(((byte)(198)))));
            this.btnAdminMenu.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAdminMenu.Iconimage = global::ResBarV0._1.Properties.Resources.ajustes;
            this.btnAdminMenu.Iconimage_right = null;
            this.btnAdminMenu.Iconimage_right_Selected = null;
            this.btnAdminMenu.Iconimage_Selected = null;
            this.btnAdminMenu.IconMarginLeft = 0;
            this.btnAdminMenu.IconMarginRight = 0;
            this.btnAdminMenu.IconRightVisible = true;
            this.btnAdminMenu.IconRightZoom = 0D;
            this.btnAdminMenu.IconVisible = true;
            this.btnAdminMenu.IconZoom = 80D;
            this.btnAdminMenu.IsTab = false;
            this.btnAdminMenu.Location = new System.Drawing.Point(281, 0);
            this.btnAdminMenu.Name = "btnAdminMenu";
            this.btnAdminMenu.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(1)))), ((int)(((byte)(37)))));
            this.btnAdminMenu.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(1)))), ((int)(((byte)(37)))));
            this.btnAdminMenu.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(233)))), ((int)(((byte)(198)))));
            this.btnAdminMenu.selected = false;
            this.btnAdminMenu.Size = new System.Drawing.Size(205, 70);
            this.btnAdminMenu.TabIndex = 9;
            this.btnAdminMenu.Text = "     Admin Menú";
            this.btnAdminMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdminMenu.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(233)))), ((int)(((byte)(198)))));
            this.btnAdminMenu.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdminMenu.Click += new System.EventHandler(this.btnAdminMenu_Click);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = null;
            this.bunifuDragControl1.Vertical = true;
            // 
            // bunifuDragControl2
            // 
            this.bunifuDragControl2.Fixed = true;
            this.bunifuDragControl2.Horizontal = true;
            this.bunifuDragControl2.TargetControl = this.barra_superior;
            this.bunifuDragControl2.Vertical = true;
            // 
            // barra_derecha
            // 
            this.barra_derecha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(1)))), ((int)(((byte)(42)))));
            this.barra_derecha.Location = new System.Drawing.Point(1014, 114);
            this.barra_derecha.Name = "barra_derecha";
            this.barra_derecha.Size = new System.Drawing.Size(10, 643);
            this.barra_derecha.TabIndex = 4;
            // 
            // panel_central
            // 
            this.panel_central.Controls.Add(this.usOrdenesActivas1);
            this.panel_central.Location = new System.Drawing.Point(10, 116);
            this.panel_central.Name = "panel_central";
            this.panel_central.Size = new System.Drawing.Size(1003, 603);
            this.panel_central.TabIndex = 5;
            // 
            // usOrdenesActivas1
            // 
            this.usOrdenesActivas1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(233)))), ((int)(((byte)(198)))));
            this.usOrdenesActivas1.Location = new System.Drawing.Point(0, 0);
            this.usOrdenesActivas1.Name = "usOrdenesActivas1";
            this.usOrdenesActivas1.Size = new System.Drawing.Size(1003, 603);
            this.usOrdenesActivas1.TabIndex = 0;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(233)))), ((int)(((byte)(198)))));
            this.ClientSize = new System.Drawing.Size(1024, 730);
            this.Controls.Add(this.panel_central);
            this.Controls.Add(this.barra_derecha);
            this.Controls.Add(this.barra_menu);
            this.Controls.Add(this.barra_superior);
            this.Controls.Add(this.barra_izquierda);
            this.Controls.Add(this.barra_inferior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.barra_superior.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BtnSalir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_cerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bnt_Minimizar)).EndInit();
            this.barra_menu.ResumeLayout(false);
            this.panel_central.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel barra_superior;
        private Bunifu.Framework.UI.BunifuImageButton btn_cerrar;
        private Bunifu.Framework.UI.BunifuImageButton bnt_Minimizar;
        private System.Windows.Forms.Panel barra_izquierda;
        private System.Windows.Forms.Panel barra_inferior;
        private System.Windows.Forms.Panel barra_menu;
        private Bunifu.Framework.UI.BunifuImageButton BtnSalir;
        private Bunifu.Framework.UI.BunifuImageButton BtnMinimizar;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl2;
        private System.Windows.Forms.Panel barra_derecha;
        private System.Windows.Forms.Panel panel_central;
        private Bunifu.Framework.UI.BunifuFlatButton btnMostrarVentas;
        private Bunifu.Framework.UI.BunifuFlatButton btnAdminMenu;
        private Controles.usOrdenesActivas usOrdenesActivas1;
    }
}

