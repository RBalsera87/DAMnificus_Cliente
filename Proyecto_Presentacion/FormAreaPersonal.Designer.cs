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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbAsignatura = new System.Windows.Forms.ComboBox();
            this.elementHost1 = new System.Windows.Forms.Integration.ElementHost();
            this.graficaNotas = new LiveCharts.Wpf.CartesianChart();
            this.cbCurso = new System.Windows.Forms.ComboBox();
            this.cbTrimestre = new System.Windows.Forms.ComboBox();
            this.btnAgregarNota = new System.Windows.Forms.Button();
            this.nota = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.graficaValoraciones = new LiveCharts.WinForms.AngularGauge();
            this.label5 = new System.Windows.Forms.Label();
            this.cbGraficaNotas = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nota)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.cbAsignatura, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.elementHost1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.cbCurso, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.cbTrimestre, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.btnAgregarNota, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.nota, 0, 9);
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.graficaValoraciones, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.cbGraficaNotas, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 10;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.000083F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52.14086F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.357384F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.357384F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.357384F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.357384F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.357384F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.357384F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.357384F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.357384F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1127, 771);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semilight", 15F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(3, 604);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(557, 41);
            this.label4.TabIndex = 12;
            this.label4.Text = "TRIMESTRE";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semilight", 15F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(3, 522);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(557, 41);
            this.label3.TabIndex = 11;
            this.label3.Text = "ASIGNATURA";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semilight", 15F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 440);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(557, 41);
            this.label2.TabIndex = 10;
            this.label2.Text = "CURSO";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbAsignatura
            // 
            this.cbAsignatura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cbAsignatura.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbAsignatura.Font = new System.Drawing.Font("Segoe UI Semilight", 10F);
            this.cbAsignatura.ForeColor = System.Drawing.Color.White;
            this.cbAsignatura.FormattingEnabled = true;
            this.cbAsignatura.Location = new System.Drawing.Point(3, 566);
            this.cbAsignatura.Name = "cbAsignatura";
            this.cbAsignatura.Size = new System.Drawing.Size(557, 25);
            this.cbAsignatura.TabIndex = 3;
            this.cbAsignatura.SelectedIndexChanged += new System.EventHandler(this.cbAsignatura_SelectedIndexChanged);
            // 
            // elementHost1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.elementHost1, 2);
            this.elementHost1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.elementHost1.Location = new System.Drawing.Point(3, 41);
            this.elementHost1.Name = "elementHost1";
            this.elementHost1.Size = new System.Drawing.Size(1121, 396);
            this.elementHost1.TabIndex = 0;
            this.elementHost1.Text = "elementHost1";
            this.elementHost1.Child = this.graficaNotas;
            // 
            // cbCurso
            // 
            this.cbCurso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cbCurso.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbCurso.Font = new System.Drawing.Font("Segoe UI Semilight", 10F);
            this.cbCurso.ForeColor = System.Drawing.Color.White;
            this.cbCurso.FormattingEnabled = true;
            this.cbCurso.Location = new System.Drawing.Point(3, 484);
            this.cbCurso.Name = "cbCurso";
            this.cbCurso.Size = new System.Drawing.Size(557, 25);
            this.cbCurso.TabIndex = 2;
            this.cbCurso.SelectedIndexChanged += new System.EventHandler(this.cbCurso_SelectedIndexChanged);
            // 
            // cbTrimestre
            // 
            this.cbTrimestre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cbTrimestre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbTrimestre.Font = new System.Drawing.Font("Segoe UI Semilight", 10F);
            this.cbTrimestre.ForeColor = System.Drawing.Color.White;
            this.cbTrimestre.FormattingEnabled = true;
            this.cbTrimestre.Location = new System.Drawing.Point(3, 648);
            this.cbTrimestre.Name = "cbTrimestre";
            this.cbTrimestre.Size = new System.Drawing.Size(557, 25);
            this.cbTrimestre.TabIndex = 4;
            // 
            // btnAgregarNota
            // 
            this.btnAgregarNota.AutoSize = true;
            this.btnAgregarNota.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnAgregarNota.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAgregarNota.Font = new System.Drawing.Font("Segoe UI Semilight", 15F);
            this.btnAgregarNota.ForeColor = System.Drawing.Color.White;
            this.btnAgregarNota.Location = new System.Drawing.Point(3, 689);
            this.btnAgregarNota.Name = "btnAgregarNota";
            this.btnAgregarNota.Size = new System.Drawing.Size(557, 35);
            this.btnAgregarNota.TabIndex = 5;
            this.btnAgregarNota.Text = "AGREGAR NOTA";
            this.btnAgregarNota.UseVisualStyleBackColor = false;
            this.btnAgregarNota.Click += new System.EventHandler(this.btnAgregarNota_Click);
            // 
            // nota
            // 
            this.nota.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.nota.DecimalPlaces = 2;
            this.nota.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nota.Font = new System.Drawing.Font("Segoe UI Semilight", 20F);
            this.nota.ForeColor = System.Drawing.Color.White;
            this.nota.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nota.Location = new System.Drawing.Point(3, 730);
            this.nota.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nota.Name = "nota";
            this.nota.Size = new System.Drawing.Size(557, 43);
            this.nota.TabIndex = 6;
            this.nota.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semilight", 25F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(566, 440);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(558, 41);
            this.label1.TabIndex = 8;
            this.label1.Text = "MEDIA ENLACES";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // graficaValoraciones
            // 
            this.graficaValoraciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.graficaValoraciones.Location = new System.Drawing.Point(566, 484);
            this.graficaValoraciones.Name = "graficaValoraciones";
            this.tableLayoutPanel1.SetRowSpan(this.graficaValoraciones, 7);
            this.graficaValoraciones.Size = new System.Drawing.Size(558, 284);
            this.graficaValoraciones.TabIndex = 9;
            this.graficaValoraciones.Text = "angularGauge1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semilight", 20F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(557, 38);
            this.label5.TabIndex = 13;
            this.label5.Text = "NOTAS";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbGraficaNotas
            // 
            this.cbGraficaNotas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cbGraficaNotas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbGraficaNotas.Font = new System.Drawing.Font("Segoe UI Semilight", 10F);
            this.cbGraficaNotas.ForeColor = System.Drawing.Color.White;
            this.cbGraficaNotas.FormattingEnabled = true;
            this.cbGraficaNotas.Location = new System.Drawing.Point(566, 3);
            this.cbGraficaNotas.Name = "cbGraficaNotas";
            this.cbGraficaNotas.Size = new System.Drawing.Size(558, 25);
            this.cbGraficaNotas.TabIndex = 14;
            this.cbGraficaNotas.SelectedIndexChanged += new System.EventHandler(this.cbGraficaNotas_SelectedIndexChanged);
            // 
            // FormAreaPersonal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1127, 771);
            this.Controls.Add(this.tableLayoutPanel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAreaPersonal";
            this.Text = "FormAreaPersonal";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nota)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Integration.ElementHost elementHost1;
        private LiveCharts.Wpf.CartesianChart graficaNotas;
        private System.Windows.Forms.ComboBox cbCurso;
        private System.Windows.Forms.ComboBox cbAsignatura;
        private System.Windows.Forms.ComboBox cbTrimestre;
        private System.Windows.Forms.Button btnAgregarNota;
        private System.Windows.Forms.NumericUpDown nota;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private LiveCharts.WinForms.AngularGauge graficaValoraciones;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbGraficaNotas;
    }
}