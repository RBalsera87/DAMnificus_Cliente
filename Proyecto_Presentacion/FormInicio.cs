using System;
using System.Windows.Forms;
using Proyecto_Negocio;
using System.Collections.Generic;
using System.Drawing;

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

        private Dictionary<string, string> datos = new Dictionary<string, string>();
        private string usuario, pass;
        private string token = "";

        public FormInicio()
        {
            InitializeComponent();
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.DoubleBuffer, true);
        }
        private Bitmap renderBmp;
        public override Image BackgroundImage
        {
            set
            {
                Image baseImage = value;
                renderBmp = new Bitmap(Width, Height,
                    System.Drawing.Imaging.PixelFormat.Format32bppPArgb);
                Graphics g = Graphics.FromImage(renderBmp);
                g.DrawImage(baseImage, 0, 0, Width, Height);
                g.Dispose();
            }
            get
            {
                return renderBmp;
            }
        }
        /*****************
         * Evento onLoad *
         *****************/
        private void FormInicio_Load(object sender, EventArgs e)
        {
            if (!UsuarioConectado.nombre.Equals("invitado"))
            {
                this.btnRegistro.Visible = false;
            }
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
            datos.Clear();
            datos.Add("nombre", tbNombre.Text);
            datos.Add("apellidos", tbApellidos.Text);
            datos.Add("email", tbEmail.Text);
            usuario = tbUsuario.Text;
            pass = tbPass.Text;

            string respuesta = await m.enviarEmailparaRegistro(usuario, datos);
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
        private async void btnAceptarToken_Click(object sender, EventArgs e)
        {
            this.panelToken.Visible = false;
            this.panelFinal.Visible = true;
            if (await m.enviarConfirmacionRegistro(usuario, pass, datos))
            {
                this.btnRegistro.Visible = false;
                this.lblTituloFinal.Text = "¡Registro completado!";
                this.lblFinal.Text =    "Te damos la bienvenida a nuestra comunidad, esperamos que saques el máximo probecho de sus funciones y te animamos a participar subiendo tus propios enlaces a documentos o videos que puedan ayudar a otros.\n" +
                                        "También te damos acceso al area personal donde podras hacer un seguimiento de tus notas, links subidos y mucho más.\n" +
                                        "Pulsa aceptar para volver a la pantalla de inicio.";
            }else
            {
                this.lblTituloFinal.Text = "¡Error al registrar usuario!";
                this.lblFinal.Text =    "Parece que ha habido un problema al registrar al usuario, puede que el servidor este ocupado y tengas que esperar unos segundos antes de volver ha intentarlo.\n" +
                                        "Si el problema persiste dirígete a la pestaña de ayuda y pulsa sobre informar de un problema. Nos ocuparemos de arreglarlo cuanto antes.";
            }

        }

        private void btnCancelarToken_Click(object sender, EventArgs e)
        {
            this.panelInicio.Visible = true;
            this.tbToken.Clear();
            this.panelToken.Visible = false;
        }
        private void btnAceptarFinal_Click(object sender, EventArgs e)
        {
            this.panelFinal.Visible = false;
            this.panelInicio.Visible = true;
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
                this.toolTipApellidos.Show("Debes rellenar tus apellidos", this.tbApellidos, 1000);
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

        private async void tbEmail_Leave(object sender, EventArgs e)
        {
            string emailIntroducido = this.tbEmail.Text;
            if (emailIntroducido == "")
            {
                this.pbEmail.Image = Proyecto_Presentacion.Properties.Resources.problem;
                this.toolTipEmail.SetToolTip(pbEmail, "Debes poner una direccion email");
                this.toolTipEmail.Show("Debes poner una direccion email", this.tbEmail, 1000);
                this.emailValido = false;
            }
            else
            {

                if (m.comprobarEmailValido(emailIntroducido))
                {
                    //Aqui se comprueba k no exista ya en la base de datos
                    if (await m.buscarEnBD("email", emailIntroducido)) // True = duplicado
                    {
                        this.pbEmail.Image = Proyecto_Presentacion.Properties.Resources.error;
                        this.toolTipEmail.SetToolTip(pbEmail, "Esta direccion email ya esta registrada");
                        this.toolTipEmail.Show("Esta direccion email ya esta registrada", this.tbEmail, 1000);
                        this.emailValido = false;
                    }else
                    {
                        this.pbEmail.Image = Proyecto_Presentacion.Properties.Resources.ok;
                        this.toolTipEmail.SetToolTip(pbEmail, "Correcto");
                        this.emailValido = true;
                    }
                    
                }
                else
                {
                    this.pbEmail.Image = Proyecto_Presentacion.Properties.Resources.problem;
                    this.toolTipEmail.SetToolTip(pbEmail, "Esta direccion email no parece válida");
                    this.toolTipEmail.Show("Esta direccion email no parece válida", this.tbEmail, 1000);
                    this.emailValido = false;
                }
                
            }
            activarBotonAceptar();
        }

        private async void tbUsuario_Leave(object sender, EventArgs e)
        {
            string usuarioIntroducido = this.tbUsuario.Text;
            if (usuarioIntroducido == "")
            {
                this.pbUser.Image = Proyecto_Presentacion.Properties.Resources.problem;
                this.toolTipUsuario.SetToolTip(pbUser, "Debes poner un nombre de usuario");
                this.toolTipUsuario.Show("Debes poner un nombre de usuario", this.tbUsuario, 1000);
                this.userValido = false;
            }
            else
            {
                //Aqui se comprueba k no exista ya en la base de datos
                if (await m.buscarEnBD("user", usuarioIntroducido)) // True = duplicado
                {
                    this.pbUser.Image = Proyecto_Presentacion.Properties.Resources.error;
                    this.toolTipUsuario.SetToolTip(pbUser, "Este nombre de usuario ya esta registrado");
                    this.toolTipUsuario.Show("Este nombre de usuario ya esta registrado", this.pbUser, 1000);
                    this.emailValido = false;
                }
                else
                {
                    this.pbUser.Image = Proyecto_Presentacion.Properties.Resources.ok;
                    this.toolTipUsuario.SetToolTip(pbUser, "Correcto");
                    this.userValido = true;
                }
                
            }
            activarBotonAceptar();
        }
        private void tbPass_Leave(object sender, EventArgs e)
        {
            if (this.tbPass.Text == "")
            {
                this.pbPass1.Image = Proyecto_Presentacion.Properties.Resources.problem;
                this.toolTipPass1.SetToolTip(pbPass1, "Debes poner una contraseña");
                this.toolTipPass1.Show("Debes poner una contraseña", this.tbPass, 1000);
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
                this.toolTipPass2.Show("Vuelve a escribir la contraseña", this.tbPass2, 1000);
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
        private void tbToken_TextChanged(object sender, EventArgs e)
        {
            if (tbToken.Text.Length > 0 && tbToken.Text.Equals(token))
            {
                this.pbToken.Image = Proyecto_Presentacion.Properties.Resources.ok;
                this.toolTipToken.SetToolTip(pbToken, "Token correcto");
                btnAceptarToken.Enabled = true;
            }
            else
            {
                this.pbToken.Image = Proyecto_Presentacion.Properties.Resources.error;
                this.toolTipToken.SetToolTip(pbToken, "El token no parece válido");
                this.toolTipToken.Show("El token no parece válido", this.tbToken, 1000);
                btnAceptarToken.Enabled = false;
            }
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
    
    }
    
}
