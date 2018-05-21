namespace _ResBar_01._01
{
    partial class Form1
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
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.PBarraEstado = new System.Windows.Forms.Panel();
            this.btnPrueba = new System.Windows.Forms.Button();
            this.btn_Minizar = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_CloseWindowsP = new Bunifu.Framework.UI.BunifuImageButton();
            this.PBarraMenu = new System.Windows.Forms.Panel();
            this.btnPrincipalMenu = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnAdmonMenu = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnEstadisticasMenu = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.PBarraEstado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Minizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_CloseWindowsP)).BeginInit();
            this.PBarraMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnPrincipalMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdmonMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEstadisticasMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 1;
            this.bunifuElipse1.TargetControl = this;
            // 
            // PBarraEstado
            // 
            this.PBarraEstado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(1)))), ((int)(((byte)(37)))));
            this.PBarraEstado.Controls.Add(this.btnPrueba);
            this.PBarraEstado.Controls.Add(this.btn_Minizar);
            this.PBarraEstado.Controls.Add(this.btn_CloseWindowsP);
            this.PBarraEstado.Dock = System.Windows.Forms.DockStyle.Top;
            this.PBarraEstado.Location = new System.Drawing.Point(0, 0);
            this.PBarraEstado.Name = "PBarraEstado";
            this.PBarraEstado.Size = new System.Drawing.Size(1024, 34);
            this.PBarraEstado.TabIndex = 0;
            // 
            // btnPrueba
            // 
            this.btnPrueba.Location = new System.Drawing.Point(198, 11);
            this.btnPrueba.Name = "btnPrueba";
            this.btnPrueba.Size = new System.Drawing.Size(75, 23);
            this.btnPrueba.TabIndex = 9;
            this.btnPrueba.Text = "button1";
            this.btnPrueba.UseVisualStyleBackColor = true;
            this.btnPrueba.Click += new System.EventHandler(this.btnPrueba_Click);
            // 
            // btn_Minizar
            // 
            this.btn_Minizar.BackColor = System.Drawing.Color.Transparent;
            this.btn_Minizar.Image = global::_ResBar_01._01.Properties.Resources.btn_eliminar;
            this.btn_Minizar.ImageActive = null;
            this.btn_Minizar.Location = new System.Drawing.Point(939, 4);
            this.btn_Minizar.Name = "btn_Minizar";
            this.btn_Minizar.Size = new System.Drawing.Size(45, 25);
            this.btn_Minizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_Minizar.TabIndex = 4;
            this.btn_Minizar.TabStop = false;
            this.btn_Minizar.Zoom = 10;
            this.btn_Minizar.Click += new System.EventHandler(this.btn_Minizar_Click);
            // 
            // btn_CloseWindowsP
            // 
            this.btn_CloseWindowsP.BackColor = System.Drawing.Color.Transparent;
            this.btn_CloseWindowsP.Image = global::_ResBar_01._01.Properties.Resources.boton_de_borrar;
            this.btn_CloseWindowsP.ImageActive = null;
            this.btn_CloseWindowsP.Location = new System.Drawing.Point(976, 4);
            this.btn_CloseWindowsP.Name = "btn_CloseWindowsP";
            this.btn_CloseWindowsP.Size = new System.Drawing.Size(45, 25);
            this.btn_CloseWindowsP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_CloseWindowsP.TabIndex = 3;
            this.btn_CloseWindowsP.TabStop = false;
            this.btn_CloseWindowsP.Zoom = 10;
            this.btn_CloseWindowsP.Click += new System.EventHandler(this.btn_CloseWindowsP_Click);
            // 
            // PBarraMenu
            // 
            this.PBarraMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(1)))), ((int)(((byte)(42)))));
            this.PBarraMenu.Controls.Add(this.btnPrincipalMenu);
            this.PBarraMenu.Controls.Add(this.btnAdmonMenu);
            this.PBarraMenu.Controls.Add(this.btnEstadisticasMenu);
            this.PBarraMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.PBarraMenu.Location = new System.Drawing.Point(0, 34);
            this.PBarraMenu.Name = "PBarraMenu";
            this.PBarraMenu.Size = new System.Drawing.Size(1024, 56);
            this.PBarraMenu.TabIndex = 1;
            // 
            // btnPrincipalMenu
            // 
            this.btnPrincipalMenu.BackColor = System.Drawing.Color.Transparent;
            this.btnPrincipalMenu.Image = global::_ResBar_01._01.Properties.Resources.casa;
            this.btnPrincipalMenu.ImageActive = null;
            this.btnPrincipalMenu.Location = new System.Drawing.Point(360, 6);
            this.btnPrincipalMenu.Name = "btnPrincipalMenu";
            this.btnPrincipalMenu.Size = new System.Drawing.Size(49, 41);
            this.btnPrincipalMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnPrincipalMenu.TabIndex = 8;
            this.btnPrincipalMenu.TabStop = false;
            this.btnPrincipalMenu.Zoom = 10;
            this.btnPrincipalMenu.Click += new System.EventHandler(this.btnPrincipalMenu_Click);
            // 
            // btnAdmonMenu
            // 
            this.btnAdmonMenu.BackColor = System.Drawing.Color.Transparent;
            this.btnAdmonMenu.Image = global::_ResBar_01._01.Properties.Resources.comedor;
            this.btnAdmonMenu.ImageActive = null;
            this.btnAdmonMenu.Location = new System.Drawing.Point(496, 6);
            this.btnAdmonMenu.Name = "btnAdmonMenu";
            this.btnAdmonMenu.Size = new System.Drawing.Size(49, 41);
            this.btnAdmonMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnAdmonMenu.TabIndex = 6;
            this.btnAdmonMenu.TabStop = false;
            this.btnAdmonMenu.Zoom = 10;
            this.btnAdmonMenu.Click += new System.EventHandler(this.btnAdmonMenu_Click);
            // 
            // btnEstadisticasMenu
            // 
            this.btnEstadisticasMenu.BackColor = System.Drawing.Color.Transparent;
            this.btnEstadisticasMenu.Image = global::_ResBar_01._01.Properties.Resources.estadistica;
            this.btnEstadisticasMenu.ImageActive = null;
            this.btnEstadisticasMenu.Location = new System.Drawing.Point(623, 6);
            this.btnEstadisticasMenu.Name = "btnEstadisticasMenu";
            this.btnEstadisticasMenu.Size = new System.Drawing.Size(49, 41);
            this.btnEstadisticasMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnEstadisticasMenu.TabIndex = 7;
            this.btnEstadisticasMenu.TabStop = false;
            this.btnEstadisticasMenu.Zoom = 10;
            this.btnEstadisticasMenu.Click += new System.EventHandler(this.btnEstadisticasMenu_Click);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.PBarraEstado;
            this.bunifuDragControl1.Vertical = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Controls.Add(this.PBarraMenu);
            this.Controls.Add(this.PBarraEstado);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.PBarraEstado.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_Minizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_CloseWindowsP)).EndInit();
            this.PBarraMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnPrincipalMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdmonMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEstadisticasMenu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel PBarraMenu;
        private System.Windows.Forms.Panel PBarraEstado;
        private Bunifu.Framework.UI.BunifuImageButton btn_Minizar;
        private Bunifu.Framework.UI.BunifuImageButton btn_CloseWindowsP;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuImageButton btnPrincipalMenu;
        private Bunifu.Framework.UI.BunifuImageButton btnAdmonMenu;
        private Bunifu.Framework.UI.BunifuImageButton btnEstadisticasMenu;
        private System.Windows.Forms.Button btnPrueba;
    }
}

