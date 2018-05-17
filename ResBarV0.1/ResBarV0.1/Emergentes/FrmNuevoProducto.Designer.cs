namespace ResBarV0._1.Emergentes
{
    partial class FrmNuevoProducto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNuevoProducto));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.barraIzquierda = new System.Windows.Forms.Panel();
            this.barraDerecha = new System.Windows.Forms.Panel();
            this.barraInferior = new System.Windows.Forms.Panel();
            this.pnBarraSuperior = new System.Windows.Forms.Panel();
            this.pbNuevoProducto = new System.Windows.Forms.PictureBox();
            this.lblNuevoProducto = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblNomProducto = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblEnviarA = new System.Windows.Forms.Label();
            this.rbtnBebida = new System.Windows.Forms.RadioButton();
            this.rbtnCocina = new System.Windows.Forms.RadioButton();
            this.txtBuscarCategoria = new Bunifu.Framework.UI.BunifuTextbox();
            this.txtPrecio = new Bunifu.Framework.UI.BunifuTextbox();
            this.txtNomProducto = new Bunifu.Framework.UI.BunifuTextbox();
            this.btnCerrar = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnAceptar = new Bunifu.Framework.UI.BunifuImageButton();
            this.pbLogoMini = new System.Windows.Forms.PictureBox();
            this.pnBarraSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbNuevoProducto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAceptar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogoMini)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 18;
            this.bunifuElipse1.TargetControl = this;
            // 
            // barraIzquierda
            // 
            this.barraIzquierda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(1)))), ((int)(((byte)(42)))));
            this.barraIzquierda.Location = new System.Drawing.Point(0, 44);
            this.barraIzquierda.Name = "barraIzquierda";
            this.barraIzquierda.Size = new System.Drawing.Size(10, 364);
            this.barraIzquierda.TabIndex = 68;
            // 
            // barraDerecha
            // 
            this.barraDerecha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(1)))), ((int)(((byte)(42)))));
            this.barraDerecha.Location = new System.Drawing.Point(586, 44);
            this.barraDerecha.Name = "barraDerecha";
            this.barraDerecha.Size = new System.Drawing.Size(10, 364);
            this.barraDerecha.TabIndex = 67;
            // 
            // barraInferior
            // 
            this.barraInferior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(1)))), ((int)(((byte)(42)))));
            this.barraInferior.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barraInferior.Location = new System.Drawing.Point(0, 408);
            this.barraInferior.Name = "barraInferior";
            this.barraInferior.Size = new System.Drawing.Size(596, 10);
            this.barraInferior.TabIndex = 66;
            // 
            // pnBarraSuperior
            // 
            this.pnBarraSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(1)))), ((int)(((byte)(37)))));
            this.pnBarraSuperior.Controls.Add(this.pbNuevoProducto);
            this.pnBarraSuperior.Controls.Add(this.lblNuevoProducto);
            this.pnBarraSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnBarraSuperior.Location = new System.Drawing.Point(0, 0);
            this.pnBarraSuperior.Name = "pnBarraSuperior";
            this.pnBarraSuperior.Size = new System.Drawing.Size(596, 44);
            this.pnBarraSuperior.TabIndex = 65;
            // 
            // pbNuevoProducto
            // 
            this.pbNuevoProducto.Image = global::ResBarV0._1.Properties.Resources.signo_mas_en_un_circulo_negro;
            this.pbNuevoProducto.Location = new System.Drawing.Point(165, 1);
            this.pbNuevoProducto.Name = "pbNuevoProducto";
            this.pbNuevoProducto.Size = new System.Drawing.Size(53, 43);
            this.pbNuevoProducto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbNuevoProducto.TabIndex = 57;
            this.pbNuevoProducto.TabStop = false;
            // 
            // lblNuevoProducto
            // 
            this.lblNuevoProducto.AutoSize = true;
            this.lblNuevoProducto.BackColor = System.Drawing.Color.Transparent;
            this.lblNuevoProducto.Font = new System.Drawing.Font("Century Gothic", 18F);
            this.lblNuevoProducto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(233)))), ((int)(((byte)(198)))));
            this.lblNuevoProducto.Location = new System.Drawing.Point(224, 9);
            this.lblNuevoProducto.Name = "lblNuevoProducto";
            this.lblNuevoProducto.Size = new System.Drawing.Size(208, 30);
            this.lblNuevoProducto.TabIndex = 10;
            this.lblNuevoProducto.Text = "Nuevo Producto";
            // 
            // lblNomProducto
            // 
            this.lblNomProducto.AutoSize = true;
            this.lblNomProducto.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.lblNomProducto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(1)))), ((int)(((byte)(37)))));
            this.lblNomProducto.Location = new System.Drawing.Point(131, 160);
            this.lblNomProducto.Name = "lblNomProducto";
            this.lblNomProducto.Size = new System.Drawing.Size(94, 22);
            this.lblNomProducto.TabIndex = 75;
            this.lblNomProducto.Text = "Nombre :";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.lblPrecio.Location = new System.Drawing.Point(118, 227);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(106, 22);
            this.lblPrecio.TabIndex = 74;
            this.lblPrecio.Text = "Precio ($) :";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.lblCategoria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(1)))), ((int)(((byte)(37)))));
            this.lblCategoria.Location = new System.Drawing.Point(111, 97);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(114, 22);
            this.lblCategoria.TabIndex = 72;
            this.lblCategoria.Text = "Categoría :";
            // 
            // lblEnviarA
            // 
            this.lblEnviarA.AutoSize = true;
            this.lblEnviarA.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.lblEnviarA.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(1)))), ((int)(((byte)(37)))));
            this.lblEnviarA.Location = new System.Drawing.Point(129, 281);
            this.lblEnviarA.Name = "lblEnviarA";
            this.lblEnviarA.Size = new System.Drawing.Size(95, 22);
            this.lblEnviarA.TabIndex = 78;
            this.lblEnviarA.Text = "Enviar a :";
            // 
            // rbtnBebida
            // 
            this.rbtnBebida.AutoSize = true;
            this.rbtnBebida.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.rbtnBebida.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(1)))), ((int)(((byte)(37)))));
            this.rbtnBebida.Location = new System.Drawing.Point(363, 281);
            this.rbtnBebida.Name = "rbtnBebida";
            this.rbtnBebida.Size = new System.Drawing.Size(83, 25);
            this.rbtnBebida.TabIndex = 81;
            this.rbtnBebida.TabStop = true;
            this.rbtnBebida.Text = "Bebida";
            this.rbtnBebida.UseVisualStyleBackColor = true;
            // 
            // rbtnCocina
            // 
            this.rbtnCocina.AutoSize = true;
            this.rbtnCocina.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.rbtnCocina.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(1)))), ((int)(((byte)(37)))));
            this.rbtnCocina.Location = new System.Drawing.Point(249, 281);
            this.rbtnCocina.Name = "rbtnCocina";
            this.rbtnCocina.Size = new System.Drawing.Size(85, 25);
            this.rbtnCocina.TabIndex = 80;
            this.rbtnCocina.TabStop = true;
            this.rbtnCocina.Text = "Cocina";
            this.rbtnCocina.UseVisualStyleBackColor = true;
            // 
            // txtBuscarCategoria
            // 
            this.txtBuscarCategoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(233)))), ((int)(((byte)(198)))));
            this.txtBuscarCategoria.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtBuscarCategoria.BackgroundImage")));
            this.txtBuscarCategoria.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtBuscarCategoria.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarCategoria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(132)))), ((int)(((byte)(26)))));
            this.txtBuscarCategoria.Icon = ((System.Drawing.Image)(resources.GetObject("txtBuscarCategoria.Icon")));
            this.txtBuscarCategoria.Location = new System.Drawing.Point(229, 83);
            this.txtBuscarCategoria.Margin = new System.Windows.Forms.Padding(4);
            this.txtBuscarCategoria.Name = "txtBuscarCategoria";
            this.txtBuscarCategoria.Size = new System.Drawing.Size(338, 48);
            this.txtBuscarCategoria.TabIndex = 82;
            this.txtBuscarCategoria.text = "Buscar categoría";
            // 
            // txtPrecio
            // 
            this.txtPrecio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(233)))), ((int)(((byte)(198)))));
            this.txtPrecio.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtPrecio.BackgroundImage")));
            this.txtPrecio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtPrecio.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtPrecio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(132)))), ((int)(((byte)(26)))));
            this.txtPrecio.Icon = ((System.Drawing.Image)(resources.GetObject("txtPrecio.Icon")));
            this.txtPrecio.Location = new System.Drawing.Point(228, 212);
            this.txtPrecio.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(338, 48);
            this.txtPrecio.TabIndex = 77;
            this.txtPrecio.text = "Ingrese el precio ($)";
            // 
            // txtNomProducto
            // 
            this.txtNomProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(233)))), ((int)(((byte)(198)))));
            this.txtNomProducto.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtNomProducto.BackgroundImage")));
            this.txtNomProducto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtNomProducto.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtNomProducto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(132)))), ((int)(((byte)(26)))));
            this.txtNomProducto.Icon = ((System.Drawing.Image)(resources.GetObject("txtNomProducto.Icon")));
            this.txtNomProducto.Location = new System.Drawing.Point(229, 147);
            this.txtNomProducto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNomProducto.Name = "txtNomProducto";
            this.txtNomProducto.Size = new System.Drawing.Size(338, 48);
            this.txtNomProducto.TabIndex = 76;
            this.txtNomProducto.text = "Nombre del Producto";
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.Transparent;
            this.btnCerrar.Image = global::ResBarV0._1.Properties.Resources.cerrar;
            this.btnCerrar.ImageActive = null;
            this.btnCerrar.Location = new System.Drawing.Point(343, 346);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(71, 56);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 71;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Zoom = 10;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.Transparent;
            this.btnAceptar.Image = global::ResBarV0._1.Properties.Resources.Aceptar;
            this.btnAceptar.ImageActive = null;
            this.btnAceptar.Location = new System.Drawing.Point(219, 346);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(71, 56);
            this.btnAceptar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnAceptar.TabIndex = 70;
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
            this.pbLogoMini.TabIndex = 69;
            this.pbLogoMini.TabStop = false;
            // 
            // FrmNuevoProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(233)))), ((int)(((byte)(198)))));
            this.ClientSize = new System.Drawing.Size(596, 418);
            this.Controls.Add(this.txtBuscarCategoria);
            this.Controls.Add(this.rbtnBebida);
            this.Controls.Add(this.rbtnCocina);
            this.Controls.Add(this.lblEnviarA);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtNomProducto);
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
            this.Name = "FrmNuevoProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmNuevoProducto";
            this.pnBarraSuperior.ResumeLayout(false);
            this.pnBarraSuperior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbNuevoProducto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAceptar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogoMini)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuImageButton btnCerrar;
        private Bunifu.Framework.UI.BunifuImageButton btnAceptar;
        private System.Windows.Forms.PictureBox pbLogoMini;
        private System.Windows.Forms.Panel barraIzquierda;
        private System.Windows.Forms.Panel barraDerecha;
        private System.Windows.Forms.Panel barraInferior;
        private System.Windows.Forms.Panel pnBarraSuperior;
        private System.Windows.Forms.PictureBox pbNuevoProducto;
        private Bunifu.Framework.UI.BunifuCustomLabel lblNuevoProducto;
        private Bunifu.Framework.UI.BunifuTextbox txtPrecio;
        private Bunifu.Framework.UI.BunifuTextbox txtNomProducto;
        private System.Windows.Forms.Label lblNomProducto;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.RadioButton rbtnBebida;
        private System.Windows.Forms.RadioButton rbtnCocina;
        private System.Windows.Forms.Label lblEnviarA;
        private Bunifu.Framework.UI.BunifuTextbox txtBuscarCategoria;
    }
}