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
            this.graficoTarta = new LiveCharts.WinForms.PieChart();
            this.graficoApilado = new LiveCharts.WinForms.CartesianChart();
            this.SuspendLayout();
            // 
            // graficoBarras
            // 
            this.graficoBarras.Location = new System.Drawing.Point(37, 24);
            this.graficoBarras.Name = "graficoBarras";
            this.graficoBarras.Size = new System.Drawing.Size(421, 253);
            this.graficoBarras.TabIndex = 0;
            this.graficoBarras.Text = "cartesianChart1";
            this.graficoBarras.ChildChanged += new System.EventHandler<System.Windows.Forms.Integration.ChildChangedEventArgs>(this.cartesianChart1_ChildChanged);
            // 
            // graficoTarta
            // 
            this.graficoTarta.Location = new System.Drawing.Point(37, 320);
            this.graficoTarta.Name = "graficoTarta";
            this.graficoTarta.Size = new System.Drawing.Size(418, 279);
            this.graficoTarta.TabIndex = 1;
            this.graficoTarta.Text = "pieChart1";
            // 
            // graficoApilado
            // 
            this.graficoApilado.Location = new System.Drawing.Point(488, 38);
            this.graficoApilado.Name = "graficoApilado";
            this.graficoApilado.Size = new System.Drawing.Size(425, 239);
            this.graficoApilado.TabIndex = 2;
            this.graficoApilado.Text = "cartesianChart1";
            // 
            // FormAreaPersonal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(959, 644);
            this.Controls.Add(this.graficoApilado);
            this.Controls.Add(this.graficoTarta);
            this.Controls.Add(this.graficoBarras);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAreaPersonal";
            this.Text = "FormAreaPersonal";
            this.ResumeLayout(false);

        }

        #endregion

        private LiveCharts.WinForms.CartesianChart graficoBarras;
        private LiveCharts.WinForms.PieChart graficoTarta;
        private LiveCharts.WinForms.CartesianChart graficoApilado;
    }
}