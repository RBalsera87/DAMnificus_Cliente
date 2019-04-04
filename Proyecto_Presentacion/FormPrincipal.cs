﻿using System;
using System.Drawing;
using System.Windows.Forms;
using Proyecto_AccesoDatos;
using System.Runtime.InteropServices;

namespace Proyecto_Presentacion
{
    public partial class FormPrincipal : Form
    {
        
    //Metodos m = new Metodos();
    AccesoDatos ad = new AccesoDatos();
        // Variables para el movimiento del formulario
        private bool agarrado = false;
        private bool maximizado = false;
        private Point puntoInicio = new Point(0, 0);
        // Variables para el cambio de tamaño del formulario
        private int tolerancia = 16;
        private const int WM_NCHITTEST = 132;
        private const int HTBOTTOMRIGHT = 17;
        private Rectangle sizeGripRectangle;
        // Variables para division del formulario
        private Size oldSize;
        private Point oldPosition;
        // Variable para el efecto sombra del formulario
        private const int CS_DROPSHADOW = 0x20000;
        public FormPrincipal()
        {
            InitializeComponent();
            //Application.VisualStyleState = VisualStyleState.NoneEnabled;
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.barraTitulo.MouseDown += new MouseEventHandler(Titulo_MouseDown);
            this.barraTitulo.MouseUp += new MouseEventHandler(Titulo_MouseUp);
            this.barraTitulo.MouseMove += new MouseEventHandler(Titulo_MouseMove);
            this.lblTitulo.MouseDown += new MouseEventHandler(Titulo_MouseDown);
            this.lblTitulo.MouseUp += new MouseEventHandler(Titulo_MouseUp);
            this.lblTitulo.MouseMove += new MouseEventHandler(Titulo_MouseMove);

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
        private void btnPrincipal_Click(object sender, EventArgs e)
        {
            resaltarColor(1);
        }

        private void btnCursos_Click(object sender, EventArgs e)
        {
            abrirFormEnPanel(new Form1());
            resaltarColor(2);
        }

        private void btnAreaPersonal_Click(object sender, EventArgs e)
        {
            abrirFormEnPanel(new FormAreaPersonal());
            resaltarColor(3);
        }

        private void btnComunidad_Click(object sender, EventArgs e)
        {
            resaltarColor(4);
        }

        private void btnConfiguracion_Click(object sender, EventArgs e)
        {
            resaltarColor(5);
        }
        private async void btnLogin_Click(object sender, EventArgs e)
        {
            if (menuLateral.Width >= 220)
            {
                //ocultarLogin();
                //Esta linea seria para encriptar la clave 
                string hash = Clave.encriptarClave("admin");
                //Imprimir la clave codificada
                MessageBox.Show(hash);
                //Esta linea seria para comprobar la clave con la BD
                bool isValid = Clave.comprobarClave(tbPass.Text, hash);
                

                AccesoDatos Acceso = new AccesoDatos();

                string x = await ad.enviarPeticionLogin("login","admin",hash,null);
                //Imprimir la respuesta al complobar
                MessageBox.Show(isValid ? "válida" : "no válida");
            }
            else
            {
                this.tmMostrarMenu.Enabled = true;
                this.lblUsuario.Visible = true;
                this.lblPass.Visible = true;
                this.lblConectado.Visible = true;
            }
        }

        public void resaltarColor(int origen)
        {
            Panel[] paneles = { panel1, panel2, panel3, panel4, panel5 };
            for (int x = 0; x < 5; x++)
            {
                if (origen == (x + 1))
                {
                    paneles[x].BackColor = System.Drawing.Color.FromArgb(255, 0, 0);
                }
                else
                {
                    paneles[x].BackColor = System.Drawing.Color.FromArgb(255, 153, 39);
                }
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

            }
            else
            {
                this.menuLateral.Width = menuLateral.Width + 5;
                actualizarTamañoPanelContenido();
            }
        }

        private void pbOcultarMenu_Click(object sender, EventArgs e)
        {
            if (menuLateral.Width == 220)
            {
                this.tmOcultarMenu.Enabled = true;
                this.lblUsuario.Visible = false;
                this.lblPass.Visible = false;
                this.lblConectado.Visible = false;
            }
            else if (menuLateral.Width == 55)
            {
                this.tmMostrarMenu.Enabled = true;
                this.lblUsuario.Visible = true;
                this.lblPass.Visible = true;
                this.lblConectado.Visible = true;
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

        /************************************************
         * Eventos para cambio de tamaño del formulario *
         ************************************************/
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

       /***********************************
        * Métodos internos del formulario *
        ***********************************/
        private void abrirFormEnPanel(object formHijo)
        {
            if (this.panelContenido.Controls.Count > 0)
            {
                this.panelContenido.Controls.RemoveAt(0);
            }
            Form fh = formHijo as Form;
            fh.TopLevel = false;
            fh.FormBorderStyle = FormBorderStyle.None;
            fh.Dock = DockStyle.Fill;
            this.panelContenido.Controls.Add(fh);
            this.panelContenido.Tag = fh;
            fh.Show();
        }
        private void ocultarLogin()
        {
            this.tmOcultarLogin.Enabled = true;
        }
        private void mostrarLogin()
        {
            this.tmMostrarLogin.Enabled = true;
        }
        private void actualizarTamañoPanelContenido()
        {
            var region = new Region(new Rectangle(0, 0, this.panelContenido.ClientRectangle.Width, this.panelContenido.ClientRectangle.Height));
            sizeGripRectangle = new Rectangle(this.ClientRectangle.Width - tolerancia, this.ClientRectangle.Height - tolerancia, tolerancia, tolerancia);
            if (!maximizado) region.Exclude(new Rectangle(this.panelContenido.Width - tolerancia, this.panelContenido.Height - tolerancia, tolerancia, tolerancia));
            this.panelContenido.Region = region;
            this.Invalidate();

        }
        

    }
}
