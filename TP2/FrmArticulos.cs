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

namespace TP2
{
    public partial class FrmArticulos : Form
    {
        private List<Articulo> listaArticulos;
        public FrmArticulos()
        {
            InitializeComponent();
        }

        private void FrmArticulos_Load(object sender, EventArgs e)
        {
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
            try
            {   
                /// -- COMBOBOX
                //Filtro:
                cboFiltro.DataSource = categoriaNegocio.Listar();

                // Criterio:
                cboCriterio.Items.Add("Comienza con");
                cboCriterio.Items.Add("Termina con");
                cboCriterio.Items.Add("Contiene");


                /// DataGridView
                ArticuloNegocio negocio = new ArticuloNegocio();
                listaArticulos = negocio.Listar();
                dgvArticulos.DataSource = listaArticulos;
                dgvArticulos.Columns["Descripcion"].Width = 150; // Ajusto ancho columna Descripcion
                dgvArticulos.Columns["Id"].Visible = false; // Oculto Columna Id
                dgvArticulos.Columns["UrlImagen"].Visible = false; // Oculto Columna ImagenUrl

                /// PictureBox
                pbxArticulo.Load(listaArticulos[0].UrlImagen.ToString()); // Cargo imagen
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                //throw;
            }
        }

        private void dgvArticulos_SelectionChanged(object sender, EventArgs e)
        {
            Articulo seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
            cargarImagen(seleccionado.UrlImagen.ToString());
        }

        private void cargarImagen(string imagen)
        {
            try
            {
                pbxArticulo.Load(imagen);
            }
            catch (Exception ex)
            {
                pbxArticulo.Load("https://static.vecteezy.com/system/resources/thumbnails/008/695/917/small_2x/no-image-available-icon-simple-two-colors-template-for-no-image-or-picture-coming-soon-and-placeholder-illustration-isolated-on-white-background-vector.jpg");
                //throw;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FrmAltaArticulo frmAltaArticulo = new FrmAltaArticulo();
            frmAltaArticulo.ShowDialog();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            FrmModificarArt frmModificarArt = new FrmModificarArt();
            frmModificarArt.ShowDialog();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            FrmEliminarArt frmEliminarArticulo = new FrmEliminarArt();
            frmEliminarArticulo.ShowDialog();
        }
    }

    
}
