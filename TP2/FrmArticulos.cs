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
                dgvArticulos.DataSource = negocio.Listar();
                dgvArticulos.Columns["Descripcion"].Width = 150; // Ajusto ancho columna Descripcion
                dgvArticulos.Columns["Id"].Visible = false; // Oculto Columna Id
                dgvArticulos.Columns["UrlImagen"].Visible = false; // Oculto Columna ImagenUrl
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                //throw;
            }
        }
    }

    
}
