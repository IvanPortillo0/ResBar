namespace _ResBar_01._01.Forms_Views
{
    partial class Form_AdmonProducto_View
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_AdmonProducto_View));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.BarraEstadoClose = new System.Windows.Forms.Panel();
            this.btn_Close = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_CloseWindowsP = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnAgregaProducto = new Bunifu.Framework.UI.BunifuImageButton();
            this.GroupLNewOrder = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dropCategoria = new Bunifu.Framework.UI.BunifuDropdown();
            this.txt_PriceProducto = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txt_NameProducto = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.btnOkAdmonProducto = new Bunifu.Framework.UI.BunifuImageButton();
            this.radioCocina = new System.Windows.Forms.RadioButton();
            this.radioBebida = new System.Windows.Forms.RadioButton();
            this.BarraEstadoClose.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_CloseWindowsP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAgregaProducto)).BeginInit();
            this.GroupLNewOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnOkAdmonProducto)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 0;
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
            this.BarraEstadoClose.Size = new System.Drawing.Size(415, 40);
            this.BarraEstadoClose.TabIndex = 13;
            // 
            // btn_Close
            // 
            this.btn_Close.BackColor = System.Drawing.Color.Transparent;
            this.btn_Close.Image = global::_ResBar_01._01.Properties.Resources.boton_de_borrar;
            this.btn_Close.ImageActive = null;
            this.btn_Close.Location = new System.Drawing.Point(352, 5);
            this.btn_Close.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(59, 30);
            this.btn_Close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_Close.TabIndex = 3;
            this.btn_Close.TabStop = false;
            this.btn_Close.Zoom = 10;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
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
            // btnAgregaProducto
            // 
            this.btnAgregaProducto.BackColor = System.Drawing.Color.Transparent;
            this.btnAgregaProducto.Image = global::_ResBar_01._01.Properties.Resources.btn_Agregar_naranja;
            this.btnAgregaProducto.ImageActive = null;
            this.btnAgregaProducto.Location = new System.Drawing.Point(336, 441);
            this.btnAgregaProducto.Name = "btnAgregaProducto";
            this.btnAgregaProducto.Size = new System.Drawing.Size(61, 59);
            this.btnAgregaProducto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnAgregaProducto.TabIndex = 15;
            this.btnAgregaProducto.TabStop = false;
            this.btnAgregaProducto.Zoom = 10;
            // 
            // GroupLNewOrder
            // 
            this.GroupLNewOrder.Controls.Add(this.radioBebida);
            this.GroupLNewOrder.Controls.Add(this.radioCocina);
            this.GroupLNewOrder.Controls.Add(this.label4);
            this.GroupLNewOrder.Controls.Add(this.label1);
            this.GroupLNewOrder.Controls.Add(this.dropCategoria);
            this.GroupLNewOrder.Controls.Add(this.txt_PriceProducto);
            this.GroupLNewOrder.Controls.Add(this.txt_NameProducto);
            this.GroupLNewOrder.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupLNewOrder.Location = new System.Drawing.Point(19, 48);
            this.GroupLNewOrder.Name = "GroupLNewOrder";
            this.GroupLNewOrder.Size = new System.Drawing.Size(378, 374);
            this.GroupLNewOrder.TabIndex = 14;
            this.GroupLNewOrder.TabStop = false;
            this.GroupLNewOrder.Text = "Administracion de Productos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(8, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 19);
            this.label4.TabIndex = 9;
            this.label4.Text = "Categoría:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(8, 273);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "Enviar a:";
            // 
            // dropCategoria
            // 
            this.dropCategoria.BackColor = System.Drawing.Color.Transparent;
            this.dropCategoria.BorderRadius = 3;
            this.dropCategoria.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(233)))), ((int)(((byte)(198)))));
            this.dropCategoria.ForeColor = System.Drawing.Color.White;
            this.dropCategoria.Items = new string[] {
        "Entradas",
        "Ensaladas",
        "Bebidas"};
            this.dropCategoria.Location = new System.Drawing.Point(106, 46);
            this.dropCategoria.Margin = new System.Windows.Forms.Padding(4);
            this.dropCategoria.Name = "dropCategoria";
            this.dropCategoria.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(132)))), ((int)(((byte)(26)))));
            this.dropCategoria.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(1)))), ((int)(((byte)(37)))));
            this.dropCategoria.selectedIndex = -1;
            this.dropCategoria.Size = new System.Drawing.Size(261, 40);
            this.dropCategoria.TabIndex = 3;
            // 
            // txt_PriceProducto
            // 
            this.txt_PriceProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(233)))), ((int)(((byte)(198)))));
            this.txt_PriceProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txt_PriceProducto.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txt_PriceProducto.ForeColor = System.Drawing.Color.Black;
            this.txt_PriceProducto.HintForeColor = System.Drawing.Color.Empty;
            this.txt_PriceProducto.HintText = "";
            this.txt_PriceProducto.isPassword = false;
            this.txt_PriceProducto.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(1)))), ((int)(((byte)(42)))));
            this.txt_PriceProducto.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(132)))), ((int)(((byte)(26)))));
            this.txt_PriceProducto.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(1)))), ((int)(((byte)(37)))));
            this.txt_PriceProducto.LineThickness = 4;
            this.txt_PriceProducto.Location = new System.Drawing.Point(9, 192);
            this.txt_PriceProducto.Margin = new System.Windows.Forms.Padding(6);
            this.txt_PriceProducto.Name = "txt_PriceProducto";
            this.txt_PriceProducto.Size = new System.Drawing.Size(358, 53);
            this.txt_PriceProducto.TabIndex = 2;
            this.txt_PriceProducto.Text = "Precio";
            this.txt_PriceProducto.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txt_NameProducto
            // 
            this.txt_NameProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(233)))), ((int)(((byte)(198)))));
            this.txt_NameProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txt_NameProducto.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txt_NameProducto.ForeColor = System.Drawing.Color.Black;
            this.txt_NameProducto.HintForeColor = System.Drawing.Color.Empty;
            this.txt_NameProducto.HintText = "";
            this.txt_NameProducto.isPassword = false;
            this.txt_NameProducto.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(1)))), ((int)(((byte)(42)))));
            this.txt_NameProducto.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(132)))), ((int)(((byte)(26)))));
            this.txt_NameProducto.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(1)))), ((int)(((byte)(37)))));
            this.txt_NameProducto.LineThickness = 4;
            this.txt_NameProducto.Location = new System.Drawing.Point(11, 103);
            this.txt_NameProducto.Margin = new System.Windows.Forms.Padding(6);
            this.txt_NameProducto.Name = "txt_NameProducto";
            this.txt_NameProducto.Size = new System.Drawing.Size(358, 53);
            this.txt_NameProducto.TabIndex = 1;
            this.txt_NameProducto.Text = "Nombre del Producto";
            this.txt_NameProducto.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.BarraEstadoClose;
            this.bunifuDragControl1.Vertical = true;
            // 
            // btnOkAdmonProducto
            // 
            this.btnOkAdmonProducto.BackColor = System.Drawing.Color.Transparent;
            this.btnOkAdmonProducto.Image = global::_ResBar_01._01.Properties.Resources.ok;
            this.btnOkAdmonProducto.ImageActive = null;
            this.btnOkAdmonProducto.Location = new System.Drawing.Point(260, 441);
            this.btnOkAdmonProducto.Name = "btnOkAdmonProducto";
            this.btnOkAdmonProducto.Size = new System.Drawing.Size(61, 59);
            this.btnOkAdmonProducto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnOkAdmonProducto.TabIndex = 26;
            this.btnOkAdmonProducto.TabStop = false;
            this.btnOkAdmonProducto.Zoom = 10;
            // 
            // radioCocina
            // 
            this.radioCocina.AutoSize = true;
            this.radioCocina.Location = new System.Drawing.Point(156, 273);
            this.radioCocina.Name = "radioCocina";
            this.radioCocina.Size = new System.Drawing.Size(81, 22);
            this.radioCocina.TabIndex = 10;
            this.radioCocina.TabStop = true;
            this.radioCocina.Text = "Cocina";
            this.radioCocina.UseVisualStyleBackColor = true;
            // 
            // radioBebida
            // 
            this.radioBebida.AutoSize = true;
            this.radioBebida.Location = new System.Drawing.Point(156, 301);
            this.radioBebida.Name = "radioBebida";
            this.radioBebida.Size = new System.Drawing.Size(79, 22);
            this.radioBebida.TabIndex = 11;
            this.radioBebida.TabStop = true;
            this.radioBebida.Text = "Bebida";
            this.radioBebida.UseVisualStyleBackColor = true;
            // 
            // Form_AdmonProducto_View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(233)))), ((int)(((byte)(198)))));
            this.ClientSize = new System.Drawing.Size(415, 512);
            this.Controls.Add(this.btnOkAdmonProducto);
            this.Controls.Add(this.BarraEstadoClose);
            this.Controls.Add(this.btnAgregaProducto);
            this.Controls.Add(this.GroupLNewOrder);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form_AdmonProducto_View";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_AdmonProducto_View";
            this.BarraEstadoClose.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_Close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_CloseWindowsP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAgregaProducto)).EndInit();
            this.GroupLNewOrder.ResumeLayout(false);
            this.GroupLNewOrder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnOkAdmonProducto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel BarraEstadoClose;
        private Bunifu.Framework.UI.BunifuImageButton btn_Close;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private Bunifu.Framework.UI.BunifuImageButton btn_CloseWindowsP;
        private Bunifu.Framework.UI.BunifuImageButton btnAgregaProducto;
        private System.Windows.Forms.GroupBox GroupLNewOrder;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuDropdown dropCategoria;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_PriceProducto;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_NameProducto;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuImageButton btnOkAdmonProducto;
        private System.Windows.Forms.RadioButton radioBebida;
        private System.Windows.Forms.RadioButton radioCocina;
    }
}