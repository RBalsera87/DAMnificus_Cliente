using System;
using System.Drawing;
using System.Windows.Forms;
using Proyecto_Negocio;
using System.Threading.Tasks;
using System.Threading;
using System.Timers;

namespace Proyecto_Presentacion
{
    public partial class FormPrincipal : Form
    {
        
        MetodosFormPrincipal m = new MetodosFormPrincipal();
        
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

        //System.Timers.Timer timer = new System.Timers.Timer(10);

        System.Windows.Forms.Timer t1 = new System.Windows.Forms.Timer();
        public FormPrincipal()
        {
            InitializeComponent();
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            //this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.barraTitulo.MouseDown += new MouseEventHandler(Titulo_MouseDown);
            this.barraTitulo.MouseUp += new MouseEventHandler(Titulo_MouseUp);
            this.barraTitulo.MouseMove += new MouseEventHandler(Titulo_MouseMove);
            this.lblTitulo.MouseDown += new MouseEventHandler(Titulo_MouseDown);
            this.lblTitulo.MouseUp += new MouseEventHandler(Titulo_MouseUp);
            this.lblTitulo.MouseMove += new MouseEventHandler(Titulo_MouseMove);
            m.abrirFormEnPanel(new FormInicio(), this.panelContenido);

            //timer.Enabled = false;
            //timer.AutoReset = true;
            //timer.Interval = 10;
            //timer.SynchronizingObject = this;
        }
        
        /*****************
         * Evento onLoad *
         *****************/
        private async void FormPrincipal_Load(object sender, EventArgs e)
        {
            Opacity = 0;      // Ponemos la opacidad a 0 para la animación
            t1.Interval = 10;  // Intervalo para animación
            t1.Tick += new EventHandler(fadeIn);  // Llama a la función que se ejecutara en el timer
            t1.Start(); // Arranca el timer de la animación de inicio

            // Arranca un hilo para comprobar si el servidor esta conectado cada 30s
            await comprobarStatusServerDaemon(TimeSpan.FromSeconds(30), CancellationToken.None);
        }
        
        /****************************
         * Eventos para los botones *
         ****************************/

        // Boton cerrar
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
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
                //timer.Elapsed -= new ElapsedEventHandler(mostrarMenuLateral);
                //timer.Elapsed += new ElapsedEventHandler(ocultarMenuLateral);
                //this.timer.Enabled = true;
                this.tmOcultarMenu.Enabled = true;
                m.ocultarLogin(this.tmOcultarLogin);
            }
            else if (menuLateral.Width == 55)
            {
                //timer.Elapsed -= new ElapsedEventHandler(ocultarMenuLateral);
                //timer.Elapsed += new ElapsedEventHandler(mostrarMenuLateral);
                //this.timer.Enabled = true;
                m.mostrarLogin(this.tmMostrarLogin);
                this.lblConectado.Visible = true;
                this.tmMostrarMenu.Enabled = true;
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

        private void btnAreaPersonal_Click(object sender, EventArgs e)
        {

            m.restaurarColorBotones(this.menuLateral);
            //if (UsuarioConectado.nombre.Equals("invitado"))
            this.btnAreaPersonal.BackColor = Color.FromArgb(73, 55, 34);
            m.abrirFormEnPanel(new FormAreaPersonal(), this.panelContenido);
        }

        private void btnComunidad_Click(object sender, EventArgs e)
        {
            m.restaurarColorBotones(this.menuLateral);
            this.btnComunidad.BackColor = Color.FromArgb(73, 55, 34);
        }

        private void btnConfiguracion_Click(object sender, EventArgs e)
        {
            m.restaurarColorBotones(this.menuLateral);
            this.btnAyudaAdmin.BackColor = Color.FromArgb(73, 55, 34);
            if (UsuarioConectado.nombre.Equals("admin"))
            {
                //Panel administración
            }
            else
            {
                m.abrirFormEnPanel(new FormAyuda(), this.panelContenido);
            }
            
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (menuLateral.Width >= 220)
            {
                string usuario = tbUsuario.Text;
                string pass = tbPass.Text;
                accionLogearDesloguear(usuario, pass);
            }
            else
            {
                this.lblConectado.Visible = true;
                this.tmMostrarMenu.Enabled = true;
                m.mostrarLogin(this.tmMostrarLogin);
            }
            
        }
        /********************************
         * Eventos para el menu lateral *
         ********************************/
        private void tbUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (UsuarioConectado.nombre.Equals("invitado"))
                {
                    accionLogearDesloguear(tbUsuario.Text, tbPass.Text);
                }

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
                }

            }
            else if (Char.IsLetterOrDigit(e.KeyChar) || e.KeyChar == '\b') // Permitimos BackSpace
            {
                e.Handled = false;
            }
            else
            {
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
        private void ocultarMenuLateral(Object source, ElapsedEventArgs e)
        {
            if (this.menuLateral.Width <= 55)
            {
                //this.timer.Enabled = false;

            }
            else
            {
                this.menuLateral.Width = menuLateral.Width - 5;
                actualizarTamañoPanelContenido();
            }
        }
        private void mostrarMenuLateral(Object source, ElapsedEventArgs e)
        {
            if (menuLateral.Width >= 220)
            {
                //this.timer.Enabled = false;
                this.lblUsuario.Visible = true;
                this.lblPass.Visible = true;
                this.lblConectado.Visible = true;
                this.tbUsuario.Visible = true;
                this.tbPass.Visible = true;
            }
            else
            {
                this.menuLateral.Width = menuLateral.Width + 5;
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
            if (Opacity >= 1)
                t1.Stop();   // Paramos el timer cuando el formulario es 100% visible
            else
                Opacity += .05;
        }
        void fadeOut(object sender, EventArgs e)
        {
            if (Opacity <= 0)
            {
                t1.Stop();
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
            t1.Tick -= new EventHandler(fadeIn);  //quita el eventhandler de la animacion de inicio
            t1.Tick += new EventHandler(fadeOut);  //y la sustituye por la nueva
            t1.Start();
            if (Opacity == 0) e.Cancel = false;   // Cuando ya es completamente transparente se cierra  
        }



        private async void accionLogearDesloguear(string usuario, string pass)
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
                        // Cambia el boton ayuda por el boton administración si el usuario es admin
                        if (usuario.Equals("admin"))
                        {
                            btnAyudaAdmin.Text = "Administración";
                            btnAyudaAdmin.Image = Proyecto_Presentacion.Properties.Resources.producto;
                        }
                        
                    }
                    else
                    {
                        MessageBox.Show(respuesta); // Cambiar esto
                        lblConectado.Text = "Conectado como invitado";
                    }

                }
                else
                {
                    // Borra token y desconecta
                    if (!await m.borrarToken(UsuarioConectado.nombre))
                    {
                        MessageBox.Show("Error al borrar token");
                    }
                    btnAyudaAdmin.Text = "Ayuda";
                    btnAyudaAdmin.Image = Proyecto_Presentacion.Properties.Resources.ayuda;
                    btnLogin.BackColor = Color.FromArgb(32, 32, 32);
                    btnLogin.Text = "Conectarse";
                    lblConectado.Text = "Conectado como invitado";
                    m.mostrarLogin(this.tmMostrarLogin);
                    UsuarioConectado.nombre = "invitado";
                    btnPrincipal.PerformClick();
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
                if (btnPrincipal.BackColor != Color.FromArgb(32, 32, 32))
                {
                    btnPrincipal.PerformClick();
                }
                //btnCursos.Enabled = btnAreaPersonal.Enabled = btnAyudaAdmin.Enabled = btnComunidad.Enabled = btnLogin.Enabled = true;
                //panel2.BackColor = panel3.BackColor = panel4.BackColor = panel5.BackColor = panel7.BackColor = Color.FromArgb(255, 153, 39);
            }
            else
            {
                pbStatusServer.Image = Proyecto_Presentacion.Properties.Resources.error;
                lblStatusServer.Text = "Servidor Offline";
                UsuarioConectado.status = "offline";
                if(btnPrincipal.BackColor != Color.FromArgb(32,32,32))
                {
                    btnPrincipal.PerformClick();
                }
                //btnCursos.Enabled = btnAreaPersonal.Enabled = btnAyudaAdmin.Enabled = btnComunidad.Enabled = btnLogin.Enabled = false;
                //panel2.BackColor = panel3.BackColor = panel4.BackColor = panel5.BackColor = panel7.BackColor = Color.Red;

            }
        }


    }
}
