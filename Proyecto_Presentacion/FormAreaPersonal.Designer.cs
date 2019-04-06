namespace Proyecto_Presentacion
{
    partial class FormAreaPersonal
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
            this.graficoBarras = new LiveCharts.WinForms.CartesianChart();
            this.panelCabecera = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSegundo = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnPrimero = new System.Windows.Forms.Button();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnIntroducirNota = new System.Windows.Forms.Button();
            this.panelDinamico1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnT1 = new System.Windows.Forms.Button();
            this.btnT2 = new System.Windows.Forms.Button();
            this.btnT3 = new System.Windows.Forms.Button();
            this.btnTF = new System.Windows.Forms.Button();
            this.panelCabecera.SuspendLayout();
            this.panelContenedor.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panelDinamico1.SuspendLayout();
            this.SuspendLayout();
            // 
            // graficoBarras
            // 
            this.graficoBarras.Dock = System.Windows.Forms.DockStyle.Fill;
            this.graficoBarras.Location = new System.Drawing.Point(0, 0);
            this.graficoBarras.Margin = new System.Windows.Forms.Padding(3, 3, 3, 20);
            this.graficoBarras.Name = "graficoBarras";
            this.graficoBarras.Size = new System.Drawing.Size(999, 637);
            this.graficoBarras.TabIndex = 0;
            this.graficoBarras.Text = "cartesianChart1";
            this.graficoBarras.ChildChanged += new System.EventHandler<System.Windows.Forms.Integration.ChildChangedEventArgs>(this.cartesianChart1_ChildChanged);
            // 
            // panelCabecera
            // 
            this.panelCabecera.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.panelCabecera.Controls.Add(this.panel2);
            this.panelCabecera.Controls.Add(this.btnSegundo);
            this.panelCabecera.Controls.Add(this.panel1);
            this.panelCabecera.Controls.Add(this.btnPrimero);
            this.panelCabecera.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCabecera.Location = new System.Drawing.Point(0, 0);
            this.panelCabecera.Name = "panelCabecera";
            this.panelCabecera.Size = new System.Drawing.Size(999, 40);
            this.panelCabecera.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(39)))));
            this.panel2.Location = new System.Drawing.Point(152, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(5, 40);
            this.panel2.TabIndex = 21;
            // 
            // btnSegundo
            // 
            this.btnSegundo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSegundo.FlatAppearance.BorderSize = 0;
            this.btnSegundo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(39)))));
            this.btnSegundo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(55)))), ((int)(((byte)(34)))));
            this.btnSegundo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSegundo.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSegundo.ForeColor = System.Drawing.Color.White;
            this.btnSegundo.Image = global::Proyecto_Presentacion.Properties.Resources.iconocurso;
            this.btnSegundo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSegundo.Location = new System.Drawing.Point(152, 0);
            this.btnSegundo.Name = "btnSegundo";
            this.btnSegundo.Size = new System.Drawing.Size(170, 40);
            this.btnSegundo.TabIndex = 20;
            this.btnSegundo.Text = "Segundo curso";
            this.btnSegundo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSegundo.UseVisualStyleBackColor = true;
            this.btnSegundo.Click += new System.EventHandler(this.btnSegundo_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(39)))));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(5, 40);
            this.panel1.TabIndex = 19;
            // 
            // btnPrimero
            // 
            this.btnPrimero.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrimero.FlatAppearance.BorderSize = 0;
            this.btnPrimero.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(39)))));
            this.btnPrimero.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(55)))), ((int)(((byte)(34)))));
            this.btnPrimero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrimero.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrimero.ForeColor = System.Drawing.Color.White;
            this.btnPrimero.Image = global::Proyecto_Presentacion.Properties.Resources.iconocurso;
            this.btnPrimero.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrimero.Location = new System.Drawing.Point(0, 0);
            this.btnPrimero.Name = "btnPrimero";
            this.btnPrimero.Size = new System.Drawing.Size(152, 40);
            this.btnPrimero.TabIndex = 18;
            this.btnPrimero.Text = "Primer curso";
            this.btnPrimero.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPrimero.UseVisualStyleBackColor = true;
            this.btnPrimero.Click += new System.EventHandler(this.btnPrimero_Click);
            // 
            // panelContenedor
            // 
            this.panelContenedor.Controls.Add(this.graficoBarras);
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(0, 40);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(999, 637);
            this.panelContenedor.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.btnIntroducirNota);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 637);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(999, 40);
            this.panel3.TabIndex = 3;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(39)))));
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(5, 40);
            this.panel5.TabIndex = 19;
            // 
            // btnIntroducirNota
            // 
            this.btnIntroducirNota.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIntroducirNota.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnIntroducirNota.FlatAppearance.BorderSize = 0;
            this.btnIntroducirNota.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(39)))));
            this.btnIntroducirNota.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(55)))), ((int)(((byte)(34)))));
            this.btnIntroducirNota.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIntroducirNota.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIntroducirNota.ForeColor = System.Drawing.Color.White;
            this.btnIntroducirNota.Image = global::Proyecto_Presentacion.Properties.Resources.iconocurso;
            this.btnIntroducirNota.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIntroducirNota.Location = new System.Drawing.Point(0, 0);
            this.btnIntroducirNota.Name = "btnIntroducirNota";
            this.btnIntroducirNota.Size = new System.Drawing.Size(999, 40);
            this.btnIntroducirNota.TabIndex = 18;
            this.btnIntroducirNota.Text = "INTRODUCIR NOTA";
            this.btnIntroducirNota.UseVisualStyleBackColor = true;
            this.btnIntroducirNota.Click += new System.EventHandler(this.btnIntroducirNota_Click);
            // 
            // panelDinamico1
            // 
            this.panelDinamico1.Controls.Add(this.btnT1);
            this.panelDinamico1.Controls.Add(this.btnT2);
            this.panelDinamico1.Controls.Add(this.btnT3);
            this.panelDinamico1.Controls.Add(this.btnTF);
            this.panelDinamico1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelDinamico1.Location = new System.Drawing.Point(0, 40);
            this.panelDinamico1.Name = "panelDinamico1";
            this.panelDinamico1.Size = new System.Drawing.Size(999, 40);
            this.panelDinamico1.TabIndex = 5;
            // 
            // btnT1
            // 
            this.btnT1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnT1.FlatAppearance.BorderSize = 0;
            this.btnT1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(39)))));
            this.btnT1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(55)))), ((int)(((byte)(34)))));
            this.btnT1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnT1.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnT1.ForeColor = System.Drawing.Color.White;
            this.btnT1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnT1.Location = new System.Drawing.Point(3, 3);
            this.btnT1.Name = "btnT1";
            this.btnT1.Size = new System.Drawing.Size(137, 40);
            this.btnT1.TabIndex = 22;
            this.btnT1.Text = "TRIMESTRE 1";
            this.btnT1.UseVisualStyleBackColor = true;
            this.btnT1.Click += new System.EventHandler(this.btnT1_Click);
            // 
            // btnT2
            // 
            this.btnT2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnT2.FlatAppearance.BorderSize = 0;
            this.btnT2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(39)))));
            this.btnT2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(55)))), ((int)(((byte)(34)))));
            this.btnT2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnT2.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnT2.ForeColor = System.Drawing.Color.White;
            this.btnT2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnT2.Location = new System.Drawing.Point(146, 3);
            this.btnT2.Name = "btnT2";
            this.btnT2.Size = new System.Drawing.Size(179, 40);
            this.btnT2.TabIndex = 24;
            this.btnT2.Text = "TRIMESTRE 2";
            this.btnT2.UseVisualStyleBackColor = true;
            this.btnT2.Click += new System.EventHandler(this.btnT2_Click);
            // 
            // btnT3
            // 
            this.btnT3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnT3.FlatAppearance.BorderSize = 0;
            this.btnT3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(39)))));
            this.btnT3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(55)))), ((int)(((byte)(34)))));
            this.btnT3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnT3.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnT3.ForeColor = System.Drawing.Color.White;
            this.btnT3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnT3.Location = new System.Drawing.Point(331, 3);
            this.btnT3.Name = "btnT3";
            this.btnT3.Size = new System.Drawing.Size(179, 40);
            this.btnT3.TabIndex = 25;
            this.btnT3.Text = "TRIMESTRE 3";
            this.btnT3.UseVisualStyleBackColor = true;
            this.btnT3.Click += new System.EventHandler(this.btnT3_Click);
            // 
            // btnTF
            // 
            this.btnTF.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTF.FlatAppearance.BorderSize = 0;
            this.btnTF.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(39)))));
            this.btnTF.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(55)))), ((int)(((byte)(34)))));
            this.btnTF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTF.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTF.ForeColor = System.Drawing.Color.White;
            this.btnTF.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTF.Location = new System.Drawing.Point(516, 3);
            this.btnTF.Name = "btnTF";
            this.btnTF.Size = new System.Drawing.Size(133, 40);
            this.btnTF.TabIndex = 26;
            this.btnTF.Text = "FINAL";
            this.btnTF.UseVisualStyleBackColor = true;
            this.btnTF.Click += new System.EventHandler(this.btnTF_Click);
            // 
            // FormAreaPersonal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(999, 677);
            this.Controls.Add(this.panelDinamico1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.panelCabecera);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAreaPersonal";
            this.Text = "FormAreaPersonal";
            this.panelCabecera.ResumeLayout(false);
            this.panelContenedor.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panelDinamico1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private LiveCharts.WinForms.CartesianChart graficoBarras;
        private System.Windows.Forms.Panel panelCabecera;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSegundo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnPrimero;
        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnIntroducirNota;
        private System.Windows.Forms.FlowLayoutPanel panelDinamico1;
        private System.Windows.Forms.Button btnT1;
        private System.Windows.Forms.Button btnT2;
        private System.Windows.Forms.Button btnT3;
        private System.Windows.Forms.Button btnTF;
    }
}