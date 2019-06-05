using EntidadesCompartidas;
using Proyecto_AccesoDatos;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Net;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Negocio
{
    public class MetodosFormCursos
    {
        AccesoDatos ad = new AccesoDatos();
        public async Task<List<Enlaces>> obtenerEnlaces(string usuario, Dictionary<string, string> datos)
        {
            return await ad.obtenerEnlaces(usuario, datos);
        }       
        
        public async Task<string> sumarYRestarValoracion(string usuario, Dictionary<string, string> datos)
        {
            return await ad.sumaryRestarValoracion(usuario, datos);
        }
        public async Task<int> cambiarActivoRevisionDesactivo(string usuario, Dictionary<string, string> datos)
        {
            return await ad.cambiarActivoRevisionDesactivo(usuario, datos);
        }
        public ImageList cargarImageListLargeEnlaces(List<Enlaces> listaEnlaces, Image imagenPorDefecto, int tamanio)
        {
            ImageList imageListLarge = new ImageList();
            imageListLarge.ImageSize = new Size(tamanio, tamanio);
            imageListLarge.TransparentColor = Color.Transparent;
            imageListLarge.ColorDepth = ColorDepth.Depth32Bit;
            Image img = null;
            foreach (Enlaces e in listaEnlaces)
            {
                if (e.imagen.Equals("") || e.imagen == null)
                {
                    img = imagenPorDefecto;
                }
                else 
                {   //Convierte imagen de un URL a Image
                    try
                    {
                        var request = WebRequest.Create(e.imagen);
                        using (var response = request.GetResponse())
                        using (var stream = response.GetResponseStream())
                            img = Bitmap.FromStream(stream);
                    }
                    catch (Exception)
                    {
                        img = imagenPorDefecto;
                    }

                }

                imageListLarge.Images.Add(e.id, img);
            }
            return imageListLarge;
        }
        public class pintarImagenTituloDesc : BrightIdeasSoftware.AbstractDecoration
        {
            public ImageList ImageList;
            public string ImageName;
            public string Title;
            public string Description;
            public int titleSize;
            public int descriptionSize;
            //Font TitleFont = new Font("Segoe UI Semilight", 12, FontStyle.Bold);
            public Color TitleColor = Color.FromArgb(255, 255, 255);
            public Font DescripionFont = new Font("Segoe UI Semilight", 10);
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
                Font titleFont = new Font("Segoe UI Semilight", titleSize, FontStyle.Bold);
                using (SolidBrush b = new SolidBrush(this.TitleColor))
                {
                    g.DrawString(this.Title, titleFont, b, textBounds, fmt);
                }

                // Draw the description
                SizeF size = g.MeasureString(this.Title, titleFont, (int)textBounds.Width, fmt);
                textBounds.Y += (int)size.Height;
                textBounds.Height -= (int)size.Height;
                StringFormat fmt2 = new StringFormat();
                fmt2.Trimming = StringTrimming.EllipsisCharacter;
                Font descriptionFont = new Font("Segoe UI Semilight", descriptionSize);
                using (SolidBrush b = new SolidBrush(this.DescriptionColor))
                {
                    g.DrawString(this.Description, descriptionFont, b, textBounds, fmt2);
                }
            }
        }
    }
}
