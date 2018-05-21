namespace _ResBar_01._01.Forms_Views
{
    partial class Form_Principal_View
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Principal_View));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtBusquedad = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.labelOrdenesActivas = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnModificarCuenta = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnAgregarProductos = new Bunifu.Framework.UI.BunifuFlatButton();
            this.BtnNewOrder = new Bunifu.Framework.UI.BunifuFlatButton();
            this.dg_Ordenes = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.LogoPrincipal = new System.Windows.Forms.PictureBox();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_Ordenes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPrincipal)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "ORDENES ACTIVAS";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtBusquedad);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(18, 73);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(682, 100);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Busqueda";
            // 
            // txtBusquedad
            // 
            this.txtBusquedad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtBusquedad.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtBusquedad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtBusquedad.HintForeColor = System.Drawing.Color.Empty;
            this.txtBusquedad.HintText = "";
            this.txtBusquedad.isPassword = false;
            this.txtBusquedad.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(1)))), ((int)(((byte)(42)))));
            this.txtBusquedad.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(132)))), ((int)(((byte)(26)))));
            this.txtBusquedad.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(1)))), ((int)(((byte)(37)))));
            this.txtBusquedad.LineThickness = 4;
            this.txtBusquedad.Location = new System.Drawing.Point(9, 25);
            this.txtBusquedad.Margin = new System.Windows.Forms.Padding(6);
            this.txtBusquedad.Name = "txtBusquedad";
            this.txtBusquedad.Size = new System.Drawing.Size(562, 53);
            this.txtBusquedad.TabIndex = 0;
            this.txtBusquedad.Text = "Ingresa tu busquedad...";
            this.txtBusquedad.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // labelOrdenesActivas
            // 
            this.labelOrdenesActivas.AutoSize = true;
            this.labelOrdenesActivas.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOrdenesActivas.Location = new System.Drawing.Point(14, 221);
            this.labelOrdenesActivas.Name = "labelOrdenesActivas";
            this.labelOrdenesActivas.Size = new System.Drawing.Size(134, 19);
            this.labelOrdenesActivas.TabIndex = 14;
            this.labelOrdenesActivas.Text = "Ordenes Activas";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bunifuFlatButton1);
            this.groupBox1.Controls.Add(this.btnModificarCuenta);
            this.groupBox1.Controls.Add(this.btnAgregarProductos);
            this.groupBox1.Controls.Add(this.BtnNewOrder);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(786, 254);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(223, 327);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Controles";
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(132)))), ((int)(((byte)(26)))));
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(132)))), ((int)(((byte)(26)))));
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 5;
            this.bunifuFlatButton1.ButtonText = "     Imprimir";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton1.Iconimage")));
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 55D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(6, 240);
            this.bunifuFlatButton1.Margin = new System.Windows.Forms.Padding(14, 11, 14, 11);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(132)))), ((int)(((byte)(26)))));
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(196, 57);
            this.bunifuFlatButton1.TabIndex = 12;
            this.bunifuFlatButton1.Text = "     Imprimir";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Century Gothic", 12F);
            this.bunifuFlatButton1.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // btnModificarCuenta
            // 
            this.btnModificarCuenta.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(132)))), ((int)(((byte)(26)))));
            this.btnModificarCuenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(132)))), ((int)(((byte)(26)))));
            this.btnModificarCuenta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnModificarCuenta.BorderRadius = 5;
            this.btnModificarCuenta.ButtonText = "     Modf. Cuenta";
            this.btnModificarCuenta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModificarCuenta.DisabledColor = System.Drawing.Color.Gray;
            this.btnModificarCuenta.Iconcolor = System.Drawing.Color.Transparent;
            this.btnModificarCuenta.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnModificarCuenta.Iconimage")));
            this.btnModificarCuenta.Iconimage_right = null;
            this.btnModificarCuenta.Iconimage_right_Selected = null;
            this.btnModificarCuenta.Iconimage_Selected = null;
            this.btnModificarCuenta.IconMarginLeft = 0;
            this.btnModificarCuenta.IconMarginRight = 0;
            this.btnModificarCuenta.IconRightVisible = true;
            this.btnModificarCuenta.IconRightZoom = 0D;
            this.btnModificarCuenta.IconVisible = true;
            this.btnModificarCuenta.IconZoom = 55D;
            this.btnModificarCuenta.IsTab = false;
            this.btnModificarCuenta.Location = new System.Drawing.Point(6, 173);
            this.btnModificarCuenta.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.btnModificarCuenta.Name = "btnModificarCuenta";
            this.btnModificarCuenta.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(132)))), ((int)(((byte)(26)))));
            this.btnModificarCuenta.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnModificarCuenta.OnHoverTextColor = System.Drawing.Color.White;
            this.btnModificarCuenta.selected = false;
            this.btnModificarCuenta.Size = new System.Drawing.Size(196, 57);
            this.btnModificarCuenta.TabIndex = 11;
            this.btnModificarCuenta.Text = "     Modf. Cuenta";
            this.btnModificarCuenta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificarCuenta.Textcolor = System.Drawing.Color.White;
            this.btnModificarCuenta.TextFont = new System.Drawing.Font("Century Gothic", 12F);
            this.btnModificarCuenta.Click += new System.EventHandler(this.btnModificarCuenta_Click);
            // 
            // btnAgregarProductos
            // 
            this.btnAgregarProductos.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(132)))), ((int)(((byte)(26)))));
            this.btnAgregarProductos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(132)))), ((int)(((byte)(26)))));
            this.btnAgregarProductos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAgregarProductos.BorderRadius = 5;
            this.btnAgregarProductos.ButtonText = "     Agregar Prd.";
            this.btnAgregarProductos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarProductos.DisabledColor = System.Drawing.Color.Gray;
            this.btnAgregarProductos.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAgregarProductos.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnAgregarProductos.Iconimage")));
            this.btnAgregarProductos.Iconimage_right = null;
            this.btnAgregarProductos.Iconimage_right_Selected = null;
            this.btnAgregarProductos.Iconimage_Selected = null;
            this.btnAgregarProductos.IconMarginLeft = 0;
            this.btnAgregarProductos.IconMarginRight = 0;
            this.btnAgregarProductos.IconRightVisible = true;
            this.btnAgregarProductos.IconRightZoom = 0D;
            this.btnAgregarProductos.IconVisible = true;
            this.btnAgregarProductos.IconZoom = 55D;
            this.btnAgregarProductos.IsTab = false;
            this.btnAgregarProductos.Location = new System.Drawing.Point(5, 107);
            this.btnAgregarProductos.Margin = new System.Windows.Forms.Padding(6);
            this.btnAgregarProductos.Name = "btnAgregarProductos";
            this.btnAgregarProductos.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(132)))), ((int)(((byte)(26)))));
            this.btnAgregarProductos.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnAgregarProductos.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAgregarProductos.selected = false;
            this.btnAgregarProductos.Size = new System.Drawing.Size(196, 52);
            this.btnAgregarProductos.TabIndex = 10;
            this.btnAgregarProductos.Text = "     Agregar Prd.";
            this.btnAgregarProductos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarProductos.Textcolor = System.Drawing.Color.White;
            this.btnAgregarProductos.TextFont = new System.Drawing.Font("Century Gothic", 12F);
            this.btnAgregarProductos.Click += new System.EventHandler(this.btnAgregarProductos_Click);
            // 
            // BtnNewOrder
            // 
            this.BtnNewOrder.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(132)))), ((int)(((byte)(26)))));
            this.BtnNewOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(132)))), ((int)(((byte)(26)))));
            this.BtnNewOrder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnNewOrder.BorderRadius = 5;
            this.BtnNewOrder.ButtonText = "     Nueva Orden";
            this.BtnNewOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnNewOrder.DisabledColor = System.Drawing.Color.Gray;
            this.BtnNewOrder.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnNewOrder.Iconimage = ((System.Drawing.Image)(resources.GetObject("BtnNewOrder.Iconimage")));
            this.BtnNewOrder.Iconimage_right = null;
            this.BtnNewOrder.Iconimage_right_Selected = null;
            this.BtnNewOrder.Iconimage_Selected = null;
            this.BtnNewOrder.IconMarginLeft = 0;
            this.BtnNewOrder.IconMarginRight = 0;
            this.BtnNewOrder.IconRightVisible = true;
            this.BtnNewOrder.IconRightZoom = 0D;
            this.BtnNewOrder.IconVisible = true;
            this.BtnNewOrder.IconZoom = 55D;
            this.BtnNewOrder.IsTab = false;
            this.BtnNewOrder.Location = new System.Drawing.Point(6, 42);
            this.BtnNewOrder.Margin = new System.Windows.Forms.Padding(4);
            this.BtnNewOrder.Name = "BtnNewOrder";
            this.BtnNewOrder.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(132)))), ((int)(((byte)(26)))));
            this.BtnNewOrder.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.BtnNewOrder.OnHoverTextColor = System.Drawing.Color.White;
            this.BtnNewOrder.selected = false;
            this.BtnNewOrder.Size = new System.Drawing.Size(196, 55);
            this.BtnNewOrder.TabIndex = 9;
            this.BtnNewOrder.Text = "     Nueva Orden";
            this.BtnNewOrder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnNewOrder.Textcolor = System.Drawing.Color.White;
            this.BtnNewOrder.TextFont = new System.Drawing.Font("Century Gothic", 12F);
            this.BtnNewOrder.Click += new System.EventHandler(this.BtnNewOrder_Click);
            // 
            // dg_Ordenes
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(132)))), ((int)(((byte)(26)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dg_Ordenes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dg_Ordenes.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dg_Ordenes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dg_Ordenes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(132)))), ((int)(((byte)(26)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dg_Ordenes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dg_Ordenes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_Ordenes.DoubleBuffered = true;
            this.dg_Ordenes.EnableHeadersVisualStyles = false;
            this.dg_Ordenes.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(132)))), ((int)(((byte)(26)))));
            this.dg_Ordenes.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(132)))), ((int)(((byte)(26)))));
            this.dg_Ordenes.HeaderForeColor = System.Drawing.Color.White;
            this.dg_Ordenes.Location = new System.Drawing.Point(18, 254);
            this.dg_Ordenes.Name = "dg_Ordenes";
            this.dg_Ordenes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(132)))), ((int)(((byte)(26)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dg_Ordenes.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dg_Ordenes.Size = new System.Drawing.Size(753, 327);
            this.dg_Ordenes.TabIndex = 11;
            // 
            // LogoPrincipal
            // 
            this.LogoPrincipal.Image = global::_ResBar_01._01.Properties.Resources.logo_large;
            this.LogoPrincipal.Location = new System.Drawing.Point(786, 9);
            this.LogoPrincipal.Name = "LogoPrincipal";
            this.LogoPrincipal.Size = new System.Drawing.Size(221, 142);
            this.LogoPrincipal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LogoPrincipal.TabIndex = 13;
            this.LogoPrincipal.TabStop = false;
            // 
            // Form_Principal_View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1024, 678);
            this.Controls.Add(this.labelOrdenesActivas);
            this.Controls.Add(this.LogoPrincipal);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dg_Ordenes);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form_Principal_View";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Principal";
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dg_Ordenes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPrincipal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelOrdenesActivas;
        private System.Windows.Forms.PictureBox LogoPrincipal;
        private System.Windows.Forms.GroupBox groupBox1;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private Bunifu.Framework.UI.BunifuFlatButton btnModificarCuenta;
        private Bunifu.Framework.UI.BunifuFlatButton btnAgregarProductos;
        private Bunifu.Framework.UI.BunifuFlatButton BtnNewOrder;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dg_Ordenes;
        private System.Windows.Forms.GroupBox groupBox2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtBusquedad;
    }
}