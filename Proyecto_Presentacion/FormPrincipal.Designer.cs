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
            this.pbIcono = new System.Windows.Forms.PictureBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnRestaurar = new System.Windows.Forms.Button();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.btnMaximizar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.menuLateral = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btnLogin = new System.Windows.Forms.Button();
            this.panelLogin = new System.Windows.Forms.Panel();
            this.lblPass = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnConfiguracion = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnComunidad = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnAreaPersonal = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCursos = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnPrincipal = new System.Windows.Forms.Button();
            this.pbOcultarMenu = new System.Windows.Forms.PictureBox();
            this.pbTitulo = new System.Windows.Forms.PictureBox();
            this.panelContenido = new System.Windows.Forms.Panel();
            this.tmOcultarMenu = new System.Windows.Forms.Timer(this.components);
            this.tmMostrarMenu = new System.Windows.Forms.Timer(this.components);
            this.lblConectado = new System.Windows.Forms.Label();
            this.tmOcultarLogin = new System.Windows.Forms.Timer(this.components);
            this.tmMostrarLogin = new System.Windows.Forms.Timer(this.components);
            this.barraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbIcono)).BeginInit();
            this.menuLateral.SuspendLayout();
            this.panelLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbOcultarMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTitulo)).BeginInit();
            this.SuspendLayout();
            // 
            // barraTitulo
            // 
            this.barraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(120)))), ((int)(((byte)(0)))));
            this.barraTitulo.Controls.Add(this.pbIcono);
            this.barraTitulo.Controls.Add(this.lblTitulo);
            this.barraTitulo.Controls.Add(this.btnRestaurar);
            this.barraTitulo.Controls.Add(this.btnMinimizar);
            this.barraTitulo.Controls.Add(this.btnMaximizar);
            this.barraTitulo.Controls.Add(this.btnCerrar);
            this.barraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.barraTitulo.Location = new System.Drawing.Point(0, 0);
            this.barraTitulo.Name = "barraTitulo";
            this.barraTitulo.Size = new System.Drawing.Size(1045, 32);
            this.barraTitulo.TabIndex = 0;
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
            this.btnRestaurar.Location = new System.Drawing.Point(975, 0);
            this.btnRestaurar.Name = "btnRestaurar";
            this.btnRestaurar.Size = new System.Drawing.Size(32, 32);
            this.btnRestaurar.TabIndex = 3;
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
            this.btnMinimizar.Location = new System.Drawing.Point(937, 0);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(32, 32);
            this.btnMinimizar.TabIndex = 2;
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
            this.btnMaximizar.Location = new System.Drawing.Point(975, 0);
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
            this.btnCerrar.Location = new System.Drawing.Point(1013, 0);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(32, 32);
            this.btnCerrar.TabIndex = 0;
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // menuLateral
            // 
            this.menuLateral.BackColor = System.Drawing.SystemColors.ControlDark;
            this.menuLateral.Controls.Add(this.lblConectado);
            this.menuLateral.Controls.Add(this.panel7);
            this.menuLateral.Controls.Add(this.btnLogin);
            this.menuLateral.Controls.Add(this.panelLogin);
            this.menuLateral.Controls.Add(this.panel5);
            this.menuLateral.Controls.Add(this.btnConfiguracion);
            this.menuLateral.Controls.Add(this.panel4);
            this.menuLateral.Controls.Add(this.btnComunidad);
            this.menuLateral.Controls.Add(this.panel3);
            this.menuLateral.Controls.Add(this.btnAreaPersonal);
            this.menuLateral.Controls.Add(this.panel2);
            this.menuLateral.Controls.Add(this.btnCursos);
            this.menuLateral.Controls.Add(this.panel1);
            this.menuLateral.Controls.Add(this.btnPrincipal);
            this.menuLateral.Controls.Add(this.pbOcultarMenu);
            this.menuLateral.Controls.Add(this.pbTitulo);
            this.menuLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuLateral.Location = new System.Drawing.Point(0, 32);
            this.menuLateral.Name = "menuLateral";
            this.menuLateral.Size = new System.Drawing.Size(220, 591);
            this.menuLateral.TabIndex = 1;
            // 
            // panel7
            // 
            this.panel7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(39)))));
            this.panel7.Location = new System.Drawing.Point(0, 541);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(5, 50);
            this.panel7.TabIndex = 17;
            // 
            // btnLogin
            // 
            this.btnLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(39)))));
            this.btnLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(55)))), ((int)(((byte)(34)))));
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Image = global::Proyecto_Presentacion.Properties.Resources.empleados;
            this.btnLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogin.Location = new System.Drawing.Point(0, 541);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(220, 50);
            this.btnLogin.TabIndex = 16;
            this.btnLogin.Text = "Conectarse";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click_1);
            // 
            // panelLogin
            // 
            this.panelLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panelLogin.Controls.Add(this.lblPass);
            this.panelLogin.Controls.Add(this.lblUsuario);
            this.panelLogin.Controls.Add(this.textBox2);
            this.panelLogin.Controls.Add(this.textBox1);
            this.panelLogin.Location = new System.Drawing.Point(0, 457);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.Size = new System.Drawing.Size(220, 80);
            this.panelLogin.TabIndex = 13;
            // 
            // lblPass
            // 
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
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.Color.White;
            this.lblUsuario.Location = new System.Drawing.Point(3, 12);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(59, 20);
            this.lblUsuario.TabIndex = 16;
            this.lblUsuario.Text = "Usuario";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBox2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(68, 47);
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = '●';
            this.textBox2.Size = new System.Drawing.Size(143, 25);
            this.textBox2.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(68, 11);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(143, 25);
            this.textBox1.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(39)))));
            this.panel5.Location = new System.Drawing.Point(0, 321);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(5, 50);
            this.panel5.TabIndex = 12;
            // 
            // btnConfiguracion
            // 
            this.btnConfiguracion.FlatAppearance.BorderSize = 0;
            this.btnConfiguracion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(39)))));
            this.btnConfiguracion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(55)))), ((int)(((byte)(34)))));
            this.btnConfiguracion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfiguracion.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfiguracion.ForeColor = System.Drawing.Color.White;
            this.btnConfiguracion.Image = global::Proyecto_Presentacion.Properties.Resources.producto;
            this.btnConfiguracion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfiguracion.Location = new System.Drawing.Point(0, 321);
            this.btnConfiguracion.Name = "btnConfiguracion";
            this.btnConfiguracion.Size = new System.Drawing.Size(220, 50);
            this.btnConfiguracion.TabIndex = 11;
            this.btnConfiguracion.Text = "Configuración";
            this.btnConfiguracion.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(39)))));
            this.panel4.Location = new System.Drawing.Point(0, 265);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(5, 50);
            this.panel4.TabIndex = 10;
            // 
            // btnComunidad
            // 
            this.btnComunidad.FlatAppearance.BorderSize = 0;
            this.btnComunidad.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(39)))));
            this.btnComunidad.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(55)))), ((int)(((byte)(34)))));
            this.btnComunidad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnComunidad.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComunidad.ForeColor = System.Drawing.Color.White;
            this.btnComunidad.Image = global::Proyecto_Presentacion.Properties.Resources.clientes;
            this.btnComunidad.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnComunidad.Location = new System.Drawing.Point(0, 265);
            this.btnComunidad.Name = "btnComunidad";
            this.btnComunidad.Size = new System.Drawing.Size(220, 50);
            this.btnComunidad.TabIndex = 9;
            this.btnComunidad.Text = "Comunidad";
            this.btnComunidad.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(39)))));
            this.panel3.Location = new System.Drawing.Point(0, 209);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(5, 50);
            this.panel3.TabIndex = 8;
            // 
            // btnAreaPersonal
            // 
            this.btnAreaPersonal.FlatAppearance.BorderSize = 0;
            this.btnAreaPersonal.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(39)))));
            this.btnAreaPersonal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(55)))), ((int)(((byte)(34)))));
            this.btnAreaPersonal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAreaPersonal.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAreaPersonal.ForeColor = System.Drawing.Color.White;
            this.btnAreaPersonal.Image = global::Proyecto_Presentacion.Properties.Resources.reportes;
            this.btnAreaPersonal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAreaPersonal.Location = new System.Drawing.Point(0, 209);
            this.btnAreaPersonal.Name = "btnAreaPersonal";
            this.btnAreaPersonal.Size = new System.Drawing.Size(220, 50);
            this.btnAreaPersonal.TabIndex = 7;
            this.btnAreaPersonal.Text = "Area Personal";
            this.btnAreaPersonal.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(39)))));
            this.panel2.Location = new System.Drawing.Point(0, 153);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(5, 50);
            this.panel2.TabIndex = 6;
            // 
            // btnCursos
            // 
            this.btnCursos.FlatAppearance.BorderSize = 0;
            this.btnCursos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(39)))));
            this.btnCursos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(55)))), ((int)(((byte)(34)))));
            this.btnCursos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCursos.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCursos.ForeColor = System.Drawing.Color.White;
            this.btnCursos.Image = global::Proyecto_Presentacion.Properties.Resources.cursos;
            this.btnCursos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCursos.Location = new System.Drawing.Point(0, 153);
            this.btnCursos.Name = "btnCursos";
            this.btnCursos.Size = new System.Drawing.Size(220, 50);
            this.btnCursos.TabIndex = 5;
            this.btnCursos.Text = "Cursos";
            this.btnCursos.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(39)))));
            this.panel1.Location = new System.Drawing.Point(0, 97);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(5, 50);
            this.panel1.TabIndex = 4;
            // 
            // btnPrincipal
            // 
            this.btnPrincipal.FlatAppearance.BorderSize = 0;
            this.btnPrincipal.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(39)))));
            this.btnPrincipal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(55)))), ((int)(((byte)(34)))));
            this.btnPrincipal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrincipal.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrincipal.ForeColor = System.Drawing.Color.White;
            this.btnPrincipal.Image = global::Proyecto_Presentacion.Properties.Resources.principal;
            this.btnPrincipal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrincipal.Location = new System.Drawing.Point(0, 97);
            this.btnPrincipal.Name = "btnPrincipal";
            this.btnPrincipal.Size = new System.Drawing.Size(220, 50);
            this.btnPrincipal.TabIndex = 3;
            this.btnPrincipal.Text = "Principal";
            this.btnPrincipal.UseVisualStyleBackColor = true;
            // 
            // pbOcultarMenu
            // 
            this.pbOcultarMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbOcultarMenu.BackgroundImage = global::Proyecto_Presentacion.Properties.Resources.Mobile_Menu_Icon;
            this.pbOcultarMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbOcultarMenu.Location = new System.Drawing.Point(174, 3);
            this.pbOcultarMenu.Name = "pbOcultarMenu";
            this.pbOcultarMenu.Size = new System.Drawing.Size(40, 32);
            this.pbOcultarMenu.TabIndex = 2;
            this.pbOcultarMenu.TabStop = false;
            this.pbOcultarMenu.Click += new System.EventHandler(this.pbOcultarMenu_Click);
            // 
            // pbTitulo
            // 
            this.pbTitulo.BackgroundImage = global::Proyecto_Presentacion.Properties.Resources.titulo;
            this.pbTitulo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbTitulo.Location = new System.Drawing.Point(0, 51);
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
            this.panelContenido.Size = new System.Drawing.Size(825, 591);
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
            // lblConectado
            // 
            this.lblConectado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblConectado.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConectado.ForeColor = System.Drawing.Color.White;
            this.lblConectado.Location = new System.Drawing.Point(3, 432);
            this.lblConectado.Name = "lblConectado";
            this.lblConectado.Size = new System.Drawing.Size(214, 22);
            this.lblConectado.TabIndex = 18;
            this.lblConectado.Text = "Conectado como invitado";
            this.lblConectado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1045, 623);
            this.Controls.Add(this.panelContenido);
            this.Controls.Add(this.menuLateral);
            this.Controls.Add(this.barraTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.barraTitulo.ResumeLayout(false);
            this.barraTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbIcono)).EndInit();
            this.menuLateral.ResumeLayout(false);
            this.panelLogin.ResumeLayout(false);
            this.panelLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbOcultarMenu)).EndInit();
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
        private System.Windows.Forms.PictureBox pbOcultarMenu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnPrincipal;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnConfiguracion;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnComunidad;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnAreaPersonal;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnCursos;
        private System.Windows.Forms.PictureBox pbIcono;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel panelLogin;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblConectado;
        private System.Windows.Forms.Timer tmOcultarLogin;
        private System.Windows.Forms.Timer tmMostrarLogin;
    }
}

