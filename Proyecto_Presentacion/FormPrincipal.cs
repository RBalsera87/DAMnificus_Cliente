using System;
using System.Drawing;
using System.Windows.Forms;
using Proyecto_Negocio;
using System.Threading.Tasks;
using System.Threading;
using System.Timers;
using System.Collections.Generic;

namespace Proyecto_Presentacion
{
    /*************************************
     * INTERFAZ DEL FORMULARIO PRINCIPAL *
     *************************************/
    public partial class FormPrincipal : Form
    {
        // Inicialización de la clase de metodos de Negocio
        MetodosFormPrincipal m = new MetodosFormPrincipal();
        // Variable para controlar boton conectar
        private bool conectando = false;
        // Variables para el movimiento del formulario
        private bool agarrado = false;
        private bool maximizado = false;
        private Point puntoInicio = new Point(0, 0);
        // Variables para el cambio de tamaño del formulario
        private int tolerancia = 16;
        private const int WM_NCHITTEST = 132;
        private const int HTBOTTOMRIGHT = 17;
        private Rectangle sizeGripRectangle;
        // Variables para los tooltips de validación
        private ToolTip toolTipUsuario = new ToolTip();
        private ToolTip toolTipPass = new ToolTip();
        // Variables para division del formulario
        private Size oldSize;
        private Point oldPosition;
        // Variable para el efecto sombra del formulario
        private const int CS_DROPSHADOW = 0x20000;
        // Timer para animación de inicio
        System.Windows.Forms.Timer fader = new System.Windows.Forms.Timer();

        /***************
         * Constructor *
         ***************/
        public FormPrincipal()
        {
            InitializeComponent();
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.barraTitulo.MouseDown += new MouseEventHandler(Titulo_MouseDown);
            this.barraTitulo.MouseUp += new MouseEventHandler(Titulo_MouseUp);
            this.barraTitulo.MouseMove += new MouseEventHandler(Titulo_MouseMove);
            this.lblTitulo.MouseDown += new MouseEventHandler(Titulo_MouseDown);
            this.lblTitulo.MouseUp += new MouseEventHandler(Titulo_MouseUp);
            this.lblTitulo.MouseMove += new MouseEventHandler(Titulo_MouseMove);
            m.abrirFormEnPanel(new FormInicio(), this.panelContenido);
        }
        
        /*****************
         * Evento onLoad *
         *****************/
        private async void FormPrincipal_Load(object sender, EventArgs e)
        {
            this.Height = 1;
            this.Width = 1;
            fader.Interval = 10;  // Intervalo para animación
            fader.Tick += new EventHandler(fadeIn);  // Llama a la función que se ejecutara en el timer
            fader.Start(); // Arranca el timer de la animación de inicio

            // Arranca un hilo para comprobar si el servidor esta conectado cada 30s
            await comprobarStatusServerDaemon(TimeSpan.FromSeconds(30), CancellationToken.None);
        }
        
        /****************************
         * Eventos para los botones *
         ****************************/

        // Boton cerrar
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            if(mostrarMensajeSalida()) this.Close();
        }
        // Boton maximizar
        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            btnMaximizar.Visible = false;
            btnRestaurar.Visible = true;
            maximizado = true;
            this.WindowState = FormWindowState.Maximized;
        }
        // Boton restaurar
        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            btnRestaurar.Visible = false;
            btnMaximizar.Visible = true;
            maximizado = false;
            this.WindowState = FormWindowState.Normal;
        }
        // Boton minimizar
        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            maximizado = false;
            this.WindowState = FormWindowState.Minimized;
        }
        // Boton maximizar dividido
        private void btnDividir_Click(object sender, EventArgs e)
        {
            int ancho = Screen.PrimaryScreen.WorkingArea.Width;
            int alto = Screen.PrimaryScreen.WorkingArea.Height;
            if (this.Location != new Point(0, 0) || maximizado)
            {
                if (!maximizado)
                {
                    oldPosition = this.Location;
                    oldSize = this.Size;
                }

                this.WindowState = FormWindowState.Normal;
                this.Location = new Point(0, 0);
                this.Size = new Size(ancho / 2, alto);
                btnRestaurar.Visible = false;
                btnMaximizar.Visible = true;
                maximizado = false;

            }
            else
            {
                this.Location = oldPosition;
                this.Size = oldSize;
            }


        }
        // Doble click en titulo maximiza
        private void barraTitulo_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (maximizado)
            {
                btnRestaurar.Visible = false;
                btnMaximizar.Visible = true;
                maximizado = false;
                this.WindowState = FormWindowState.Normal;
            }else
            {
                btnMaximizar.Visible = false;
                btnRestaurar.Visible = true;
                maximizado = true;
                this.WindowState = FormWindowState.Maximized;
            }
            
        }
        //Botones del menu lateral
        private void btnRefreshStatus_Click(object sender, EventArgs e)
        {
            this.comprobarStatusServidor();
        }
        private void btnMoverMenu_Click(object sender, EventArgs e)
        {
            if (menuLateral.Width == 220)
            {
                if (btnCursos.BackColor != Color.FromArgb(73, 55, 34))
                {
                    this.tmOcultarMenu.Enabled = true;
                }
                else
                {
                    menuLateral.Width = 55;
                    this.lblConectado.Visible = false;
                    actualizarTamañoPanelContenido();
                }
                if (UsuarioConectado.nombre.Equals("invitado"))
                    m.ocultarLogin(this.tmOcultarLogin);
            }
            else if (menuLateral.Width == 55)
            {
                this.lblConectado.Visible = true;
                if (UsuarioConectado.nombre.Equals("invitado"))
                    m.mostrarLogin(this.tmMostrarLogin);

                if (btnCursos.BackColor != Color.FromArgb(73, 55, 34))
                {
                    this.tmMostrarMenu.Enabled = true;
                }
                else
                {
                    menuLateral.Width = 220;
                    actualizarTamañoPanelContenido();
                }

            }
        }
        private void btnPrincipal_Click(object sender, EventArgs e)
        {
            m.restaurarColorBotones(this.menuLateral);
            this.btnPrincipal.BackColor = Color.FromArgb(73, 55, 34);
            m.abrirFormEnPanel(new FormInicio(), this.panelContenido);
        }

        private void btnCursos_Click(object sender, EventArgs e)
        {

            m.restaurarColorBotones(this.menuLateral);
            this.btnCursos.BackColor = Color.FromArgb(73, 55, 34);
            m.abrirFormEnPanel(new FormCursos(), this.panelContenido);
        }

        private async void btnAreaPersonal_Click(object sender, EventArgs e)
        {
            MetodosFormAreaPersonal met = new MetodosFormAreaPersonal();
            int curso;
            List<string> asignaturas;
            int user;
            List<Double> todasNotas;
            List<Double> notasMedias;
            if (UsuarioConectado.nombre.Equals("invitado"))
            {
                curso = 0;
                asignaturas = null;
                user = -1;
                todasNotas = null;
                notasMedias = null;
            }
            else
            {
                curso = await met.sacarCurso(UsuarioConectado.nombre);
                asignaturas = await met.sacarAsignaturas(curso, UsuarioConectado.nombre);
                user = await met.sacarUsuario(UsuarioConectado.nombre);
                todasNotas = await met.recogidaNotas(curso, user, UsuarioConectado.nombre);
                notasMedias = await met.mediaNotas(curso, user, UsuarioConectado.nombre);
            }
            
            m.restaurarColorBotones(this.menuLateral);
            this.btnAreaPersonal.BackColor = Color.FromArgb(73, 55, 34);
            m.abrirFormEnPanel(new FormAreaPersonal(curso, asignaturas, user, todasNotas, notasMedias), this.panelContenido);
        }

        private void btnComunidad_Click(object sender, EventArgs e)
        {
            m.restaurarColorBotones(this.menuLateral);
            this.btnSubida.BackColor = Color.FromArgb(73, 55, 34);
            if (UsuarioConectado.nombre == "invitado")
            {
                m.abrirFormEnPanel(new FormSubida(), this.panelContenido);
                MsgBox.Show("Solo los usuarios registrados pueden subir enlaces a la aplicación, si quieres compartir" +
                    "algun documento de interés con la comunidad puedes registrarte gratuitamente en la pantalla principal" +
                    "de la aplicación. Pulsa en aceptar para ser redirigido a la pantalla principal y poder acceder al registro.",
                    "Característica para usuarios registrados", MsgBox.Buttons.OK, MsgBox.Icon.Info, MsgBox.AnimateStyle.FadeIn);
                m.abrirFormEnPanel(new FormInicio(), this.panelContenido);
                m.restaurarColorBotones(this.menuLateral);
                this.btnPrincipal.BackColor = Color.FromArgb(73, 55, 34);
            }
            else
            {
                m.abrirFormEnPanel(new FormSubida(), this.panelContenido);
            }
            
        }

        private void btnConfiguracion_Click(object sender, EventArgs e)
        {
            m.restaurarColorBotones(this.menuLateral);
            this.btnAyudaAdmin.BackColor = Color.FromArgb(73, 55, 34);
            //string rango = await m.obtenerCredenciales(UsuarioConectado.nombre);
            if (UsuarioConectado.credenciales.Equals("admin"))
            {
                m.abrirFormEnPanel(new FormAdministracion(), this.panelContenido);
            }
            else
            {
                m.abrirFormEnPanel(new FormAyuda(), this.panelContenido);
            }
            
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            try
            {
                if (mostrarMensajeSalida()) this.Close();
            }
            catch (InvalidOperationException)
            {

            }

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (menuLateral.Width >= 220)
            {
                string usuario = tbUsuario.Text;
                string pass = tbPass.Text;
                accionLogearDesloguear(usuario, pass);
                UsuarioConectado.resetearUsuarioConectado();
            }
            else
            {
                this.lblConectado.Visible = true;
                if (btnCursos.BackColor != Color.FromArgb(73, 55, 34)) this.tmMostrarMenu.Enabled = true;
                else menuLateral.Width = 220;
                if (UsuarioConectado.nombre.Equals("invitado")) m.mostrarLogin(this.tmMostrarLogin);

            }
            
        }
        /**********************************************
         * Eventos de validación para el menu lateral *
         **********************************************/
        private void tbUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (UsuarioConectado.nombre.Equals("invitado"))
                {
                    accionLogearDesloguear(tbUsuario.Text, tbPass.Text);
                }
                e.Handled = true;

            }
            else if (Char.IsLetterOrDigit(e.KeyChar)|| e.KeyChar == '\b') // Permitimos BackSpace
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void tbPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (UsuarioConectado.nombre.Equals("invitado"))
                {
                    accionLogearDesloguear(tbUsuario.Text, tbPass.Text);
                    e.Handled = true; //Quita el sonido "beep" de windows al dar enter
                }
            }
            else if (Char.IsLetterOrDigit(e.KeyChar) || e.KeyChar == '\b') // Permitimos BackSpace
            {
                e.Handled = false;
            }
            else
            {
                System.Media.SystemSounds.Beep.Play(); //Sonido "beep" de windows
                e.Handled = true;
                this.toolTipPass.Show("Caracter no permitido, solo letras y numeros", this.tbPass, 1000);
            }

        }

        /********************************
         * Eventos para el menu lateral *
         ********************************/
        private void tmOcultarMenu_Tick(object sender, EventArgs e)
        {
            if (menuLateral.Width <= 55)
            {
                this.tmOcultarMenu.Enabled = false;
                this.lblConectado.Visible = false;
            }
            else
            {
                this.menuLateral.Width = menuLateral.Width - 5;
                actualizarTamañoPanelContenido();
            }
        }
        
        private void tmMostrarMenu_Tick(object sender, EventArgs e)
        {
            if (menuLateral.Width >= 220)
            {
                this.tmMostrarMenu.Enabled = false;
                this.lblStatusServer.Visible = true;
                this.pbStatusServer.Visible = true;
            }
            else
            {
                this.menuLateral.Width = menuLateral.Width + 5;
                actualizarTamañoPanelContenido();
            }
        }
        private void tmOcultarLogin_Tick(object sender, EventArgs e)
        {

            if (panelLogin.Height <= 0)
            {
                this.tmOcultarLogin.Enabled = false;
            }
            else
            {
                this.panelLogin.Height = panelLogin.Height - 5;
                this.lblConectado.Location = new Point(
                    this.lblConectado.Location.X,
                    this.lblConectado.Location.Y + 5);
                this.panelLogin.Location = new Point(
                     this.panelLogin.Location.X,
                     this.panelLogin.Location.Y + 5);
            }
        }
        private void tmMostrarLogin_Tick(object sender, EventArgs e)
        {
            if (panelLogin.Height >= 80)
            {
                this.tmMostrarLogin.Enabled = false;

            }
            else
            {
                this.panelLogin.Height = panelLogin.Height + 5;
                this.lblConectado.Location = new Point(
                    this.lblConectado.Location.X,
                    this.lblConectado.Location.Y - 5);
                this.panelLogin.Location = new Point(
                     this.panelLogin.Location.X,
                     this.panelLogin.Location.Y - 5);
            }
        }
        private void pbTitulo_DoubleClick(object sender, EventArgs e)
        {
            MsgBox.Show("Creada como proyecto final para el curso de Desarrollo de " +
                "Aplicaciones Multiplataforma 2018/19 del IES Gaspar Melchor de Jovellanos por:\r\r" +
                "Rubén Balsera, Antonio Illarramendi y Valentín Sanchez.\r\r" +
                "Contacto: damnificusjovellanos@gmail.com", "Acerca de la Aplicación DAMníficus", MsgBox.Buttons.OK, MsgBox.Icon.Shield, MsgBox.AnimateStyle.FadeIn);
        }


        /******************************************
         * Eventos para movimiento del formulario *
         ******************************************/
        public void Titulo_MouseUp(object sender, MouseEventArgs e)
        {
            this.agarrado = false;
        }

        public void Titulo_MouseDown(object sender, MouseEventArgs e)
        {
            this.puntoInicio = e.Location;
            this.agarrado = true;
        }

        public void Titulo_MouseMove(object sender, MouseEventArgs e)
        {
            if (this.agarrado)
            {
                Point p1 = new Point(e.X, e.Y);
                Point p2 = this.barraTitulo.PointToScreen(p1);
                Point p3 = new Point(p2.X - this.puntoInicio.X,
                                     p2.Y - this.puntoInicio.Y);
                this.Location = p3;
            }
        }

        //Animaciones
        void fadeIn(object sender, EventArgs e)
        {
            if (this.Width >= 1136)
            {
                fader.Stop();   // Paramos el timer cuando el formulario es 100% visible
                this.MinimumSize = new Size(800,600);
            }
            else
            {
                if (this.Height <= 670)
                    this.Height += 30;
                this.Width += 50;
            }
                

        }
        void fadeOut(object sender, EventArgs e)
        {
            if (Opacity <= 0)
            {
                fader.Stop();
                Close();
            }
            else
                Opacity -= 0.05;
        }
        /*************************************************************
         * Eventos para cambio de tamaño y redibujado del formulario *
         *************************************************************/
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_NCHITTEST:
                    if (!maximizado)
                    {
                        base.WndProc(ref m);
                        var hitPoint = this.PointToClient(new Point(m.LParam.ToInt32() & 0xffff, m.LParam.ToInt32() >> 16));
                        if (sizeGripRectangle.Contains(hitPoint))
                            m.Result = new IntPtr(HTBOTTOMRIGHT);
                    }
                    
                    break;
                default:
                    base.WndProc(ref m);
                    break;
            }
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            actualizarTamañoPanelContenido();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            ControlPaint.DrawSizeGrip(e.Graphics, Color.Black, sizeGripRectangle);
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_DROPSHADOW;
                return cp;
            }
        }
        // Este metodo redibuja el panel donde se cargan los formularios 
        // con un boton para redimensionar la ventana.
        private void actualizarTamañoPanelContenido()
        {
            var region = new Region(new Rectangle(0, 0, this.panelContenido.ClientRectangle.Width, this.panelContenido.ClientRectangle.Height));
            sizeGripRectangle = new Rectangle(this.ClientRectangle.Width - tolerancia, this.ClientRectangle.Height - tolerancia, tolerancia, tolerancia);
            if (!maximizado) region.Exclude(new Rectangle(this.panelContenido.Width - tolerancia, this.panelContenido.Height - tolerancia, tolerancia, tolerancia));
            this.panelContenido.Region = region;
            this.Invalidate();
        }

        // Evento para borrar el token si el usuario sale de la aplicación sin desconectarse
        private async void FormPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            await m.borrarToken(UsuarioConectado.nombre);
            // Animacion fadeout cuando se sale
            e.Cancel = true;    // cancela el cerrado de la aplicación
            fader.Tick -= new EventHandler(fadeIn);  //quita el eventhandler de la animacion de inicio
            fader.Tick += new EventHandler(fadeOut);  //y la sustituye por la nueva
            fader.Start();
            if (Opacity == 0) e.Cancel = false;   // Cuando ya es completamente transparente se cierra  
        }

        /***********************************
         * Métodos internos del formulario *
         ***********************************/
        public async void accionLogearDesloguear(string usuario, string pass)
        {
            if (!conectando)
            {
                if (usuario.Equals("") && btnLogin.Text.Equals("Conectarse"))
                {
                    this.toolTipUsuario.Show("Escribe primero tu nombre de usuario", this.tbUsuario, 1000);
                }
                else if (pass.Equals("") && btnLogin.Text.Equals("Conectarse"))
                {
                    this.toolTipPass.Show("Escribe tambien tu contraseña", this.tbPass, 1000);
                }
                else
                {
                    if (UsuarioConectado.nombre.Equals("invitado"))
                    {
                        conectando = true;
                        lblConectado.Text = "Conectando...";
                        string respuesta = await m.conectarConServidor(usuario, pass);
                        if (respuesta.Equals("Acceso concedido"))
                        {
                            UsuarioConectado.nombre = usuario;
                            lblConectado.Text = "Conectando como " + usuario;
                            btnLogin.Text = "Desconectarse";
                            btnLogin.BackColor = Color.FromArgb(91, 183, 108);
                            m.ocultarLogin(this.tmOcultarLogin);
                            tbUsuario.Text = "";
                            tbPass.Text = "";
                            btnPrincipal.PerformClick();
                            // Cambia el boton ayuda por el boton administración si el usuario es admin
                            string rango = await m.obtenerCredenciales(UsuarioConectado.nombre);
                            UsuarioConectado.credenciales = rango;
                            if (UsuarioConectado.credenciales.Equals("admin"))
                            {
                                btnAyudaAdmin.Text = "Administración";
                                btnAyudaAdmin.Image = Proyecto_Presentacion.Properties.Resources.producto;
                            }
                        }
                        else if (respuesta.Equals("usuarioYaConectado"))
                        {
                            MsgBox.Show("Usuario ya conectado, por favor cierre la otra instancia para poder conectarse desde ésta.", "Conexión", MsgBox.Buttons.OK, MsgBox.Icon.Exclamation, MsgBox.AnimateStyle.FadeIn);
                            lblConectado.Text = "Conectado como invitado";
                        }
                        else
                        {
                            MsgBox.Show(respuesta, "Conexión", MsgBox.Buttons.OK, MsgBox.Icon.Exclamation, MsgBox.AnimateStyle.FadeIn);
                            lblConectado.Text = "Conectado como invitado";
                        }
                        conectando = false;
                    }
                    else
                    {
                        conectando = true;
                        // Borra token y desconecta
                        if (!await m.borrarToken(UsuarioConectado.nombre))
                        {
                            MsgBox.Show("Parece que ha habido un error al borrar el token de la base de datos", "Desconexión", 
                                MsgBox.Buttons.OK, MsgBox.Icon.Warning, MsgBox.AnimateStyle.FadeIn);
                        }
                        btnAyudaAdmin.Text = "Ayuda";
                        btnAyudaAdmin.Image = Proyecto_Presentacion.Properties.Resources.ayuda;
                        btnLogin.BackColor = Color.FromArgb(32, 32, 32);
                        btnLogin.Text = "Conectarse";
                        lblConectado.Text = "Conectado como invitado";
                        m.mostrarLogin(this.tmMostrarLogin);
                        UsuarioConectado.nombre = "invitado";
                        conectando = false;
                        btnPrincipal.PerformClick();
                    }
                }
            }     
        }

        // Crea un hilo demonio para comprobar la conexion con el servidor
        public async Task comprobarStatusServerDaemon(TimeSpan interval, CancellationToken cancellationToken)
        {
            while (true)
            {
                this.comprobarStatusServidor();
                await Task.Delay(interval, cancellationToken);
                if (cancellationToken.IsCancellationRequested) break;
            }
        }

        // Comprueba que el servidor este online
        private async void comprobarStatusServidor()
        {
            if (await m.pedirStatusServidor())
            {
                pbStatusServer.Image = Proyecto_Presentacion.Properties.Resources.ok;
                lblStatusServer.Text = "Servidor Online";
                UsuarioConectado.status = "online";
            }
            else
            {
                pbStatusServer.Image = Proyecto_Presentacion.Properties.Resources.error;
                lblStatusServer.Text = "Servidor Offline";
                UsuarioConectado.status = "offline";                
            }
        }
        private bool mostrarMensajeSalida()
        {
            DialogResult respuesta = MsgBox.Show("¿Está seguro de que desea salir de la aplicación?", "Salir",
                                MsgBox.Buttons.YesNo, MsgBox.Icon.Question, MsgBox.AnimateStyle.FadeIn);
            switch (respuesta)
            {
                //case DialogResult.OK:
                case DialogResult.Yes:
                    return true;

                case DialogResult.No:
                //case DialogResult.Abort:
                    return false;

                default:
                    throw new ApplicationException("Resultado de dialogo inesperado");
            }
        }
    }
}
