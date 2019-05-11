using LiveCharts;
using LiveCharts.Wpf;
using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Windows;
using Proyecto_Negocio;
using System.Threading.Tasks;

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

        public FormAreaPersonal() { }
        public FormAreaPersonal(int curso, List<string>asignaturas, int user, List<double> todasNotas, List<double> notasMedias)
        {
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.DoubleBuffer, true);
            this.curso = curso;
            this.nombresAsignaturas = asignaturas;
            this.user = user;
            this.todasNotas = todasNotas;
            this.mediaNotas = notasMedias;
            InitializeComponent();
            DoubleBuffered = true;
            if (usuario.Equals("invitado") || curso == 0)
            {
                cargarModelo();
            }
            else
            {
                cargaComponentes();
                cargaGraficas(curso);
            }
        }

        public void cargaComponentes()
        {
            
            lbAsignaturas.DataSource = nombresAsignaturas;
            lbAsignaturas.SelectedIndex = 0;
            lblTrimestre.Text = "TRIMESTRE 1";
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e){ }

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

        
        private async void btnAgregarNota_Click(object sender, EventArgs e)
        {
            if (usuario.Equals("invitado") || curso == 0)
            {
                MsgBox.Show("Estas funciones solo estan disponibles para usuarios registrados, por favor regístrate o logueate para disfrutar de estas ventajas", "Funciones solo para usuarios", MsgBox.Buttons.OK, MsgBox.Icon.Error, MsgBox.AnimateStyle.FadeIn);
            }
            else
            {
                int trimestre = tbTrimestre.Value + 1;
                string nota = notaIntroducir.Value.ToString();
                nota = nota.Replace(",", ".");
                string asignatura = lbAsignaturas.SelectedItem.ToString();
                met.agregarNota(nota, trimestre, asignatura, user);
                vaciadoListas();
                todasNotas = await met.recogidaNotas(curso, user, usuario);
                mediaNotas = await met.mediaNotas(curso, user, usuario);
                cargaComponentes();
                cargaGraficas(curso);
            }
                
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
            

            graficaNotas.LegendLocation = LegendLocation.Bottom;
        }
        
            
        public void cargarModelo()
        {
            graficaNotas.AxisX.Clear();
            graficaNotas.Series = new SeriesCollection
            {
                new ColumnSeries
                {
                    Title = "Bases de datos",
                    Values = new ChartValues<double> { 1, 1, 1 }
                }
            };
            graficaNotas.Series.Add(new ColumnSeries
            {
                Title = "Entornos de desarrollo",
                Values = new ChartValues<double> { 2, 2, 2 }
            });
            graficaNotas.Series.Add(new ColumnSeries
            {
                Title = "Lenguaje de marcas",
                Values = new ChartValues<double> { 3, 3, 3 }
            });
            graficaNotas.Series.Add(new ColumnSeries
            {
                Title = "Programación",
                Values = new ChartValues<double> { 4, 4, 4 }
            });
            graficaNotas.Series.Add(new ColumnSeries
            {
                Title = "Sistemas informáticos",
                Values = new ChartValues<double> { 5, 5, 5 }
            });
            graficaNotas.Series.Add(new ColumnSeries
            {
                Title = "Formación y orientación laboral",
                Values = new ChartValues<double> { 6, 6, 6 }
            });
            graficaNotas.AxisX.Add(new Axis
            {
                Labels = new[] { "TRIMESTRE 1", "TRIMESTRE 2", "TRIMESTRE 3" }
            });

            graficaMedias.Series = new SeriesCollection
                {
                    new PieSeries
                    {
                        Title = "Bases de datos",
                        Values = new ChartValues<double> {1},
                        DataLabels = true,
                    },
                    new PieSeries
                    {
                        Title = "Entornos de desarrollo",
                        Values = new ChartValues<double> {2},
                        DataLabels = true,
                    },
                    new PieSeries
                    {
                        Title = "Lenguaje de marcas",
                        Values = new ChartValues<double> {3},
                        DataLabels = true,
                    },
                    new PieSeries
                    {
                        Title = "Programación",
                        Values = new ChartValues<double> {4},
                        DataLabels = true,
                    },
                    new PieSeries
                    {
                        Title = "Sistemas informáticos",
                        Values = new ChartValues<double> {5},
                        DataLabels = true,
                    },
                    new PieSeries
                    {
                        Title = "Formación y orientación laboral",
                        Values = new ChartValues<double> {6},
                        DataLabels = true,
                    }
                };
            graficaNotas.LegendLocation = LegendLocation.Bottom;

            lbAsignaturas.Items.Add("Bases de datos");
            lbAsignaturas.Items.Add("Entornos de desarrollo");
            lbAsignaturas.Items.Add("Lenguaje de marcas");
            lbAsignaturas.Items.Add("Programación");
            lbAsignaturas.Items.Add("Sistemas informáticos");
            lbAsignaturas.Items.Add("Formación y orientación laboral");

            lblTrimestre.Text = "TRIMESTRE 1";
        }


    }
}
