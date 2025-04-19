using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Negocio;

namespace Tp2
{
    public partial class FrmAltaArticulo : Form
    {
        private Articulo articulo = null;
        public FrmAltaArticulo()
        {
            InitializeComponent();
        }

        public FrmAltaArticulo(Articulo articulo)
        {
            InitializeComponent();
            this.articulo = articulo;
            Text = "Modificar Articulo";
            lblTitulo.Text = "Articulo";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            
            ArticuloNegocio negocio = new ArticuloNegocio();

            try
            {
                if (articulo == null) {
                    
                    articulo = new Articulo();
                }

                articulo.Nombre = txtNombre.Text;
                articulo.Codigo = txtCodigo.Text;
                articulo.Descripcion = txtDescripcion.Text;
                articulo.Marca = (Marca)cbxMarca.SelectedItem;
                articulo.Categoria = (Categoria)cbxCategoria.SelectedItem;
                articulo.Precio = decimal.Parse(txtPrecio.Text);

                articulo.UrlImagen = new Imagen();
                articulo.UrlImagen.ImagenUrl = txtUrlImagen.Text;

                if(articulo.Id != 0)
                {
                    negocio.modificarArticulo(articulo);
                    MessageBox.Show("Articulo modificado exitosamente");

                }
                else
                {
                    negocio.AgregarArticulo(articulo);
                    MessageBox.Show("Articulo agregado exitosamente");

                }

                Close();

              

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void FrmAltaArticulo_Load(object sender, EventArgs e)
        {
            indicarObligatorio();
            controlAceptar();
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
            MarcaNegocio marcaNegocio = new MarcaNegocio();
            

            try
            {
                cbxCategoria.DataSource = categoriaNegocio.Listar();
                cbxCategoria.ValueMember = "Id";
                cbxCategoria.DisplayMember = "Descripcion";


                cbxMarca.DataSource = marcaNegocio.Listar();
                cbxMarca.ValueMember = "Id";
                cbxMarca.DisplayMember = "Descripcion";

                if (articulo != null)
                {
                    txtCodigo.Text = articulo.Codigo;
                    txtNombre.Text = articulo.Nombre;
                    txtDescripcion.Text = articulo.Descripcion;
                    //TODO
                    /************** PRUEBAS Validacion *****************************/
                    if (articulo.Categoria == null || articulo.Categoria.Id == 0)
                    {
                        MessageBox.Show("Este articulo no posee categoria. Por favor corrija campos segun corresponda");
                    }
                    else
                    {
                        cbxCategoria.SelectedValue = articulo.Categoria.Id;
                    }
                    /**************************************************************/                    
                    //cbxCategoria.SelectedValue = articulo.Categoria.Id;
                    cbxMarca.SelectedValue = articulo.Marca.Id;
                    txtPrecio.Text = articulo.Precio.ToString();
                    txtUrlImagen.Text = articulo.UrlImagen.ImagenUrl;
                    cargarImagen(articulo.UrlImagen.ImagenUrl);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                //throw
            }
        }

        

        private void cargarImagen(string imagen)
        {
            try
            {
                pbxArticulo.Load(imagen);
            }
            catch (Exception)
            {

                pbxArticulo.Load("https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSDQQGGvsya8PwOD-0KOh6bClw8zRFxEpUaIWvZawv5IdEHPdLMs6C4DalMrGeinUXpp4I&usqp=CAU");
            }

        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 59) && e.KeyChar != 8)
                e.Handled = true;
        }

        /*
        private void txtUrlImagen_Leave(object sender, EventArgs e)
        {
            cargarImagen(txtUrlImagen.Text);
            ValidarCampo(txtUrlImagen);
        }

        private void txtCodigo_Leave(object sender, EventArgs e)
        {
            ValidarCampo(txtCodigo);

        }

        private void ValidarCampo(TextBox campo)
        {
            

            if (campo.Text.Trim() == "")
            {

                campo.BackColor = Color.Red;
                
            }
            else
            {
                campo.BackColor = System.Drawing.SystemColors.Control;
                

            }
        }

        private void txtNombre_Leave(object sender, EventArgs e)
        {
            ValidarCampo(txtNombre);
        }

        private void txtDescripcion_Leave(object sender, EventArgs e)
        {
            ValidarCampo(txtDescripcion);
        }

        private void txtPrecio_Leave(object sender, EventArgs e)
        {
            ValidarCampo(txtPrecio);
        }
        */

        // Metodo controla que los campos esten llenos para habilitar boton ACEPTAR
        private void controlAceptar()
        {
            if (!string.IsNullOrWhiteSpace(txtCodigo.Text)
                && !string.IsNullOrWhiteSpace(txtNombre.Text)
                && !string.IsNullOrWhiteSpace(txtDescripcion.Text)
                && !string.IsNullOrWhiteSpace(txtPrecio.Text)
                && !string.IsNullOrWhiteSpace(txtUrlImagen.Text))
            {
                btnAceptar.Enabled = true;
            }
            else
            {
                btnAceptar.Enabled = false;
            }
        }

        // Metodo indica si un campo obligatorio esta vacio mostrando asterisco rojo (OPCIONAL)
        private void indicarObligatorio()
        {
            if (string.IsNullOrWhiteSpace(txtCodigo.Text))
            {
                lblCodigoRojo.Visible = true;
            }
            else
            {
                lblCodigoRojo.Visible = false;
            }

            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                lblNombreRojo.Visible = true;
            }
            else
            {
                lblNombreRojo.Visible = false;

            }

            if (string.IsNullOrWhiteSpace(txtDescripcion.Text))
            {
                lblDescripcionRojo.Visible = true;
            }
            else
            {
                lblDescripcionRojo.Visible = false;
            }

            if (string.IsNullOrWhiteSpace(txtPrecio.Text))
            {
                lblPrecioRojo.Visible = true;
            }
            else
            {
                lblPrecioRojo.Visible = false;
            }

            if (string.IsNullOrWhiteSpace(txtUrlImagen.Text))
            {
                lblUrlImagenRojo.Visible = true;
            }
            else
            {
                lblUrlImagenRojo.Visible = false;
            }

        }

        // Eventos Varios
        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            indicarObligatorio();
            controlAceptar();
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            indicarObligatorio();
            controlAceptar();
        }

        private void txtDescripcion_TextChanged(object sender, EventArgs e)
        {
            indicarObligatorio();
            controlAceptar();
        }

        private void txtPrecio_TextChanged(object sender, EventArgs e)
        {
            indicarObligatorio();
            controlAceptar();
        }

        private void txtUrlImagen_TextChanged(object sender, EventArgs e)
        {
            indicarObligatorio();
            controlAceptar();
            cargarImagen(txtUrlImagen.Text);
        }
    }
}
