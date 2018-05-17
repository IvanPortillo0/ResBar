namespace ResBarV0._1.Emergentes
{
    partial class FrmModificarProducto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmModificarProducto));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.rbtnBebida = new System.Windows.Forms.RadioButton();
            this.rbtnCocina = new System.Windows.Forms.RadioButton();
            this.lblEnviarA = new System.Windows.Forms.Label();
            this.lblNomProducto = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.barraIzquierda = new System.Windows.Forms.Panel();
            this.barraDerecha = new System.Windows.Forms.Panel();
            this.barraInferior = new System.Windows.Forms.Panel();
            this.pnBarraSuperior = new System.Windows.Forms.Panel();
            this.lblModificarProducto = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.pnModCategoria = new System.Windows.Forms.FlowLayoutPanel();
            this.btnModificarProducto = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnEliminarProducto = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txtBuscarProducto = new Bunifu.Framework.UI.BunifuTextbox();
            this.txtBuscarCategoria = new Bunifu.Framework.UI.BunifuTextbox();
            this.txtModPrecio = new Bunifu.Framework.UI.BunifuTextbox();
            this.btnCerrar = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnAceptar = new Bunifu.Framework.UI.BunifuImageButton();
            this.pbLogoMini = new System.Windows.Forms.PictureBox();
            this.pbModificarProducto = new System.Windows.Forms.PictureBox();
            this.pnBarraSuperior.SuspendLayout();
            this.pnModCategoria.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAceptar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogoMini)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbModificarProducto)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 18;
            this.bunifuElipse1.TargetControl = this;
            // 
            // rbtnBebida
            // 
            this.rbtnBebida.AutoSize = true;
            this.rbtnBebida.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.rbtnBebida.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(1)))), ((int)(((byte)(37)))));
            this.rbtnBebida.Location = new System.Drawing.Point(360, 281);
            this.rbtnBebida.Name = "rbtnBebida";
            this.rbtnBebida.Size = new System.Drawing.Size(83, 25);
            this.rbtnBebida.TabIndex = 97;
            this.rbtnBebida.TabStop = true;
            this.rbtnBebida.Text = "Bebida";
            this.rbtnBebida.UseVisualStyleBackColor = true;
            // 
            // rbtnCocina
            // 
            this.rbtnCocina.AutoSize = true;
            this.rbtnCocina.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.rbtnCocina.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(1)))), ((int)(((byte)(37)))));
            this.rbtnCocina.Location = new System.Drawing.Point(246, 281);
            this.rbtnCocina.Name = "rbtnCocina";
            this.rbtnCocina.Size = new System.Drawing.Size(85, 25);
            this.rbtnCocina.TabIndex = 96;
            this.rbtnCocina.TabStop = true;
            this.rbtnCocina.Text = "Cocina";
            this.rbtnCocina.UseVisualStyleBackColor = true;
            // 
            // lblEnviarA
            // 
            this.lblEnviarA.AutoSize = true;
            this.lblEnviarA.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.lblEnviarA.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(1)))), ((int)(((byte)(37)))));
            this.lblEnviarA.Location = new System.Drawing.Point(126, 281);
            this.lblEnviarA.Name = "lblEnviarA";
            this.lblEnviarA.Size = new System.Drawing.Size(95, 22);
            this.lblEnviarA.TabIndex = 95;
            this.lblEnviarA.Text = "Enviar a :";
            // 
            // lblNomProducto
            // 
            this.lblNomProducto.AutoSize = true;
            this.lblNomProducto.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.lblNomProducto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(1)))), ((int)(((byte)(37)))));
            this.lblNomProducto.Location = new System.Drawing.Point(127, 160);
            this.lblNomProducto.Name = "lblNomProducto";
            this.lblNomProducto.Size = new System.Drawing.Size(94, 22);
            this.lblNomProducto.TabIndex = 92;
            this.lblNomProducto.Text = "Nombre :";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.lblPrecio.Location = new System.Drawing.Point(115, 227);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(106, 22);
            this.lblPrecio.TabIndex = 91;
            this.lblPrecio.Text = "Precio ($) :";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.lblCategoria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(1)))), ((int)(((byte)(37)))));
            this.lblCategoria.Location = new System.Drawing.Point(108, 97);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(114, 22);
            this.lblCategoria.TabIndex = 90;
            this.lblCategoria.Text = "Categoría :";
            // 
            // barraIzquierda
            // 
            this.barraIzquierda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(1)))), ((int)(((byte)(42)))));
            this.barraIzquierda.Location = new System.Drawing.Point(0, 44);
            this.barraIzquierda.Name = "barraIzquierda";
            this.barraIzquierda.Size = new System.Drawing.Size(10, 364);
            this.barraIzquierda.TabIndex = 86;
            // 
            // barraDerecha
            // 
            this.barraDerecha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(1)))), ((int)(((byte)(42)))));
            this.barraDerecha.Location = new System.Drawing.Point(710, 44);
            this.barraDerecha.Name = "barraDerecha";
            this.barraDerecha.Size = new System.Drawing.Size(10, 364);
            this.barraDerecha.TabIndex = 85;
            // 
            // barraInferior
            // 
            this.barraInferior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(1)))), ((int)(((byte)(42)))));
            this.barraInferior.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barraInferior.Location = new System.Drawing.Point(0, 408);
            this.barraInferior.Name = "barraInferior";
            this.barraInferior.Size = new System.Drawing.Size(720, 10);
            this.barraInferior.TabIndex = 84;
            // 
            // pnBarraSuperior
            // 
            this.pnBarraSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(1)))), ((int)(((byte)(37)))));
            this.pnBarraSuperior.Controls.Add(this.pbModificarProducto);
            this.pnBarraSuperior.Controls.Add(this.lblModificarProducto);
            this.pnBarraSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnBarraSuperior.Location = new System.Drawing.Point(0, 0);
            this.pnBarraSuperior.Name = "pnBarraSuperior";
            this.pnBarraSuperior.Size = new System.Drawing.Size(720, 44);
            this.pnBarraSuperior.TabIndex = 83;
            // 
            // lblModificarProducto
            // 
            this.lblModificarProducto.AutoSize = true;
            this.lblModificarProducto.BackColor = System.Drawing.Color.Transparent;
            this.lblModificarProducto.Font = new System.Drawing.Font("Century Gothic", 18F);
            this.lblModificarProducto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(233)))), ((int)(((byte)(198)))));
            this.lblModificarProducto.Location = new System.Drawing.Point(257, 9);
            this.lblModificarProducto.Name = "lblModificarProducto";
            this.lblModificarProducto.Size = new System.Drawing.Size(242, 30);
            this.lblModificarProducto.TabIndex = 10;
            this.lblModificarProducto.Text = "Modificar Producto";
            // 
            // pnModCategoria
            // 
            this.pnModCategoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(132)))), ((int)(((byte)(26)))));
            this.pnModCategoria.Controls.Add(this.btnModificarProducto);
            this.pnModCategoria.Controls.Add(this.btnEliminarProducto);
            this.pnModCategoria.Location = new System.Drawing.Point(560, 113);
            this.pnModCategoria.Name = "pnModCategoria";
            this.pnModCategoria.Size = new System.Drawing.Size(143, 107);
            this.pnModCategoria.TabIndex = 100;
            // 
            // btnModificarProducto
            // 
            this.btnModificarProducto.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(1)))), ((int)(((byte)(37)))));
            this.btnModificarProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(233)))), ((int)(((byte)(198)))));
            this.btnModificarProducto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnModificarProducto.BorderRadius = 5;
            this.btnModificarProducto.ButtonText = "Modificar Producto";
            this.btnModificarProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModificarProducto.DisabledColor = System.Drawing.Color.Gray;
            this.btnModificarProducto.Iconcolor = System.Drawing.Color.Transparent;
            this.btnModificarProducto.Iconimage = global::ResBarV0._1.Properties.Resources.editar_lapiz_mod__2_;
            this.btnModificarProducto.Iconimage_right = null;
            this.btnModificarProducto.Iconimage_right_Selected = null;
            this.btnModificarProducto.Iconimage_Selected = null;
            this.btnModificarProducto.IconMarginLeft = 0;
            this.btnModificarProducto.IconMarginRight = 0;
            this.btnModificarProducto.IconRightVisible = true;
            this.btnModificarProducto.IconRightZoom = 0D;
            this.btnModificarProducto.IconVisible = true;
            this.btnModificarProducto.IconZoom = 75D;
            this.btnModificarProducto.IsTab = false;
            this.btnModificarProducto.Location = new System.Drawing.Point(3, 3);
            this.btnModificarProducto.Name = "btnModificarProducto";
            this.btnModificarProducto.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(233)))), ((int)(((byte)(198)))));
            this.btnModificarProducto.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(1)))), ((int)(((byte)(37)))));
            this.btnModificarProducto.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(132)))), ((int)(((byte)(26)))));
            this.btnModificarProducto.selected = false;
            this.btnModificarProducto.Size = new System.Drawing.Size(139, 48);
            this.btnModificarProducto.TabIndex = 9;
            this.btnModificarProducto.Text = "Modificar Producto";
            this.btnModificarProducto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnModificarProducto.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(132)))), ((int)(((byte)(26)))));
            this.btnModificarProducto.TextFont = new System.Drawing.Font("Century Gothic", 12F);
            // 
            // btnEliminarProducto
            // 
            this.btnEliminarProducto.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(1)))), ((int)(((byte)(37)))));
            this.btnEliminarProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(233)))), ((int)(((byte)(198)))));
            this.btnEliminarProducto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEliminarProducto.BorderRadius = 5;
            this.btnEliminarProducto.ButtonText = "Eliminar Producto";
            this.btnEliminarProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminarProducto.DisabledColor = System.Drawing.Color.Gray;
            this.btnEliminarProducto.Iconcolor = System.Drawing.Color.Transparent;
            this.btnEliminarProducto.Iconimage = global::ResBarV0._1.Properties.Resources.borrar__1_;
            this.btnEliminarProducto.Iconimage_right = null;
            this.btnEliminarProducto.Iconimage_right_Selected = null;
            this.btnEliminarProducto.Iconimage_Selected = null;
            this.btnEliminarProducto.IconMarginLeft = 0;
            this.btnEliminarProducto.IconMarginRight = 0;
            this.btnEliminarProducto.IconRightVisible = true;
            this.btnEliminarProducto.IconRightZoom = 0D;
            this.btnEliminarProducto.IconVisible = true;
            this.btnEliminarProducto.IconZoom = 75D;
            this.btnEliminarProducto.IsTab = false;
            this.btnEliminarProducto.Location = new System.Drawing.Point(3, 57);
            this.btnEliminarProducto.Name = "btnEliminarProducto";
            this.btnEliminarProducto.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(233)))), ((int)(((byte)(198)))));
            this.btnEliminarProducto.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(1)))), ((int)(((byte)(37)))));
            this.btnEliminarProducto.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(132)))), ((int)(((byte)(26)))));
            this.btnEliminarProducto.selected = false;
            this.btnEliminarProducto.Size = new System.Drawing.Size(139, 48);
            this.btnEliminarProducto.TabIndex = 12;
            this.btnEliminarProducto.Text = "Eliminar Producto";
            this.btnEliminarProducto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnEliminarProducto.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(132)))), ((int)(((byte)(26)))));
            this.btnEliminarProducto.TextFont = new System.Drawing.Font("Century Gothic", 12F);
            // 
            // txtBuscarProducto
            // 
            this.txtBuscarProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(233)))), ((int)(((byte)(198)))));
            this.txtBuscarProducto.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtBuscarProducto.BackgroundImage")));
            this.txtBuscarProducto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtBuscarProducto.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarProducto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(132)))), ((int)(((byte)(26)))));
            this.txtBuscarProducto.Icon = ((System.Drawing.Image)(resources.GetObject("txtBuscarProducto.Icon")));
            this.txtBuscarProducto.Location = new System.Drawing.Point(225, 148);
            this.txtBuscarProducto.Margin = new System.Windows.Forms.Padding(4);
            this.txtBuscarProducto.Name = "txtBuscarProducto";
            this.txtBuscarProducto.Size = new System.Drawing.Size(310, 48);
            this.txtBuscarProducto.TabIndex = 99;
            this.txtBuscarProducto.text = "Buscar Producto";
            // 
            // txtBuscarCategoria
            // 
            this.txtBuscarCategoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(233)))), ((int)(((byte)(198)))));
            this.txtBuscarCategoria.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtBuscarCategoria.BackgroundImage")));
            this.txtBuscarCategoria.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtBuscarCategoria.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarCategoria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(132)))), ((int)(((byte)(26)))));
            this.txtBuscarCategoria.Icon = ((System.Drawing.Image)(resources.GetObject("txtBuscarCategoria.Icon")));
            this.txtBuscarCategoria.Location = new System.Drawing.Point(226, 83);
            this.txtBuscarCategoria.Margin = new System.Windows.Forms.Padding(4);
            this.txtBuscarCategoria.Name = "txtBuscarCategoria";
            this.txtBuscarCategoria.Size = new System.Drawing.Size(310, 48);
            this.txtBuscarCategoria.TabIndex = 98;
            this.txtBuscarCategoria.text = "Buscar categoría";
            // 
            // txtModPrecio
            // 
            this.txtModPrecio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(233)))), ((int)(((byte)(198)))));
            this.txtModPrecio.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtModPrecio.BackgroundImage")));
            this.txtModPrecio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtModPrecio.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtModPrecio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(132)))), ((int)(((byte)(26)))));
            this.txtModPrecio.Icon = ((System.Drawing.Image)(resources.GetObject("txtModPrecio.Icon")));
            this.txtModPrecio.Location = new System.Drawing.Point(225, 212);
            this.txtModPrecio.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtModPrecio.Name = "txtModPrecio";
            this.txtModPrecio.Size = new System.Drawing.Size(310, 48);
            this.txtModPrecio.TabIndex = 94;
            this.txtModPrecio.text = "Precio ($)";
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.Transparent;
            this.btnCerrar.Image = global::ResBarV0._1.Properties.Resources.cerrar;
            this.btnCerrar.ImageActive = null;
            this.btnCerrar.Location = new System.Drawing.Point(371, 346);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(71, 56);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 89;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Zoom = 10;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.Transparent;
            this.btnAceptar.Image = global::ResBarV0._1.Properties.Resources.Aceptar;
            this.btnAceptar.ImageActive = null;
            this.btnAceptar.Location = new System.Drawing.Point(247, 346);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(71, 56);
            this.btnAceptar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnAceptar.TabIndex = 88;
            this.btnAceptar.TabStop = false;
            this.btnAceptar.Zoom = 10;
            // 
            // pbLogoMini
            // 
            this.pbLogoMini.Image = global::ResBarV0._1.Properties.Resources.logo_lite;
            this.pbLogoMini.Location = new System.Drawing.Point(15, 49);
            this.pbLogoMini.Name = "pbLogoMini";
            this.pbLogoMini.Size = new System.Drawing.Size(88, 85);
            this.pbLogoMini.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogoMini.TabIndex = 87;
            this.pbLogoMini.TabStop = false;
            // 
            // pbModificarProducto
            // 
            this.pbModificarProducto.Image = global::ResBarV0._1.Properties.Resources.editar_lapiz_mod__1_;
            this.pbModificarProducto.Location = new System.Drawing.Point(198, 1);
            this.pbModificarProducto.Name = "pbModificarProducto";
            this.pbModificarProducto.Size = new System.Drawing.Size(53, 42);
            this.pbModificarProducto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbModificarProducto.TabIndex = 57;
            this.pbModificarProducto.TabStop = false;
            // 
            // FrmModificarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(233)))), ((int)(((byte)(198)))));
            this.ClientSize = new System.Drawing.Size(720, 418);
            this.Controls.Add(this.pnModCategoria);
            this.Controls.Add(this.txtBuscarProducto);
            this.Controls.Add(this.txtBuscarCategoria);
            this.Controls.Add(this.rbtnBebida);
            this.Controls.Add(this.rbtnCocina);
            this.Controls.Add(this.lblEnviarA);
            this.Controls.Add(this.txtModPrecio);
            this.Controls.Add(this.lblNomProducto);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.pbLogoMini);
            this.Controls.Add(this.barraIzquierda);
            this.Controls.Add(this.barraDerecha);
            this.Controls.Add(this.barraInferior);
            this.Controls.Add(this.pnBarraSuperior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmModificarProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmModificarProducto";
            this.pnBarraSuperior.ResumeLayout(false);
            this.pnBarraSuperior.PerformLayout();
            this.pnModCategoria.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAceptar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogoMini)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbModificarProducto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuTextbox txtBuscarCategoria;
        private System.Windows.Forms.RadioButton rbtnBebida;
        private System.Windows.Forms.RadioButton rbtnCocina;
        private System.Windows.Forms.Label lblEnviarA;
        private Bunifu.Framework.UI.BunifuTextbox txtModPrecio;
        private System.Windows.Forms.Label lblNomProducto;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblCategoria;
        private Bunifu.Framework.UI.BunifuImageButton btnCerrar;
        private Bunifu.Framework.UI.BunifuImageButton btnAceptar;
        private System.Windows.Forms.PictureBox pbLogoMini;
        private System.Windows.Forms.Panel barraIzquierda;
        private System.Windows.Forms.Panel barraDerecha;
        private System.Windows.Forms.Panel barraInferior;
        private System.Windows.Forms.Panel pnBarraSuperior;
        private System.Windows.Forms.PictureBox pbModificarProducto;
        private Bunifu.Framework.UI.BunifuCustomLabel lblModificarProducto;
        private Bunifu.Framework.UI.BunifuTextbox txtBuscarProducto;
        private System.Windows.Forms.FlowLayoutPanel pnModCategoria;
        private Bunifu.Framework.UI.BunifuFlatButton btnModificarProducto;
        private Bunifu.Framework.UI.BunifuFlatButton btnEliminarProducto;
    }
}