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
    public partial class FrmImagen : Form
    {
        private List<Imagen> ListaImagen;
        public FrmImagen()
        {
            InitializeComponent();
        }

        private void Cargar()
        {
            ImagenNegocio negocio = new ImagenNegocio();
            ListaImagen = negocio.Listar();
            dgvImagenes.DataSource = ListaImagen;
            dgvImagenes.Columns["ImagenUrl"].Width = 280;
            dgvImagenes.Columns["IdArticulo"].Width = 70;
            dgvImagenes.Columns["Id"].Visible = false;
            pbxImagen.Load(ListaImagen[0].ImagenUrl.ToString());
        }

        private void FrmImagen_Load(object sender, EventArgs e)
        {
            Cargar();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FrmAltaImagen FrmAltaImagen = new FrmAltaImagen();
            FrmAltaImagen.ShowDialog();
            Cargar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvImagenes.CurrentRow == null || dgvImagenes.CurrentRow.DataBoundItem == null)
            {
                MessageBox.Show("Por favor seleccione una url de la lista",
                              "Selección requerida",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Warning);
                return;
            }
            ImagenNegocio negocio = new ImagenNegocio();
            Imagen seleccionado;
            try
            {
                DialogResult respuesta = MessageBox.Show("¿Esta seguro que quiere eliminar este articulo?", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (respuesta == DialogResult.Yes)
                {
                    seleccionado = (Imagen)dgvImagenes.CurrentRow.DataBoundItem;
                    negocio.EliminarImagen(seleccionado.Id);
                    Cargar();
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvImagenes.CurrentRow == null || dgvImagenes.CurrentRow.DataBoundItem == null)
            {
                MessageBox.Show("Por favor seleccione un url de la lista",
                          "Selección requerida",
                          MessageBoxButtons.OK,
                          MessageBoxIcon.Warning);
                return;
            }
            Imagen seleccionada;
            seleccionada = (Imagen)dgvImagenes.CurrentRow.DataBoundItem;

            FrmAltaImagen frmModificar = new FrmAltaImagen(seleccionada);
            frmModificar.ShowDialog();
            Cargar();
        }

        private void dgvImagenes_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvImagenes.CurrentRow != null)
            {
                Imagen seleccionado = (Imagen)dgvImagenes.CurrentRow.DataBoundItem;
                //pbxImagen.Load(seleccionado.ImagenUrl.ToString());
                cargarImagen(seleccionado.ImagenUrl.ToString());
            }
        }

        private void cargarImagen(string imagen)
        {
            try
            {
                pbxImagen.Load(imagen);
            }
            catch (Exception)
            {
                pbxImagen.Load("https://static.vecteezy.com/system/resources/thumbnails/008/695/917/small_2x/no-image-available-icon-simple-two-colors-template-for-no-image-or-picture-coming-soon-and-placeholder-illustration-isolated-on-white-background-vector.jpg");
                //throw;
            }
        }
    }
}
