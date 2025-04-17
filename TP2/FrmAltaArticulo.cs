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
                    cbxCategoria.SelectedValue = articulo.Categoria.Id;
                    cbxMarca.SelectedValue = articulo.Marca.Id;
                    txtPrecio.Text = articulo.Precio.ToString();
                    txtUrlImagen.Text = articulo.UrlImagen.ImagenUrl;
                    cargarImagen(articulo.UrlImagen.ImagenUrl);
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void txtUrlImagen_Leave(object sender, EventArgs e)
        {
            cargarImagen(txtUrlImagen.Text);
            ValidarCampo(txtUrlImagen);
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
    }
}
