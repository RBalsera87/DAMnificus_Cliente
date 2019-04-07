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
        Proyecto_Negocio.MetodosFormAreaPersonal met = new Proyecto_Negocio.MetodosFormAreaPersonal();
        List<double> notas = new List<double> { };
        List<String> cursos = new List<string> { };
        List<String> asignaturas = new List<string> { };
        List<String> trimestres = new List<string> { };

        public FormAreaPersonal()
        {
            notas = met.cargarListaNotas();
            met.cargarComboboxes(cursos, asignaturas, trimestres);
            InitializeComponent();
            DoubleBuffered = true;

            foreach(string aux in cursos)
            {
                cbCurso.Items.Add(aux);
            }
            foreach (string aux in asignaturas)
            {
                cbAsignatura.Items.Add(aux);
            }
            foreach (string aux in trimestres)
            {
                cbTrimestre.Items.Add(aux);
            }
            cbCurso.SelectedIndex = 0;
            cbAsignatura.SelectedIndex = 0;
            //cbTrimestre.SelectedIndex = 0;

            graficaNotas.Series = new SeriesCollection
                {
                    new RowSeries
                    {
                        Title = "NOTAS",
                        Values = new ChartValues<double> (notas)
                    }
                };

            graficaNotas.AxisY.Add(new Axis
            {
                Title = "ASIGNATURAS",
                Labels = new[] { "Acceso", "Interfaces", "PSP", "Moviles", "FOL2", "Ingles", "SGE" }
            });


            Func<ChartPoint, string> labelPoint = chartPoint =>
                string.Format("{0} ({1:P})", chartPoint.Y, chartPoint.Participation);

            graficaValoraciones.Series = new SeriesCollection
            {
                new PieSeries
                {
                    Title = "Maria",
                    Values = new ChartValues<double> {3},
                    PushOut = 15,
                    DataLabels = true,
                    LabelPoint = labelPoint
                },
                new PieSeries
                {
                    Title = "Charles",
                    Values = new ChartValues<double> {4},
                    DataLabels = true,
                    LabelPoint = labelPoint
                },
                new PieSeries
                {
                    Title = "Frida",
                    Values = new ChartValues<double> {6},
                    DataLabels = true,
                    LabelPoint = labelPoint
                },
                new PieSeries
                {
                    Title = "Frederic",
                    Values = new ChartValues<double> {2},
                    DataLabels = true,
                    LabelPoint = labelPoint
                }
            };

            graficaValoraciones.LegendLocation = LegendLocation.Bottom;

        }

    }
}
