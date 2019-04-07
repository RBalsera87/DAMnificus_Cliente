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
        public FormAreaPersonal()
        {
            notas = met.cargarListaNotas();
            InitializeComponent();
            DoubleBuffered = true;

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
        }
    }
}
