using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Negocio
{
    
    public class Metodos
    {
        /****************************************
         * Métodos para el Formulario Principal *
         ****************************************/
        public void abrirFormEnPanel(object formHijo, Panel panelContenido)
        {
            if (panelContenido.Controls.Count > 0)
            {
                panelContenido.Controls.RemoveAt(0);
            }
            Form fh = formHijo as Form;
            fh.TopLevel = false;
            fh.FormBorderStyle = FormBorderStyle.None;
            fh.Dock = DockStyle.Fill;
            panelContenido.Controls.Add(fh);
            panelContenido.Tag = fh;
            fh.Show();
        }
        public void ocultarLogin(Timer tmOcultarLogin)
        {
            tmOcultarLogin.Enabled = true;
        }
        public void mostrarLogin(Timer tmMostrarLogin)
        {
            tmMostrarLogin.Enabled = true;
        }
        public void restaurarColorBotones(Panel menuLateral)
        {
            List<Button> botones = menuLateral.Controls.OfType<Button>().ToList();
            foreach (Button btn in botones)
            {
                btn.BackColor = Color.FromArgb(32, 32, 32);
            }
        }

    }
}
