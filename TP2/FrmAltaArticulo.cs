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
        public FrmAltaArticulo()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private async void btnAceptar_Click(object sender, EventArgs e)
        {
            Articulo articuloNuevo = new Articulo();
            ArticuloNegocio negocio = new ArticuloNegocio();

            try
            {
                articuloNuevo.Nombre = txtNombre.Text;
                articuloNuevo.Codigo = txtCodigo.Text;
                articuloNuevo.Descripcion = txtDescripcion.Text;
                articuloNuevo.Marca = (Marca)cbxMarca.SelectedItem;
                articuloNuevo.Categoria = (Categoria)cbxCategoria.SelectedItem;
                articuloNuevo.Precio = decimal.Parse(txtPrecio.Text);

                articuloNuevo.UrlImagen = new Imagen();
                articuloNuevo.UrlImagen.ImagenUrl = txtUrlImagen.Text;

                negocio.AgregarArticulo(articuloNuevo);
                MessageBox.Show("Articulo agregado exitosamente");
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
                cbxMarca.DataSource = marcaNegocio.Listar();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void txtUrlImagen_Leave(object sender, EventArgs e)
        {
            cargarImagen(txtUrlImagen.Text);
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
            if (campo.Text == "")
            {

                campo.BackColor = Color.Red;
                btnAceptar.Enabled = false;
            }
            else
            {
                campo.BackColor = System.Drawing.SystemColors.Control;
                btnAceptar.Enabled = true;

            }
        }
    }
}
