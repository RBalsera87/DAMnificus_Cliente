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
        public FormAyuda()
        {
            InitializeComponent();
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.DoubleBuffer, true);
        }

        private void FormAyuda_Load(object sender, EventArgs e)
        {
            if (UsuarioConectado.nombre.Equals("invitado"))
            {
                this.panelCambiarPass.Enabled = false;
                this.panelReportar.Enabled = false;
            }
            else
            {
                this.panelPassOlvidada.Enabled = false;
            }
        }
    }
}
