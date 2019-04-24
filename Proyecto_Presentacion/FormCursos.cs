using BrightIdeasSoftware;
using EntidadesCompartidas;
using Proyecto_Negocio;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Windows.Forms;
using System.Windows.Media.Imaging;

namespace Proyecto_Presentacion
{
    public partial class FormCursos : Form
    {
        private Dictionary<string,string> datos = new Dictionary<string,string>();

        MetodosFormCursos m = new MetodosFormCursos();
        public FormCursos()
        {
            InitializeComponent();
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.DoubleBuffer, true);
        }

        private void FormCursos_Load(object sender, System.EventArgs e)
        {
            panelAsignaturas1.Height = 0;
            panelAsignaturas2.Height = 0;
            //Quita los encabezados de la lista
            listadoEnlaces.HeaderStyle = ColumnHeaderStyle.None;
            listadoEnlaces.Font = new Font("Segoe UI Semilight", 10, FontStyle.Bold);
        }

        /****************************
         * Eventos para los botones *
         ****************************/
        private void btnPrimero_Click(object sender, System.EventArgs e)
        {
            restaurarColorBotones(panelDinamico2);
            this.btnSegundo.BackColor = Color.FromArgb(32, 32, 32);
            this.btnPrimero.BackColor = Color.FromArgb(73, 55, 34);
            if (panelAsignaturas1.Height == 0)
            {
                this.tmPanelAsig1.Enabled = true;
            }
            else if (panelAsignaturas1.Height == 40)
            {
                this.tmPanelAsigOcultar1.Enabled = true;
            }
            if (panelAsignaturas2.Height > 0)
            {
                panelAsignaturas2.Height = 0;
            }

        }

        private void btnSegundo_Click(object sender, System.EventArgs e)
        {
            restaurarColorBotones(panelDinamico1);
            this.btnPrimero.BackColor = Color.FromArgb(32, 32, 32);
            this.btnSegundo.BackColor = Color.FromArgb(73, 55, 34);
            if (panelAsignaturas2.Height == 0)
            {
                this.tmPanelAsig2.Enabled = true;
            }
            else if (panelAsignaturas2.Height == 40)
            {
                this.tmPanelAsigOcultar2.Enabled = true;
            }
            if (panelAsignaturas1.Height > 0)
            {
                panelAsignaturas1.Height = 0;
            }
        }

        // Botones de asignaturas de primero
        private void btnBbdd_Click(object sender, System.EventArgs e)
        {
            restaurarColorBotones(panelDinamico1);
            this.btnBbdd.BackColor = Color.FromArgb(73, 55, 34);
            pedirEnlaces(btnBbdd.Text);

        }

        private void btnEntornos_Click(object sender, System.EventArgs e)
        {
            restaurarColorBotones(panelDinamico1);
            this.btnEntornos.BackColor = Color.FromArgb(73, 55, 34);
            pedirEnlaces(btnEntornos.Text);
        }

        private void btnLenguajes_Click(object sender, System.EventArgs e)
        {
            restaurarColorBotones(panelDinamico1);
            this.btnLenguajes.BackColor = Color.FromArgb(73, 55, 34);
            pedirEnlaces(btnLenguajes.Text);
        }
       
        private void btnProgramacion_Click(object sender, System.EventArgs e)
        {
            restaurarColorBotones(panelDinamico1);
            this.btnProgramacion.BackColor = Color.FromArgb(73, 55, 34);
            pedirEnlaces(btnProgramacion.Text);
        }

        private void btnSistemas_Click(object sender, System.EventArgs e)
        {
            restaurarColorBotones(panelDinamico1);
            this.btnSistemas.BackColor = Color.FromArgb(73, 55, 34);
            pedirEnlaces(btnSistemas.Text);
        }
        
        // Botones de asignaturas de segundo
        private void btnAccesoDatos_Click(object sender, System.EventArgs e)
        {
            restaurarColorBotones(panelDinamico2);
            this.btnAccesoDatos.BackColor = Color.FromArgb(73, 55, 34);
            pedirEnlaces(btnAccesoDatos.Text);
        }

        private void btnInterfaces_Click(object sender, System.EventArgs e)
        {
            restaurarColorBotones(panelDinamico2);
            this.btnInterfaces.BackColor = Color.FromArgb(73, 55, 34);
            pedirEnlaces(btnInterfaces.Text);
        }

        private void btnGestion_Click(object sender, System.EventArgs e)
        {
            restaurarColorBotones(panelDinamico2);
            this.btnGestion.BackColor = Color.FromArgb(73, 55, 34);
            pedirEnlaces(btnGestion.Text);
        }

        private void btnProcesos_Click(object sender, System.EventArgs e)
        {
            restaurarColorBotones(panelDinamico2);
            this.btnProcesos.BackColor = Color.FromArgb(73, 55, 34);
            pedirEnlaces(btnProcesos.Text);
        }

        private void btnMultimedia_Click(object sender, System.EventArgs e)
        {
            restaurarColorBotones(panelDinamico2);
            this.btnMultimedia.BackColor = Color.FromArgb(73, 55, 34);
            pedirEnlaces(btnMultimedia.Text);
        }


        private async void pedirEnlaces(string asignatura)
        {
            datos.Clear();
            datos.Add("asignatura", asignatura);

            listaEnlaces = await m.obtenerEnlaces(UsuarioConectado.nombre, datos);
            if (listaEnlaces != null)
            {

                iniciarObjectListView();
            }
            else
            {
                MessageBox.Show("Lo sentimos no hay enlaces para la asignatura " + asignatura);
            }
        }


        /**************************************
         * Timers para animacion de los menus *
         **************************************/
        private void tmPanelAsig1_Tick(object sender, System.EventArgs e)
        {
            if (this.panelAsignaturas1.Height == 40)
            {
                this.tmPanelAsig1.Enabled = false;
            }
            else
            {
                this.panelAsignaturas1.Height = panelAsignaturas1.Height + 5;
            }
        }

        private void tmPanelAsig2_Tick(object sender, System.EventArgs e)
        {
            if (this.panelAsignaturas2.Height == 40)
            {
                this.tmPanelAsig2.Enabled = false;
            }
            else
            {
                this.panelAsignaturas2.Height = panelAsignaturas2.Height + 5;
            }
        }

        private void tmPanelAsigOcultar1_Tick(object sender, System.EventArgs e)
        {
            if (this.panelAsignaturas1.Height == 0)
            {
                this.tmPanelAsigOcultar1.Enabled = false;
            }
            else
            {
                this.panelAsignaturas1.Height = panelAsignaturas1.Height - 5;
            }
        }

        private void tmPanelAsigOcultar2_Tick(object sender, System.EventArgs e)
        {
            if (this.panelAsignaturas2.Height == 0)
            {
                this.tmPanelAsigOcultar2.Enabled = false;
            }
            else
            {
                this.panelAsignaturas2.Height = panelAsignaturas2.Height - 5;
            }
        }

       /***********************************
        * Métodos internos del formulario *
        ***********************************/
        private void restaurarColorBotones(Panel panel)
        {
            List<Button> botones = panel.Controls.OfType<Button>().ToList();
            foreach (Button btn in botones)
            {
                btn.BackColor = Color.FromArgb(32, 32, 32);
            }
        }




        //***********************************************

        private List<Enlaces> listaEnlaces = new List<Enlaces>();

        private void iniciarObjectListView()
        {
            
            this.InitializeModel();
            listadoEnlaces.ModelFilter = TextMatchFilter.Contains(listadoEnlaces, "repair");
            listadoEnlaces.Font = new Font("Segoe UI Semilight", 10, FontStyle.Bold);
        }
        public void InitializeModel()
        {
            //var a = (Object)await m.obtenerEnlaces(UsuarioConectado.nombre);
            //listaEnlaces = (List<Enlaces>)a;
            cargarImagenes();


            listadoEnlaces.RowHeight = 90;
            this.columnaLike.ImageGetter = delegate (object x) {
                switch (((Enlaces)x).like)
                {
                    case true:
                        return "like+1";
                    case false:

                        return "like";
                }
                return "";
            };
            this.columnaDontLike.ImageGetter = delegate (object x) {
                switch (((Enlaces)x).dontLike)
                {
                    case true:
                        return "dontLike-1";
                    case false:

                        return "dontLike";
                }
                return "";
            };


            this.columnaValoracion.ImageGetter = delegate (object x) {
                var valoracion = int.Parse(((Enlaces)x).valoracion);
                //MessageBox.Show(valoracion.ToString());
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
        public void InitializeObjectListView()
        {
            MessageBox.Show(listaEnlaces.Count.ToString());
            this.columnaLike.AspectGetter = delegate (object x)
            {
                return ((Enlaces)x).like;
            };
            this.columnaLike.AspectToStringConverter = delegate (object x)
            {
                return String.Empty;
            };
            listadoEnlaces.RowHeight = 90;
            this.columnaLike.ImageGetter = delegate (object x) {
                switch (((Enlaces)x).like)
                {
                    case true:
                        return "like+1";
                    case false:

                        return "like";
                }
                return "";
            };
            this.columnaDontLike.ImageGetter = delegate (object x) {
                switch (((Enlaces)x).dontLike)
                {
                    case true:
                        return "dontLike-1";
                    case false:

                        return "dontLike";
                }
                return "";
            };


            this.columnaValoracion.ImageGetter = delegate (object x) {
                var valoracion = int.Parse(((Enlaces)x).valoracion);
                MessageBox.Show(valoracion.ToString());
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



        private void objectListView1_FormatCell(object sender, BrightIdeasSoftware.FormatCellEventArgs e)
        {
            pintar(e);
        }
        private void pintar(BrightIdeasSoftware.FormatCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                Enlaces enlace = (Enlaces)e.Model;
                pintarImagenTituloDesc decoration = new pintarImagenTituloDesc();
                decoration.ImageList = this.imageListLarge;
                decoration.Title = enlace.titulo;
                decoration.ImageName = enlace.id;
                decoration.Description = enlace.descripcion;
                e.SubItem.Decoration = decoration;
            }
        }
        //  CAPTURO EVENTO CLICK CON LA CELDA QUE A CLICKADO Y SI ES LA COLUMNA LIKE
        //  OBTENGO EL OBJETO Y LE SUMO 1 LIKE
        private async void listadoEnlaces_CellClick(object sender, BrightIdeasSoftware.CellClickEventArgs e)
        {
            if (e.Column == columnaLike)
            {
                Enlaces enlace = (Enlaces)e.Model;
                if (!enlace.like)
                {
                    //Object linkSeleccionado = objectListView1.SelectedObject;
                    Dictionary<string, string> datos = new Dictionary<string, string>();
                    datos.Add("id", enlace.id);
                    datos.Add("operacion", "sumar");
                    try
                    {
                        bool likeCorrecto = await m.sumarYRestarValoracion(UsuarioConectado.nombre, datos);
                        if (likeCorrecto)
                        {
                            enlace.like = true;
                        }
                    }
                    catch (NullReferenceException nre)
                    {
                        //¿Dar mensaje?
                    }
                    
                }
            }
            if (e.Column == columnaDontLike)
            {
                Enlaces enlace = (Enlaces)e.Model;
                if (!enlace.dontLike)
                {
                    Dictionary<string, string> datos = new Dictionary<string, string>();
                    datos.Add("id", enlace.id);
                    datos.Add("operacion", "sumar");
                    bool likeCorrecto = await m.sumarYRestarValoracion(UsuarioConectado.nombre, datos);
                    if (likeCorrecto)
                    {
                        enlace.dontLike = true;
                    }
                }
            }

        }
        //Abre link al hacer doble click sobre la Fila
        private void listadoEnlaces_ItemActivate(object sender, EventArgs e)
        {
            Object linkSeleccionado = listadoEnlaces.SelectedObject;
            Enlaces URL = (Enlaces)linkSeleccionado;
            System.Diagnostics.Process.Start(URL.link);
        }

        public void cargarImagenes()
        {
            imageListSmall.Images.Add("1Estrellas", Proyecto_Presentacion.Properties.Resources.unaEstrellas);
            imageListSmall.Images.Add("2Estrellas", Proyecto_Presentacion.Properties.Resources.dosEstrellas);
            imageListSmall.Images.Add("3Estrellas", Proyecto_Presentacion.Properties.Resources.tresEstrellas);
            imageListSmall.Images.Add("4Estrellas", Proyecto_Presentacion.Properties.Resources.cuatroEstrellas);
            imageListSmall.Images.Add("5Estrellas", Proyecto_Presentacion.Properties.Resources.cincoEstrellas);
            listadoEnlaces.SmallImageList = imageListSmall;

            Image img = null;
            foreach (Enlaces e in listaEnlaces)
            {
                if (e.imagen.Equals("") || e.imagen == null)
                {
                    img = Image.FromFile(Application.StartupPath + "/../../Resources/titulo.png");
                }
                else if (!e.imagen.Contains("localhost"))
                {   //Convierte imagen de un URL a Image
                    var request = WebRequest.Create(e.imagen);
                    using (var response = request.GetResponse())
                    using (var stream = response.GetResponseStream())
                    {
                        img = Bitmap.FromStream(stream);
                    }
                }
                else
                {
                    img = Image.FromFile(Application.StartupPath + e.imagen);
                }

                imageListLarge.Images.Add(e.id, img);

            }
            //Size tamanio = new Size(80, 80);
            ////Image imagen = Image.FromFile(Application.StartupPath + "/../../images/pildoras.jpg");
            //Bitmap bitmatImagen = new Bitmap(ima, tamanio);


            //Image a = Image.FromFile(Application.StartupPath + "/../../images/pildoras.jpg");
            //imageListLarge.Images.Add("/../../images/pildoras.jpg", a);
        }

        public class pintarImagenTituloDesc : BrightIdeasSoftware.AbstractDecoration
        {
            public ImageList ImageList;
            public string ImageName;
            public string Title;
            public string Description;

            public Font TitleFont = new Font("Segoe UI Semilight", 12, FontStyle.Bold);
            public Color TitleColor = Color.FromArgb(255, 255, 255);
            public Font DescripionFont = new Font("Tahoma", 9);
            public Color DescriptionColor = Color.FromArgb(255, 255, 255);
            public Size CellPadding = new Size(1, 1);

            public override void Draw(BrightIdeasSoftware.ObjectListView olv, Graphics g, Rectangle r)
            {
                Rectangle cellBounds = this.CellBounds;
                cellBounds.Inflate(-this.CellPadding.Width, -this.CellPadding.Height);
                Rectangle textBounds = cellBounds;

                if (this.ImageList != null && !String.IsNullOrEmpty(this.ImageName))
                {
                    g.DrawImage(this.ImageList.Images[this.ImageName], cellBounds.Location);
                    textBounds.X += this.ImageList.ImageSize.Width;
                    textBounds.Width -= this.ImageList.ImageSize.Width;
                }

                //g.DrawRectangle(Pens.Red, textBounds);

                // Draw the title
                StringFormat fmt = new StringFormat(StringFormatFlags.NoWrap);
                fmt.Trimming = StringTrimming.EllipsisCharacter;
                fmt.Alignment = StringAlignment.Near;
                fmt.LineAlignment = StringAlignment.Near;

                using (SolidBrush b = new SolidBrush(this.TitleColor))
                {
                    g.DrawString(this.Title, this.TitleFont, b, textBounds, fmt);
                }

                // Draw the description
                SizeF size = g.MeasureString(this.Title, this.TitleFont, (int)textBounds.Width, fmt);
                textBounds.Y += (int)size.Height;
                textBounds.Height -= (int)size.Height;
                StringFormat fmt2 = new StringFormat();
                fmt2.Trimming = StringTrimming.EllipsisCharacter;
                using (SolidBrush b = new SolidBrush(this.DescriptionColor))
                {
                    g.DrawString(this.Description, this.DescripionFont, b, textBounds, fmt2);
                }
            }
        }
    }
}