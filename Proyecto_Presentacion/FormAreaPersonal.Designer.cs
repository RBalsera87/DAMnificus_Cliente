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
            this.elementHost1 = new System.Windows.Forms.Integration.ElementHost();
            this.graficaNotas = new LiveCharts.Wpf.CartesianChart();
            this.elementHost2 = new System.Windows.Forms.Integration.ElementHost();
            this.graficaValoraciones = new LiveCharts.Wpf.PieChart();
            this.cbCurso = new System.Windows.Forms.ComboBox();
            this.cbAsignatura = new System.Windows.Forms.ComboBox();
            this.cbTrimestre = new System.Windows.Forms.ComboBox();
            this.btnAgregarNota = new System.Windows.Forms.Button();
            this.nota = new System.Windows.Forms.NumericUpDown();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nota)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.cbAsignatura, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.elementHost1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.elementHost2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.cbCurso, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.cbTrimestre, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnAgregarNota, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.nota, 0, 5);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 66.66666F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1127, 771);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // elementHost1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.elementHost1, 2);
            this.elementHost1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.elementHost1.Location = new System.Drawing.Point(3, 3);
            this.elementHost1.Name = "elementHost1";
            this.elementHost1.Size = new System.Drawing.Size(1121, 508);
            this.elementHost1.TabIndex = 0;
            this.elementHost1.Text = "elementHost1";
            this.elementHost1.Child = this.graficaNotas;
            // 
            // elementHost2
            // 
            this.elementHost2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.elementHost2.Location = new System.Drawing.Point(566, 517);
            this.elementHost2.Name = "elementHost2";
            this.tableLayoutPanel1.SetRowSpan(this.elementHost2, 5);
            this.elementHost2.Size = new System.Drawing.Size(558, 251);
            this.elementHost2.TabIndex = 1;
            this.elementHost2.Text = "elementHost2";
            this.elementHost2.Child = this.graficaValoraciones;
            // 
            // cbCurso
            // 
            this.cbCurso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cbCurso.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbCurso.Font = new System.Drawing.Font("Segoe UI Semilight", 20F);
            this.cbCurso.ForeColor = System.Drawing.Color.White;
            this.cbCurso.FormattingEnabled = true;
            this.cbCurso.Location = new System.Drawing.Point(3, 517);
            this.cbCurso.Name = "cbCurso";
            this.cbCurso.Size = new System.Drawing.Size(557, 45);
            this.cbCurso.TabIndex = 2;
            this.cbCurso.SelectedIndexChanged += new System.EventHandler(this.cbCurso_SelectedIndexChanged);
            // 
            // cbAsignatura
            // 
            this.cbAsignatura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cbAsignatura.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbAsignatura.Font = new System.Drawing.Font("Segoe UI Semilight", 20F);
            this.cbAsignatura.ForeColor = System.Drawing.Color.White;
            this.cbAsignatura.FormattingEnabled = true;
            this.cbAsignatura.Location = new System.Drawing.Point(3, 568);
            this.cbAsignatura.Name = "cbAsignatura";
            this.cbAsignatura.Size = new System.Drawing.Size(557, 45);
            this.cbAsignatura.TabIndex = 3;
            this.cbAsignatura.SelectedIndexChanged += new System.EventHandler(this.cbAsignatura_SelectedIndexChanged);
            // 
            // cbTrimestre
            // 
            this.cbTrimestre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cbTrimestre.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbTrimestre.Font = new System.Drawing.Font("Segoe UI Semilight", 20F);
            this.cbTrimestre.ForeColor = System.Drawing.Color.White;
            this.cbTrimestre.FormattingEnabled = true;
            this.cbTrimestre.Location = new System.Drawing.Point(3, 619);
            this.cbTrimestre.Name = "cbTrimestre";
            this.cbTrimestre.Size = new System.Drawing.Size(557, 45);
            this.cbTrimestre.TabIndex = 4;
            // 
            // btnAgregarNota
            // 
            this.btnAgregarNota.AutoSize = true;
            this.btnAgregarNota.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnAgregarNota.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAgregarNota.Font = new System.Drawing.Font("Segoe UI Semilight", 30F);
            this.btnAgregarNota.ForeColor = System.Drawing.Color.White;
            this.btnAgregarNota.Location = new System.Drawing.Point(3, 670);
            this.btnAgregarNota.Name = "btnAgregarNota";
            this.btnAgregarNota.Size = new System.Drawing.Size(557, 45);
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
            this.nota.Font = new System.Drawing.Font("Segoe UI Semilight", 35F);
            this.nota.ForeColor = System.Drawing.Color.White;
            this.nota.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nota.Location = new System.Drawing.Point(3, 721);
            this.nota.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nota.Name = "nota";
            this.nota.Size = new System.Drawing.Size(557, 70);
            this.nota.TabIndex = 6;
            this.nota.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
        private System.Windows.Forms.Integration.ElementHost elementHost2;
        private LiveCharts.Wpf.PieChart graficaValoraciones;
        private System.Windows.Forms.ComboBox cbCurso;
        private System.Windows.Forms.ComboBox cbAsignatura;
        private System.Windows.Forms.ComboBox cbTrimestre;
        private System.Windows.Forms.Button btnAgregarNota;
        private System.Windows.Forms.NumericUpDown nota;
    }
}