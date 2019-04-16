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
        MetodosFormCursos m = new MetodosFormCursos();
        private int cont;
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
            this.InitializeModel();
            //cargarImagenes();
            //this.InitializeObjectListView();
            
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
        }

        private void btnEntornos_Click(object sender, System.EventArgs e)
        {
            restaurarColorBotones(panelDinamico1);
            this.btnEntornos.BackColor = Color.FromArgb(73, 55, 34);
        }

        private void btnLenguajes_Click(object sender, System.EventArgs e)
        {
            restaurarColorBotones(panelDinamico1);
            this.btnLenguajes.BackColor = Color.FromArgb(73, 55, 34);
        }

        private void btnProgramacion_Click(object sender, System.EventArgs e)
        {
            restaurarColorBotones(panelDinamico1);
            this.btnProgramacion.BackColor = Color.FromArgb(73, 55, 34);
        }

        private void btnSistemas_Click(object sender, System.EventArgs e)
        {
            restaurarColorBotones(panelDinamico1);
            this.btnSistemas.BackColor = Color.FromArgb(73, 55, 34);
        }
        
        // Botones de asignaturas de segundo
        private void btnAccesoDatos_Click(object sender, System.EventArgs e)
        {
            restaurarColorBotones(panelDinamico2);
            this.btnAccesoDatos.BackColor = Color.FromArgb(73, 55, 34);
        }

        private void btnInterfaces_Click(object sender, System.EventArgs e)
        {
            restaurarColorBotones(panelDinamico2);
            this.btnInterfaces.BackColor = Color.FromArgb(73, 55, 34);
        }

        private void btnGestion_Click(object sender, System.EventArgs e)
        {
            restaurarColorBotones(panelDinamico2);
            this.btnGestion.BackColor = Color.FromArgb(73, 55, 34);
        }

        private void btnProcesos_Click(object sender, System.EventArgs e)
        {
            restaurarColorBotones(panelDinamico2);
            this.btnProcesos.BackColor = Color.FromArgb(73, 55, 34);
        }

        private void btnMultimedia_Click(object sender, System.EventArgs e)
        {
            restaurarColorBotones(panelDinamico2);
            this.btnMultimedia.BackColor = Color.FromArgb(73, 55, 34);
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

       /************************************
        * ListView Mostrar videos          *
        ************************************/
        private List<Enlaces> listaEnlaces;
        private async void InitializeModel() {
            listaEnlaces = await m.obtenerEnlaces(UsuarioConectado.nombre); 
            cargarImagenes();
            listadoEnlaces.RowHeight = 90;
            //columnaValoracion.AspectToStringConverter  = delegate (object x)
            //{

            //    cont++;
            //    if(int.Parse(listaEnlaces[cont].valoracion) <= 2)
            //    {
            //        columnaValoracion.ImageKey = "1Estrellas";
            //    }else if(int.Parse(listaEnlaces[cont].valoracion) <= 4){
            //        columnaValoracion.ImageKey = "2Estrellas";
            //    }else if (int.Parse(listaEnlaces[cont].valoracion) <= 6)
            //    {
            //        columnaValoracion.ImageKey = "3Estrellas";
            //    }else if (int.Parse(listaEnlaces[cont].valoracion) <= 8)
            //    {
            //        columnaValoracion.ImageKey = "4Estrellas";
            //    }else if (int.Parse(listaEnlaces[cont].valoracion) <= 10)
            //    {
            //        columnaValoracion.ImageKey = "5Estrellas";
            //    }
            //    if(cont == listaEnlaces.Count - 1)
            //    {
            //        cont = 0;
            //    }
            //    return "";

            //};
            //this.columnaTitulo.AspectToStringConverter = delegate (object x)
            //{
            //    return "";
            //};
            
            this.listadoEnlaces.SetObjects(this.listaEnlaces);
        }
        //Añade a la primera columna la Imagen el Título y la Descripción
        public void InitializeObjectListView() {
            //Aumenta el tamaño de las filas
            listadoEnlaces.RowHeight = 90;
            this.columnaTitulo.AspectToStringConverter = delegate (object x)
            {
                return "";
            };
            this.listadoEnlaces.SetObjects(this.listaEnlaces);
        }

        
        //Recorre el List que tiene los enlaces, convierte las rutas de images a Images y las añade a imageListLarge
        public void cargarImagenes()
        {
            imageListSmall.Images.Add("1Estrellas",Proyecto_Presentacion.Properties.Resources.unaEstrellas);
            imageListSmall.Images.Add("2Estrellas", Proyecto_Presentacion.Properties.Resources.dosEstrellas);
            imageListSmall.Images.Add("3Estrellas", Proyecto_Presentacion.Properties.Resources.tresEstrellas);
            imageListSmall.Images.Add("4Estrellas", Proyecto_Presentacion.Properties.Resources.cuatroEstrellas);
            imageListSmall.Images.Add("5Estrellas", Proyecto_Presentacion.Properties.Resources.cincoEstrellas);
            listadoEnlaces.SmallImageList = imageListSmall;

            Image img = null;
            foreach(Enlaces e in listaEnlaces)
            {
                if(e.imagen.Equals("") || e.imagen == null)
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
        private void listadoEnlaces_FormatCell(object sender, BrightIdeasSoftware.FormatCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                Enlaces Enlaces = (Enlaces)e.Model;
                pintarImagenTituloDesc decoration = new pintarImagenTituloDesc();
                decoration.ImageList = this.imageListLarge;
                decoration.Title = Enlaces.titulo;
                decoration.ImageName = Enlaces.id;
                decoration.Description = Enlaces.descripcion;
                e.SubItem.Decoration = decoration;
            }
            if(e.ColumnIndex == 1)
            {
                Enlaces Enlaces = (Enlaces)e.Model;
                pintarImagenTituloDesc decoration = new pintarImagenTituloDesc();
                decoration.ImageList = this.imageListSmall;
                decoration.Title = null;
                decoration.ImageName = Enlaces.valoracion;
                decoration.Description = null;
                e.SubItem.Decoration = decoration;
            }
        }
        //Abre link al hacer doble click sobre la Fila
        private void listadoEnlaces_ItemActivate(object sender, EventArgs e)
        {
            Object linkSeleccionado = listadoEnlaces.SelectedObject;
            Enlaces URL = (Enlaces)linkSeleccionado;
            System.Diagnostics.Process.Start(URL.link );
        }
    }

    
    //Clase que pinta la Imagen el Título y la Descripción en la misma celda
    public class pintarImagenTituloDesc : BrightIdeasSoftware.AbstractDecoration
    {
        public ImageList ImageList;
        public string ImageName;
        public string Title;
        public string Description;

        public Font TitleFont = new Font("Tahoma", 9, FontStyle.Bold);
        public Color TitleColor = Color.FromArgb(255, 255, 255);
        public Font DescripionFont = new Font("Tahoma", 9);
        public Color DescriptionColor = Color.FromArgb(255, 255, 255);
        public Size CellPadding = new Size(1, 1);

        public override void Draw(BrightIdeasSoftware.ObjectListView olv, Graphics g, Rectangle r) {

            Rectangle cellBounds = this.CellBounds;
            cellBounds.Inflate(-this.CellPadding.Width, -this.CellPadding.Height);
            Rectangle textBounds = cellBounds;

            if (Title == null && Description == null)
            {
                try
                {
                    int valoracion = int.Parse(ImageName);
                               
                    if(valoracion <= 20)
                    {
                        ImageName = "1Estrellas";
                    }else if(valoracion <= 40)
                    {
                        ImageName = "2Estrellas";
                    }
                    else if (valoracion <= 60)
                    {
                        ImageName = "3Estrellas";
                    }
                    else if (valoracion <= 80)
                    {
                        ImageName = "4Estrellas";
                    }
                    else if (valoracion <= 100)
                    {
                        ImageName = "5Estrellas";
                    }
                }catch(Exception e){

                }

                g.DrawImage(this.ImageList.Images[this.ImageName], cellBounds.Location);
                textBounds.X += this.ImageList.ImageSize.Width;
                textBounds.Width -= this.ImageList.ImageSize.Width;
            }
            else
            {
                if (this.ImageList != null && !String.IsNullOrEmpty(this.ImageName))
                {
                    //var request = WebRequest.Create("");
                    //Image ima;
                    //using (var response = request.GetResponse())
                    //using (var stream = response.GetResponseStream())
                    //{
                    //    ima = Bitmap.FromStream(stream);
                    //}

                    //Size tamanio = new Size(80, 80);
                    ////Image imagen = Image.FromFile(Application.StartupPath + "/../../images/pildoras.jpg");
                    //Bitmap bitmatImagen = new Bitmap(ima,tamanio);
                    //g.DrawImage(bitmatImagen, cellBounds.Location);
                    //textBounds.X += bitmatImagen.Width;
                    //textBounds.Width -= bitmatImagen.Width;


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