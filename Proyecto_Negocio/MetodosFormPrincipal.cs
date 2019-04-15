using Proyecto_AccesoDatos;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Negocio
{
    /****************************************
     * Métodos para el Formulario Principal *
     ****************************************/
    public class MetodosFormPrincipal
    {
        AccesoDatos ad = new AccesoDatos();
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
        public async Task<bool> pedirStatusServidor()
        {
            return await ad.pedirStatusServidor(UsuarioConectado.nombre);
        }
        public async Task<string> conectarConServidor(string usuario, string pass)
        {
            string respuesta = await ad.comenzarLogin(usuario, pass);
            return respuesta;
        }
        public async Task<bool> borrarToken(string usuario)
        {
            bool respuesta = await ad.borrarToken(usuario);
            return respuesta;
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
                if (btn.Name != "btnLogin")
                {
                    btn.BackColor = Color.FromArgb(32, 32, 32);
                }

            }
        }

    }
}