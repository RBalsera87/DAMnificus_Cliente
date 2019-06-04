using LiveCharts;
using LiveCharts.Wpf;
using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Windows;
using Proyecto_Negocio;
using BrightIdeasSoftware;
using EntidadesCompartidas;
using System.Drawing;
using System.Linq;
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
        public FormAreaPersonal(int curso, List<string> asignaturas, int user, List<double> todasNotas, List<double> notasMedias)
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
            lblTrimestre.Text = "Trimestre 1";
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
        private void FormAreaPersonal_Load(object sender, EventArgs e)
        {
            listadoEnlaces.HeaderStyle = ColumnHeaderStyle.None;
            listadoEnlaces.Font = new Font("Segoe UI Semilight", 9, System.Drawing.FontStyle.Bold);
            InitializeEmptyListMsgOverlay();
            listadoEnlaces.EmptyListMsg = "Cargando...";
            if (UsuarioConectado.nombre.Equals("invitado"))
            {
                obtenerEnlaces("todas");
            }else
            {
                obtenerEnlaces("personal");
            }
            

        }
        public void cargaComponentes()
        {

            lbAsignaturas.DataSource = nombresAsignaturas;
            lbAsignaturas.SelectedIndex = 0;

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e) { }

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
            switch (tbTrimestre.Value)
            {
                case 0:
                    lblTrimestre.Text = "Trimestre 1";
                    break;
                case 1:
                    lblTrimestre.Text = "Trimestre 2";
                    break;
                case 2:
                    lblTrimestre.Text = "Trimestre 3";
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
                bool aux = await met.hayNota(trimestre, asignatura, user, usuario);
                if (aux)
                {
                    if (MsgBox.Show("Ya hay una nota asociada a esa asignatura en ese trimestre. ¿Quieres sobreescribirla?", "Conflicto entre notas", MsgBox.Buttons.YesNo, MsgBox.Icon.Question, MsgBox.AnimateStyle.FadeIn) == DialogResult.Yes)
                    {
                        await met.agregarNota(nota, trimestre, asignatura, user, usuario);
                        MsgBox.Show("Nota cambiada satisfactoriamente", "Conflicto resuelto", MsgBox.Buttons.OK, MsgBox.Icon.Question, MsgBox.AnimateStyle.FadeIn);
                    }
                    else
                    {
                        MsgBox.Show("Se dejará la nota ya existente", "Conflicto resuelto", MsgBox.Buttons.OK, MsgBox.Icon.Question, MsgBox.AnimateStyle.FadeIn);
                    }
                }
                else
                {
                    await met.agregarNota(nota, trimestre, asignatura, user, usuario);
                }
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
                    Labels = new[] { "Trimestre 1", "Trimestre 2", "Trimestre 3" }
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
                    Labels = new[] { "Trimestre 1", "Trimestre 2" }
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

            lblTrimestre.Text = "Trimestre 1";
        }

        //***************************************************************
        //************************OBJECTLISTVIEW*************************
        private List<Enlaces> listaEnlaces = new List<Enlaces>();
        private Dictionary<string, string> datos = new Dictionary<string, string>();
        MetodosFormCursos mfc = new MetodosFormCursos();
        private async void obtenerEnlaces(string asignatura)
        {
            datos.Clear();
            datos.Add("asignatura", asignatura);
            datos.Add("credenciales", UsuarioConectado.credenciales);
            listaEnlaces = await mfc.obtenerEnlaces(UsuarioConectado.nombre, datos);
            if (listaEnlaces != null)
            {
                iniciarObjectListView();
            }
            else
            {
                listadoEnlaces.EmptyListMsg = "Aún no has subido ningún enlace. \nAnímate a participar.";
            }
        }

        protected virtual void InitializeEmptyListMsgOverlay()
        {
            TextOverlay textOverlay = this.listadoEnlaces.EmptyListMsgOverlay as TextOverlay;
            textOverlay.TextColor = Color.FromArgb(231, 120, 0);
            textOverlay.BackColor = Color.FromArgb(32, 32, 32);
            textOverlay.BorderWidth = 0.0f;
            textOverlay.Font = new Font("Segoe UI Semilight", 22);
        }

        private void iniciarObjectListView()
        {

            this.InitializeModel();
            //listadoEnlaces.ModelFilter = TextMatchFilter.Contains(listadoEnlaces, "repair");
            listadoEnlaces.Font = new Font("Segoe UI Semilight", 9, System.Drawing.FontStyle.Bold);
            listadoEnlaces.CellToolTip.Font = new Font("Segoe UI Semilight", 10, System.Drawing.FontStyle.Bold);

        }
        public void InitializeModel()
        {
            cargarImagenes();

            //Inicializa los tooltip
            listadoEnlaces.CellToolTipShowing += new EventHandler<ToolTipShowingEventArgs>(listadoEnlaces_CellToolTipShowing);
            //Asigna tamaño del ancho de la fila
            listadoEnlaces.RowHeight = 90;
            
            this.columnaTema.ImageGetter = delegate (object x) {
                switch (((Enlaces)x).like)
                {
                    case true:
                        return "like+1";
                    case false:

                        return "like";
                }
                return "";
            };
            this.columnaValoracion.ImageGetter = delegate (object x) {
                var valoracion = int.Parse(((Enlaces)x).valoracion);
                if (valoracion <= 20)
                {
                    return "1Estrellas";
                }
                else if (valoracion <= 40)
                {
                    return "2Estrellas";
                }
                else if (valoracion <= 60)
                {
                    return "3Estrellas";
                }
                else if (valoracion <= 80)
                {
                    return "4Estrellas";
                }
                else if (valoracion <= 100)
                {
                    return "5Estrellas";
                }
                else
                {
                    return "";
                }

            };

            this.columnaTitulo.AspectToStringConverter = delegate (object x)
            {
                return "";
            };
            this.listadoEnlaces.SetObjects(this.listaEnlaces);
        }

        private void listadoEnlaces_FormatCell(object sender, BrightIdeasSoftware.FormatCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                Enlaces enlace = (Enlaces)e.Model;
                MetodosFormCursos.pintarImagenTituloDesc decoration = new Proyecto_Negocio.MetodosFormCursos.pintarImagenTituloDesc();

                decoration.ImageList = this.imageListLarge;
                decoration.Title = enlace.titulo;
                decoration.ImageName = enlace.id;
                decoration.Description = enlace.descripcion;
                decoration.titleSize = 10;
                decoration.descriptionSize = 9;
                e.SubItem.Decoration = decoration;
            }
        }
        //Abre link al hacer doble click sobre la Fila
        private void listadoEnlaces_ItemActivate(object sender, EventArgs e)
        {
            try
            {
                Object enlaceSeleccionado = listadoEnlaces.SelectedObject;
                Enlaces enlace = (Enlaces)enlaceSeleccionado;
                System.Diagnostics.Process.Start(enlace.link);
            }
            catch (Exception)
            {
                MsgBox.Show("Ha ocurrido un error abrir el enlace", "Error enlace", MsgBox.Buttons.OK, MsgBox.Icon.Error, MsgBox.AnimateStyle.FadeIn);
            }
        }

        public void cargarImagenes()
        {
            imageListSmall.Images.Add("1Estrellas", Proyecto_Presentacion.Properties.Resources.unaEstrellas);
            imageListSmall.Images.Add("2Estrellas", Proyecto_Presentacion.Properties.Resources.dosEstrellas);
            imageListSmall.Images.Add("3Estrellas", Proyecto_Presentacion.Properties.Resources.tresEstrellas);
            imageListSmall.Images.Add("4Estrellas", Proyecto_Presentacion.Properties.Resources.cuatroEstrellas);
            imageListSmall.Images.Add("5Estrellas", Proyecto_Presentacion.Properties.Resources.cincoEstrellas);

            listadoEnlaces.SmallImageList = imageListSmall;
            imageListLarge = mfc.cargarImageListLargeEnlaces(listaEnlaces, System.Windows.Forms.Application.StartupPath, 70);

        }
        public bool containsIgnoreMayusMin(string source, string value, StringComparison comparisonType)
        {
            return source?.IndexOf(value, comparisonType) >= 0;
        }
        private string quitarAcentos(string texto)
        {
            byte[] tempBytes;
            tempBytes = System.Text.Encoding.GetEncoding("ISO-8859-8").GetBytes(texto);
            string textoSinAcentos = System.Text.Encoding.UTF8.GetString(tempBytes);
            return textoSinAcentos;
        }

        //Método para poner los tooltip
        private void listadoEnlaces_CellToolTipShowing(object sender, ToolTipShowingEventArgs e)
        {
            e.ToolTipControl.IsBalloon = true;
            
            if (e.Column == columnaTema)
            {
                Enlaces enlace = (Enlaces)e.Model;
                e.Text = enlace.tema;
            }
            
        }
        private void listBox_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0) return;
            bool seleccionado = false;
            string listBox = lbAsignaturas.Items[e.Index].ToString();
            // Si se selecciona un elemento, cambia el color de fondo.
            if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
            {
                seleccionado = true;
                e = new DrawItemEventArgs(e.Graphics,
                                         e.Font,
                                         e.Bounds,
                                         e.Index,
                                         e.State ^ DrawItemState.Selected,
                                         e.ForeColor,
                                         Color.FromArgb(255, 153, 39));// Color seleccionado
            }

            // Dibuja el fondo del control ListBox para cada elemento.
            e.DrawBackground();
            // Dibuja el texto del elemento actual
            if (seleccionado)
                e.Graphics.DrawString(listBox, e.Font, Brushes.Black, e.Bounds, StringFormat.GenericDefault);
            else
                e.Graphics.DrawString(listBox, e.Font, Brushes.DarkGray, e.Bounds, StringFormat.GenericDefault);
            // Si el cuadro de lista tiene el foco, dibuja un rectángulo alrededor del elemento seleccionado.
            e.DrawFocusRectangle();
        }
    }
}
