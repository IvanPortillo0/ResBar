namespace _ResBar_01._01.Forms_Views
{
    partial class Form_AddCategorias_View
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_AddCategorias_View));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.BarraEstadoClose = new System.Windows.Forms.Panel();
            this.btn_Close = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_CloseWindowsP = new Bunifu.Framework.UI.BunifuImageButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_AddCategoria = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btn_AddCategoria = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.BarraEstadoClose.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_CloseWindowsP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_AddCategoria)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // BarraEstadoClose
            // 
            this.BarraEstadoClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(1)))), ((int)(((byte)(37)))));
            this.BarraEstadoClose.Controls.Add(this.btn_Close);
            this.BarraEstadoClose.Controls.Add(this.bunifuImageButton1);
            this.BarraEstadoClose.Controls.Add(this.btn_CloseWindowsP);
            this.BarraEstadoClose.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarraEstadoClose.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BarraEstadoClose.Location = new System.Drawing.Point(0, 0);
            this.BarraEstadoClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BarraEstadoClose.Name = "BarraEstadoClose";
            this.BarraEstadoClose.Size = new System.Drawing.Size(398, 40);
            this.BarraEstadoClose.TabIndex = 5;
            // 
            // btn_Close
            // 
            this.btn_Close.BackColor = System.Drawing.Color.Transparent;
            this.btn_Close.Image = global::_ResBar_01._01.Properties.Resources.boton_de_borrar;
            this.btn_Close.ImageActive = null;
            this.btn_Close.Location = new System.Drawing.Point(338, 5);
            this.btn_Close.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(59, 30);
            this.btn_Close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_Close.TabIndex = 3;
            this.btn_Close.TabStop = false;
            this.btn_Close.Zoom = 10;
            this.btn_Close.Click += new System.EventHandler(this.bunifuImageButton2_Click);
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(1395, 11);
            this.bunifuImageButton1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(68, 38);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 2;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            // 
            // btn_CloseWindowsP
            // 
            this.btn_CloseWindowsP.BackColor = System.Drawing.Color.Transparent;
            this.btn_CloseWindowsP.Image = ((System.Drawing.Image)(resources.GetObject("btn_CloseWindowsP.Image")));
            this.btn_CloseWindowsP.ImageActive = null;
            this.btn_CloseWindowsP.Location = new System.Drawing.Point(1450, 11);
            this.btn_CloseWindowsP.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_CloseWindowsP.Name = "btn_CloseWindowsP";
            this.btn_CloseWindowsP.Size = new System.Drawing.Size(68, 38);
            this.btn_CloseWindowsP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_CloseWindowsP.TabIndex = 1;
            this.btn_CloseWindowsP.TabStop = false;
            this.btn_CloseWindowsP.Zoom = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(94, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 23);
            this.label1.TabIndex = 23;
            this.label1.Text = "NUEVA CATEGORÍA";
            // 
            // txt_AddCategoria
            // 
            this.txt_AddCategoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(233)))), ((int)(((byte)(198)))));
            this.txt_AddCategoria.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txt_AddCategoria.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txt_AddCategoria.ForeColor = System.Drawing.Color.Black;
            this.txt_AddCategoria.HintForeColor = System.Drawing.Color.Empty;
            this.txt_AddCategoria.HintText = "";
            this.txt_AddCategoria.isPassword = false;
            this.txt_AddCategoria.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(1)))), ((int)(((byte)(42)))));
            this.txt_AddCategoria.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(132)))), ((int)(((byte)(26)))));
            this.txt_AddCategoria.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(1)))), ((int)(((byte)(37)))));
            this.txt_AddCategoria.LineThickness = 4;
            this.txt_AddCategoria.Location = new System.Drawing.Point(21, 111);
            this.txt_AddCategoria.Margin = new System.Windows.Forms.Padding(6);
            this.txt_AddCategoria.Name = "txt_AddCategoria";
            this.txt_AddCategoria.Size = new System.Drawing.Size(358, 53);
            this.txt_AddCategoria.TabIndex = 24;
            this.txt_AddCategoria.Text = "Escribe la Categoría...";
            this.txt_AddCategoria.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btn_AddCategoria
            // 
            this.btn_AddCategoria.BackColor = System.Drawing.Color.Transparent;
            this.btn_AddCategoria.Image = global::_ResBar_01._01.Properties.Resources.btn_Agregar_naranja;
            this.btn_AddCategoria.ImageActive = null;
            this.btn_AddCategoria.Location = new System.Drawing.Point(319, 187);
            this.btn_AddCategoria.Name = "btn_AddCategoria";
            this.btn_AddCategoria.Size = new System.Drawing.Size(60, 56);
            this.btn_AddCategoria.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_AddCategoria.TabIndex = 25;
            this.btn_AddCategoria.TabStop = false;
            this.btn_AddCategoria.Zoom = 10;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.BarraEstadoClose;
            this.bunifuDragControl1.Vertical = true;
            // 
            // Form_AddCategorias_View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(233)))), ((int)(((byte)(198)))));
            this.ClientSize = new System.Drawing.Size(398, 266);
            this.Controls.Add(this.btn_AddCategoria);
            this.Controls.Add(this.txt_AddCategoria);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BarraEstadoClose);
            this.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form_AddCategorias_View";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_AddCategorias_View";
            this.BarraEstadoClose.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_Close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_CloseWindowsP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_AddCategoria)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel BarraEstadoClose;
        private Bunifu.Framework.UI.BunifuImageButton btn_Close;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private Bunifu.Framework.UI.BunifuImageButton btn_CloseWindowsP;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_AddCategoria;
        private Bunifu.Framework.UI.BunifuImageButton btn_AddCategoria;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
    }
}