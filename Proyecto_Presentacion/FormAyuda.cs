using Proyecto_Negocio;
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
    public partial class FormAyuda : Form
    {
        private ToolTip toolTipCambiar1 = new ToolTip();
        private ToolTip toolTipCambiar2 = new ToolTip();
        private ToolTip toolTipCambiar3 = new ToolTip();
        private ToolTip toolTipCurso = new ToolTip();
        private ToolTip toolTipReporte = new ToolTip();
        private ToolTip toolTipEmailToken = new ToolTip();
        private ToolTip toolTipPass1 = new ToolTip();
        private ToolTip toolTipPass2 = new ToolTip();
        public FormAyuda()
        {
            InitializeComponent();
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
        }

        private void FormAyuda_Load(object sender, EventArgs e)
        {
            if (UsuarioConectado.nombre.Equals("invitado"))
            {
                //this.panelCambiarPass.Enabled = false;
                //this.panelReportar.Enabled = false;
                //this.panelCurso.Enabled = false;
            }
            else
            {
                //this.panelPassOlvidada.Enabled = false;
            }
        }

        private void btnContraer_Click(object sender, EventArgs e)
        {
            tablePanel.ColumnStyles[1].SizeType = SizeType.Absolute;
            tablePanel.ColumnStyles[1].Width = 0;
            this.btnExpandir.Visible = true;
        }

        private void btnExpandir_Click(object sender, EventArgs e)
        {
            tablePanel.ColumnStyles[1].SizeType = SizeType.Percent;
            tablePanel.ColumnStyles[1].Width = 40;
            this.btnExpandir.Visible = false;
        }

        private void tbCambiar1_TextChanged(object sender, EventArgs e)
        {
            if (tbCambiar1.Text.Length > 0)
            {
                tbCambiar2.Enabled = tbCambiar3.Enabled = true;
                this.pbCambiar1.Image = Proyecto_Presentacion.Properties.Resources.ok;
                this.toolTipCambiar1.SetToolTip(tbCambiar1, "Correcto");
            }
            else
            {
                tbCambiar2.Enabled = tbCambiar3.Enabled = false;
                this.pbCambiar1.Image = Proyecto_Presentacion.Properties.Resources.problem;
                this.toolTipCambiar1.SetToolTip(pbCambiar1, "Escribe tu contraseña actual");
                this.toolTipCambiar1.Show("Escribe tu contraseña actual", this.tbCambiar1, 1000);
            }
        }
        private void tbCambiar2_Leave(object sender, EventArgs e)
        {
            if (tbCambiar2.Text.Length > 0)
            {
                this.pbCambiar2.Image = Proyecto_Presentacion.Properties.Resources.ok;
                this.toolTipCambiar2.SetToolTip(tbCambiar2, "Correcto");
            }
            else
            {
                this.pbCambiar2.Image = Proyecto_Presentacion.Properties.Resources.problem;
                this.toolTipCambiar2.SetToolTip(pbCambiar2, "Escribe una nueva contraseña");
                this.toolTipCambiar2.Show("Escribe una nueva contraseña", this.tbCambiar2, 1000);
            }
        }

        private void tbCambiar3_TextChanged(object sender, EventArgs e)
        {
            if (tbCambiar3.Text.Equals(tbCambiar2.Text))
            {
                this.btnCambiarPass.Enabled = true;
                this.pbCambiar3.Image = Proyecto_Presentacion.Properties.Resources.ok;
                this.toolTipCambiar3.SetToolTip(tbCambiar3, "Las contraseñas coinciden");
            }
            else
            {
                this.btnCambiarPass.Enabled = false;
                this.pbCambiar3.Image = Proyecto_Presentacion.Properties.Resources.problem;
                this.toolTipCambiar3.SetToolTip(pbCambiar1, "Las contraseñas no coinciden");
                this.toolTipCambiar3.Show("Las contraseñas no coinciden", this.tbCambiar3, 1000);
            }
        }
        private void tbCambiar3_Leave(object sender, EventArgs e)
        {
            if (tbCambiar3.Text.Equals(tbCambiar2.Text))
            {
                this.btnCambiarPass.Enabled = true;
                this.pbCambiar3.Image = Proyecto_Presentacion.Properties.Resources.ok;
                this.toolTipCambiar3.SetToolTip(tbCambiar3, "Las contraseñas coinciden");
            }
            else
            {
                this.btnCambiarPass.Enabled = false;
                this.pbCambiar3.Image = Proyecto_Presentacion.Properties.Resources.problem;
                this.toolTipCambiar3.SetToolTip(pbCambiar1, "Las contraseñas no coinciden");
                this.toolTipCambiar3.Show("Las contraseñas no coinciden", this.tbCambiar3, 1000);
            }
        }
        private void btnCambiarPass_Click(object sender, EventArgs e)
        {
            // comprobar password, si coincide se cambia por el nuevo (1peticion)

        }

        private void tbTituloRep_TextChanged(object sender, EventArgs e)
        {
            if (tbTituloRep.Text.Length > 0 && tbReporte.Text.Length > 0)
            {
                btnEnvReporte.Enabled = true;
            }
            else
            {
                btnEnvReporte.Enabled = false;
            }
        }

        private void tbReporte_TextChanged(object sender, EventArgs e)
        {
            if (tbTituloRep.Text.Length > 0 && tbReporte.Text.Length > 0)
            {
                btnEnvReporte.Enabled = true;
            }
            else
            {
                btnEnvReporte.Enabled = false;
            }
        }
    }
}
