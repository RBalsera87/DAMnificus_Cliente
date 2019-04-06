using LiveCharts;
using LiveCharts.Wpf;
using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace Proyecto_Presentacion
{
    
    public partial class FormAreaPersonal : Form
    {
        FormPrincipal aux = new FormPrincipal();
        List<double> notasPrimeroPrimer = new List<double> { 1, 8, 0, 4, 5, 0 };
        List<double> notasPrimeroSegundo = new List<double> { 2, 8, 0, 4, 5, 0 };
        List<double> notasPrimeroTercer = new List<double> { 3, 8, 0, 4, 5, 0 };
        List<double> notasPrimeroFinal = new List<double> { 4, 8, 0, 4, 5, 0 };

        List<double> notasSegundoPrimer = new List<double> { 1, 8, 0, 4, 5, 0 , 3};
        List<double> notasSegundoSegundo = new List<double> { 2, 8, 0, 4, 5, 0 , 5};
        List<double> notasSegundoTercer = new List<double> { 3, 8, 0, 4, 5, 0, 8 };
        List<double> notasSegundoFinal = new List<double> { 4, 8, 0, 4, 5, 0, 10 };

        public FormAreaPersonal()
        {
            
            InitializeComponent();
            DoubleBuffered = true;
            this.btnPrimero.BackColor = Color.FromArgb(73, 55, 34);
            this.btnT1.BackColor = Color.FromArgb(73, 55, 34);
            cargarPrimeraGrafica();


        }

        private void cartesianChart1_ChildChanged(object sender, System.Windows.Forms.Integration.ChildChangedEventArgs e)
        {

        }

        /****************************
        * Eventos para los botones *
        ****************************/

        private void btnSegundo_Click(object sender, EventArgs e)
        {

            this.btnPrimero.BackColor = Color.FromArgb(32, 32, 32);
            this.btnSegundo.BackColor = Color.FromArgb(73, 55, 34);
            cargarPrimeraGrafica();
        }

        private void btnPrimero_Click(object sender, EventArgs e)
        {
            
            this.btnSegundo.BackColor = Color.FromArgb(32, 32, 32);
            this.btnPrimero.BackColor = Color.FromArgb(73, 55, 34);
            cargarPrimeraGrafica();
        }

        private void btnT1_Click(object sender, EventArgs e)
        {
            this.btnT1.BackColor = Color.FromArgb(73, 55, 34);
            this.btnT2.BackColor = Color.FromArgb(32, 32, 32);
            this.btnT3.BackColor = Color.FromArgb(32, 32, 32);
            this.btnTF.BackColor = Color.FromArgb(32, 32, 32);

            cargarPrimeraGrafica();
        }

        private void btnT2_Click(object sender, EventArgs e)
        {
            this.btnT1.BackColor = Color.FromArgb(32, 32, 32);
            this.btnT2.BackColor = Color.FromArgb(73, 55, 34);
            this.btnT3.BackColor = Color.FromArgb(32, 32, 32);
            this.btnTF.BackColor = Color.FromArgb(32, 32, 32);

            if (this.btnPrimero.BackColor == Color.FromArgb(73, 55, 34))
            {
                graficoBarras.Series = new SeriesCollection
                {
                    new RowSeries
                    {
                        Title = "NOTAS",
                        Values = new ChartValues<double> (notasPrimeroSegundo)
                    }
                };
            }
            else
            {
                graficoBarras.Series = new SeriesCollection
                {
                    new RowSeries
                    {
                        Title = "NOTAS",
                        Values = new ChartValues<double> (notasSegundoSegundo)
                    }
                };
            }
        }

        private void btnT3_Click(object sender, EventArgs e)
        {
            this.btnT1.BackColor = Color.FromArgb(32, 32, 32);
            this.btnT2.BackColor = Color.FromArgb(32, 32, 32);
            this.btnT3.BackColor = Color.FromArgb(73, 55, 34);
            this.btnTF.BackColor = Color.FromArgb(32, 32, 32);

            if (this.btnPrimero.BackColor == Color.FromArgb(73, 55, 34))
            {
                graficoBarras.Series = new SeriesCollection
                {
                    new RowSeries
                    {
                        Title = "NOTAS",
                        Values = new ChartValues<double> (notasPrimeroTercer)
                    }
                };
            }
            else
            {
                graficoBarras.Series = new SeriesCollection
                {
                    new RowSeries
                    {
                        Title = "NOTAS",
                        Values = new ChartValues<double> (notasSegundoTercer)
                    }
                };
            }
        }

        private void btnTF_Click(object sender, EventArgs e)
        {
            this.btnT1.BackColor = Color.FromArgb(32, 32, 32);
            this.btnT2.BackColor = Color.FromArgb(32, 32, 32);
            this.btnT3.BackColor = Color.FromArgb(32, 32, 32);
            this.btnTF.BackColor = Color.FromArgb(73, 55, 34);

            if (this.btnPrimero.BackColor == Color.FromArgb(73, 55, 34))
            {
                graficoBarras.Series = new SeriesCollection
                {
                    new RowSeries
                    {
                        Title = "NOTAS",
                        Values = new ChartValues<double> (notasPrimeroFinal)
                    }
                };
            }
            else
            {
                graficoBarras.Series = new SeriesCollection
                {
                    new RowSeries
                    {
                        Title = "NOTAS",
                        Values = new ChartValues<double> (notasSegundoFinal)
                    }
                };
            }
        }

        private void cargarPrimeraGrafica()
        {
            this.btnT1.BackColor = Color.FromArgb(73, 55, 34);
            this.btnT2.BackColor = Color.FromArgb(32, 32, 32);
            this.btnT3.BackColor = Color.FromArgb(32, 32, 32);
            this.btnTF.BackColor = Color.FromArgb(32, 32, 32);

            if (this.btnPrimero.BackColor == Color.FromArgb(73, 55, 34))
            {
                graficoBarras.AxisY.Clear();
                graficoBarras.Series = new SeriesCollection
                {
                    new RowSeries
                    {
                        Title = "NOTAS",
                        Values = new ChartValues<double> (notasPrimeroPrimer)
                    }
                };


                graficoBarras.AxisY.Add(new Axis
                {
                    Title = "ASIGNATURAS",
                    Labels = new[] { "BASES", "ENTORNOS", "FOL", "MARCAS", "PROGRAMACION", "SISTEMAS" }
                });
            }
            else
            {
                graficoBarras.AxisY.Clear();
                graficoBarras.Series = new SeriesCollection
                {
                    new RowSeries
                    {
                        Title = "NOTAS",
                        Values = new ChartValues<double> (notasSegundoPrimer)
                    }
                };


                graficoBarras.AxisY.Add(new Axis
                {
                    Title = "ASIGNATURAS",
                    Labels = new[] { "ACCESO", "INTERFACES", "EIE", "INGLES", "PSP", "PMDM", "SGE" }
                });
            }
        }

        private void btnIntroducirNota_Click(object sender, EventArgs e)
        {
            
        }
    }
}
