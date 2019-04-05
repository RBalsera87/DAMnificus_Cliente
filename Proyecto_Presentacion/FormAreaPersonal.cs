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
        List<double> notasPrimero = new List<double> { 1, 2, 3, 4, 5, 6 };
        List<double> notasSegundo = new List<double> { 1, 2, 3, 4, 5, 6, 7 };
        public FormAreaPersonal()
        {
            
            InitializeComponent();
            DoubleBuffered = true;
            this.btnPrimero.BackColor = Color.FromArgb(73, 55, 34);
            // Grafico de barras
            graficoBarras.Series = new SeriesCollection
            {

                new RowSeries
                {
                    Title = "NOTAS",
                    Values = new ChartValues<double>(notasPrimero)
                }
            };


            graficoBarras.AxisY.Add(new Axis
            {
                Title = "ASIGNATURAS",
                Labels = new[] { "BASES", "ENTORNOS", "FOL", "MARCAS", "PROGRAMACION", "SISTEMAS" }
            });


        }

        private void cartesianChart1_ChildChanged(object sender, System.Windows.Forms.Integration.ChildChangedEventArgs e)
        {

        }

        private void btnSegundo_Click(object sender, EventArgs e)
        {

            this.btnPrimero.BackColor = Color.FromArgb(32, 32, 32);
            this.btnSegundo.BackColor = Color.FromArgb(73, 55, 34);
            graficoBarras.AxisY.Clear();
            graficoBarras.Series = new SeriesCollection
            {
                new RowSeries
                {
                    Title = "NOTAS",
                    Values = new ChartValues<double> (notasSegundo)
                }
            };


            graficoBarras.AxisY.Add(new Axis
            {
                Title = "ASIGNATURAS",
                Labels = new[] { "ACCESO", "INTERFACES", "EIE", "INGLES", "PSP", "PMDM", "SGE" }
            });
        }

        private void btnPrimero_Click(object sender, EventArgs e)
        {
            
            this.btnSegundo.BackColor = Color.FromArgb(32, 32, 32);
            this.btnPrimero.BackColor = Color.FromArgb(73, 55, 34);
            graficoBarras.AxisY.Clear();
            graficoBarras.Series = new SeriesCollection
            {
                new RowSeries
                {
                    Title = "NOTAS",
                    Values = new ChartValues<double>(notasPrimero)
                }
            };


            graficoBarras.AxisY.Add(new Axis
            {
                Title = "ASIGNATURAS",
                Labels = new[] { "BASES", "ENTORNOS", "FOL", "MARCAS", "PROGRAMACION", "SISTEMAS" }
            });
        }
    }
}
