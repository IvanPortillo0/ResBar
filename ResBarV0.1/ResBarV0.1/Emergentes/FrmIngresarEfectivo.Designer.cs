namespace ResBarV0._1.Emergentes
{
    partial class FrmIngresarEfectivo
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
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.btnCerrar = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnAceptar = new Bunifu.Framework.UI.BunifuImageButton();
            this.pbLogoMini = new System.Windows.Forms.PictureBox();
            this.barraIzquierda = new System.Windows.Forms.Panel();
            this.barraDerecha = new System.Windows.Forms.Panel();
            this.barraInferior = new System.Windows.Forms.Panel();
            this.pnBarraSuperior = new System.Windows.Forms.Panel();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblCambio = new System.Windows.Forms.Label();
            this.lblEfectivo = new System.Windows.Forms.Label();
            this.pnTxtEfectivo = new System.Windows.Forms.FlowLayoutPanel();
            this.txtEfectivo = new System.Windows.Forms.TextBox();
            this.pnTxtTotal = new System.Windows.Forms.FlowLayoutPanel();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.pnTxtCaqmbio = new System.Windows.Forms.FlowLayoutPanel();
            this.txtCambio = new System.Windows.Forms.TextBox();
            this.lblFormato = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAceptar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogoMini)).BeginInit();
            this.pnTxtEfectivo.SuspendLayout();
            this.pnTxtTotal.SuspendLayout();
            this.pnTxtCaqmbio.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 10;
            this.bunifuElipse1.TargetControl = this;
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.Transparent;
            this.btnCerrar.Image = global::ResBarV0._1.Properties.Resources.cerrar;
            this.btnCerrar.ImageActive = null;
            this.btnCerrar.Location = new System.Drawing.Point(248, 203);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(71, 56);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 78;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Zoom = 10;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.Transparent;
            this.btnAceptar.Image = global::ResBarV0._1.Properties.Resources.Aceptar;
            this.btnAceptar.ImageActive = null;
            this.btnAceptar.Location = new System.Drawing.Point(142, 203);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(71, 56);
            this.btnAceptar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnAceptar.TabIndex = 77;
            this.btnAceptar.TabStop = false;
            this.btnAceptar.Zoom = 10;
            // 
            // pbLogoMini
            // 
            this.pbLogoMini.Image = global::ResBarV0._1.Properties.Resources.logo_lite;
            this.pbLogoMini.Location = new System.Drawing.Point(16, 16);
            this.pbLogoMini.Name = "pbLogoMini";
            this.pbLogoMini.Size = new System.Drawing.Size(50, 67);
            this.pbLogoMini.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogoMini.TabIndex = 76;
            this.pbLogoMini.TabStop = false;
            // 
            // barraIzquierda
            // 
            this.barraIzquierda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(1)))), ((int)(((byte)(42)))));
            this.barraIzquierda.Dock = System.Windows.Forms.DockStyle.Left;
            this.barraIzquierda.Location = new System.Drawing.Point(0, 10);
            this.barraIzquierda.Name = "barraIzquierda";
            this.barraIzquierda.Size = new System.Drawing.Size(10, 276);
            this.barraIzquierda.TabIndex = 75;
            // 
            // barraDerecha
            // 
            this.barraDerecha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(1)))), ((int)(((byte)(42)))));
            this.barraDerecha.Dock = System.Windows.Forms.DockStyle.Right;
            this.barraDerecha.Location = new System.Drawing.Point(420, 10);
            this.barraDerecha.Name = "barraDerecha";
            this.barraDerecha.Size = new System.Drawing.Size(10, 276);
            this.barraDerecha.TabIndex = 74;
            // 
            // barraInferior
            // 
            this.barraInferior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(1)))), ((int)(((byte)(42)))));
            this.barraInferior.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barraInferior.Location = new System.Drawing.Point(0, 286);
            this.barraInferior.Name = "barraInferior";
            this.barraInferior.Size = new System.Drawing.Size(430, 10);
            this.barraInferior.TabIndex = 73;
            // 
            // pnBarraSuperior
            // 
            this.pnBarraSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(1)))), ((int)(((byte)(37)))));
            this.pnBarraSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnBarraSuperior.Location = new System.Drawing.Point(0, 0);
            this.pnBarraSuperior.Name = "pnBarraSuperior";
            this.pnBarraSuperior.Size = new System.Drawing.Size(430, 10);
            this.pnBarraSuperior.TabIndex = 72;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.lblTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(1)))), ((int)(((byte)(37)))));
            this.lblTotal.Location = new System.Drawing.Point(117, 82);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(88, 22);
            this.lblTotal.TabIndex = 81;
            this.lblTotal.Text = "Total ($):";
            // 
            // lblCambio
            // 
            this.lblCambio.AutoSize = true;
            this.lblCambio.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.lblCambio.Location = new System.Drawing.Point(81, 140);
            this.lblCambio.Name = "lblCambio";
            this.lblCambio.Size = new System.Drawing.Size(123, 22);
            this.lblCambio.TabIndex = 80;
            this.lblCambio.Text = "Cambio ($) :";
            // 
            // lblEfectivo
            // 
            this.lblEfectivo.AutoSize = true;
            this.lblEfectivo.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.lblEfectivo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(1)))), ((int)(((byte)(37)))));
            this.lblEfectivo.Location = new System.Drawing.Point(81, 25);
            this.lblEfectivo.Name = "lblEfectivo";
            this.lblEfectivo.Size = new System.Drawing.Size(125, 22);
            this.lblEfectivo.TabIndex = 79;
            this.lblEfectivo.Text = "Efectivo ($) :";
            // 
            // pnTxtEfectivo
            // 
            this.pnTxtEfectivo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(132)))), ((int)(((byte)(26)))));
            this.pnTxtEfectivo.Controls.Add(this.txtEfectivo);
            this.pnTxtEfectivo.Location = new System.Drawing.Point(221, 25);
            this.pnTxtEfectivo.Name = "pnTxtEfectivo";
            this.pnTxtEfectivo.Size = new System.Drawing.Size(167, 25);
            this.pnTxtEfectivo.TabIndex = 82;
            // 
            // txtEfectivo
            // 
            this.txtEfectivo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(233)))), ((int)(((byte)(198)))));
            this.txtEfectivo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEfectivo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtEfectivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEfectivo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(1)))), ((int)(((byte)(37)))));
            this.txtEfectivo.Location = new System.Drawing.Point(3, 3);
            this.txtEfectivo.Name = "txtEfectivo";
            this.txtEfectivo.Size = new System.Drawing.Size(161, 19);
            this.txtEfectivo.TabIndex = 0;
            // 
            // pnTxtTotal
            // 
            this.pnTxtTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(132)))), ((int)(((byte)(26)))));
            this.pnTxtTotal.Controls.Add(this.txtTotal);
            this.pnTxtTotal.Location = new System.Drawing.Point(221, 82);
            this.pnTxtTotal.Name = "pnTxtTotal";
            this.pnTxtTotal.Size = new System.Drawing.Size(167, 25);
            this.pnTxtTotal.TabIndex = 83;
            // 
            // txtTotal
            // 
            this.txtTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(233)))), ((int)(((byte)(198)))));
            this.txtTotal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTotal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(1)))), ((int)(((byte)(37)))));
            this.txtTotal.Location = new System.Drawing.Point(3, 3);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(161, 19);
            this.txtTotal.TabIndex = 0;
            // 
            // pnTxtCaqmbio
            // 
            this.pnTxtCaqmbio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(132)))), ((int)(((byte)(26)))));
            this.pnTxtCaqmbio.Controls.Add(this.txtCambio);
            this.pnTxtCaqmbio.Location = new System.Drawing.Point(221, 139);
            this.pnTxtCaqmbio.Name = "pnTxtCaqmbio";
            this.pnTxtCaqmbio.Size = new System.Drawing.Size(167, 25);
            this.pnTxtCaqmbio.TabIndex = 84;
            // 
            // txtCambio
            // 
            this.txtCambio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(233)))), ((int)(((byte)(198)))));
            this.txtCambio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCambio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCambio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCambio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(1)))), ((int)(((byte)(37)))));
            this.txtCambio.Location = new System.Drawing.Point(3, 3);
            this.txtCambio.Name = "txtCambio";
            this.txtCambio.ReadOnly = true;
            this.txtCambio.Size = new System.Drawing.Size(161, 19);
            this.txtCambio.TabIndex = 0;
            // 
            // lblFormato
            // 
            this.lblFormato.AutoSize = true;
            this.lblFormato.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormato.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(1)))), ((int)(((byte)(42)))));
            this.lblFormato.Location = new System.Drawing.Point(221, 53);
            this.lblFormato.Name = "lblFormato";
            this.lblFormato.Size = new System.Drawing.Size(117, 17);
            this.lblFormato.TabIndex = 85;
            this.lblFormato.Text = "*Formato: ##.##";
            // 
            // FrmIngresarEfectivo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(233)))), ((int)(((byte)(198)))));
            this.ClientSize = new System.Drawing.Size(430, 296);
            this.Controls.Add(this.lblFormato);
            this.Controls.Add(this.pnTxtCaqmbio);
            this.Controls.Add(this.pnTxtTotal);
            this.Controls.Add(this.pnTxtEfectivo);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblCambio);
            this.Controls.Add(this.lblEfectivo);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.pbLogoMini);
            this.Controls.Add(this.barraIzquierda);
            this.Controls.Add(this.barraDerecha);
            this.Controls.Add(this.barraInferior);
            this.Controls.Add(this.pnBarraSuperior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmIngresarEfectivo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmIngresarEfectivo";
            this.Load += new System.EventHandler(this.FrmIngresarEfectivo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAceptar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogoMini)).EndInit();
            this.pnTxtEfectivo.ResumeLayout(false);
            this.pnTxtEfectivo.PerformLayout();
            this.pnTxtTotal.ResumeLayout(false);
            this.pnTxtTotal.PerformLayout();
            this.pnTxtCaqmbio.ResumeLayout(false);
            this.pnTxtCaqmbio.PerformLayout();
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
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblCambio;
        private System.Windows.Forms.Label lblEfectivo;
        private System.Windows.Forms.FlowLayoutPanel pnTxtEfectivo;
        private System.Windows.Forms.TextBox txtEfectivo;
        private System.Windows.Forms.FlowLayoutPanel pnTxtCaqmbio;
        private System.Windows.Forms.TextBox txtCambio;
        private System.Windows.Forms.FlowLayoutPanel pnTxtTotal;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label lblFormato;
    }
}