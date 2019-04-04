using LiveCharts;
using LiveCharts.Wpf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Presentacion
{
    public partial class FormAreaPersonal : Form
    {
        List<double> controles = new List<double> { 7.8, 5.0, 3.9, 9.65, 6, 8, 2 };
        List<double> finales = new List<double> { 6.2, 4.4, 9.01, 10, 7, 8, 9 };
        public FormAreaPersonal()
        {
            InitializeComponent();

            /******************************************************************************************
             * Para cargar los controles y los examenes se accederá a la base de datos del alumno     *
             * En la base de datos, las notas estaran guardadas tal y como se obtienen en el examen,  *
             *  para luego ser tratadas con los pesos correspondientes aplicados a cada asignatura,   *
             *  para por ultimo ser cargados aqui y que la suma de las notas no supere el 10          *
             *                                                                                        *
             *                      #TODO: HACER QUE SEA DEL TODO RESPONSIVE                          *
             ******************************************************************************************/

            // Grafico de barras
            graficoBarras.Series = new SeriesCollection
            {
                new StackedRowSeries
                {
                    Values = new ChartValues<double>(controles),
                    StackMode = StackMode.Values,
                    Title = "Primer control",
                    DataLabels = true
                },
                new StackedRowSeries
                {
                    Values = new ChartValues<double>(finales),
                    StackMode = StackMode.Values, 
                    Title = "Examen final",
                    DataLabels = true
                }
            };
            

            graficoBarras.AxisY.Add(new Axis
            {
                Labels = new[] { "Acceso a Datos", "Desarrollo de Interfaces", "Empresa e Iniciativa Emprendedora",
                    "Inglés Técnico", "Programación de Servicios y Procesos", "Programación Multimedia y Dispositivos Móviles",
                "Sistemas de Gestión Empresarial"}
            });

            graficoBarras.AxisX.Add(new Axis
            {
                Title = "NOTA"
            });

            var tooltip = new DefaultTooltip
            {
                SelectionMode = TooltipSelectionMode.SharedYValues
            };

            graficoBarras.DataTooltip = tooltip;

            
        }

        private void cartesianChart1_ChildChanged(object sender, System.Windows.Forms.Integration.ChildChangedEventArgs e)
        {

        }
    }
}
