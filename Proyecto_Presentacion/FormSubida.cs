using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Presentacion
{
    public partial class FormSubida : Form
    {
        private bool tituloOk = false;
        private bool imagenOk = false;
        private bool enlaceOk = false;
        private bool descripcionOk = false;
        private bool temaOk = false;

        public FormSubida()
        {
            InitializeComponent();
        }
        private void btnContraer_Click(object sender, EventArgs e)
        {
            tablePanel.ColumnStyles[1].SizeType = SizeType.Absolute;
            tablePanel.ColumnStyles[1].Width = 0;
            this.btnExpandir.Visible = true;
            this.btnContraer.Visible = false;
        }

        private void btnExpandir_Click(object sender, EventArgs e)
        {
            tablePanel.ColumnStyles[1].SizeType = SizeType.Percent;
            tablePanel.ColumnStyles[1].Width = 40;
            this.btnExpandir.Visible = false;
            this.btnContraer.Visible = true;
        }
        private void radioButtonPrimero_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void radioButtonSegundo_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void tbTitulo_TextChanged(object sender, EventArgs e)
        {
            if (tbTitulo.Text.Trim().Length > 0)
            {
                tituloOk = true;
                pbTitulo.Image = Proyecto_Presentacion.Properties.Resources.ok;
            }

            else
            {
                tituloOk = false;
                pbTitulo.Image = Proyecto_Presentacion.Properties.Resources.problem;
            }
        }
        private void tbImagen_TextChanged(object sender, EventArgs e)
        {
            if (tbTitulo.Text.Trim().Length > 0) pbImagen.Visible = true;
            else pbImagen.Visible = false;
        }

        private void tbDescripcion_TextChanged(object sender, EventArgs e)
        {
            if (tbDescripcion.Text.Trim().Length > 0)
            {
                descripcionOk = true;
                pbDescripcion.Image = Proyecto_Presentacion.Properties.Resources.ok;
            }
            else
            {
                descripcionOk = false;
                pbDescripcion.Image = Proyecto_Presentacion.Properties.Resources.problem;
            }          
        }
        private void tbEnlace_TextChanged(object sender, EventArgs e)
        {
            if (tbEnlace.Text.Trim().Length > 0)
            {
                enlaceOk = true;
                pbEnlace.Image = Proyecto_Presentacion.Properties.Resources.ok;
            }
            else
            {
                enlaceOk = false;
                pbEnlace.Image = Proyecto_Presentacion.Properties.Resources.problem;
            }
        }
    }
}
