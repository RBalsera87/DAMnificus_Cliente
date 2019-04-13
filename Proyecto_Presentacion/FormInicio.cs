using System;
using System.Windows.Forms;
using Proyecto_Negocio;
using System.Collections.Generic;

namespace Proyecto_Presentacion
{
    public partial class FormInicio : Form
    {
        MetodosFormInicio m = new MetodosFormInicio();
        private ToolTip toolTipNombre = new ToolTip();
        private ToolTip toolTipApellidos = new ToolTip();
        private ToolTip toolTipEmail = new ToolTip();
        private ToolTip toolTipUsuario = new ToolTip();
        private ToolTip toolTipPass1 = new ToolTip();
        private ToolTip toolTipPass2 = new ToolTip();
        private ToolTip toolTipToken = new ToolTip();

        private bool nombreValido = false;
        private bool apellidosValido = false;
        private bool emailValido = false;
        private bool userValido = false;
        private bool passValido = false;

        private string token = "";

        public FormInicio()
        {
            InitializeComponent();
            this.DoubleBuffered = true;

        }

        /****************************
         * Eventos para los botones *
         ****************************/
        private void btnRegistro_Click(object sender, EventArgs e)
        {
            this.panelInicio.Visible = false;
            this.panelRegistro.Visible = true;
            this.tbNombre.Focus();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.panelInicio.Visible = true;
            this.panelRegistro.Visible = false;
            resetearTextboxes();
            resetearPictureBoxes();
            resetearTooltips();
        }

        private async void btnAceptar_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> datos = new Dictionary<string, string>();
            datos.Add("nombre", tbNombre.Text);
            datos.Add("apellidos", tbApellidos.Text);
            datos.Add("email", tbEmail.Text);

            string respuesta = await m.enviarEmailparaRegistro(tbUsuario.Text, tbPass.Text, datos);
            if (respuesta.Equals("emailNoEnviado")) 
            {
                MessageBox.Show("Error al enviar el email, ver consola de servidor");
            }
            else
            {
                this.panelRegistro.Visible = false;
                this.panelToken.Visible = true;
                token = respuesta;
                resetearTextboxes();
                resetearPictureBoxes();
                resetearTooltips();
            }

        }
        private void btnAceptarToken_Click(object sender, EventArgs e)
        {
            this.panelInicio.Visible = true;
            this.panelToken.Visible = false;
            // Meter al usuario en BBDD
            this.lblBienvenido.Text = "¡Usuario registrado exitósamente!";
            this.btnRegistro.Visible = false;
            // else this.lblBienvenido.Text = "¡Error al registrar usuario";
        }

        private void btnCancelarToken_Click(object sender, EventArgs e)
        {
            this.panelInicio.Visible = true;
            this.panelToken.Visible = false;
        }

        /******************************
         * Eventos para los textboxes *
         ******************************/
        private void tbNombre_Leave(object sender, EventArgs e)
        {
            if (this.tbNombre.Text == "")
            {
                this.pbName.Image = Proyecto_Presentacion.Properties.Resources.problem;
                this.toolTipNombre.SetToolTip(pbName, "Debes rellenar el nombre");
                this.toolTipNombre.Show("Debes rellenar el nombre",this.tbNombre,1000);
                this.nombreValido = false;
            }
            else
            {
                this.pbName.Image = Proyecto_Presentacion.Properties.Resources.ok;
                this.toolTipNombre.SetToolTip(pbName, "Correcto");
                this.nombreValido = true;
            }
            activarBotonAceptar();
        }

        private void tbApellido_Leave(object sender, EventArgs e)
        {
            if (this.tbApellidos.Text == "")
            {
                this.pbApell.Image = Proyecto_Presentacion.Properties.Resources.problem;
                this.toolTipApellidos.SetToolTip(pbApell, "Debes rellenar tus apellidos");
                this.toolTipNombre.Show("Debes rellenar tus apellidos", this.tbApellidos, 1000);
                this.apellidosValido = false;
            }
            else
            {
                this.pbApell.Image = Proyecto_Presentacion.Properties.Resources.ok;
                this.toolTipApellidos.SetToolTip(pbApell, "Correcto");
                this.apellidosValido = true;
            }
            activarBotonAceptar();
        }

        private void tbEmail_Leave(object sender, EventArgs e)
        {
            if (this.tbEmail.Text == "")
            {
                this.pbEmail.Image = Proyecto_Presentacion.Properties.Resources.problem;
                this.toolTipEmail.SetToolTip(pbEmail, "Debes poner una direccion email");
                this.toolTipNombre.Show("Debes poner una direccion email", this.tbEmail, 1000);
                this.emailValido = false;
            }
            else
            {

                if (m.comprobarEmailValido(this.tbEmail.Text))
                {
                    //Aqui se debe comprobar k no exista en la base de datos
                    //si no existe se pone OK
                    //si existe imagen error
                    this.pbEmail.Image = Proyecto_Presentacion.Properties.Resources.ok;
                    this.toolTipEmail.SetToolTip(pbEmail, "Correcto");
                    this.emailValido = true;
                }
                else
                {
                    this.pbEmail.Image = Proyecto_Presentacion.Properties.Resources.error;
                    this.toolTipEmail.SetToolTip(pbEmail, "Esta direccion email no parece válida");
                    this.toolTipNombre.Show("Esta direccion email no parece válida", this.tbEmail, 1000);
                    this.emailValido = false;
                }
                activarBotonAceptar();
            }
            
        }

        private void tbUsuario_Leave(object sender, EventArgs e)
        {
            if (this.tbUsuario.Text == "")
            {
                this.pbUser.Image = Proyecto_Presentacion.Properties.Resources.problem;
                this.toolTipUsuario.SetToolTip(pbUser, "Debes poner un nombre de usuario");
                this.toolTipNombre.Show("Debes poner un nombre de usuario", this.tbUsuario, 1000);
                this.userValido = false;
            }
            else
            {
                //Aqui se debe comprobar k no exista en la base de datos
                //si no existe se pone OK
                //si existe imagen error
                this.pbUser.Image = Proyecto_Presentacion.Properties.Resources.ok;
                this.toolTipUsuario.SetToolTip(pbUser, "Correcto");
                this.userValido = true;
            }
            activarBotonAceptar();
        }
        private void tbPass_Leave(object sender, EventArgs e)
        {
            if (this.tbPass.Text == "")
            {
                this.pbPass1.Image = Proyecto_Presentacion.Properties.Resources.problem;
                this.toolTipPass1.SetToolTip(pbPass1, "Debes poner una contraseña");
                this.toolTipNombre.Show("Debes poner una contraseña", this.tbPass, 1000);
            }
            else
            {
                //Si el password es valido se pon ok
                this.pbPass1.Image = Proyecto_Presentacion.Properties.Resources.ok;
                this.toolTipPass1.SetToolTip(pbPass1, "Correcto");;
            }
            activarBotonAceptar();
        }
        private void tbPass2_Leave(object sender, EventArgs e)
        {
            if (this.tbPass2.Text == "")
            {
                this.pbPass2.Image = Proyecto_Presentacion.Properties.Resources.problem;
                this.toolTipPass2.SetToolTip(pbPass2, "Vuelve a escribir la contraseña");
                this.toolTipNombre.Show("Vuelve a escribir la contraseña", this.tbPass2, 1000);
                passValido = false;
            }
            else if (!this.tbPass.Text.Equals(this.tbPass2.Text))
            {
                this.pbPass2.Image = Proyecto_Presentacion.Properties.Resources.error;
                this.toolTipPass2.SetToolTip(pbPass2, "Las contraseñas no coinciden");
                this.toolTipNombre.Show("Las contraseñas no coinciden", this.tbPass2, 1000);
                passValido = false;
            }
            activarBotonAceptar();
        }
        private void tbPass2_TextChanged(object sender, EventArgs e)
        {
            if (this.tbPass2.Text.Equals(this.tbPass.Text))
            {
                this.pbPass2.Image = Proyecto_Presentacion.Properties.Resources.ok;
                this.toolTipPass2.SetToolTip(pbPass2, "Correcto");
                passValido = true;
            }else
            {
                passValido = false;
            }
            activarBotonAceptar();
        }

       /**********************************************
        * Métodos internos para el Formulario Inicio *
        **********************************************/
        private void activarBotonAceptar()
        {
            if (nombreValido && apellidosValido && emailValido && userValido && passValido)
            {
                this.btnAceptar.Enabled = true;
            }
            else
            {
                this.btnAceptar.Enabled = false;
            }
        }
        private void resetearTooltips()
        {
            this.toolTipNombre.SetToolTip(pbName, "");
            this.toolTipApellidos.SetToolTip(pbApell, "");
            this.toolTipEmail.SetToolTip(pbEmail, "");
            this.toolTipUsuario.SetToolTip(pbUser, "");
            this.toolTipPass1.SetToolTip(pbPass1, "");
            this.toolTipPass2.SetToolTip(pbPass2, "");
        }
        private void resetearTextboxes()
        {
            this.tbNombre.Clear();
            this.tbApellidos.Clear();
            this.tbEmail.Clear();
            this.tbUsuario.Clear();
            this.tbPass.Clear();
            this.tbPass2.Clear();
        }
        private void resetearPictureBoxes()
        {
            this.pbName.Image = null;
            this.pbApell.Image = null;
            this.pbEmail.Image = null;
            this.pbUser.Image = null;
            this.pbPass1.Image = null;
            this.pbPass2.Image = null;
        }

        private void tbToken_TextChanged(object sender, EventArgs e)
        {
            if (tbToken.Text.Length > 0 && tbToken.Text.Equals(token))
            {
                this.pbToken.Image = Proyecto_Presentacion.Properties.Resources.ok;
                this.toolTipToken.SetToolTip(pbToken, "Token correcto");
                btnAceptarToken.Enabled = true;
            }else
            {
                this.pbToken.Image = Proyecto_Presentacion.Properties.Resources.error;
                this.toolTipToken.SetToolTip(pbToken, "El token no parece válido");
                this.toolTipToken.Show("El token no parece válido", this.tbToken, 1000);
                btnAceptarToken.Enabled = false;
            }
        }

        private void FormInicio_Load(object sender, EventArgs e)
        {
            if (!UsuarioConectado.nombre.Equals("invitado"))
            {
                this.btnRegistro.Visible = false;
            }
        }
    }
    
}
