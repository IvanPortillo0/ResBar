namespace _ResBar_01._01.Forms_Views
{
    partial class Form_NuevaOrden_View
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_NuevaOrden_View));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.BarraEstadoClose = new System.Windows.Forms.Panel();
            this.btn_close = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_CloseWindowsP = new Bunifu.Framework.UI.BunifuImageButton();
            this.GroupLNewOrder = new System.Windows.Forms.GroupBox();
            this.bunifuMaterialTextbox2 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuMaterialTextbox1 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtMesa = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btnAgregarOrden = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.BarraEstadoClose.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_CloseWindowsP)).BeginInit();
            this.GroupLNewOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnAgregarOrden)).BeginInit();
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
            this.BarraEstadoClose.Controls.Add(this.btn_close);
            this.BarraEstadoClose.Controls.Add(this.bunifuImageButton1);
            this.BarraEstadoClose.Controls.Add(this.btn_CloseWindowsP);
            this.BarraEstadoClose.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarraEstadoClose.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BarraEstadoClose.Location = new System.Drawing.Point(0, 0);
            this.BarraEstadoClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BarraEstadoClose.Name = "BarraEstadoClose";
            this.BarraEstadoClose.Size = new System.Drawing.Size(415, 40);
            this.BarraEstadoClose.TabIndex = 10;
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.Color.Transparent;
            this.btn_close.Image = global::_ResBar_01._01.Properties.Resources.boton_de_borrar;
            this.btn_close.ImageActive = null;
            this.btn_close.Location = new System.Drawing.Point(352, 5);
            this.btn_close.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(59, 30);
            this.btn_close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_close.TabIndex = 3;
            this.btn_close.TabStop = false;
            this.btn_close.Zoom = 10;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
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
            // GroupLNewOrder
            // 
            this.GroupLNewOrder.Controls.Add(this.bunifuMaterialTextbox2);
            this.GroupLNewOrder.Controls.Add(this.bunifuMaterialTextbox1);
            this.GroupLNewOrder.Controls.Add(this.txtMesa);
            this.GroupLNewOrder.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupLNewOrder.Location = new System.Drawing.Point(19, 92);
            this.GroupLNewOrder.Name = "GroupLNewOrder";
            this.GroupLNewOrder.Size = new System.Drawing.Size(378, 295);
            this.GroupLNewOrder.TabIndex = 11;
            this.GroupLNewOrder.TabStop = false;
            this.GroupLNewOrder.Text = "NuevaOrden";
            // 
            // bunifuMaterialTextbox2
            // 
            this.bunifuMaterialTextbox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(233)))), ((int)(((byte)(198)))));
            this.bunifuMaterialTextbox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuMaterialTextbox2.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.bunifuMaterialTextbox2.ForeColor = System.Drawing.Color.Black;
            this.bunifuMaterialTextbox2.HintForeColor = System.Drawing.Color.Empty;
            this.bunifuMaterialTextbox2.HintText = "";
            this.bunifuMaterialTextbox2.isPassword = false;
            this.bunifuMaterialTextbox2.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(1)))), ((int)(((byte)(42)))));
            this.bunifuMaterialTextbox2.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(132)))), ((int)(((byte)(26)))));
            this.bunifuMaterialTextbox2.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(1)))), ((int)(((byte)(37)))));
            this.bunifuMaterialTextbox2.LineThickness = 4;
            this.bunifuMaterialTextbox2.Location = new System.Drawing.Point(9, 192);
            this.bunifuMaterialTextbox2.Margin = new System.Windows.Forms.Padding(6);
            this.bunifuMaterialTextbox2.Name = "bunifuMaterialTextbox2";
            this.bunifuMaterialTextbox2.Size = new System.Drawing.Size(358, 53);
            this.bunifuMaterialTextbox2.TabIndex = 2;
            this.bunifuMaterialTextbox2.Text = "Cliente...";
            this.bunifuMaterialTextbox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuMaterialTextbox1
            // 
            this.bunifuMaterialTextbox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(233)))), ((int)(((byte)(198)))));
            this.bunifuMaterialTextbox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuMaterialTextbox1.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.bunifuMaterialTextbox1.ForeColor = System.Drawing.Color.Black;
            this.bunifuMaterialTextbox1.HintForeColor = System.Drawing.Color.Empty;
            this.bunifuMaterialTextbox1.HintText = "";
            this.bunifuMaterialTextbox1.isPassword = false;
            this.bunifuMaterialTextbox1.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(1)))), ((int)(((byte)(42)))));
            this.bunifuMaterialTextbox1.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(132)))), ((int)(((byte)(26)))));
            this.bunifuMaterialTextbox1.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(1)))), ((int)(((byte)(37)))));
            this.bunifuMaterialTextbox1.LineThickness = 4;
            this.bunifuMaterialTextbox1.Location = new System.Drawing.Point(11, 103);
            this.bunifuMaterialTextbox1.Margin = new System.Windows.Forms.Padding(6);
            this.bunifuMaterialTextbox1.Name = "bunifuMaterialTextbox1";
            this.bunifuMaterialTextbox1.Size = new System.Drawing.Size(358, 53);
            this.bunifuMaterialTextbox1.TabIndex = 1;
            this.bunifuMaterialTextbox1.Text = "Mesero...";
            this.bunifuMaterialTextbox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtMesa
            // 
            this.txtMesa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(233)))), ((int)(((byte)(198)))));
            this.txtMesa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtMesa.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtMesa.ForeColor = System.Drawing.Color.Black;
            this.txtMesa.HintForeColor = System.Drawing.Color.White;
            this.txtMesa.HintText = "";
            this.txtMesa.isPassword = false;
            this.txtMesa.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(1)))), ((int)(((byte)(42)))));
            this.txtMesa.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(132)))), ((int)(((byte)(26)))));
            this.txtMesa.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(1)))), ((int)(((byte)(37)))));
            this.txtMesa.LineThickness = 4;
            this.txtMesa.Location = new System.Drawing.Point(9, 25);
            this.txtMesa.Margin = new System.Windows.Forms.Padding(6);
            this.txtMesa.Name = "txtMesa";
            this.txtMesa.Size = new System.Drawing.Size(358, 53);
            this.txtMesa.TabIndex = 0;
            this.txtMesa.Text = "Ingresa la mesa...";
            this.txtMesa.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btnAgregarOrden
            // 
            this.btnAgregarOrden.BackColor = System.Drawing.Color.Transparent;
            this.btnAgregarOrden.Image = global::_ResBar_01._01.Properties.Resources.btn_Agregar_naranja;
            this.btnAgregarOrden.ImageActive = null;
            this.btnAgregarOrden.Location = new System.Drawing.Point(325, 435);
            this.btnAgregarOrden.Name = "btnAgregarOrden";
            this.btnAgregarOrden.Size = new System.Drawing.Size(61, 59);
            this.btnAgregarOrden.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnAgregarOrden.TabIndex = 12;
            this.btnAgregarOrden.TabStop = false;
            this.btnAgregarOrden.Zoom = 10;
            this.btnAgregarOrden.Click += new System.EventHandler(this.btnAgregarOrden_Click);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.BarraEstadoClose;
            this.bunifuDragControl1.Vertical = true;
            // 
            // Form_NuevaOrden_View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(233)))), ((int)(((byte)(198)))));
            this.ClientSize = new System.Drawing.Size(415, 512);
            this.Controls.Add(this.BarraEstadoClose);
            this.Controls.Add(this.btnAgregarOrden);
            this.Controls.Add(this.GroupLNewOrder);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form_NuevaOrden_View";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_NuevaOrden_View";
            this.BarraEstadoClose.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_CloseWindowsP)).EndInit();
            this.GroupLNewOrder.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnAgregarOrden)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel BarraEstadoClose;
        private Bunifu.Framework.UI.BunifuImageButton btn_close;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private Bunifu.Framework.UI.BunifuImageButton btn_CloseWindowsP;
        private Bunifu.Framework.UI.BunifuImageButton btnAgregarOrden;
        private System.Windows.Forms.GroupBox GroupLNewOrder;
        private Bunifu.Framework.UI.BunifuMaterialTextbox bunifuMaterialTextbox2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox bunifuMaterialTextbox1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtMesa;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
    }
}