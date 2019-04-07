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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.elementHost1 = new System.Windows.Forms.Integration.ElementHost();
            this.graficaNotas = new LiveCharts.Wpf.CartesianChart();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.elementHost2 = new System.Windows.Forms.Integration.ElementHost();
            this.pieChart1 = new LiveCharts.Wpf.PieChart();
            this.cbCurso = new System.Windows.Forms.ComboBox();
            this.cbAsignatura = new System.Windows.Forms.ComboBox();
            this.cbTrimestre = new System.Windows.Forms.ComboBox();
            this.nota = new System.Windows.Forms.NumericUpDown();
            this.btnAgregarNota = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nota)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.elementHost1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semilight", 12F);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1127, 403);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "NOTAS";
            // 
            // elementHost1
            // 
            this.elementHost1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.elementHost1.Location = new System.Drawing.Point(3, 25);
            this.elementHost1.Name = "elementHost1";
            this.elementHost1.Size = new System.Drawing.Size(1121, 375);
            this.elementHost1.TabIndex = 0;
            this.elementHost1.Text = "elementHost1";
            this.elementHost1.Child = this.graficaNotas;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnAgregarNota);
            this.groupBox2.Controls.Add(this.nota);
            this.groupBox2.Controls.Add(this.cbTrimestre);
            this.groupBox2.Controls.Add(this.cbAsignatura);
            this.groupBox2.Controls.Add(this.cbCurso);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI Semilight", 12F);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(0, 403);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(474, 368);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "AGREGAR NOTAS";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.elementHost2);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI Semilight", 12F);
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(474, 403);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(386, 368);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "VALORACION DE ENLACES SUBIDOS";
            // 
            // elementHost2
            // 
            this.elementHost2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.elementHost2.Location = new System.Drawing.Point(3, 25);
            this.elementHost2.Name = "elementHost2";
            this.elementHost2.Size = new System.Drawing.Size(380, 340);
            this.elementHost2.TabIndex = 0;
            this.elementHost2.Text = "elementHost2";
            this.elementHost2.Child = this.pieChart1;
            // 
            // cbCurso
            // 
            this.cbCurso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cbCurso.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbCurso.ForeColor = System.Drawing.Color.White;
            this.cbCurso.FormattingEnabled = true;
            this.cbCurso.Location = new System.Drawing.Point(3, 25);
            this.cbCurso.Name = "cbCurso";
            this.cbCurso.Size = new System.Drawing.Size(468, 29);
            this.cbCurso.TabIndex = 0;
            // 
            // cbAsignatura
            // 
            this.cbAsignatura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cbAsignatura.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbAsignatura.ForeColor = System.Drawing.Color.White;
            this.cbAsignatura.FormattingEnabled = true;
            this.cbAsignatura.Location = new System.Drawing.Point(3, 54);
            this.cbAsignatura.Name = "cbAsignatura";
            this.cbAsignatura.Size = new System.Drawing.Size(468, 29);
            this.cbAsignatura.TabIndex = 1;
            // 
            // cbTrimestre
            // 
            this.cbTrimestre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cbTrimestre.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbTrimestre.ForeColor = System.Drawing.Color.White;
            this.cbTrimestre.FormattingEnabled = true;
            this.cbTrimestre.Location = new System.Drawing.Point(3, 83);
            this.cbTrimestre.Name = "cbTrimestre";
            this.cbTrimestre.Size = new System.Drawing.Size(468, 29);
            this.cbTrimestre.TabIndex = 2;
            // 
            // nota
            // 
            this.nota.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.nota.DecimalPlaces = 2;
            this.nota.Dock = System.Windows.Forms.DockStyle.Top;
            this.nota.ForeColor = System.Drawing.Color.White;
            this.nota.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nota.Location = new System.Drawing.Point(3, 112);
            this.nota.Maximum = new decimal(new int[] {
            100,
            0,
            0,
            65536});
            this.nota.Name = "nota";
            this.nota.Size = new System.Drawing.Size(468, 29);
            this.nota.TabIndex = 3;
            this.nota.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nota.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            // 
            // btnAgregarNota
            // 
            this.btnAgregarNota.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnAgregarNota.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAgregarNota.Location = new System.Drawing.Point(3, 141);
            this.btnAgregarNota.Name = "btnAgregarNota";
            this.btnAgregarNota.Size = new System.Drawing.Size(468, 46);
            this.btnAgregarNota.TabIndex = 4;
            this.btnAgregarNota.Text = "Agregar Nota";
            this.btnAgregarNota.UseVisualStyleBackColor = false;
            // 
            // FormAreaPersonal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1127, 771);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAreaPersonal";
            this.Text = "FormAreaPersonal";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nota)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Integration.ElementHost elementHost1;
        private LiveCharts.Wpf.CartesianChart graficaNotas;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Integration.ElementHost elementHost2;
        private LiveCharts.Wpf.PieChart pieChart1;
        private System.Windows.Forms.ComboBox cbTrimestre;
        private System.Windows.Forms.ComboBox cbAsignatura;
        private System.Windows.Forms.ComboBox cbCurso;
        private System.Windows.Forms.NumericUpDown nota;
        private System.Windows.Forms.Button btnAgregarNota;
    }
}