using LiveCharts;
using LiveCharts.Wpf;
using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Media;

namespace Proyecto_Presentacion
{
    
    public partial class FormAreaPersonal : Form
    {
        Proyecto_Negocio.MetodosFormAreaPersonal met = new Proyecto_Negocio.MetodosFormAreaPersonal();
        List<double> notas1 = new List<double> { };
        List<double> notas2 = new List<double> { };
        List<String> cursos = new List<string> { };
        List<String> asignaturas = new List<string> { };
        List<String> trimestres = new List<string> { };

        public FormAreaPersonal()
        {
            notas1 = met.cargarListaNotasT1();
            notas2 = met.cargarListaNotasT2();

            met.cargarCursos(cursos);
            InitializeComponent();
            DoubleBuffered = true;

            foreach(string aux in cursos)
            {
                cbCurso.Items.Add(aux);
            }
            
            cbCurso.SelectedIndex = 0;

            graficaNotas.Series = new SeriesCollection
                {
                    new StackedRowSeries
                    {
                        Title = "NOTA TRIMESTRE 1",
                        
                        Values = new ChartValues<double> (notas1)
                    },
                    new StackedRowSeries
                    {
                        Title = "NOTA TRIMESTRE 2",
                        Values = new ChartValues<double> (notas2)
                    }
                };

            graficaNotas.AxisY.Add(new Axis
            {
                Title = "ASIGNATURAS",
                Labels = new[] { "Acceso a Datos", " Desarrollo de Interfaces", "Programación de Servicios y Procesos", "Programacion Multimedia y Dispositivos Móviles", "Empresa e Iniciativa Emprendedora", "Inglés Técnico", "Sistemas de Gestión Empresarial", "Programacion", "Bases de Datos", "Entornos de Desarrollo", "Sistemas Informáticos", "Formación y Orientación Laboral", "Lenguaje de Marcas" }
            });

            Func<ChartPoint, string> labelPoint = chartPoint =>
                string.Format("{0} ({1:P})", chartPoint.Y, chartPoint.Participation);

            graficaValoraciones.Value = met.mediaValoraciones();
            graficaValoraciones.FromValue = 0;
            graficaValoraciones.ToValue = 100;
            graficaValoraciones.Base.Foreground = Brushes.White;
            graficaValoraciones.Base.FontWeight = FontWeights.Bold;
            graficaValoraciones.Base.FontSize = 16;
            graficaValoraciones.SectionsInnerRadius = 0.4;

            graficaValoraciones.Sections.Add(new AngularSection
            {
                FromValue = 0,
                ToValue = 50,
                Fill = new SolidColorBrush(Color.FromRgb(255, 0, 0))
            });
            graficaValoraciones.Sections.Add(new AngularSection
            {
                FromValue = 50,
                ToValue = 80,
                Fill = new SolidColorBrush(Color.FromRgb(255,255, 0))
            });
            graficaValoraciones.Sections.Add(new AngularSection
            {
                FromValue = 80,
                ToValue = 100,
                Fill = new SolidColorBrush(Color.FromRgb(0, 255, 0))
            });
            
        }

        private void cbCurso_SelectedIndexChanged(object sender, EventArgs e)
        {
            string curso = cbCurso.SelectedItem.ToString();
            this.cbAsignatura.Items.Clear();
            this.cbTrimestre.Items.Clear();
            asignaturas.Clear();
            met.cargarAsignaturas(asignaturas, curso);
            foreach (string aux in asignaturas)
            {
                cbAsignatura.Items.Add(aux);
            }
        }

        private void cbAsignatura_SelectedIndexChanged(object sender, EventArgs e)
        {
            string asignatura = cbAsignatura.SelectedItem.ToString();
            this.cbTrimestre.Items.Clear();
            trimestres.Clear();
            met.cargarTrimestres(trimestres, asignatura);
            foreach (string aux in trimestres)
            {
                cbTrimestre.Items.Add(aux);
            }
        }

        private void btnAgregarNota_Click(object sender, EventArgs e)
        {
            string asignatura = cbAsignatura.SelectedItem.ToString();
            string trimestre = cbTrimestre.SelectedItem.ToString();
            string nota = this.nota.Value.ToString();
            nota = nota.Replace(",", ".");
            met.agregarNota(asignatura, trimestre, nota);
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
