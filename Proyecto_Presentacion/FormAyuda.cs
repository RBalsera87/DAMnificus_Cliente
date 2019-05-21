using Proyecto_Negocio;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Proyecto_Presentacion
{
    public partial class FormAyuda : Form
    {
        MetodosFormAyuda m = new MetodosFormAyuda();
        private ToolTip toolTipCambiar1 = new ToolTip();
        private ToolTip toolTipCambiar2 = new ToolTip();
        private ToolTip toolTipCambiar3 = new ToolTip();
        private ToolTip toolTipReporte = new ToolTip();
        private ToolTip toolTipEmailToken = new ToolTip();
        private ToolTip toolTipPass1 = new ToolTip();
        private ToolTip toolTipPass2 = new ToolTip();
        private Dictionary<string, string> datos = new Dictionary<string, string>();
        private string curso;
        private string token = "";
        private string email = "";
        public FormAyuda()
        {
            InitializeComponent();
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
        }

        private async void FormAyuda_Load(object sender, EventArgs e)
        {
            if (UsuarioConectado.nombre.Equals("invitado"))
            {
                this.panelCambiarPass.Enabled = false;
                this.panelReportar.Enabled = false;
                this.panelCurso.Enabled = false;
            }
            else
            {
                this.panelPassOlvidada.Enabled = false;
                curso = await m.obtenerCurso(UsuarioConectado.nombre);
                if (curso.Equals("curso1")) this.radioButtonPrimero.Checked = true;
                else if (curso.Equals("curso2")) this.radioButtonSegundo.Checked = true;
                else this.radioNinguno.Checked = true;
                this.radioNinguno.CheckedChanged += radioButtons_CheckedChanged;
                this.radioButtonPrimero.CheckedChanged += radioButtons_CheckedChanged;
                this.radioButtonSegundo.CheckedChanged += radioButtons_CheckedChanged;
            }
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

        private void tbCambiar1_TextChanged(object sender, EventArgs e)
        {
            if (tbCambiar1.Text.Length > 0)
            {
                lblCambiar2.Enabled = lblCambiar3.Enabled = tbCambiar2.Enabled = tbCambiar3.Enabled = true;
                this.pbCambiar1.Image = Proyecto_Presentacion.Properties.Resources.ok;
                this.toolTipCambiar1.SetToolTip(tbCambiar1, "Correcto");
            }
            else
            {
                lblCambiar2.Enabled = lblCambiar3.Enabled = tbCambiar2.Enabled = tbCambiar3.Enabled = false;
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
        private async void btnCambiarPass_Click(object sender, EventArgs e)
        {
            string respuesta = await m.cambiarPass(UsuarioConectado.nombre, tbCambiar1.Text, tbCambiar3.Text);
            if (respuesta.Equals("passCambiada"))
            {
                MsgBox.Show("La contraseña se ha cambiado satisfactoriamente.", "Contraseña actualizada", MsgBox.Buttons.OK, MsgBox.Icon.Info, MsgBox.AnimateStyle.FadeIn);
                this.tbCambiar1.Clear();
                this.tbCambiar2.Clear();
                this.tbCambiar3.Clear();
            }
            else if (respuesta.Equals("passNoCambiada"))
            {
                MsgBox.Show("Ha habido un problema al guardar la nueva contraseña.", "Contraseña no actualizada", MsgBox.Buttons.OK, MsgBox.Icon.Error, MsgBox.AnimateStyle.FadeIn);
            }
            else if (respuesta.Equals("passNoValida"))
            {
                MsgBox.Show("La contraseña actual que has introducido es incorrecta.", "Contraseña no actualizada", MsgBox.Buttons.OK, MsgBox.Icon.Exclamation, MsgBox.AnimateStyle.FadeIn);
                this.tbCambiar1.Text = "";
            }
            else if (respuesta.Equals("tokenNoValido"))
            {
                MsgBox.Show("El token de sesión de tu usuario no parece valido, cierra sesión y vuelve a conectarte.", "Contraseña no actualizada", MsgBox.Buttons.OK, MsgBox.Icon.Warning, MsgBox.AnimateStyle.FadeIn);
            }
            else
            {
                MsgBox.Show("El servidor no responde, por favor revisa tu conexión a internet.", "Contraseña no actualizada", MsgBox.Buttons.OK, MsgBox.Icon.Warning, MsgBox.AnimateStyle.FadeIn);
            }
            btnCambiarPass.Enabled = false;
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

        private async void btnCurso_Click(object sender, EventArgs e)
        {
            curso = await m.obtenerCurso(UsuarioConectado.nombre);
            string mensaje = "Error al cambiar el curso";
            if (curso.Equals("curso1") || curso.Equals("curso2"))
            {
                if (MsgBox.Show("Tienes notas de tu curso guardadas en la base de datos. ¿Ahora con el cambio quieres borrarlas?", "¿Que es lo que quieres que hagamos?", MsgBox.Buttons.YesNo, MsgBox.Icon.Question, MsgBox.AnimateStyle.FadeIn) == DialogResult.Yes)
                {
                    await m.borrarNotas(UsuarioConectado.nombre, curso);
                }
            }
            if (this.radioButtonPrimero.Checked)
            {
                if (curso.Equals("curso1")) mensaje = "Ya tienes primero como curso actual";
                else if (await m.cambiarCurso(UsuarioConectado.nombre, "curso1")) mensaje = "Cambiado a primer curso";
            }
            else if (this.radioButtonSegundo.Checked)
            {
                if (curso.Equals("curso2")) mensaje = "Ya tienes segundo como curso actual";
                else if (await m.cambiarCurso(UsuarioConectado.nombre, "curso2")) mensaje = "Cambiado a segundo curso";
            }
            else
            {
                if (curso.Equals("curso0")) mensaje = "Actualmente no tienes un curso asignado";
                else if (await m.cambiarCurso(UsuarioConectado.nombre, "curso0")) mensaje = "Cambiado a ningun curso";
            }
            MsgBox.Show(mensaje, "Curso cambiado", MsgBox.Buttons.OK, MsgBox.Icon.Exclamation, MsgBox.AnimateStyle.FadeIn);
        }

        private async void btnEnvReporte_Click(object sender, EventArgs e)
        {
            this.btnEnvReporte.Enabled = false;
            datos.Clear();
            datos.Add("titulo", tbTituloRep.Text);
            datos.Add("reporte", tbReporte.Text);
            if (await m.enviarEmailReporte(UsuarioConectado.nombre, datos))
            {
                MsgBox.Show("El reporte ha sido enviado satisfactoriamente, gracias por tu aportación", "Reporte enviado", MsgBox.Buttons.OK, MsgBox.Icon.Info, MsgBox.AnimateStyle.FadeIn);
                this.tbTituloRep.Clear();
                this.tbReporte.Clear();
            }
            else
            {
                MsgBox.Show("El reporte no se ha podido enviar debido a un error", "Reporte no enviado", MsgBox.Buttons.OK, MsgBox.Icon.Error, MsgBox.AnimateStyle.FadeIn);
                this.btnEnvReporte.Enabled = true;
            }
        }

        private void radioButtons_CheckedChanged(object sender, EventArgs e)
        {
            this.btnCurso.Enabled = true;
        }

        private void tbEmailToken_TextChanged(object sender, EventArgs e)
        {
            if (this.lblEmailToken.Text.Equals("Email"))
            {
                if (tbEmailToken.Text.Length > 0)
                {
                    if (m.comprobarEmailValido(tbEmailToken.Text))
                    {
                        this.pbEmailToken.Image = Proyecto_Presentacion.Properties.Resources.ok;
                        this.toolTipEmailToken.SetToolTip(tbEmailToken, "Correcto");
                        this.btnEnviarEmailToken.Enabled = true;
                    }
                    else
                    {
                        this.pbEmailToken.Image = Proyecto_Presentacion.Properties.Resources.problem;
                        this.toolTipEmailToken.SetToolTip(pbEmailToken, "Introduce un email válido");
                        this.btnEnviarEmailToken.Enabled = false;
                    }

                }
                else
                {
                    this.pbEmailToken.Image = Proyecto_Presentacion.Properties.Resources.problem;
                    this.toolTipEmailToken.SetToolTip(pbEmailToken, "Introduce tu email");
                    this.toolTipEmailToken.Show("Introduce tu email", this.tbEmailToken, 1000);
                    this.btnEnviarEmailToken.Enabled = false;
                }
            }
            else
            {
                if (tbEmailToken.Text.Length > 0 && tbEmailToken.Text.Equals(token))
                {
                    this.pbEmailToken.Image = Proyecto_Presentacion.Properties.Resources.ok;
                    this.toolTipEmailToken.SetToolTip(tbEmailToken, "Correcto");
                    this.lblPass.Enabled = this.lblPass2.Enabled = this.tbPass.Enabled = this.tbPass2.Enabled = true;

                }
                else
                {
                    this.pbEmailToken.Image = Proyecto_Presentacion.Properties.Resources.error;
                    this.toolTipEmailToken.SetToolTip(pbEmailToken, "El token no parece válido");
                    this.toolTipEmailToken.Show("El token no parece válido", this.pbEmailToken, 1000);
                    this.lblPass.Enabled = this.lblPass2.Enabled = this.tbPass.Enabled = this.tbPass2.Enabled = false;
                }
            }


        }

        private async void btnEnviarEmailToken_Click(object sender, EventArgs e)
        {
            this.btnEnviarEmailToken.Enabled = false;
            if (lblEmailToken.Text.Equals("Email"))
            {
                email = tbEmailToken.Text;
                if (await m.buscarEmailEnBD(email))
                {
                    datos.Clear();
                    datos.Add("email", email);
                    string respuesta = await m.enviarEmailPassPerdida(UsuarioConectado.nombre, datos);
                    if (respuesta.Equals("emailNoEnviado"))
                    {
                        MsgBox.Show("El correo no se ha podido enviar debido a un error.", "Email no enviado", MsgBox.Buttons.OK, MsgBox.Icon.Error, MsgBox.AnimateStyle.FadeIn);
                    }
                    else
                    {
                        MsgBox.Show("El correo se ha mandado satisfactoriamente, revisa tu correo para copiar el token.", "Email enviado", MsgBox.Buttons.OK, MsgBox.Icon.Info, MsgBox.AnimateStyle.FadeIn);
                        token = respuesta;
                        this.btnEnviarEmailToken.Text = "Cambiar contraseña";
                        this.lblEmailToken.Text = "Token";
                        this.tbEmailToken.Clear();
                        this.pbEmailToken.Image = Proyecto_Presentacion.Properties.Resources.problem;
                        this.toolTipEmailToken.SetToolTip(pbEmailToken, "Introduce el token");
                        this.toolTipEmailToken.Show("Introduce el token", this.tbEmailToken, 1000);

                    }
                }
                else
                {
                    MsgBox.Show("Esa dirección de correo no esta registrada en nuestra aplicación.", "Email enviado", MsgBox.Buttons.OK, MsgBox.Icon.Exclamation, MsgBox.AnimateStyle.FadeIn);

                    this.btnEnviarEmailToken.Enabled = true;
                }

            }
            else
            {
                if (await m.restaurarPass(email, tbPass2.Text))
                {
                    MsgBox.Show("La contraseña se ha cambiado satisfactoriamente.", "Contraseña actualizada", MsgBox.Buttons.OK, MsgBox.Icon.Info, MsgBox.AnimateStyle.FadeIn);

                    token = email = "";
                    this.tbPass.Clear();
                    this.tbPass2.Clear();
                    this.tbEmailToken.Clear();
                    this.pbEmailToken.Visible = false;
                    this.pbPass.Visible = false;
                    this.pbPass2.Visible = false;
                    this.panelPassOlvidada.Enabled = false;
                }
                else
                {
                    MsgBox.Show("Ha habido un problema al restaurar la contraseña.", "Contraseña no restaurada", MsgBox.Buttons.OK, MsgBox.Icon.Error, MsgBox.AnimateStyle.FadeIn);
                    this.btnEnviarEmailToken.Enabled = true;
                }
            }
        }

        private void tbPass_Leave(object sender, EventArgs e)
        {
            if (tbPass.Text.Length > 0)
            {
                this.pbPass.Image = Proyecto_Presentacion.Properties.Resources.ok;
                this.toolTipPass1.SetToolTip(tbPass, "Correcto");
            }
            else
            {
                this.pbPass.Image = Proyecto_Presentacion.Properties.Resources.problem;
                this.toolTipPass1.SetToolTip(pbPass, "Escribe una nueva contraseña");
                this.toolTipPass1.Show("Escribe una nueva contraseña", this.tbPass, 1000);
            }
        }

        private void tbPass2_TextChanged(object sender, EventArgs e)
        {
            if (tbPass2.Text.Equals(tbPass.Text))
            {
                this.btnEnviarEmailToken.Enabled = true;
                this.pbPass2.Image = Proyecto_Presentacion.Properties.Resources.ok;
                this.toolTipPass2.SetToolTip(tbPass2, "Las contraseñas coinciden");
            }
            else
            {
                this.btnEnviarEmailToken.Enabled = false;
                this.pbPass2.Image = Proyecto_Presentacion.Properties.Resources.problem;
                this.toolTipPass2.SetToolTip(pbPass2, "Las contraseñas no coinciden");
                this.toolTipPass2.Show("Las contraseñas no coinciden", this.tbPass2, 1000);
            }
        }

        private void tbPass2_Leave(object sender, EventArgs e)
        {
            if (tbPass2.Text.Equals(tbPass.Text))
            {
                this.btnEnviarEmailToken.Enabled = true;
                this.pbPass2.Image = Proyecto_Presentacion.Properties.Resources.ok;
                this.toolTipPass2.SetToolTip(tbPass2, "Las contraseñas coinciden");
            }
            else
            {
                this.btnEnviarEmailToken.Enabled = false;
                this.pbPass2.Image = Proyecto_Presentacion.Properties.Resources.problem;
                this.toolTipPass2.SetToolTip(pbPass2, "Las contraseñas no coinciden");
                this.toolTipPass2.Show("Las contraseñas no coinciden", this.tbPass2, 1000);
            }
        }
    }
}
