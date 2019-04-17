namespace Proyecto_Presentacion
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.barraTitulo = new System.Windows.Forms.Panel();
            this.btnDividir = new System.Windows.Forms.Button();
            this.pbIcono = new System.Windows.Forms.PictureBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnRestaurar = new System.Windows.Forms.Button();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.btnMaximizar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.menuLateral = new System.Windows.Forms.Panel();
            this.btnMoverMenu = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnRefreshStatus = new System.Windows.Forms.Button();
            this.pbStatusServer = new System.Windows.Forms.PictureBox();
            this.lblConectado = new System.Windows.Forms.Label();
            this.lblStatusServer = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btnLogin = new System.Windows.Forms.Button();
            this.panelLogin = new System.Windows.Forms.Panel();
            this.lblPass = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.tbPass = new System.Windows.Forms.TextBox();
            this.tbUsuario = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnAyudaAdmin = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnComunidad = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnAreaPersonal = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCursos = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnPrincipal = new System.Windows.Forms.Button();
            this.pbTitulo = new System.Windows.Forms.PictureBox();
            this.panelContenido = new System.Windows.Forms.Panel();
            this.tmOcultarMenu = new System.Windows.Forms.Timer(this.components);
            this.tmMostrarMenu = new System.Windows.Forms.Timer(this.components);
            this.tmOcultarLogin = new System.Windows.Forms.Timer(this.components);
            this.tmMostrarLogin = new System.Windows.Forms.Timer(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.barraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbIcono)).BeginInit();
            this.menuLateral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbStatusServer)).BeginInit();
            this.panelLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbTitulo)).BeginInit();
            this.SuspendLayout();
            // 
            // barraTitulo
            // 
            this.barraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(120)))), ((int)(((byte)(0)))));
            this.barraTitulo.Controls.Add(this.btnDividir);
            this.barraTitulo.Controls.Add(this.pbIcono);
            this.barraTitulo.Controls.Add(this.lblTitulo);
            this.barraTitulo.Controls.Add(this.btnRestaurar);
            this.barraTitulo.Controls.Add(this.btnMinimizar);
            this.barraTitulo.Controls.Add(this.btnMaximizar);
            this.barraTitulo.Controls.Add(this.btnCerrar);
            this.barraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.barraTitulo.Location = new System.Drawing.Point(0, 0);
            this.barraTitulo.Name = "barraTitulo";
            this.barraTitulo.Size = new System.Drawing.Size(1136, 32);
            this.barraTitulo.TabIndex = 0;
            this.barraTitulo.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.barraTitulo_MouseDoubleClick);
            // 
            // btnDividir
            // 
            this.btnDividir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDividir.BackgroundImage = global::Proyecto_Presentacion.Properties.Resources.Icono_dividir;
            this.btnDividir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDividir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDividir.FlatAppearance.BorderSize = 0;
            this.btnDividir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDividir.Location = new System.Drawing.Point(1008, 0);
            this.btnDividir.Name = "btnDividir";
            this.btnDividir.Size = new System.Drawing.Size(32, 32);
            this.btnDividir.TabIndex = 6;
            this.btnDividir.TabStop = false;
            this.btnDividir.UseVisualStyleBackColor = true;
            this.btnDividir.Click += new System.EventHandler(this.btnDividir_Click);
            // 
            // pbIcono
            // 
            this.pbIcono.Enabled = false;
            this.pbIcono.Image = global::Proyecto_Presentacion.Properties.Resources.principal;
            this.pbIcono.Location = new System.Drawing.Point(3, 3);
            this.pbIcono.Name = "pbIcono";
            this.pbIcono.Size = new System.Drawing.Size(27, 26);
            this.pbIcono.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbIcono.TabIndex = 5;
            this.pbIcono.TabStop = false;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(32, 4);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(148, 25);
            this.lblTitulo.TabIndex = 4;
            this.lblTitulo.Text = "DAMnificus App";
            // 
            // btnRestaurar
            // 
            this.btnRestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRestaurar.BackgroundImage = global::Proyecto_Presentacion.Properties.Resources.Icono_Restaurar;
            this.btnRestaurar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRestaurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRestaurar.FlatAppearance.BorderSize = 0;
            this.btnRestaurar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestaurar.Location = new System.Drawing.Point(1072, 0);
            this.btnRestaurar.Name = "btnRestaurar";
            this.btnRestaurar.Size = new System.Drawing.Size(32, 32);
            this.btnRestaurar.TabIndex = 3;
            this.btnRestaurar.TabStop = false;
            this.btnRestaurar.UseVisualStyleBackColor = true;
            this.btnRestaurar.Visible = false;
            this.btnRestaurar.Click += new System.EventHandler(this.btnRestaurar_Click);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.BackgroundImage = global::Proyecto_Presentacion.Properties.Resources.Icono_Minimizar;
            this.btnMinimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizar.FlatAppearance.BorderSize = 0;
            this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizar.Location = new System.Drawing.Point(1040, 0);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(32, 32);
            this.btnMinimizar.TabIndex = 2;
            this.btnMinimizar.TabStop = false;
            this.btnMinimizar.UseVisualStyleBackColor = true;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximizar.BackgroundImage = global::Proyecto_Presentacion.Properties.Resources.Icono_Maximizar;
            this.btnMaximizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMaximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMaximizar.FlatAppearance.BorderSize = 0;
            this.btnMaximizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximizar.Location = new System.Drawing.Point(1072, 0);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Size = new System.Drawing.Size(32, 32);
            this.btnMaximizar.TabIndex = 1;
            this.btnMaximizar.UseVisualStyleBackColor = true;
            this.btnMaximizar.Click += new System.EventHandler(this.btnMaximizar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.BackgroundImage = global::Proyecto_Presentacion.Properties.Resources.Icono_cerrar_FN;
            this.btnCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Location = new System.Drawing.Point(1104, 0);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(32, 32);
            this.btnCerrar.TabIndex = 0;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // menuLateral
            // 
            this.menuLateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.menuLateral.Controls.Add(this.btnMoverMenu);
            this.menuLateral.Controls.Add(this.panel6);
            this.menuLateral.Controls.Add(this.btnSalir);
            this.menuLateral.Controls.Add(this.btnRefreshStatus);
            this.menuLateral.Controls.Add(this.pbStatusServer);
            this.menuLateral.Controls.Add(this.lblConectado);
            this.menuLateral.Controls.Add(this.lblStatusServer);
            this.menuLateral.Controls.Add(this.panel7);
            this.menuLateral.Controls.Add(this.btnLogin);
            this.menuLateral.Controls.Add(this.panelLogin);
            this.menuLateral.Controls.Add(this.panel5);
            this.menuLateral.Controls.Add(this.btnAyudaAdmin);
            this.menuLateral.Controls.Add(this.panel4);
            this.menuLateral.Controls.Add(this.btnComunidad);
            this.menuLateral.Controls.Add(this.panel3);
            this.menuLateral.Controls.Add(this.btnAreaPersonal);
            this.menuLateral.Controls.Add(this.panel2);
            this.menuLateral.Controls.Add(this.btnCursos);
            this.menuLateral.Controls.Add(this.panel1);
            this.menuLateral.Controls.Add(this.btnPrincipal);
            this.menuLateral.Controls.Add(this.pbTitulo);
            this.menuLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuLateral.Location = new System.Drawing.Point(0, 32);
            this.menuLateral.Name = "menuLateral";
            this.menuLateral.Size = new System.Drawing.Size(220, 638);
            this.menuLateral.TabIndex = 1;
            // 
            // btnMoverMenu
            // 
            this.btnMoverMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMoverMenu.BackgroundImage = global::Proyecto_Presentacion.Properties.Resources.Mobile_Menu_Icon;
            this.btnMoverMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMoverMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMoverMenu.FlatAppearance.BorderSize = 0;
            this.btnMoverMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMoverMenu.Location = new System.Drawing.Point(174, 3);
            this.btnMoverMenu.Name = "btnMoverMenu";
            this.btnMoverMenu.Size = new System.Drawing.Size(40, 32);
            this.btnMoverMenu.TabIndex = 22;
            this.btnMoverMenu.TabStop = false;
            this.btnMoverMenu.UseVisualStyleBackColor = true;
            this.btnMoverMenu.Click += new System.EventHandler(this.btnMoverMenu_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(39)))));
            this.panel6.Location = new System.Drawing.Point(0, 367);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(5, 50);
            this.panel6.TabIndex = 21;
            // 
            // btnSalir
            // 
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(39)))));
            this.btnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(55)))), ((int)(((byte)(34)))));
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Image = global::Proyecto_Presentacion.Properties.Resources.salir;
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.Location = new System.Drawing.Point(0, 367);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(220, 50);
            this.btnSalir.TabIndex = 20;
            this.btnSalir.TabStop = false;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnRefreshStatus
            // 
            this.btnRefreshStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefreshStatus.BackgroundImage = global::Proyecto_Presentacion.Properties.Resources.refresh;
            this.btnRefreshStatus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRefreshStatus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefreshStatus.FlatAppearance.BorderSize = 0;
            this.btnRefreshStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefreshStatus.Location = new System.Drawing.Point(5, 6);
            this.btnRefreshStatus.Name = "btnRefreshStatus";
            this.btnRefreshStatus.Size = new System.Drawing.Size(16, 16);
            this.btnRefreshStatus.TabIndex = 7;
            this.btnRefreshStatus.TabStop = false;
            this.btnRefreshStatus.UseVisualStyleBackColor = true;
            this.btnRefreshStatus.Click += new System.EventHandler(this.btnRefreshStatus_Click);
            // 
            // pbStatusServer
            // 
            this.pbStatusServer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbStatusServer.Image = global::Proyecto_Presentacion.Properties.Resources.problem;
            this.pbStatusServer.Location = new System.Drawing.Point(25, 7);
            this.pbStatusServer.Name = "pbStatusServer";
            this.pbStatusServer.Size = new System.Drawing.Size(16, 16);
            this.pbStatusServer.TabIndex = 19;
            this.pbStatusServer.TabStop = false;
            // 
            // lblConectado
            // 
            this.lblConectado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblConectado.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConectado.ForeColor = System.Drawing.Color.White;
            this.lblConectado.Location = new System.Drawing.Point(3, 487);
            this.lblConectado.Name = "lblConectado";
            this.lblConectado.Size = new System.Drawing.Size(214, 14);
            this.lblConectado.TabIndex = 18;
            this.lblConectado.Text = "Conectado como invitado";
            this.lblConectado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblStatusServer
            // 
            this.lblStatusServer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStatusServer.AutoSize = true;
            this.lblStatusServer.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatusServer.ForeColor = System.Drawing.Color.White;
            this.lblStatusServer.Location = new System.Drawing.Point(44, 5);
            this.lblStatusServer.Name = "lblStatusServer";
            this.lblStatusServer.Size = new System.Drawing.Size(87, 17);
            this.lblStatusServer.TabIndex = 18;
            this.lblStatusServer.Text = "Conectando...";
            this.lblStatusServer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel7
            // 
            this.panel7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(39)))));
            this.panel7.Location = new System.Drawing.Point(0, 588);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(5, 50);
            this.panel7.TabIndex = 17;
            // 
            // btnLogin
            // 
            this.btnLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(39)))));
            this.btnLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(55)))), ((int)(((byte)(34)))));
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Image = global::Proyecto_Presentacion.Properties.Resources.empleados;
            this.btnLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogin.Location = new System.Drawing.Point(0, 588);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(220, 50);
            this.btnLogin.TabIndex = 16;
            this.btnLogin.TabStop = false;
            this.btnLogin.Text = "Conectarse";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // panelLogin
            // 
            this.panelLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panelLogin.Controls.Add(this.lblPass);
            this.panelLogin.Controls.Add(this.lblUsuario);
            this.panelLogin.Controls.Add(this.tbPass);
            this.panelLogin.Controls.Add(this.tbUsuario);
            this.panelLogin.Location = new System.Drawing.Point(0, 504);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.Size = new System.Drawing.Size(220, 80);
            this.panelLogin.TabIndex = 13;
            // 
            // lblPass
            // 
            this.lblPass.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPass.AutoSize = true;
            this.lblPass.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPass.ForeColor = System.Drawing.Color.White;
            this.lblPass.Location = new System.Drawing.Point(17, 48);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(45, 20);
            this.lblPass.TabIndex = 17;
            this.lblPass.Text = "Clave";
            this.lblPass.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblUsuario
            // 
            this.lblUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.Color.White;
            this.lblUsuario.Location = new System.Drawing.Point(3, 12);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(59, 20);
            this.lblUsuario.TabIndex = 16;
            this.lblUsuario.Text = "Usuario";
            // 
            // tbPass
            // 
            this.tbPass.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbPass.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPass.ForeColor = System.Drawing.Color.White;
            this.tbPass.Location = new System.Drawing.Point(68, 47);
            this.tbPass.MaxLength = 56;
            this.tbPass.Name = "tbPass";
            this.tbPass.PasswordChar = '●';
            this.tbPass.Size = new System.Drawing.Size(143, 25);
            this.tbPass.TabIndex = 1;
            this.tbPass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPass_KeyPress);
            // 
            // tbUsuario
            // 
            this.tbUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbUsuario.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUsuario.ForeColor = System.Drawing.Color.White;
            this.tbUsuario.Location = new System.Drawing.Point(68, 11);
            this.tbUsuario.MaxLength = 32;
            this.tbUsuario.Name = "tbUsuario";
            this.tbUsuario.Size = new System.Drawing.Size(143, 25);
            this.tbUsuario.TabIndex = 0;
            this.tbUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbUsuario_KeyPress);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(39)))));
            this.panel5.Location = new System.Drawing.Point(0, 311);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(5, 50);
            this.panel5.TabIndex = 12;
            // 
            // btnAyudaAdmin
            // 
            this.btnAyudaAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAyudaAdmin.FlatAppearance.BorderSize = 0;
            this.btnAyudaAdmin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(39)))));
            this.btnAyudaAdmin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(55)))), ((int)(((byte)(34)))));
            this.btnAyudaAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAyudaAdmin.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAyudaAdmin.ForeColor = System.Drawing.Color.White;
            this.btnAyudaAdmin.Image = global::Proyecto_Presentacion.Properties.Resources.ayuda;
            this.btnAyudaAdmin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAyudaAdmin.Location = new System.Drawing.Point(0, 311);
            this.btnAyudaAdmin.Name = "btnAyudaAdmin";
            this.btnAyudaAdmin.Size = new System.Drawing.Size(220, 50);
            this.btnAyudaAdmin.TabIndex = 11;
            this.btnAyudaAdmin.TabStop = false;
            this.btnAyudaAdmin.Text = "Ayuda";
            this.btnAyudaAdmin.UseVisualStyleBackColor = true;
            this.btnAyudaAdmin.Click += new System.EventHandler(this.btnConfiguracion_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(39)))));
            this.panel4.Location = new System.Drawing.Point(0, 255);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(5, 50);
            this.panel4.TabIndex = 10;
            // 
            // btnComunidad
            // 
            this.btnComunidad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnComunidad.FlatAppearance.BorderSize = 0;
            this.btnComunidad.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(39)))));
            this.btnComunidad.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(55)))), ((int)(((byte)(34)))));
            this.btnComunidad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnComunidad.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComunidad.ForeColor = System.Drawing.Color.White;
            this.btnComunidad.Image = global::Proyecto_Presentacion.Properties.Resources.clientes;
            this.btnComunidad.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnComunidad.Location = new System.Drawing.Point(0, 255);
            this.btnComunidad.Name = "btnComunidad";
            this.btnComunidad.Size = new System.Drawing.Size(220, 50);
            this.btnComunidad.TabIndex = 9;
            this.btnComunidad.TabStop = false;
            this.btnComunidad.Text = "Comunidad";
            this.btnComunidad.UseVisualStyleBackColor = true;
            this.btnComunidad.Click += new System.EventHandler(this.btnComunidad_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(39)))));
            this.panel3.Location = new System.Drawing.Point(0, 199);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(5, 50);
            this.panel3.TabIndex = 8;
            // 
            // btnAreaPersonal
            // 
            this.btnAreaPersonal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAreaPersonal.FlatAppearance.BorderSize = 0;
            this.btnAreaPersonal.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(39)))));
            this.btnAreaPersonal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(55)))), ((int)(((byte)(34)))));
            this.btnAreaPersonal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAreaPersonal.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAreaPersonal.ForeColor = System.Drawing.Color.White;
            this.btnAreaPersonal.Image = global::Proyecto_Presentacion.Properties.Resources.reportes;
            this.btnAreaPersonal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAreaPersonal.Location = new System.Drawing.Point(0, 199);
            this.btnAreaPersonal.Name = "btnAreaPersonal";
            this.btnAreaPersonal.Size = new System.Drawing.Size(220, 50);
            this.btnAreaPersonal.TabIndex = 7;
            this.btnAreaPersonal.TabStop = false;
            this.btnAreaPersonal.Text = "Area Personal";
            this.btnAreaPersonal.UseVisualStyleBackColor = true;
            this.btnAreaPersonal.Click += new System.EventHandler(this.btnAreaPersonal_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(39)))));
            this.panel2.Location = new System.Drawing.Point(0, 143);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(5, 50);
            this.panel2.TabIndex = 6;
            // 
            // btnCursos
            // 
            this.btnCursos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCursos.FlatAppearance.BorderSize = 0;
            this.btnCursos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(39)))));
            this.btnCursos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(55)))), ((int)(((byte)(34)))));
            this.btnCursos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCursos.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCursos.ForeColor = System.Drawing.Color.White;
            this.btnCursos.Image = global::Proyecto_Presentacion.Properties.Resources.cursos;
            this.btnCursos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCursos.Location = new System.Drawing.Point(0, 143);
            this.btnCursos.Name = "btnCursos";
            this.btnCursos.Size = new System.Drawing.Size(220, 50);
            this.btnCursos.TabIndex = 5;
            this.btnCursos.TabStop = false;
            this.btnCursos.Text = "Cursos";
            this.btnCursos.UseVisualStyleBackColor = true;
            this.btnCursos.Click += new System.EventHandler(this.btnCursos_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(39)))));
            this.panel1.Location = new System.Drawing.Point(0, 87);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(5, 50);
            this.panel1.TabIndex = 4;
            // 
            // btnPrincipal
            // 
            this.btnPrincipal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrincipal.FlatAppearance.BorderSize = 0;
            this.btnPrincipal.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(39)))));
            this.btnPrincipal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(55)))), ((int)(((byte)(34)))));
            this.btnPrincipal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrincipal.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrincipal.ForeColor = System.Drawing.Color.White;
            this.btnPrincipal.Image = global::Proyecto_Presentacion.Properties.Resources.principal;
            this.btnPrincipal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrincipal.Location = new System.Drawing.Point(0, 87);
            this.btnPrincipal.Name = "btnPrincipal";
            this.btnPrincipal.Size = new System.Drawing.Size(220, 50);
            this.btnPrincipal.TabIndex = 3;
            this.btnPrincipal.TabStop = false;
            this.btnPrincipal.Text = "Principal";
            this.btnPrincipal.UseVisualStyleBackColor = true;
            this.btnPrincipal.Click += new System.EventHandler(this.btnPrincipal_Click);
            // 
            // pbTitulo
            // 
            this.pbTitulo.BackgroundImage = global::Proyecto_Presentacion.Properties.Resources.titulo;
            this.pbTitulo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbTitulo.Location = new System.Drawing.Point(0, 41);
            this.pbTitulo.Name = "pbTitulo";
            this.pbTitulo.Size = new System.Drawing.Size(220, 40);
            this.pbTitulo.TabIndex = 0;
            this.pbTitulo.TabStop = false;
            // 
            // panelContenido
            // 
            this.panelContenido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelContenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenido.ForeColor = System.Drawing.Color.Black;
            this.panelContenido.Location = new System.Drawing.Point(220, 32);
            this.panelContenido.Name = "panelContenido";
            this.panelContenido.Size = new System.Drawing.Size(916, 638);
            this.panelContenido.TabIndex = 2;
            // 
            // tmOcultarMenu
            // 
            this.tmOcultarMenu.Interval = 10;
            this.tmOcultarMenu.Tick += new System.EventHandler(this.tmOcultarMenu_Tick);
            // 
            // tmMostrarMenu
            // 
            this.tmMostrarMenu.Interval = 10;
            this.tmMostrarMenu.Tick += new System.EventHandler(this.tmMostrarMenu_Tick);
            // 
            // tmOcultarLogin
            // 
            this.tmOcultarLogin.Interval = 10;
            this.tmOcultarLogin.Tick += new System.EventHandler(this.tmOcultarLogin_Tick);
            // 
            // tmMostrarLogin
            // 
            this.tmMostrarLogin.Interval = 10;
            this.tmMostrarLogin.Tick += new System.EventHandler(this.tmMostrarLogin_Tick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1136, 670);
            this.Controls.Add(this.panelContenido);
            this.Controls.Add(this.menuLateral);
            this.Controls.Add(this.barraTitulo);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DAMnificus App";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.barraTitulo.ResumeLayout(false);
            this.barraTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbIcono)).EndInit();
            this.menuLateral.ResumeLayout(false);
            this.menuLateral.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbStatusServer)).EndInit();
            this.panelLogin.ResumeLayout(false);
            this.panelLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbTitulo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel barraTitulo;
        private System.Windows.Forms.Panel menuLateral;
        private System.Windows.Forms.Panel panelContenido;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnRestaurar;
        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.Button btnMaximizar;
        private System.Windows.Forms.PictureBox pbTitulo;
        private System.Windows.Forms.Timer tmOcultarMenu;
        private System.Windows.Forms.Timer tmMostrarMenu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnPrincipal;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnAyudaAdmin;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnComunidad;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnAreaPersonal;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnCursos;
        private System.Windows.Forms.PictureBox pbIcono;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel panelLogin;
        private System.Windows.Forms.TextBox tbPass;
        private System.Windows.Forms.TextBox tbUsuario;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblConectado;
        private System.Windows.Forms.Timer tmOcultarLogin;
        private System.Windows.Forms.Timer tmMostrarLogin;
        private System.Windows.Forms.Button btnDividir;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label lblStatusServer;
        private System.Windows.Forms.PictureBox pbStatusServer;
        private System.Windows.Forms.Button btnRefreshStatus;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnMoverMenu;
    }
}

