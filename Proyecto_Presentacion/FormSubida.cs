using Proyecto_Negocio;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Proyecto_Presentacion
{
    public partial class FormSubida : Form
    {
        MetodosFormSubida m = new MetodosFormSubida();
        private bool tituloOk = false;
        private bool enlaceOk = false;
        private bool descripcionOk = false;
        private bool temaOk = false;
        List<string> listaAsignaturas, listaTemas;

        public FormSubida()
        {
            InitializeComponent();
        }
        private void FormSubida_Load(object sender, EventArgs e)
        {
            
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
            tablePanel.ColumnStyles[1].Width = 30;
            this.btnExpandir.Visible = false;
            this.btnContraer.Visible = true;
        }
        private async void btnSubirEnlace_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> datos = new Dictionary<string, string>();
            datos.Add("titulo", tbTitulo.Text.Trim());
            if (tbImagen.Text.Trim().Length > 0)
                datos.Add("imagen", tbImagen.Text.Trim());
            else
                datos.Add("imagen", "");
            datos.Add("descripcion", tbDescripcion.Text.Trim());
            datos.Add("enlace", tbEnlace.Text.Trim());
            var tipoSeleccionado = groupBoxTipo.Controls.OfType<RadioButton>()
                                      .FirstOrDefault(r => r.Checked);
            datos.Add("tipo", tipoSeleccionado.Text);
            datos.Add("tema", lbTema.GetItemText(lbTema.SelectedItem));
            if (await m.enviarNuevoEnlace(UsuarioConectado.nombre, datos))
            {
                MsgBox.Show("El enlace ha sido subido satisfactoriamente a la base de datos. Por el momento no será visible " +
                    "hasta que un administrador lo revise y lo active si todo es correcto.",
                    "Enlace subido", MsgBox.Buttons.OK, MsgBox.Icon.Info, MsgBox.AnimateStyle.FadeIn);
                tbTitulo.Clear();
                tbImagen.Clear();
                tbDescripcion.Clear();
                tbEnlace.Clear();
                lbAsignatura.Items.Clear();
                lbTema.Items.Clear();
                radioButtonPrimero.Checked = radioButtonSegundo.Checked = false;
                btnSubirEnlace.Enabled = false;
            }                                 
            else
                MsgBox.Show("Error al subir el enlace en la base de datos, comprueba que los campos esten correctamente rellenos.", 
                    "Enlace no subido", MsgBox.Buttons.OK, MsgBox.Icon.Warning, MsgBox.AnimateStyle.FadeIn);
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
            comprobarActivarBoton();
        }
        private void tbTitulo_Leave(object sender, EventArgs e)
        {
            tbTitulo_TextChanged(this, new EventArgs());
        }
        
        private void tbImagen_TextChanged(object sender, EventArgs e)
        {
            if (tbImagen.Text.Trim().Length > 0)
                pbImagen.Visible = true;
            else
                pbImagen.Visible = false;
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
            comprobarActivarBoton();
        }
        private void tbDescripcion_Leave(object sender, EventArgs e)
        {
            tbDescripcion_TextChanged(this, new EventArgs());
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
            comprobarActivarBoton();
        }
        private void tbEnlace_Leave(object sender, EventArgs e)
        {
            tbEnlace_TextChanged(this, new EventArgs());
        }
        private async void radioButtonPrimero_CheckedChanged(object sender, EventArgs e)
        {
            lbTema.Items.Clear();
            temaOk = false;
            btnSubirEnlace.Enabled = false;
            if (radioButtonPrimero.Checked)
            {
                lbAsignatura.Items.Clear();
                listaAsignaturas = await m.obtenerAsignaturas(UsuarioConectado.nombre, 1);
                foreach ( string asign in listaAsignaturas)
                {
                    lbAsignatura.Items.Add(asign);
                }
                lbAsignatura.Enabled = true;            
            }
        }
        private async void radioButtonSegundo_CheckedChanged(object sender, EventArgs e)
        {
            lbTema.Items.Clear();
            temaOk = false;
            btnSubirEnlace.Enabled = false;
            if (radioButtonSegundo.Checked)
            {
                lbAsignatura.Items.Clear();
                listaAsignaturas = await m.obtenerAsignaturas(UsuarioConectado.nombre, 2);
                foreach (string asign in listaAsignaturas)
                {
                    lbAsignatura.Items.Add(asign);
                }
                lbAsignatura.Enabled = true;
            }
        }
        private async void lbAsignatura_SelectedIndexChanged(object sender, EventArgs e)
        {
            temaOk = false;
            btnSubirEnlace.Enabled = false;
            lbTema.Items.Clear();
            string asignatura = lbAsignatura.GetItemText(lbAsignatura.SelectedItem);
            listaTemas = await m.obtenerTemas(UsuarioConectado.nombre, asignatura);
            foreach (string tema in listaTemas)
            {
                lbTema.Items.Add(tema);
            }
            lbTema.Enabled = true;            
        }

        private void lbTema_SelectedIndexChanged(object sender, EventArgs e)
        {
            temaOk = true;
            comprobarActivarBoton();
        }
        private void listBoxes_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0) return;
            bool seleccionado = false;
            string listBox = "";
            // Evalua que listBox hay que dibujar
            if (sender.Equals(lbAsignatura))
                listBox = lbAsignatura.Items[e.Index].ToString();            
            else if (sender.Equals(lbTema))
                listBox = lbTema.Items[e.Index].ToString();            
            // Si se selecciona un elemento, cambia el color de fondo.
            if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
            {
                seleccionado = true;
                e = new DrawItemEventArgs(e.Graphics,
                                         e.Font,
                                         e.Bounds,
                                         e.Index,
                                         e.State ^ DrawItemState.Selected,
                                         e.ForeColor,
                                         Color.FromArgb(255, 153, 39));// Color seleccionado
            }
               
            // Dibuja el fondo del control ListBox para cada elemento.
            e.DrawBackground();
            // Dibuja el texto del elemento actual
            if (seleccionado)
                e.Graphics.DrawString(listBox, e.Font, Brushes.Black, e.Bounds, StringFormat.GenericDefault);
            else
                e.Graphics.DrawString(listBox, e.Font, Brushes.DarkGray, e.Bounds, StringFormat.GenericDefault);
            // Si el cuadro de lista tiene el foco, dibuja un rectángulo alrededor del elemento seleccionado.
            e.DrawFocusRectangle();
        }
        private void comprobarActivarBoton()
        {
            if (tituloOk && descripcionOk && enlaceOk && temaOk)
                btnSubirEnlace.Enabled = true;
            else
                btnSubirEnlace.Enabled = false;
        }
    }
}
