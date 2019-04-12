namespace Proyecto_Presentacion
{
    partial class FormInicio
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInicio));
            this.panelTrasero = new System.Windows.Forms.Panel();
            this.panelInicio = new System.Windows.Forms.Panel();
            this.panelRegistro = new System.Windows.Forms.Panel();
            this.tbPass2 = new System.Windows.Forms.TextBox();
            this.lblPass2 = new System.Windows.Forms.Label();
            this.tbPass = new System.Windows.Forms.TextBox();
            this.lblPass1 = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.tbUsuario = new System.Windows.Forms.TextBox();
            this.lblApellidos = new System.Windows.Forms.Label();
            this.tbApellidos = new System.Windows.Forms.TextBox();
            this.labelNombre = new System.Windows.Forms.Label();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.lblRegistro = new System.Windows.Forms.Label();
            this.btnRegistro = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelBienvenido = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.pbEmail = new System.Windows.Forms.PictureBox();
            this.pbUser = new System.Windows.Forms.PictureBox();
            this.pbPass1 = new System.Windows.Forms.PictureBox();
            this.pbPass2 = new System.Windows.Forms.PictureBox();
            this.pbName = new System.Windows.Forms.PictureBox();
            this.pbApell = new System.Windows.Forms.PictureBox();
            this.panelTrasero.SuspendLayout();
            this.panelInicio.SuspendLayout();
            this.panelRegistro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPass1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPass2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbApell)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTrasero
            // 
            this.panelTrasero.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelTrasero.BackColor = System.Drawing.Color.Black;
            this.panelTrasero.Controls.Add(this.panelInicio);
            this.panelTrasero.Location = new System.Drawing.Point(209, 149);
            this.panelTrasero.Name = "panelTrasero";
            this.panelTrasero.Size = new System.Drawing.Size(500, 300);
            this.panelTrasero.TabIndex = 0;
            // 
            // panelInicio
            // 
            this.panelInicio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelInicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.panelInicio.Controls.Add(this.panelRegistro);
            this.panelInicio.Controls.Add(this.btnRegistro);
            this.panelInicio.Controls.Add(this.label1);
            this.panelInicio.Controls.Add(this.labelBienvenido);
            this.panelInicio.Location = new System.Drawing.Point(3, 3);
            this.panelInicio.Name = "panelInicio";
            this.panelInicio.Size = new System.Drawing.Size(494, 294);
            this.panelInicio.TabIndex = 1;
            // 
            // panelRegistro
            // 
            this.panelRegistro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelRegistro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.panelRegistro.Controls.Add(this.pbApell);
            this.panelRegistro.Controls.Add(this.pbName);
            this.panelRegistro.Controls.Add(this.pbPass2);
            this.panelRegistro.Controls.Add(this.pbPass1);
            this.panelRegistro.Controls.Add(this.pbUser);
            this.panelRegistro.Controls.Add(this.pbEmail);
            this.panelRegistro.Controls.Add(this.lblCorreo);
            this.panelRegistro.Controls.Add(this.tbEmail);
            this.panelRegistro.Controls.Add(this.tbPass2);
            this.panelRegistro.Controls.Add(this.lblPass2);
            this.panelRegistro.Controls.Add(this.tbPass);
            this.panelRegistro.Controls.Add(this.lblPass1);
            this.panelRegistro.Controls.Add(this.lblUsuario);
            this.panelRegistro.Controls.Add(this.tbUsuario);
            this.panelRegistro.Controls.Add(this.lblApellidos);
            this.panelRegistro.Controls.Add(this.tbApellidos);
            this.panelRegistro.Controls.Add(this.labelNombre);
            this.panelRegistro.Controls.Add(this.tbNombre);
            this.panelRegistro.Controls.Add(this.btnCancelar);
            this.panelRegistro.Controls.Add(this.btnAceptar);
            this.panelRegistro.Controls.Add(this.lblRegistro);
            this.panelRegistro.Location = new System.Drawing.Point(0, 0);
            this.panelRegistro.Name = "panelRegistro";
            this.panelRegistro.Size = new System.Drawing.Size(494, 294);
            this.panelRegistro.TabIndex = 5;
            this.panelRegistro.Visible = false;
            // 
            // tbPass2
            // 
            this.tbPass2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbPass2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPass2.ForeColor = System.Drawing.Color.White;
            this.tbPass2.Location = new System.Drawing.Point(262, 208);
            this.tbPass2.MaxLength = 56;
            this.tbPass2.Name = "tbPass2";
            this.tbPass2.PasswordChar = '●';
            this.tbPass2.Size = new System.Drawing.Size(191, 25);
            this.tbPass2.TabIndex = 6;
            this.tbPass2.TextChanged += new System.EventHandler(this.tbPass2_TextChanged);
            this.tbPass2.Leave += new System.EventHandler(this.tbPass2_Leave);
            // 
            // lblPass2
            // 
            this.lblPass2.AutoSize = true;
            this.lblPass2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPass2.ForeColor = System.Drawing.Color.White;
            this.lblPass2.Location = new System.Drawing.Point(38, 209);
            this.lblPass2.Name = "lblPass2";
            this.lblPass2.Size = new System.Drawing.Size(146, 20);
            this.lblPass2.TabIndex = 15;
            this.lblPass2.Text = "Confirma contraseña";
            // 
            // tbPass
            // 
            this.tbPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbPass.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPass.ForeColor = System.Drawing.Color.White;
            this.tbPass.Location = new System.Drawing.Point(262, 177);
            this.tbPass.MaxLength = 56;
            this.tbPass.Name = "tbPass";
            this.tbPass.PasswordChar = '●';
            this.tbPass.Size = new System.Drawing.Size(191, 25);
            this.tbPass.TabIndex = 5;
            this.tbPass.Leave += new System.EventHandler(this.tbPass_Leave);
            // 
            // lblPass1
            // 
            this.lblPass1.AutoSize = true;
            this.lblPass1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPass1.ForeColor = System.Drawing.Color.White;
            this.lblPass1.Location = new System.Drawing.Point(38, 178);
            this.lblPass1.Name = "lblPass1";
            this.lblPass1.Size = new System.Drawing.Size(148, 20);
            this.lblPass1.TabIndex = 13;
            this.lblPass1.Text = "Introduce contraseña";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.Color.White;
            this.lblUsuario.Location = new System.Drawing.Point(38, 147);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(137, 20);
            this.lblUsuario.TabIndex = 11;
            this.lblUsuario.Text = "Nombre de usuario";
            // 
            // tbUsuario
            // 
            this.tbUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbUsuario.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUsuario.ForeColor = System.Drawing.Color.White;
            this.tbUsuario.Location = new System.Drawing.Point(262, 146);
            this.tbUsuario.MaxLength = 32;
            this.tbUsuario.Name = "tbUsuario";
            this.tbUsuario.Size = new System.Drawing.Size(191, 25);
            this.tbUsuario.TabIndex = 4;
            this.tbUsuario.Leave += new System.EventHandler(this.tbUsuario_Leave);
            // 
            // lblApellidos
            // 
            this.lblApellidos.AutoSize = true;
            this.lblApellidos.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellidos.ForeColor = System.Drawing.Color.White;
            this.lblApellidos.Location = new System.Drawing.Point(38, 85);
            this.lblApellidos.Name = "lblApellidos";
            this.lblApellidos.Size = new System.Drawing.Size(72, 20);
            this.lblApellidos.TabIndex = 9;
            this.lblApellidos.Text = "Apellidos";
            // 
            // tbApellidos
            // 
            this.tbApellidos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbApellidos.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbApellidos.ForeColor = System.Drawing.Color.White;
            this.tbApellidos.Location = new System.Drawing.Point(137, 84);
            this.tbApellidos.MaxLength = 64;
            this.tbApellidos.Name = "tbApellidos";
            this.tbApellidos.Size = new System.Drawing.Size(316, 25);
            this.tbApellidos.TabIndex = 2;
            this.tbApellidos.Leave += new System.EventHandler(this.tbApellido_Leave);
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombre.ForeColor = System.Drawing.Color.White;
            this.labelNombre.Location = new System.Drawing.Point(38, 54);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(64, 20);
            this.labelNombre.TabIndex = 7;
            this.labelNombre.Text = "Nombre";
            // 
            // tbNombre
            // 
            this.tbNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbNombre.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNombre.ForeColor = System.Drawing.Color.White;
            this.tbNombre.Location = new System.Drawing.Point(137, 53);
            this.tbNombre.MaxLength = 64;
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(316, 25);
            this.tbNombre.TabIndex = 1;
            this.tbNombre.Leave += new System.EventHandler(this.tbNombre_Leave);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(39)))));
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(55)))), ((int)(((byte)(34)))));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(65, 244);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(140, 40);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.TabStop = false;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAceptar.Enabled = false;
            this.btnAceptar.FlatAppearance.BorderSize = 0;
            this.btnAceptar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(39)))));
            this.btnAceptar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(55)))), ((int)(((byte)(34)))));
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAceptar.Location = new System.Drawing.Point(289, 244);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(140, 40);
            this.btnAceptar.TabIndex = 4;
            this.btnAceptar.TabStop = false;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // lblRegistro
            // 
            this.lblRegistro.AutoSize = true;
            this.lblRegistro.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistro.ForeColor = System.Drawing.Color.White;
            this.lblRegistro.Location = new System.Drawing.Point(123, 6);
            this.lblRegistro.Name = "lblRegistro";
            this.lblRegistro.Size = new System.Drawing.Size(256, 25);
            this.lblRegistro.TabIndex = 0;
            this.lblRegistro.Text = "Introduce tus datos por favor";
            // 
            // btnRegistro
            // 
            this.btnRegistro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistro.FlatAppearance.BorderSize = 0;
            this.btnRegistro.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(39)))));
            this.btnRegistro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(55)))), ((int)(((byte)(34)))));
            this.btnRegistro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistro.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnRegistro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegistro.Location = new System.Drawing.Point(143, 244);
            this.btnRegistro.Name = "btnRegistro";
            this.btnRegistro.Size = new System.Drawing.Size(212, 38);
            this.btnRegistro.TabIndex = 4;
            this.btnRegistro.TabStop = false;
            this.btnRegistro.Text = "Regístrate pulsando aquí";
            this.btnRegistro.UseVisualStyleBackColor = true;
            this.btnRegistro.Click += new System.EventHandler(this.btnRegistro_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(30, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(442, 189);
            this.label1.TabIndex = 1;
            this.label1.Text = resources.GetString("label1.Text");
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelBienvenido
            // 
            this.labelBienvenido.AutoSize = true;
            this.labelBienvenido.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBienvenido.ForeColor = System.Drawing.Color.White;
            this.labelBienvenido.Location = new System.Drawing.Point(132, 6);
            this.labelBienvenido.Name = "labelBienvenido";
            this.labelBienvenido.Size = new System.Drawing.Size(233, 25);
            this.labelBienvenido.TabIndex = 0;
            this.labelBienvenido.Text = "¡Bienvenido a DAMnificus!";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::Proyecto_Presentacion.Properties.Resources.titulo;
            this.pictureBox1.Location = new System.Drawing.Point(169, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(575, 105);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorreo.ForeColor = System.Drawing.Color.White;
            this.lblCorreo.Location = new System.Drawing.Point(38, 116);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(132, 20);
            this.lblCorreo.TabIndex = 18;
            this.lblCorreo.Text = "Correo electrónico";
            // 
            // tbEmail
            // 
            this.tbEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbEmail.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEmail.ForeColor = System.Drawing.Color.White;
            this.tbEmail.Location = new System.Drawing.Point(196, 115);
            this.tbEmail.MaxLength = 89;
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(257, 25);
            this.tbEmail.TabIndex = 3;
            this.tbEmail.Leave += new System.EventHandler(this.tbEmail_Leave);
            // 
            // pbEmail
            // 
            this.pbEmail.Location = new System.Drawing.Point(459, 120);
            this.pbEmail.Name = "pbEmail";
            this.pbEmail.Size = new System.Drawing.Size(16, 16);
            this.pbEmail.TabIndex = 19;
            this.pbEmail.TabStop = false;
            // 
            // pbUser
            // 
            this.pbUser.Location = new System.Drawing.Point(459, 151);
            this.pbUser.Name = "pbUser";
            this.pbUser.Size = new System.Drawing.Size(16, 16);
            this.pbUser.TabIndex = 20;
            this.pbUser.TabStop = false;
            // 
            // pbPass1
            // 
            this.pbPass1.Location = new System.Drawing.Point(459, 182);
            this.pbPass1.Name = "pbPass1";
            this.pbPass1.Size = new System.Drawing.Size(16, 16);
            this.pbPass1.TabIndex = 21;
            this.pbPass1.TabStop = false;
            // 
            // pbPass2
            // 
            this.pbPass2.Location = new System.Drawing.Point(459, 213);
            this.pbPass2.Name = "pbPass2";
            this.pbPass2.Size = new System.Drawing.Size(16, 16);
            this.pbPass2.TabIndex = 22;
            this.pbPass2.TabStop = false;
            // 
            // pbName
            // 
            this.pbName.Location = new System.Drawing.Point(459, 58);
            this.pbName.Name = "pbName";
            this.pbName.Size = new System.Drawing.Size(16, 16);
            this.pbName.TabIndex = 23;
            this.pbName.TabStop = false;
            // 
            // pbApell
            // 
            this.pbApell.Location = new System.Drawing.Point(459, 89);
            this.pbApell.Name = "pbApell";
            this.pbApell.Size = new System.Drawing.Size(16, 16);
            this.pbApell.TabIndex = 24;
            this.pbApell.TabStop = false;
            // 
            // FormInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.BackgroundImage = global::Proyecto_Presentacion.Properties.Resources.fondo_inicio_naranja;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(921, 594);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panelTrasero);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormInicio";
            this.Text = "FormInicio";
            this.panelTrasero.ResumeLayout(false);
            this.panelInicio.ResumeLayout(false);
            this.panelInicio.PerformLayout();
            this.panelRegistro.ResumeLayout(false);
            this.panelRegistro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPass1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPass2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbApell)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTrasero;
        private System.Windows.Forms.Panel panelInicio;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelBienvenido;
        private System.Windows.Forms.Button btnRegistro;
        private System.Windows.Forms.Panel panelRegistro;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label lblRegistro;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.Label lblApellidos;
        private System.Windows.Forms.TextBox tbApellidos;
        private System.Windows.Forms.Label lblPass1;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.TextBox tbUsuario;
        private System.Windows.Forms.TextBox tbPass2;
        private System.Windows.Forms.Label lblPass2;
        private System.Windows.Forms.TextBox tbPass;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.PictureBox pbPass2;
        private System.Windows.Forms.PictureBox pbPass1;
        private System.Windows.Forms.PictureBox pbUser;
        private System.Windows.Forms.PictureBox pbEmail;
        private System.Windows.Forms.PictureBox pbApell;
        private System.Windows.Forms.PictureBox pbName;
    }
}