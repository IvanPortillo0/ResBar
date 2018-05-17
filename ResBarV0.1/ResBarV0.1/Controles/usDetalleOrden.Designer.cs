namespace ResBarV0._1.Controles
{
    partial class usDetalleOrden
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(usDetalleOrden));
            this.lblMesero = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblMesa = new System.Windows.Forms.Label();
            this.dgDetalleOrden = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.bunifuSeparator3 = new Bunifu.Framework.UI.BunifuSeparator();
            this.bunifuSeparator2 = new Bunifu.Framework.UI.BunifuSeparator();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblMostrarFechaHora = new System.Windows.Forms.Label();
            this.lblComentario = new System.Windows.Forms.Label();
            this.pnContenedorBotones = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAgregarProducto = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnModificarCuenta = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnEliminarCuenta = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txtComentario = new Bunifu.Framework.UI.BunifuTextbox();
            this.pbLogoMini = new System.Windows.Forms.PictureBox();
            this.btnQuitarProducto = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnRestarCantidad = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnSumarCantidad = new Bunifu.Framework.UI.BunifuImageButton();
            this.txtCliente = new Bunifu.Framework.UI.BunifuTextbox();
            this.txtMesero = new Bunifu.Framework.UI.BunifuTextbox();
            this.txtMesa = new Bunifu.Framework.UI.BunifuTextbox();
            ((System.ComponentModel.ISupportInitialize)(this.dgDetalleOrden)).BeginInit();
            this.pnContenedorBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogoMini)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnQuitarProducto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestarCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSumarCantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMesero
            // 
            this.lblMesero.AutoSize = true;
            this.lblMesero.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.lblMesero.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(1)))), ((int)(((byte)(37)))));
            this.lblMesero.Location = new System.Drawing.Point(132, 102);
            this.lblMesero.Name = "lblMesero";
            this.lblMesero.Size = new System.Drawing.Size(86, 22);
            this.lblMesero.TabIndex = 60;
            this.lblMesero.Text = "Mesero :";
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.lblCliente.Location = new System.Drawing.Point(133, 167);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(84, 22);
            this.lblCliente.TabIndex = 59;
            this.lblCliente.Text = "Cliente :";
            // 
            // lblMesa
            // 
            this.lblMesa.AutoSize = true;
            this.lblMesa.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.lblMesa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(1)))), ((int)(((byte)(37)))));
            this.lblMesa.Location = new System.Drawing.Point(147, 40);
            this.lblMesa.Name = "lblMesa";
            this.lblMesa.Size = new System.Drawing.Size(69, 22);
            this.lblMesa.TabIndex = 57;
            this.lblMesa.Text = "Mesa :";
            // 
            // dgDetalleOrden
            // 
            this.dgDetalleOrden.AllowUserToAddRows = false;
            this.dgDetalleOrden.AllowUserToDeleteRows = false;
            this.dgDetalleOrden.AllowUserToResizeColumns = false;
            this.dgDetalleOrden.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(233)))), ((int)(((byte)(198)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(1)))), ((int)(((byte)(37)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(1)))), ((int)(((byte)(42)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(233)))), ((int)(((byte)(198)))));
            this.dgDetalleOrden.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgDetalleOrden.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(233)))), ((int)(((byte)(198)))));
            this.dgDetalleOrden.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgDetalleOrden.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(132)))), ((int)(((byte)(26)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(233)))), ((int)(((byte)(198)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgDetalleOrden.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgDetalleOrden.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(233)))), ((int)(((byte)(198)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(1)))), ((int)(((byte)(37)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(1)))), ((int)(((byte)(42)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(233)))), ((int)(((byte)(198)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgDetalleOrden.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgDetalleOrden.DoubleBuffered = true;
            this.dgDetalleOrden.EnableHeadersVisualStyles = false;
            this.dgDetalleOrden.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(132)))), ((int)(((byte)(26)))));
            this.dgDetalleOrden.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(132)))), ((int)(((byte)(26)))));
            this.dgDetalleOrden.HeaderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(233)))), ((int)(((byte)(198)))));
            this.dgDetalleOrden.Location = new System.Drawing.Point(102, 252);
            this.dgDetalleOrden.MultiSelect = false;
            this.dgDetalleOrden.Name = "dgDetalleOrden";
            this.dgDetalleOrden.ReadOnly = true;
            this.dgDetalleOrden.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(233)))), ((int)(((byte)(198)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(1)))), ((int)(((byte)(37)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(1)))), ((int)(((byte)(42)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(233)))), ((int)(((byte)(198)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgDetalleOrden.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgDetalleOrden.RowHeadersVisible = false;
            this.dgDetalleOrden.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgDetalleOrden.Size = new System.Drawing.Size(494, 180);
            this.dgDetalleOrden.TabIndex = 66;
            // 
            // bunifuSeparator3
            // 
            this.bunifuSeparator3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator3.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(1)))), ((int)(((byte)(37)))));
            this.bunifuSeparator3.LineThickness = 1;
            this.bunifuSeparator3.Location = new System.Drawing.Point(78, 252);
            this.bunifuSeparator3.Name = "bunifuSeparator3";
            this.bunifuSeparator3.Size = new System.Drawing.Size(21, 182);
            this.bunifuSeparator3.TabIndex = 65;
            this.bunifuSeparator3.Transparency = 255;
            this.bunifuSeparator3.Vertical = true;
            // 
            // bunifuSeparator2
            // 
            this.bunifuSeparator2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(1)))), ((int)(((byte)(37)))));
            this.bunifuSeparator2.LineThickness = 1;
            this.bunifuSeparator2.Location = new System.Drawing.Point(674, 252);
            this.bunifuSeparator2.Name = "bunifuSeparator2";
            this.bunifuSeparator2.Size = new System.Drawing.Size(21, 182);
            this.bunifuSeparator2.TabIndex = 64;
            this.bunifuSeparator2.Transparency = 255;
            this.bunifuSeparator2.Vertical = true;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.lblFecha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(1)))), ((int)(((byte)(37)))));
            this.lblFecha.Location = new System.Drawing.Point(139, 217);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(78, 22);
            this.lblFecha.TabIndex = 72;
            this.lblFecha.Text = "Fecha :";
            // 
            // lblMostrarFechaHora
            // 
            this.lblMostrarFechaHora.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMostrarFechaHora.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(1)))), ((int)(((byte)(37)))));
            this.lblMostrarFechaHora.Location = new System.Drawing.Point(224, 217);
            this.lblMostrarFechaHora.Name = "lblMostrarFechaHora";
            this.lblMostrarFechaHora.Size = new System.Drawing.Size(338, 22);
            this.lblMostrarFechaHora.TabIndex = 73;
            this.lblMostrarFechaHora.Text = "05/03/2018   4:00 pm";
            // 
            // lblComentario
            // 
            this.lblComentario.AutoSize = true;
            this.lblComentario.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.lblComentario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(1)))), ((int)(((byte)(37)))));
            this.lblComentario.Location = new System.Drawing.Point(99, 452);
            this.lblComentario.Name = "lblComentario";
            this.lblComentario.Size = new System.Drawing.Size(129, 22);
            this.lblComentario.TabIndex = 74;
            this.lblComentario.Text = "Comentario :";
            // 
            // pnContenedorBotones
            // 
            this.pnContenedorBotones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(1)))), ((int)(((byte)(37)))));
            this.pnContenedorBotones.Controls.Add(this.btnAgregarProducto);
            this.pnContenedorBotones.Controls.Add(this.btnModificarCuenta);
            this.pnContenedorBotones.Controls.Add(this.btnEliminarCuenta);
            this.pnContenedorBotones.Location = new System.Drawing.Point(699, 260);
            this.pnContenedorBotones.Name = "pnContenedorBotones";
            this.pnContenedorBotones.Size = new System.Drawing.Size(191, 162);
            this.pnContenedorBotones.TabIndex = 77;
            // 
            // btnAgregarProducto
            // 
            this.btnAgregarProducto.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(1)))), ((int)(((byte)(37)))));
            this.btnAgregarProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(132)))), ((int)(((byte)(26)))));
            this.btnAgregarProducto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAgregarProducto.BorderRadius = 5;
            this.btnAgregarProducto.ButtonText = "Agregar Productos";
            this.btnAgregarProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarProducto.DisabledColor = System.Drawing.Color.Gray;
            this.btnAgregarProducto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(233)))), ((int)(((byte)(198)))));
            this.btnAgregarProducto.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAgregarProducto.Iconimage = global::ResBarV0._1.Properties.Resources.bandeja_de_comida_cubierta_en_una_mano_del_servicio_de_habitaciones_del_hotel;
            this.btnAgregarProducto.Iconimage_right = null;
            this.btnAgregarProducto.Iconimage_right_Selected = null;
            this.btnAgregarProducto.Iconimage_Selected = null;
            this.btnAgregarProducto.IconMarginLeft = 0;
            this.btnAgregarProducto.IconMarginRight = 0;
            this.btnAgregarProducto.IconRightVisible = true;
            this.btnAgregarProducto.IconRightZoom = 0D;
            this.btnAgregarProducto.IconVisible = true;
            this.btnAgregarProducto.IconZoom = 70D;
            this.btnAgregarProducto.IsTab = false;
            this.btnAgregarProducto.Location = new System.Drawing.Point(3, 3);
            this.btnAgregarProducto.Name = "btnAgregarProducto";
            this.btnAgregarProducto.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(132)))), ((int)(((byte)(26)))));
            this.btnAgregarProducto.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(1)))), ((int)(((byte)(37)))));
            this.btnAgregarProducto.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(233)))), ((int)(((byte)(198)))));
            this.btnAgregarProducto.selected = false;
            this.btnAgregarProducto.Size = new System.Drawing.Size(186, 48);
            this.btnAgregarProducto.TabIndex = 9;
            this.btnAgregarProducto.Text = "Agregar Productos";
            this.btnAgregarProducto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAgregarProducto.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(233)))), ((int)(((byte)(198)))));
            this.btnAgregarProducto.TextFont = new System.Drawing.Font("Century Gothic", 12F);
            // 
            // btnModificarCuenta
            // 
            this.btnModificarCuenta.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(1)))), ((int)(((byte)(37)))));
            this.btnModificarCuenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(132)))), ((int)(((byte)(26)))));
            this.btnModificarCuenta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnModificarCuenta.BorderRadius = 5;
            this.btnModificarCuenta.ButtonText = "Modificar Cuenta";
            this.btnModificarCuenta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModificarCuenta.DisabledColor = System.Drawing.Color.Gray;
            this.btnModificarCuenta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(233)))), ((int)(((byte)(198)))));
            this.btnModificarCuenta.Iconcolor = System.Drawing.Color.Transparent;
            this.btnModificarCuenta.Iconimage = global::ResBarV0._1.Properties.Resources.editar;
            this.btnModificarCuenta.Iconimage_right = null;
            this.btnModificarCuenta.Iconimage_right_Selected = null;
            this.btnModificarCuenta.Iconimage_Selected = null;
            this.btnModificarCuenta.IconMarginLeft = 0;
            this.btnModificarCuenta.IconMarginRight = 0;
            this.btnModificarCuenta.IconRightVisible = true;
            this.btnModificarCuenta.IconRightZoom = 0D;
            this.btnModificarCuenta.IconVisible = true;
            this.btnModificarCuenta.IconZoom = 70D;
            this.btnModificarCuenta.IsTab = false;
            this.btnModificarCuenta.Location = new System.Drawing.Point(3, 57);
            this.btnModificarCuenta.Name = "btnModificarCuenta";
            this.btnModificarCuenta.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(132)))), ((int)(((byte)(26)))));
            this.btnModificarCuenta.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(1)))), ((int)(((byte)(37)))));
            this.btnModificarCuenta.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(233)))), ((int)(((byte)(198)))));
            this.btnModificarCuenta.selected = false;
            this.btnModificarCuenta.Size = new System.Drawing.Size(186, 48);
            this.btnModificarCuenta.TabIndex = 10;
            this.btnModificarCuenta.Text = "Modificar Cuenta";
            this.btnModificarCuenta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnModificarCuenta.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(233)))), ((int)(((byte)(198)))));
            this.btnModificarCuenta.TextFont = new System.Drawing.Font("Century Gothic", 12F);
            // 
            // btnEliminarCuenta
            // 
            this.btnEliminarCuenta.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(1)))), ((int)(((byte)(37)))));
            this.btnEliminarCuenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(132)))), ((int)(((byte)(26)))));
            this.btnEliminarCuenta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEliminarCuenta.BorderRadius = 5;
            this.btnEliminarCuenta.ButtonText = "   Eliminar    Cuenta";
            this.btnEliminarCuenta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminarCuenta.DisabledColor = System.Drawing.Color.Gray;
            this.btnEliminarCuenta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(1)))), ((int)(((byte)(42)))));
            this.btnEliminarCuenta.Iconcolor = System.Drawing.Color.Transparent;
            this.btnEliminarCuenta.Iconimage = global::ResBarV0._1.Properties.Resources.archivo_borrar;
            this.btnEliminarCuenta.Iconimage_right = null;
            this.btnEliminarCuenta.Iconimage_right_Selected = null;
            this.btnEliminarCuenta.Iconimage_Selected = null;
            this.btnEliminarCuenta.IconMarginLeft = 0;
            this.btnEliminarCuenta.IconMarginRight = 0;
            this.btnEliminarCuenta.IconRightVisible = true;
            this.btnEliminarCuenta.IconRightZoom = 0D;
            this.btnEliminarCuenta.IconVisible = true;
            this.btnEliminarCuenta.IconZoom = 70D;
            this.btnEliminarCuenta.IsTab = false;
            this.btnEliminarCuenta.Location = new System.Drawing.Point(3, 111);
            this.btnEliminarCuenta.Name = "btnEliminarCuenta";
            this.btnEliminarCuenta.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(132)))), ((int)(((byte)(26)))));
            this.btnEliminarCuenta.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(1)))), ((int)(((byte)(37)))));
            this.btnEliminarCuenta.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(233)))), ((int)(((byte)(198)))));
            this.btnEliminarCuenta.selected = false;
            this.btnEliminarCuenta.Size = new System.Drawing.Size(186, 48);
            this.btnEliminarCuenta.TabIndex = 11;
            this.btnEliminarCuenta.Text = "   Eliminar    Cuenta";
            this.btnEliminarCuenta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnEliminarCuenta.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(233)))), ((int)(((byte)(198)))));
            this.btnEliminarCuenta.TextFont = new System.Drawing.Font("Century Gothic", 12F);
            // 
            // txtComentario
            // 
            this.txtComentario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(233)))), ((int)(((byte)(198)))));
            this.txtComentario.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtComentario.BackgroundImage")));
            this.txtComentario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtComentario.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtComentario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(132)))), ((int)(((byte)(26)))));
            this.txtComentario.Icon = ((System.Drawing.Image)(resources.GetObject("txtComentario.Icon")));
            this.txtComentario.Location = new System.Drawing.Point(234, 440);
            this.txtComentario.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtComentario.Name = "txtComentario";
            this.txtComentario.Size = new System.Drawing.Size(331, 48);
            this.txtComentario.TabIndex = 75;
            this.txtComentario.text = "Comentario";
            // 
            // pbLogoMini
            // 
            this.pbLogoMini.Image = global::ResBarV0._1.Properties.Resources.logo_lite;
            this.pbLogoMini.Location = new System.Drawing.Point(9, 8);
            this.pbLogoMini.Name = "pbLogoMini";
            this.pbLogoMini.Size = new System.Drawing.Size(93, 142);
            this.pbLogoMini.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogoMini.TabIndex = 70;
            this.pbLogoMini.TabStop = false;
            // 
            // btnQuitarProducto
            // 
            this.btnQuitarProducto.BackColor = System.Drawing.Color.Transparent;
            this.btnQuitarProducto.Image = global::ResBarV0._1.Properties.Resources.basurero;
            this.btnQuitarProducto.ImageActive = null;
            this.btnQuitarProducto.Location = new System.Drawing.Point(608, 385);
            this.btnQuitarProducto.Name = "btnQuitarProducto";
            this.btnQuitarProducto.Size = new System.Drawing.Size(64, 44);
            this.btnQuitarProducto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnQuitarProducto.TabIndex = 69;
            this.btnQuitarProducto.TabStop = false;
            this.btnQuitarProducto.Zoom = 10;
            // 
            // btnRestarCantidad
            // 
            this.btnRestarCantidad.BackColor = System.Drawing.Color.Transparent;
            this.btnRestarCantidad.Image = global::ResBarV0._1.Properties.Resources.menos__1_;
            this.btnRestarCantidad.ImageActive = null;
            this.btnRestarCantidad.Location = new System.Drawing.Point(608, 322);
            this.btnRestarCantidad.Name = "btnRestarCantidad";
            this.btnRestarCantidad.Size = new System.Drawing.Size(64, 44);
            this.btnRestarCantidad.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnRestarCantidad.TabIndex = 68;
            this.btnRestarCantidad.TabStop = false;
            this.btnRestarCantidad.Zoom = 10;
            // 
            // btnSumarCantidad
            // 
            this.btnSumarCantidad.BackColor = System.Drawing.Color.Transparent;
            this.btnSumarCantidad.Image = global::ResBarV0._1.Properties.Resources.boton_de_suma__1_;
            this.btnSumarCantidad.ImageActive = null;
            this.btnSumarCantidad.Location = new System.Drawing.Point(608, 260);
            this.btnSumarCantidad.Name = "btnSumarCantidad";
            this.btnSumarCantidad.Size = new System.Drawing.Size(64, 44);
            this.btnSumarCantidad.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnSumarCantidad.TabIndex = 67;
            this.btnSumarCantidad.TabStop = false;
            this.btnSumarCantidad.Zoom = 10;
            // 
            // txtCliente
            // 
            this.txtCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(233)))), ((int)(((byte)(198)))));
            this.txtCliente.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtCliente.BackgroundImage")));
            this.txtCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtCliente.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(132)))), ((int)(((byte)(26)))));
            this.txtCliente.Icon = ((System.Drawing.Image)(resources.GetObject("txtCliente.Icon")));
            this.txtCliente.Location = new System.Drawing.Point(227, 154);
            this.txtCliente.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(338, 48);
            this.txtCliente.TabIndex = 63;
            this.txtCliente.text = "Cliente";
            // 
            // txtMesero
            // 
            this.txtMesero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(233)))), ((int)(((byte)(198)))));
            this.txtMesero.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtMesero.BackgroundImage")));
            this.txtMesero.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtMesero.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtMesero.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(132)))), ((int)(((byte)(26)))));
            this.txtMesero.Icon = ((System.Drawing.Image)(resources.GetObject("txtMesero.Icon")));
            this.txtMesero.Location = new System.Drawing.Point(228, 89);
            this.txtMesero.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMesero.Name = "txtMesero";
            this.txtMesero.Size = new System.Drawing.Size(338, 48);
            this.txtMesero.TabIndex = 61;
            this.txtMesero.text = "Mesero";
            // 
            // txtMesa
            // 
            this.txtMesa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(233)))), ((int)(((byte)(198)))));
            this.txtMesa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtMesa.BackgroundImage")));
            this.txtMesa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtMesa.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtMesa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(132)))), ((int)(((byte)(26)))));
            this.txtMesa.Icon = ((System.Drawing.Image)(resources.GetObject("txtMesa.Icon")));
            this.txtMesa.Location = new System.Drawing.Point(228, 28);
            this.txtMesa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMesa.Name = "txtMesa";
            this.txtMesa.Size = new System.Drawing.Size(338, 48);
            this.txtMesa.TabIndex = 58;
            this.txtMesa.text = "Mesa";
            // 
            // usDetalleOrden
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(233)))), ((int)(((byte)(198)))));
            this.Controls.Add(this.pnContenedorBotones);
            this.Controls.Add(this.txtComentario);
            this.Controls.Add(this.lblComentario);
            this.Controls.Add(this.lblMostrarFechaHora);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.pbLogoMini);
            this.Controls.Add(this.btnQuitarProducto);
            this.Controls.Add(this.btnRestarCantidad);
            this.Controls.Add(this.btnSumarCantidad);
            this.Controls.Add(this.dgDetalleOrden);
            this.Controls.Add(this.bunifuSeparator3);
            this.Controls.Add(this.bunifuSeparator2);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.txtMesero);
            this.Controls.Add(this.lblMesero);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.txtMesa);
            this.Controls.Add(this.lblMesa);
            this.Name = "usDetalleOrden";
            this.Size = new System.Drawing.Size(900, 575);
            this.Load += new System.EventHandler(this.usDetalleOrden_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgDetalleOrden)).EndInit();
            this.pnContenedorBotones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogoMini)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnQuitarProducto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestarCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSumarCantidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuTextbox txtCliente;
        private Bunifu.Framework.UI.BunifuTextbox txtMesero;
        private System.Windows.Forms.Label lblMesero;
        private System.Windows.Forms.Label lblCliente;
        private Bunifu.Framework.UI.BunifuTextbox txtMesa;
        private System.Windows.Forms.Label lblMesa;
        private Bunifu.Framework.UI.BunifuImageButton btnQuitarProducto;
        private Bunifu.Framework.UI.BunifuImageButton btnRestarCantidad;
        private Bunifu.Framework.UI.BunifuImageButton btnSumarCantidad;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgDetalleOrden;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator3;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator2;
        private System.Windows.Forms.PictureBox pbLogoMini;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblMostrarFechaHora;
        private System.Windows.Forms.Label lblComentario;
        private Bunifu.Framework.UI.BunifuTextbox txtComentario;
        private System.Windows.Forms.FlowLayoutPanel pnContenedorBotones;
        private Bunifu.Framework.UI.BunifuFlatButton btnAgregarProducto;
        private Bunifu.Framework.UI.BunifuFlatButton btnModificarCuenta;
        private Bunifu.Framework.UI.BunifuFlatButton btnEliminarCuenta;
    }
}
