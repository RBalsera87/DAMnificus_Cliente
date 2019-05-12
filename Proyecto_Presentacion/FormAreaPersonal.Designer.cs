using LiveCharts.WinForms;
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
            this.graficaNotas = new LiveCharts.WinForms.CartesianChart();
            this.graficaMedias = new LiveCharts.WinForms.PieChart();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAgregarNota = new System.Windows.Forms.Button();
            this.lblTrimestre = new System.Windows.Forms.Label();
            this.tbTrimestre = new System.Windows.Forms.TrackBar();
            this.lbAsignaturas = new System.Windows.Forms.ListBox();
            this.notaIntroducir = new System.Windows.Forms.NumericUpDown();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbTrimestre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.notaIntroducir)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.graficaNotas, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.graficaMedias, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1127, 771);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // graficaNotas
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.graficaNotas, 2);
            this.graficaNotas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.graficaNotas.Location = new System.Drawing.Point(3, 3);
            this.graficaNotas.Name = "graficaNotas";
            this.graficaNotas.Size = new System.Drawing.Size(744, 418);
            this.graficaNotas.TabIndex = 0;
            this.graficaNotas.Text = "cartesianChart1";
            // 
            // graficaMedias
            // 
            this.graficaMedias.Dock = System.Windows.Forms.DockStyle.Fill;
            this.graficaMedias.Location = new System.Drawing.Point(3, 427);
            this.graficaMedias.Name = "graficaMedias";
            this.graficaMedias.Size = new System.Drawing.Size(369, 341);
            this.graficaMedias.TabIndex = 1;
            this.graficaMedias.Text = "pieChart1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAgregarNota);
            this.groupBox1.Controls.Add(this.lblTrimestre);
            this.groupBox1.Controls.Add(this.tbTrimestre);
            this.groupBox1.Controls.Add(this.lbAsignaturas);
            this.groupBox1.Controls.Add(this.notaIntroducir);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semilight", 12F);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(753, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(371, 418);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "AGREGAR NOTA";
            // 
            // btnAgregarNota
            // 
            this.btnAgregarNota.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnAgregarNota.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAgregarNota.ForeColor = System.Drawing.Color.White;
            this.btnAgregarNota.Location = new System.Drawing.Point(3, 292);
            this.btnAgregarNota.Name = "btnAgregarNota";
            this.btnAgregarNota.Size = new System.Drawing.Size(365, 52);
            this.btnAgregarNota.TabIndex = 4;
            this.btnAgregarNota.Text = "AGREGAR";
            this.btnAgregarNota.UseVisualStyleBackColor = false;
            this.btnAgregarNota.Click += new System.EventHandler(this.btnAgregarNota_Click);
            // 
            // lblTrimestre
            // 
            this.lblTrimestre.AutoSize = true;
            this.lblTrimestre.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTrimestre.Location = new System.Drawing.Point(3, 271);
            this.lblTrimestre.Name = "lblTrimestre";
            this.lblTrimestre.Size = new System.Drawing.Size(49, 21);
            this.lblTrimestre.TabIndex = 2;
            this.lblTrimestre.Text = "label1";
            this.lblTrimestre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbTrimestre
            // 
            this.tbTrimestre.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbTrimestre.LargeChange = 1;
            this.tbTrimestre.Location = new System.Drawing.Point(3, 226);
            this.tbTrimestre.Maximum = 2;
            this.tbTrimestre.Name = "tbTrimestre";
            this.tbTrimestre.Size = new System.Drawing.Size(365, 45);
            this.tbTrimestre.TabIndex = 3;
            this.tbTrimestre.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.tbTrimestre.Scroll += new System.EventHandler(this.tbTrimestre_Scroll);
            // 
            // lbAsignaturas
            // 
            this.lbAsignaturas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbAsignaturas.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbAsignaturas.ForeColor = System.Drawing.Color.White;
            this.lbAsignaturas.FormattingEnabled = true;
            this.lbAsignaturas.ItemHeight = 21;
            this.lbAsignaturas.Location = new System.Drawing.Point(3, 54);
            this.lbAsignaturas.Name = "lbAsignaturas";
            this.lbAsignaturas.Size = new System.Drawing.Size(365, 172);
            this.lbAsignaturas.TabIndex = 1;
            // 
            // notaIntroducir
            // 
            this.notaIntroducir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.notaIntroducir.DecimalPlaces = 2;
            this.notaIntroducir.Dock = System.Windows.Forms.DockStyle.Top;
            this.notaIntroducir.ForeColor = System.Drawing.Color.White;
            this.notaIntroducir.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.notaIntroducir.Location = new System.Drawing.Point(3, 25);
            this.notaIntroducir.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.notaIntroducir.Name = "notaIntroducir";
            this.notaIntroducir.Size = new System.Drawing.Size(365, 29);
            this.notaIntroducir.TabIndex = 0;
            this.notaIntroducir.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbTrimestre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.notaIntroducir)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private LiveCharts.WinForms.CartesianChart graficaNotas;
        private LiveCharts.WinForms.PieChart graficaMedias;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown notaIntroducir;
        private System.Windows.Forms.Label lblTrimestre;
        private System.Windows.Forms.TrackBar tbTrimestre;
        private System.Windows.Forms.ListBox lbAsignaturas;
        private System.Windows.Forms.Button btnAgregarNota;
    }
}