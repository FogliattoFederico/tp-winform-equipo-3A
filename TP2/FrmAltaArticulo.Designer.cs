namespace Tp2
{
    partial class FrmAltaArticulo
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
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.cbxMarca = new System.Windows.Forms.ComboBox();
            this.cbxCategoria = new System.Windows.Forms.ComboBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.lblUrlImagen = new System.Windows.Forms.Label();
            this.txtUrlImagen = new System.Windows.Forms.TextBox();
            this.pbxArticulo = new System.Windows.Forms.PictureBox();
            this.lblUrlImagenRojo = new System.Windows.Forms.Label();
            this.lblPrecioRojo = new System.Windows.Forms.Label();
            this.lblDescripcionRojo = new System.Windows.Forms.Label();
            this.lblNombreRojo = new System.Windows.Forms.Label();
            this.lblCodigoRojo = new System.Windows.Forms.Label();
            this.lblLeyendaObligatorio = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbxArticulo)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(133, 108);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(138, 20);
            this.txtNombre.TabIndex = 1;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(133, 129);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(138, 20);
            this.txtDescripcion.TabIndex = 2;
            this.txtDescripcion.TextChanged += new System.EventHandler(this.txtDescripcion_TextChanged);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(133, 87);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(138, 20);
            this.txtCodigo.TabIndex = 0;
            this.txtCodigo.TextChanged += new System.EventHandler(this.txtCodigo_TextChanged);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(55, 112);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 3;
            this.lblNombre.Text = "Nombre";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(37, 133);
            this.lblDescripcion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(63, 13);
            this.lblDescripcion.TabIndex = 4;
            this.lblDescripcion.Text = "Descripcion";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(59, 91);
            this.lblCodigo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(40, 13);
            this.lblCodigo.TabIndex = 5;
            this.lblCodigo.Text = "Codigo";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(171, 269);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 26);
            this.btnAceptar.TabIndex = 7;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(288, 269);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 26);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(63, 155);
            this.lblMarca.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(37, 13);
            this.lblMarca.TabIndex = 8;
            this.lblMarca.Text = "Marca";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(46, 177);
            this.lblCategoria.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(52, 13);
            this.lblCategoria.TabIndex = 9;
            this.lblCategoria.Text = "Categoria";
            // 
            // cbxMarca
            // 
            this.cbxMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxMarca.FormattingEnabled = true;
            this.cbxMarca.Location = new System.Drawing.Point(133, 150);
            this.cbxMarca.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbxMarca.Name = "cbxMarca";
            this.cbxMarca.Size = new System.Drawing.Size(138, 21);
            this.cbxMarca.TabIndex = 3;
            // 
            // cbxCategoria
            // 
            this.cbxCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCategoria.FormattingEnabled = true;
            this.cbxCategoria.Location = new System.Drawing.Point(133, 172);
            this.cbxCategoria.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbxCategoria.Name = "cbxCategoria";
            this.cbxCategoria.Size = new System.Drawing.Size(138, 21);
            this.cbxCategoria.TabIndex = 4;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(195, 21);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(169, 29);
            this.lblTitulo.TabIndex = 12;
            this.lblTitulo.Text = "Nuevo Articulo";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(63, 198);
            this.lblPrecio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(37, 13);
            this.lblPrecio.TabIndex = 13;
            this.lblPrecio.Text = "Precio";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(133, 194);
            this.txtPrecio.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(138, 20);
            this.txtPrecio.TabIndex = 5;
            this.txtPrecio.TextChanged += new System.EventHandler(this.txtPrecio_TextChanged);
            this.txtPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecio_KeyPress);
            // 
            // lblUrlImagen
            // 
            this.lblUrlImagen.AutoSize = true;
            this.lblUrlImagen.Location = new System.Drawing.Point(45, 216);
            this.lblUrlImagen.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUrlImagen.Name = "lblUrlImagen";
            this.lblUrlImagen.Size = new System.Drawing.Size(58, 13);
            this.lblUrlImagen.TabIndex = 16;
            this.lblUrlImagen.Text = "Url Imagen";
            // 
            // txtUrlImagen
            // 
            this.txtUrlImagen.Location = new System.Drawing.Point(133, 214);
            this.txtUrlImagen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtUrlImagen.Name = "txtUrlImagen";
            this.txtUrlImagen.Size = new System.Drawing.Size(138, 20);
            this.txtUrlImagen.TabIndex = 6;
            this.txtUrlImagen.TextChanged += new System.EventHandler(this.txtUrlImagen_TextChanged);
            // 
            // pbxArticulo
            // 
            this.pbxArticulo.Location = new System.Drawing.Point(305, 87);
            this.pbxArticulo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbxArticulo.Name = "pbxArticulo";
            this.pbxArticulo.Size = new System.Drawing.Size(188, 144);
            this.pbxArticulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxArticulo.TabIndex = 17;
            this.pbxArticulo.TabStop = false;
            // 
            // lblUrlImagenRojo
            // 
            this.lblUrlImagenRojo.AutoSize = true;
            this.lblUrlImagenRojo.ForeColor = System.Drawing.Color.Red;
            this.lblUrlImagenRojo.Location = new System.Drawing.Point(272, 218);
            this.lblUrlImagenRojo.Name = "lblUrlImagenRojo";
            this.lblUrlImagenRojo.Size = new System.Drawing.Size(11, 13);
            this.lblUrlImagenRojo.TabIndex = 27;
            this.lblUrlImagenRojo.Text = "*";
            this.lblUrlImagenRojo.Visible = false;
            // 
            // lblPrecioRojo
            // 
            this.lblPrecioRojo.AutoSize = true;
            this.lblPrecioRojo.ForeColor = System.Drawing.Color.Red;
            this.lblPrecioRojo.Location = new System.Drawing.Point(272, 198);
            this.lblPrecioRojo.Name = "lblPrecioRojo";
            this.lblPrecioRojo.Size = new System.Drawing.Size(11, 13);
            this.lblPrecioRojo.TabIndex = 26;
            this.lblPrecioRojo.Text = "*";
            this.lblPrecioRojo.Visible = false;
            // 
            // lblDescripcionRojo
            // 
            this.lblDescripcionRojo.AutoSize = true;
            this.lblDescripcionRojo.ForeColor = System.Drawing.Color.Red;
            this.lblDescripcionRojo.Location = new System.Drawing.Point(272, 133);
            this.lblDescripcionRojo.Name = "lblDescripcionRojo";
            this.lblDescripcionRojo.Size = new System.Drawing.Size(11, 13);
            this.lblDescripcionRojo.TabIndex = 25;
            this.lblDescripcionRojo.Text = "*";
            this.lblDescripcionRojo.Visible = false;
            // 
            // lblNombreRojo
            // 
            this.lblNombreRojo.AutoSize = true;
            this.lblNombreRojo.ForeColor = System.Drawing.Color.Red;
            this.lblNombreRojo.Location = new System.Drawing.Point(272, 113);
            this.lblNombreRojo.Name = "lblNombreRojo";
            this.lblNombreRojo.Size = new System.Drawing.Size(11, 13);
            this.lblNombreRojo.TabIndex = 24;
            this.lblNombreRojo.Text = "*";
            this.lblNombreRojo.Visible = false;
            // 
            // lblCodigoRojo
            // 
            this.lblCodigoRojo.AutoSize = true;
            this.lblCodigoRojo.ForeColor = System.Drawing.Color.Red;
            this.lblCodigoRojo.Location = new System.Drawing.Point(272, 93);
            this.lblCodigoRojo.Name = "lblCodigoRojo";
            this.lblCodigoRojo.Size = new System.Drawing.Size(11, 13);
            this.lblCodigoRojo.TabIndex = 23;
            this.lblCodigoRojo.Text = "*";
            this.lblCodigoRojo.Visible = false;
            // 
            // lblLeyendaObligatorio
            // 
            this.lblLeyendaObligatorio.AutoSize = true;
            this.lblLeyendaObligatorio.ForeColor = System.Drawing.Color.Red;
            this.lblLeyendaObligatorio.Location = new System.Drawing.Point(88, 246);
            this.lblLeyendaObligatorio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLeyendaObligatorio.Name = "lblLeyendaObligatorio";
            this.lblLeyendaObligatorio.Size = new System.Drawing.Size(110, 13);
            this.lblLeyendaObligatorio.TabIndex = 29;
            this.lblLeyendaObligatorio.Text = "Campos Obligatorios *";
            // 
            // FrmAltaArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 343);
            this.Controls.Add(this.lblLeyendaObligatorio);
            this.Controls.Add(this.lblUrlImagenRojo);
            this.Controls.Add(this.lblPrecioRojo);
            this.Controls.Add(this.lblDescripcionRojo);
            this.Controls.Add(this.lblNombreRojo);
            this.Controls.Add(this.lblCodigoRojo);
            this.Controls.Add(this.pbxArticulo);
            this.Controls.Add(this.lblUrlImagen);
            this.Controls.Add(this.txtUrlImagen);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.cbxCategoria);
            this.Controls.Add(this.cbxMarca);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtNombre);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MinimumSize = new System.Drawing.Size(410, 329);
            this.Name = "FrmAltaArticulo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Articulo";
            this.Load += new System.EventHandler(this.FrmAltaArticulo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxArticulo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.ComboBox cbxMarca;
        private System.Windows.Forms.ComboBox cbxCategoria;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label lblUrlImagen;
        private System.Windows.Forms.TextBox txtUrlImagen;
        private System.Windows.Forms.PictureBox pbxArticulo;
        private System.Windows.Forms.Label lblUrlImagenRojo;
        private System.Windows.Forms.Label lblPrecioRojo;
        private System.Windows.Forms.Label lblDescripcionRojo;
        private System.Windows.Forms.Label lblNombreRojo;
        private System.Windows.Forms.Label lblCodigoRojo;
        private System.Windows.Forms.Label lblLeyendaObligatorio;
    }
}