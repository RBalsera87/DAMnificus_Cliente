namespace Proyecto_Presentacion
{
    partial class FormAyuda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAyuda));
            this.panelCabecera = new System.Windows.Forms.Panel();
            this.lblAyuda = new System.Windows.Forms.Label();
            this.tablePanel = new System.Windows.Forms.TableLayoutPanel();
            this.panelTexto = new System.Windows.Forms.Panel();
            this.labelPassExp = new System.Windows.Forms.Label();
            this.panelTrasero = new System.Windows.Forms.Panel();
            this.panelPassOlvidada = new System.Windows.Forms.Panel();
            this.lblPass2 = new System.Windows.Forms.Label();
            this.panelCambiarPass = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tbPass2 = new System.Windows.Forms.TextBox();
            this.lblPass = new System.Windows.Forms.Label();
            this.tbPass = new System.Windows.Forms.TextBox();
            this.btnEnviarEmailToken = new System.Windows.Forms.Button();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.tbEmailToken = new System.Windows.Forms.TextBox();
            this.lblPassPerdida = new System.Windows.Forms.Label();
            this.lblCambiarPassExp = new System.Windows.Forms.Label();
            this.panelReportar = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.btnEnvReporte = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tbReporte = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelCabecera.SuspendLayout();
            this.tablePanel.SuspendLayout();
            this.panelTexto.SuspendLayout();
            this.panelTrasero.SuspendLayout();
            this.panelPassOlvidada.SuspendLayout();
            this.panelCambiarPass.SuspendLayout();
            this.panelReportar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelCabecera
            // 
            this.panelCabecera.BackColor = System.Drawing.Color.Black;
            this.panelCabecera.Controls.Add(this.panel1);
            this.panelCabecera.Controls.Add(this.lblAyuda);
            this.panelCabecera.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCabecera.Location = new System.Drawing.Point(0, 0);
            this.panelCabecera.Name = "panelCabecera";
            this.panelCabecera.Size = new System.Drawing.Size(915, 40);
            this.panelCabecera.TabIndex = 0;
            // 
            // lblAyuda
            // 
            this.lblAyuda.AutoSize = true;
            this.lblAyuda.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAyuda.ForeColor = System.Drawing.Color.White;
            this.lblAyuda.Location = new System.Drawing.Point(11, 7);
            this.lblAyuda.Name = "lblAyuda";
            this.lblAyuda.Size = new System.Drawing.Size(65, 25);
            this.lblAyuda.TabIndex = 17;
            this.lblAyuda.Text = "Ayuda";
            // 
            // tablePanel
            // 
            this.tablePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tablePanel.ColumnCount = 2;
            this.tablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tablePanel.Controls.Add(this.panelTexto, 1, 0);
            this.tablePanel.Controls.Add(this.panelTrasero, 0, 0);
            this.tablePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanel.Location = new System.Drawing.Point(0, 40);
            this.tablePanel.Name = "tablePanel";
            this.tablePanel.RowCount = 1;
            this.tablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tablePanel.Size = new System.Drawing.Size(915, 571);
            this.tablePanel.TabIndex = 1;
            // 
            // panelTexto
            // 
            this.panelTexto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelTexto.Controls.Add(this.label9);
            this.panelTexto.Controls.Add(this.lblCambiarPassExp);
            this.panelTexto.Controls.Add(this.labelPassExp);
            this.panelTexto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTexto.Location = new System.Drawing.Point(552, 3);
            this.panelTexto.Name = "panelTexto";
            this.panelTexto.Size = new System.Drawing.Size(360, 565);
            this.panelTexto.TabIndex = 1;
            // 
            // labelPassExp
            // 
            this.labelPassExp.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.labelPassExp.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPassExp.ForeColor = System.Drawing.Color.White;
            this.labelPassExp.Location = new System.Drawing.Point(0, 414);
            this.labelPassExp.Name = "labelPassExp";
            this.labelPassExp.Size = new System.Drawing.Size(360, 151);
            this.labelPassExp.TabIndex = 18;
            this.labelPassExp.Text = resources.GetString("labelPassExp.Text");
            this.labelPassExp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelTrasero
            // 
            this.panelTrasero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.panelTrasero.Controls.Add(this.panelReportar);
            this.panelTrasero.Controls.Add(this.panelPassOlvidada);
            this.panelTrasero.Controls.Add(this.panelCambiarPass);
            this.panelTrasero.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTrasero.Location = new System.Drawing.Point(3, 3);
            this.panelTrasero.Name = "panelTrasero";
            this.panelTrasero.Size = new System.Drawing.Size(543, 565);
            this.panelTrasero.TabIndex = 2;
            // 
            // panelPassOlvidada
            // 
            this.panelPassOlvidada.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.panelPassOlvidada.Controls.Add(this.lblPass2);
            this.panelPassOlvidada.Controls.Add(this.tbPass2);
            this.panelPassOlvidada.Controls.Add(this.lblPass);
            this.panelPassOlvidada.Controls.Add(this.tbPass);
            this.panelPassOlvidada.Controls.Add(this.btnEnviarEmailToken);
            this.panelPassOlvidada.Controls.Add(this.lblCorreo);
            this.panelPassOlvidada.Controls.Add(this.tbEmailToken);
            this.panelPassOlvidada.Controls.Add(this.lblPassPerdida);
            this.panelPassOlvidada.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelPassOlvidada.Location = new System.Drawing.Point(0, 411);
            this.panelPassOlvidada.Name = "panelPassOlvidada";
            this.panelPassOlvidada.Size = new System.Drawing.Size(543, 154);
            this.panelPassOlvidada.TabIndex = 1;
            // 
            // lblPass2
            // 
            this.lblPass2.AutoSize = true;
            this.lblPass2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPass2.ForeColor = System.Drawing.Color.DarkGray;
            this.lblPass2.Location = new System.Drawing.Point(9, 110);
            this.lblPass2.Name = "lblPass2";
            this.lblPass2.Size = new System.Drawing.Size(133, 20);
            this.lblPass2.TabIndex = 25;
            this.lblPass2.Text = "Escríbela de nuevo";
            // 
            // panelCambiarPass
            // 
            this.panelCambiarPass.Controls.Add(this.label4);
            this.panelCambiarPass.Controls.Add(this.textBox3);
            this.panelCambiarPass.Controls.Add(this.textBox1);
            this.panelCambiarPass.Controls.Add(this.label3);
            this.panelCambiarPass.Controls.Add(this.label1);
            this.panelCambiarPass.Controls.Add(this.textBox2);
            this.panelCambiarPass.Controls.Add(this.label2);
            this.panelCambiarPass.Controls.Add(this.button1);
            this.panelCambiarPass.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCambiarPass.Location = new System.Drawing.Point(0, 0);
            this.panelCambiarPass.Name = "panelCambiarPass";
            this.panelCambiarPass.Size = new System.Drawing.Size(543, 151);
            this.panelCambiarPass.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkGray;
            this.label4.Location = new System.Drawing.Point(9, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 20);
            this.label4.TabIndex = 26;
            this.label4.Text = "Escríbela de nuevo";
            // 
            // textBox3
            // 
            this.textBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBox3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.ForeColor = System.Drawing.Color.White;
            this.textBox3.Location = new System.Drawing.Point(148, 49);
            this.textBox3.MaxLength = 56;
            this.textBox3.Name = "textBox3";
            this.textBox3.PasswordChar = '●';
            this.textBox3.Size = new System.Drawing.Size(224, 25);
            this.textBox3.TabIndex = 32;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(148, 110);
            this.textBox1.MaxLength = 56;
            this.textBox1.Name = "textBox1";
            this.textBox1.PasswordChar = '●';
            this.textBox1.Size = new System.Drawing.Size(224, 25);
            this.textBox1.TabIndex = 31;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(9, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 21);
            this.label3.TabIndex = 25;
            this.label3.Text = "Cambiar contraseña";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGray;
            this.label1.Location = new System.Drawing.Point(9, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 20);
            this.label1.TabIndex = 30;
            this.label1.Text = "Contraseña nueva";
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBox2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.Color.White;
            this.textBox2.Location = new System.Drawing.Point(148, 79);
            this.textBox2.MaxLength = 56;
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = '●';
            this.textBox2.Size = new System.Drawing.Size(224, 25);
            this.textBox2.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkGray;
            this.label2.Location = new System.Drawing.Point(9, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 20);
            this.label2.TabIndex = 27;
            this.label2.Text = "Contraseña actual";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(39)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(55)))), ((int)(((byte)(34)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(401, 64);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 59);
            this.button1.TabIndex = 28;
            this.button1.TabStop = false;
            this.button1.Text = "Cambiar contraseña";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // tbPass2
            // 
            this.tbPass2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPass2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbPass2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPass2.ForeColor = System.Drawing.Color.White;
            this.tbPass2.Location = new System.Drawing.Point(148, 109);
            this.tbPass2.MaxLength = 56;
            this.tbPass2.Name = "tbPass2";
            this.tbPass2.PasswordChar = '●';
            this.tbPass2.Size = new System.Drawing.Size(224, 25);
            this.tbPass2.TabIndex = 23;
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPass.ForeColor = System.Drawing.Color.DarkGray;
            this.lblPass.Location = new System.Drawing.Point(9, 79);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(126, 20);
            this.lblPass.TabIndex = 22;
            this.lblPass.Text = "Contraseña nueva";
            // 
            // tbPass
            // 
            this.tbPass.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbPass.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPass.ForeColor = System.Drawing.Color.White;
            this.tbPass.Location = new System.Drawing.Point(148, 79);
            this.tbPass.MaxLength = 56;
            this.tbPass.Name = "tbPass";
            this.tbPass.PasswordChar = '●';
            this.tbPass.Size = new System.Drawing.Size(224, 25);
            this.tbPass.TabIndex = 21;
            // 
            // btnEnviarEmailToken
            // 
            this.btnEnviarEmailToken.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEnviarEmailToken.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEnviarEmailToken.FlatAppearance.BorderSize = 0;
            this.btnEnviarEmailToken.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(39)))));
            this.btnEnviarEmailToken.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(55)))), ((int)(((byte)(34)))));
            this.btnEnviarEmailToken.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnviarEmailToken.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnviarEmailToken.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnEnviarEmailToken.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEnviarEmailToken.Location = new System.Drawing.Point(401, 65);
            this.btnEnviarEmailToken.Name = "btnEnviarEmailToken";
            this.btnEnviarEmailToken.Size = new System.Drawing.Size(115, 56);
            this.btnEnviarEmailToken.TabIndex = 20;
            this.btnEnviarEmailToken.TabStop = false;
            this.btnEnviarEmailToken.Text = "Enviar email";
            this.btnEnviarEmailToken.UseVisualStyleBackColor = true;
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorreo.ForeColor = System.Drawing.Color.DarkGray;
            this.lblCorreo.Location = new System.Drawing.Point(9, 47);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(46, 20);
            this.lblCorreo.TabIndex = 19;
            this.lblCorreo.Text = "Email";
            // 
            // tbEmailToken
            // 
            this.tbEmailToken.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbEmailToken.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbEmailToken.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEmailToken.ForeColor = System.Drawing.Color.White;
            this.tbEmailToken.Location = new System.Drawing.Point(61, 47);
            this.tbEmailToken.MaxLength = 89;
            this.tbEmailToken.Name = "tbEmailToken";
            this.tbEmailToken.Size = new System.Drawing.Size(311, 25);
            this.tbEmailToken.TabIndex = 18;
            // 
            // lblPassPerdida
            // 
            this.lblPassPerdida.AutoSize = true;
            this.lblPassPerdida.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassPerdida.ForeColor = System.Drawing.Color.White;
            this.lblPassPerdida.Location = new System.Drawing.Point(9, 9);
            this.lblPassPerdida.Name = "lblPassPerdida";
            this.lblPassPerdida.Size = new System.Drawing.Size(152, 21);
            this.lblPassPerdida.TabIndex = 17;
            this.lblPassPerdida.Text = "Contraseña olvidada";
            // 
            // lblCambiarPassExp
            // 
            this.lblCambiarPassExp.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblCambiarPassExp.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCambiarPassExp.ForeColor = System.Drawing.Color.White;
            this.lblCambiarPassExp.Location = new System.Drawing.Point(0, 0);
            this.lblCambiarPassExp.Name = "lblCambiarPassExp";
            this.lblCambiarPassExp.Size = new System.Drawing.Size(360, 151);
            this.lblCambiarPassExp.TabIndex = 19;
            this.lblCambiarPassExp.Text = resources.GetString("lblCambiarPassExp.Text");
            this.lblCambiarPassExp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelReportar
            // 
            this.panelReportar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.panelReportar.Controls.Add(this.tbReporte);
            this.panelReportar.Controls.Add(this.label6);
            this.panelReportar.Controls.Add(this.btnEnvReporte);
            this.panelReportar.Controls.Add(this.label7);
            this.panelReportar.Controls.Add(this.textBox6);
            this.panelReportar.Controls.Add(this.label8);
            this.panelReportar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelReportar.Location = new System.Drawing.Point(0, 151);
            this.panelReportar.Name = "panelReportar";
            this.panelReportar.Size = new System.Drawing.Size(543, 260);
            this.panelReportar.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkGray;
            this.label6.Location = new System.Drawing.Point(9, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 20);
            this.label6.TabIndex = 22;
            this.label6.Text = "Descripción";
            // 
            // btnEnvReporte
            // 
            this.btnEnvReporte.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEnvReporte.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEnvReporte.FlatAppearance.BorderSize = 0;
            this.btnEnvReporte.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(39)))));
            this.btnEnvReporte.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(55)))), ((int)(((byte)(34)))));
            this.btnEnvReporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnvReporte.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnvReporte.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnEnvReporte.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEnvReporte.Location = new System.Drawing.Point(401, 29);
            this.btnEnvReporte.Name = "btnEnvReporte";
            this.btnEnvReporte.Size = new System.Drawing.Size(115, 55);
            this.btnEnvReporte.TabIndex = 20;
            this.btnEnvReporte.TabStop = false;
            this.btnEnvReporte.Text = "Enviar reporte";
            this.btnEnvReporte.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DarkGray;
            this.label7.Location = new System.Drawing.Point(9, 47);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 20);
            this.label7.TabIndex = 19;
            this.label7.Text = "Título";
            // 
            // textBox6
            // 
            this.textBox6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBox6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox6.ForeColor = System.Drawing.Color.White;
            this.textBox6.Location = new System.Drawing.Point(61, 46);
            this.textBox6.MaxLength = 89;
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(311, 25);
            this.textBox6.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(9, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(241, 21);
            this.label8.TabIndex = 17;
            this.label8.Text = "Reportar bug o enviar sugerencia\r\n";
            // 
            // label9
            // 
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(0, 151);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(360, 263);
            this.label9.TabIndex = 20;
            this.label9.Text = resources.GetString("label9.Text");
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbReporte
            // 
            this.tbReporte.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbReporte.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbReporte.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbReporte.ForeColor = System.Drawing.Color.White;
            this.tbReporte.Location = new System.Drawing.Point(13, 102);
            this.tbReporte.MaxLength = 1000;
            this.tbReporte.Multiline = true;
            this.tbReporte.Name = "tbReporte";
            this.tbReporte.Size = new System.Drawing.Size(503, 152);
            this.tbReporte.TabIndex = 26;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(39)))));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(5, 40);
            this.panel1.TabIndex = 33;
            // 
            // FormAyuda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(915, 611);
            this.Controls.Add(this.tablePanel);
            this.Controls.Add(this.panelCabecera);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAyuda";
            this.Text = "FormAyuda";
            this.Load += new System.EventHandler(this.FormAyuda_Load);
            this.panelCabecera.ResumeLayout(false);
            this.panelCabecera.PerformLayout();
            this.tablePanel.ResumeLayout(false);
            this.panelTexto.ResumeLayout(false);
            this.panelTrasero.ResumeLayout(false);
            this.panelPassOlvidada.ResumeLayout(false);
            this.panelPassOlvidada.PerformLayout();
            this.panelCambiarPass.ResumeLayout(false);
            this.panelCambiarPass.PerformLayout();
            this.panelReportar.ResumeLayout(false);
            this.panelReportar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelCabecera;
        private System.Windows.Forms.Label lblAyuda;
        private System.Windows.Forms.TableLayoutPanel tablePanel;
        private System.Windows.Forms.Panel panelTexto;
        private System.Windows.Forms.Label labelPassExp;
        private System.Windows.Forms.Panel panelTrasero;
        private System.Windows.Forms.Panel panelPassOlvidada;
        private System.Windows.Forms.Label lblPass2;
        private System.Windows.Forms.TextBox tbPass2;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.TextBox tbPass;
        private System.Windows.Forms.Button btnEnviarEmailToken;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.TextBox tbEmailToken;
        private System.Windows.Forms.Label lblPassPerdida;
        private System.Windows.Forms.Panel panelCambiarPass;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblCambiarPassExp;
        private System.Windows.Forms.Panel panelReportar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnEnvReporte;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbReporte;
        private System.Windows.Forms.Panel panel1;
    }
}