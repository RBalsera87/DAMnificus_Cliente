using LiveCharts;
using LiveCharts.Wpf;
using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Media;
using Proyecto_Negocio;

namespace Proyecto_Presentacion
{
    
    public partial class FormAreaPersonal : Form
    {
        MetodosFormAreaPersonal met = new MetodosFormAreaPersonal();
        string usuario = UsuarioConectado.nombre;
        int user, curso;
        List<string> nombresAsignaturas = new List<string> { };
        List<double> todasNotas = new List<double> { };
        List<double> mediaNotas = new List<double> { };
        List<double> notasAsignatura1 = new List<double> { };
        List<double> notasAsignatura2 = new List<double> { };
        List<double> notasAsignatura3 = new List<double> { };
        List<double> notasAsignatura4 = new List<double> { };
        List<double> notasAsignatura5 = new List<double> { };
        List<double> notasAsignatura6 = new List<double> { };
        List<double> notasAsignatura7 = new List<double> { };
        

        public FormAreaPersonal()
        {
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.DoubleBuffer, true);
            InitializeComponent();
            DoubleBuffered = true;

            curso = met.sacarCurso(usuario);
            user = met.sacarUsuario(usuario);
            cargaComponentes();
            cargaGraficas(curso);         
            
            
        }
        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        public void vaciadoListas()
        {
            notasAsignatura1.Clear();
            notasAsignatura2.Clear();
            notasAsignatura3.Clear();
            notasAsignatura4.Clear();
            notasAsignatura5.Clear();
            notasAsignatura6.Clear();
            notasAsignatura7.Clear();
        }

        private void tbTrimestre_Scroll(object sender, EventArgs e)
        {
            switch(tbTrimestre.Value)
            {
                case 0:lblTrimestre.Text = "TRIMESTRE 1";
                    break;
                case 1:lblTrimestre.Text = "TRIMESTRE 2";
                    break;
                case 2: lblTrimestre.Text = "TRIMESTRE 3";
                    break;
            }
        }

        public void cargaComponentes()
        {
            nombresAsignaturas = met.sacarAsignaturas(curso);
            todasNotas = met.recogidaNotas(curso, user);
            mediaNotas = met.mediaNotas(curso, user);
            lbAsignaturas.DataSource = nombresAsignaturas;
            lbAsignaturas.SelectedIndex = 0;
            lblTrimestre.Text = "TRIMESTRE 1";
        }

        private void btnAgregarNota_Click(object sender, EventArgs e)
        {
            int trimestre = tbTrimestre.Value + 1;
            string nota = notaIntroducir.Value.ToString();
            nota = nota.Replace(",", ".");
            string asignatura = lbAsignaturas.SelectedItem.ToString();
            met.agregarNota(nota, trimestre, asignatura, user);
            vaciadoListas();
            cargaComponentes();
            cargaGraficas(curso);
        }

        public void cargaGraficas(int curso)
        {
            if (curso == 1)
            {
                tbTrimestre.Maximum = 2;
                for (int x = 0; x < todasNotas.Count; x++)
                {
                    if (x >= 0 && x < 3)
                    {
                        notasAsignatura1.Add(todasNotas[x]);
                    }
                    else if (x >= 3 && x < 6)
                    {
                        notasAsignatura2.Add(todasNotas[x]);
                    }
                    else if (x >= 6 && x < 9)
                    {
                        notasAsignatura3.Add(todasNotas[x]);
                    }
                    else if (x >= 9 && x < 12)
                    {
                        notasAsignatura4.Add(todasNotas[x]);
                    }
                    else if (x >= 12 && x < 15)
                    {
                        notasAsignatura5.Add(todasNotas[x]);
                    }
                    else
                    {
                        notasAsignatura6.Add(todasNotas[x]);
                    }
                }
                graficaNotas.AxisX.Clear();
                graficaNotas.Series = new SeriesCollection
                {
                    new ColumnSeries
                    {
                        Title = nombresAsignaturas[0],
                        Values = new ChartValues<double> (notasAsignatura1)
                    }
                };
                graficaNotas.Series.Add(new ColumnSeries
                {
                    Title = nombresAsignaturas[1],
                    Values = new ChartValues<double>(notasAsignatura2)
                });
                graficaNotas.Series.Add(new ColumnSeries
                {
                    Title = nombresAsignaturas[2],
                    Values = new ChartValues<double>(notasAsignatura3)
                });
                graficaNotas.Series.Add(new ColumnSeries
                {
                    Title = nombresAsignaturas[3],
                    Values = new ChartValues<double>(notasAsignatura4)
                });
                graficaNotas.Series.Add(new ColumnSeries
                {
                    Title = nombresAsignaturas[4],
                    Values = new ChartValues<double>(notasAsignatura5)
                });
                graficaNotas.Series.Add(new ColumnSeries
                {
                    Title = nombresAsignaturas[5],
                    Values = new ChartValues<double>(notasAsignatura6)
                });
                graficaNotas.AxisX.Add(new Axis
                {
                    Labels = new[] { "TRIMESTRE 1", "TRIMESTRE 2", "TRIMESTRE 3" }
                });

                graficaMedias.Series = new SeriesCollection
                {
                    new PieSeries
                    {
                        Title = nombresAsignaturas[0],
                        Values = new ChartValues<double> {mediaNotas[0] },
                        DataLabels = true,
                    },
                    new PieSeries
                    {
                        Title = nombresAsignaturas[1],
                        Values = new ChartValues<double> {mediaNotas[1] },
                        DataLabels = true,
                    },
                    new PieSeries
                    {
                        Title = nombresAsignaturas[2],
                        Values = new ChartValues<double> {mediaNotas[2] },
                        DataLabels = true,
                    },
                    new PieSeries
                    {
                        Title = nombresAsignaturas[3],
                        Values = new ChartValues<double> {mediaNotas[3] },
                        DataLabels = true,
                    },
                    new PieSeries
                    {
                        Title = nombresAsignaturas[4],
                        Values = new ChartValues<double> {mediaNotas[4] },
                        DataLabels = true,
                    },
                    new PieSeries
                    {
                        Title = nombresAsignaturas[5],
                        Values = new ChartValues<double> {mediaNotas[5] },
                        DataLabels = true,
                    }
                };



            }
            else if (curso == 2)
            {
                tbTrimestre.Maximum = 1;
                for (int x = 0; x < todasNotas.Count; x++)
                {
                    if (x >= 0 && x < 2)
                    {
                        notasAsignatura1.Add(todasNotas[x]);
                    }
                    else if (x >= 2 && x < 4)
                    {
                        notasAsignatura2.Add(todasNotas[x]);
                    }
                    else if (x >= 4 && x < 6)
                    {
                        notasAsignatura3.Add(todasNotas[x]);
                    }
                    else if (x >= 6 && x < 8)
                    {
                        notasAsignatura4.Add(todasNotas[x]);
                    }
                    else if (x >= 8 && x < 10)
                    {
                        notasAsignatura5.Add(todasNotas[x]);
                    }
                    else if (x >= 10 && x < 12)
                    {
                        notasAsignatura6.Add(todasNotas[x]);
                    }
                    else
                    {
                        notasAsignatura7.Add(todasNotas[x]);
                    }
                }
                graficaNotas.AxisX.Clear();
                graficaNotas.Series = new SeriesCollection
                {
                    new ColumnSeries
                    {
                        Title = nombresAsignaturas[0],
                        Values = new ChartValues<double> (notasAsignatura1)
                    }
                };
                graficaNotas.Series.Add(new ColumnSeries
                {
                    Title = nombresAsignaturas[1],
                    Values = new ChartValues<double>(notasAsignatura2)
                });
                graficaNotas.Series.Add(new ColumnSeries
                {
                    Title = nombresAsignaturas[2],
                    Values = new ChartValues<double>(notasAsignatura3)
                });
                graficaNotas.Series.Add(new ColumnSeries
                {
                    Title = nombresAsignaturas[3],
                    Values = new ChartValues<double>(notasAsignatura4)
                });
                graficaNotas.Series.Add(new ColumnSeries
                {
                    Title = nombresAsignaturas[4],
                    Values = new ChartValues<double>(notasAsignatura5)
                });
                graficaNotas.Series.Add(new ColumnSeries
                {
                    Title = nombresAsignaturas[5],
                    Values = new ChartValues<double>(notasAsignatura6)
                });
                graficaNotas.Series.Add(new ColumnSeries
                {
                    Title = nombresAsignaturas[6],
                    Values = new ChartValues<double>(notasAsignatura7)
                });
                graficaNotas.AxisX.Add(new Axis
                {
                    Labels = new[] { "TRIMESTRE 1", "TRIMESTRE 2" }
                });


                graficaMedias.Series = new SeriesCollection
                {
                    new PieSeries
                    {
                        Title = nombresAsignaturas[0],
                        Values = new ChartValues<double> {mediaNotas[0] },
                        DataLabels = true,
                    },
                    new PieSeries
                    {
                        Title = nombresAsignaturas[1],
                        Values = new ChartValues<double> {mediaNotas[1] },
                        DataLabels = true,
                    },
                    new PieSeries
                    {
                        Title = nombresAsignaturas[2],
                        Values = new ChartValues<double> {mediaNotas[2] },
                        DataLabels = true,
                    },
                    new PieSeries
                    {
                        Title = nombresAsignaturas[3],
                        Values = new ChartValues<double> {mediaNotas[3] },
                        DataLabels = true,
                    },
                    new PieSeries
                    {
                        Title = nombresAsignaturas[4],
                        Values = new ChartValues<double> {mediaNotas[4] },
                        DataLabels = true,
                    },
                    new PieSeries
                    {
                        Title = nombresAsignaturas[5],
                        Values = new ChartValues<double> {mediaNotas[5] },
                        DataLabels = true,
                    },
                    new PieSeries
                    {
                        Title = nombresAsignaturas[6],
                        Values = new ChartValues<double> {mediaNotas[6] },
                        DataLabels = true,
                    }
                };
            }
            

            graficaMedias.LegendLocation = LegendLocation.Bottom;
        }
        
            
        
    }
}
