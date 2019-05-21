using BrightIdeasSoftware;
using EntidadesCompartidas;
using Proyecto_Negocio;
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
    public partial class FormAdministracion : Form
    {
        private MetodosFormAdministracion mfa = new MetodosFormAdministracion();
        private MetodosFormCursos mfc = new MetodosFormCursos();
        private List<Enlaces> listaEnlaces = new List<Enlaces>();
        private Dictionary<string, string> datos = new Dictionary<string, string>();
        public FormAdministracion()
        {
            InitializeComponent();
        }
        private void FormAdministracion_Load(object sender, EventArgs e)
        {
            objectListView1.HeaderStyle = ColumnHeaderStyle.None;
            objectListView1.Font = new Font("Segoe UI Semilight", 9, FontStyle.Bold);
            objectListView1.CellToolTip.Font = new Font("Segoe UI Semilight",10, FontStyle.Bold);
        }
        private async void pedirEnlaces(string asignatura)
        {
            datos.Clear();
            datos.Add("asignatura", asignatura);

            listaEnlaces = await mfc.obtenerEnlaces(UsuarioConectado.credenciales, datos);
            if (listaEnlaces != null)
            {
                iniciarObjectListView();              
                if (btnPrimero.Enabled == false)
                {
                    btnPrimero.Enabled = true;
                }
                else if (btnSegundo.Enabled == false)
                {
                    btnSegundo.Enabled = true;
                }

            }
            else
            {
                this.objectListView1.SetObjects(new List<Enlaces>());
                MsgBox.Show("Lo sentimos no hay enlaces para la asignatura " + asignatura + ". Intentaremos agregarlos lo antes posible.", "No hay enlaces", MsgBox.Buttons.OK, MsgBox.Icon.Error, MsgBox.AnimateStyle.FadeIn);
            }
        }

        private void iniciarObjectListView()
        {

            this.InitializeModel();
            //objectListView1.ModelFilter = TextMatchFilter.Contains(objectListView1, "repair");
            objectListView1.CellToolTip.Font = new Font("Segoe UI Semilight", 10, FontStyle.Bold);
            objectListView1.CellToolTip.ForeColor = Color.Red;

        }
        public void InitializeModel()
        {
            cargarImagenes();

            //Inicializa los tooltip
            objectListView1.CellToolTipShowing += new EventHandler<ToolTipShowingEventArgs>(objectListView1_CellToolTipShowing);
            //Asigna tamaño del ancho de la fila
            objectListView1.RowHeight = 80;
            this.Column8.ImageGetter = delegate (object x)
            {
                return "papelera";
            };
            this.Column7.ImageGetter = delegate (object x)
            {
                switch (((Enlaces)x).reportarFallo)
                {
                    case 0:
                        return "error";
                    case 1:
                        return "ok";
                    case 2:
                        return "problem";
                }
                return "";
            };
            //this.Column4.ImageGetter = delegate (object x) {
            //    switch (((Enlaces)x).like)
            //    {
            //        case true:
            //            return "like+1";
            //        case false:

            //            return "like";
            //    }
            //    return "";
            //};
            //this.Column5.ImageGetter = delegate (object x) {
            //    switch (((Enlaces)x).dontLike)
            //    {
            //        case true:
            //            return "dontLike-1";
            //        case false:

            //            return "dontLike";
            //    }
            //    return "";
            //};


            //this.Column3.ImageGetter = delegate (object x) {
            //    var valoracion = int.Parse(((Enlaces)x).valoracion);
            //    if (valoracion <= 20)
            //    {
            //        return "1Estrellas";
            //    }
            //    else if (valoracion <= 40)
            //    {
            //        return "2Estrellas";
            //    }
            //    else if (valoracion <= 60)
            //    {
            //        return "3Estrellas";
            //    }
            //    else if (valoracion <= 80)
            //    {
            //        return "4Estrellas";
            //    }
            //    else if (valoracion <= 100)
            //    {
            //        return "5Estrellas";
            //    }
            //    else
            //    {
            //        return "";
            //    }

            //};

            //this.Column1.AspectToStringConverter = delegate (object x)
            //{
            //    return "";
            //};
            this.objectListView1.SetObjects(this.listaEnlaces);
        }

        //private void objectListView1_FormatCell(object sender, BrightIdeasSoftware.FormatCellEventArgs e)
        //{
        //    if (e.Column == Column1)
        //    {
        //        Enlaces enlace = (Enlaces)e.Model;
        //        MetodosFormCursos.pintarImagenTituloDesc decoration = new Proyecto_Negocio.MetodosFormCursos.pintarImagenTituloDesc();

        //        decoration.ImageList = this.imageListLarge;
        //        decoration.Title = enlace.asignatura;
        //        decoration.ImageName = null;
        //        decoration.Description = enlace.tema;
        //        e.SubItem.Decoration = decoration;
        //    }
        //}
        //  CAPTURO EVENTO CLICK CON LA CELDA QUE A CLICKADO Y SI ES LA COLUMNA LIKE
        //  OBTENGO EL OBJETO Y LE SUMO 1 LIKE
        private async void objectListView1_CellClick(object sender, BrightIdeasSoftware.CellClickEventArgs e)
        {
            //if (e.Column == Column4)
            //{
            //    Enlaces enlace = (Enlaces)e.Model;
            //    if (!enlace.like)
            //    {
            //        //Object linkSeleccionado = objectListView1.SelectedObject;
            //        Dictionary<string, string> datos = new Dictionary<string, string>();
            //        datos.Add("id", enlace.id);
            //        datos.Add("operacion", "sumar");
            //        string likeCorrecto = await m.sumarYRestarValoracion(UsuarioConectado.nombre, datos);
            //        if (likeCorrecto.Equals("invitado"))
            //        {
            //            MsgBox.Show("Estas funciones solo estan disponibles para usuarios registrados, por favor regístrate o logueate para disfrutar de estas ventajas", "Funciones solo para usuarios", MsgBox.Buttons.OK, MsgBox.Icon.Error, MsgBox.AnimateStyle.FadeIn);

            //        }
            //        else if (likeCorrecto.Equals("true"))
            //        {
            //            enlace.like = true;
            //            objectListView1.RefreshObject(enlace);

            //        }
            //        else
            //        {
            //            //¿¿MENSAJE??
            //        }

            //    }
            //}
            //if (e.Column == Column5)
            //{
            //    Enlaces enlace = (Enlaces)e.Model;
            //    if (!enlace.dontLike)
            //    {
            //        Dictionary<string, string> datos = new Dictionary<string, string>();
            //        datos.Add("id", enlace.id);
            //        datos.Add("operacion", "restar");

            //        string dontlikeCorrecto = await m.sumarYRestarValoracion(UsuarioConectado.nombre, datos);
            //        if (dontlikeCorrecto.Equals("invitado"))
            //        {
            //            MsgBox.Show("Estas funciones solo estan disponibles para usuarios registrados, por favor regístrate o logueate para disfrutar de estas ventajas", "Funciones solo para usuarios", MsgBox.Buttons.OK, MsgBox.Icon.Error, MsgBox.AnimateStyle.FadeIn);
            //        }
            //        else if (dontlikeCorrecto.Equals("true"))
            //        {
            //            enlace.dontLike = true;
            //            objectListView1.RefreshObject(enlace);
            //        }
            //        else
            //        {
            //            //¿¿MENSAJE??
            //        }
            //    }
            //}
            if (e.Column == Column7)
            {
                Enlaces enlace = (Enlaces)e.Model;               
                        Dictionary<string, string> datos = new Dictionary<string, string>();
                        datos.Add("id", enlace.id);

                        int estadoCorrecto = await mfc.cambiarActivoRevisionDesactivo(UsuarioConectado.credenciales, datos);
                        if (estadoCorrecto != -1)
                        {
                            enlace.reportarFallo = estadoCorrecto;
                            objectListView1.RefreshObject(enlace);
                        }
                        else
                        {
                        MsgBox.Show("Ha ocurrido un error al actualizar la Base de datos","ATENCIÓN", MsgBox.Buttons.OK, MsgBox.Icon.Error, MsgBox.AnimateStyle.FadeIn);
                        }
            }
            if (e.Column == Column8)
            {
                Enlaces enlace = (Enlaces)e.Model;

                DialogResult respuesta = MsgBox.Show("¿Está seguro de que desea eliminar el enlace con id " + enlace.id + "?", "Eliminar",
                                MsgBox.Buttons.YesNo, MsgBox.Icon.Question, MsgBox.AnimateStyle.FadeIn);


                if (respuesta == DialogResult.Yes)
                {
                    Dictionary<string, string> datos = new Dictionary<string, string>();
                    datos.Add("id", enlace.id);

                    bool correcto = await mfa.borrarEnlace(UsuarioConectado.nombre, datos);
                    if (correcto)
                    {
                        objectListView1.RemoveObject(enlace);
                        objectListView1.BuildList();
                    }
                    else
                    {
                        MsgBox.Show("Ha ocurrido un error al borrar el enlace", "Error al borrar", MsgBox.Buttons.OK, MsgBox.Icon.Error, MsgBox.AnimateStyle.FadeIn);
                    }
                }
            }


        }

        //Abre link al hacer doble click sobre la Fila
        private void objectListView1_ItemActivate(object sender, EventArgs e)
        {
            Object linkSeleccionado = objectListView1.SelectedObject;
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
            imageListSmall.Images.Add("ok", Proyecto_Presentacion.Properties.Resources.ok);
            imageListSmall.Images.Add("problem", Proyecto_Presentacion.Properties.Resources.revision);
            imageListSmall.Images.Add("error", Proyecto_Presentacion.Properties.Resources.reportar);
            imageListSmall.Images.Add("like", Proyecto_Presentacion.Properties.Resources.like);
            imageListSmall.Images.Add("like+1", Proyecto_Presentacion.Properties.Resources.like_1);
            imageListSmall.Images.Add("dontLike", Proyecto_Presentacion.Properties.Resources.dislike);
            imageListSmall.Images.Add("dontLike-1", Proyecto_Presentacion.Properties.Resources.dislike_1);
            imageListSmall.Images.Add("papelera", Proyecto_Presentacion.Properties.Resources.papelera);

            objectListView1.SmallImageList = imageListSmall;
            imageListLarge = mfc.cargarImageListLargeEnlaces(listaEnlaces, Application.StartupPath);

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


        private void tbBuscar_TextChanged(object sender, EventArgs e)
        {
            if (tbBuscar.Text != " Buscar ")
            {
                
                this.objectListView1.ModelFilter = new ModelFilter(delegate (object x)
                {
                    if(tbBuscar.Text != " Buscar " && tbBuscar.Text != "")
                    {
                        var enla = x as Enlaces;
                        string tituloSinAcentos = quitarAcentos(enla.id);
                        string tbBuscarSinAcentos = quitarAcentos(tbBuscar.Text);

                        return x != null && (containsIgnoreMayusMin(tituloSinAcentos, tbBuscarSinAcentos, StringComparison.InvariantCultureIgnoreCase));

                    }
                    return true;
                });
            }

        }


        //Si tbBuscar esta vacio pone el texto buscar
        private void tbBuscar_Leave(object sender, EventArgs e)
        {
            if (tbBuscar.Text == "")
            {
                tbBuscar.Text = " Buscar ";
                objectListView1.BuildList();
            }
        }
        //Limpia el texto Buscar del tbBuscar
        private void tbBuscar_Enter(object sender, EventArgs e)
        {
            tbBuscar.Clear();
        }
        private void objectListView1_CellToolTipShowing(object sender, ToolTipShowingEventArgs e)
        {
            e.ToolTipControl.IsBalloon = true;
            Enlaces enlace = (Enlaces)e.Model;

            if (e.Column == Column3)
            {
                e.Text = enlace.tema;
            }
            if (e.Column == Column6)
            {
                e.Text = enlace.titulo;
            }
            if (e.Column == Column7)
            {
                if (enlace.reportarFallo == 1)
                {
                    e.Text = "Activo";
                }
                else if(enlace.reportarFallo == 2)
                {
                    e.Text = "Revisar";
                }else
                {
                    e.Text = "Caido";
                }
            }
            if (e.Column == Column8)
            { 
                    e.Text = "Eliminar";
            }
        }

        private void btnSegundo_Click(object sender, EventArgs e)
        {          
            objectListView1.HeaderStyle = ColumnHeaderStyle.Clickable;
            btnSegundo.Enabled = false;
            objectListView1.Focus();
            //Ocupa el espacio libre
            //Column1.FillsFreeSpace = false;
            Column3.FillsFreeSpace = true;

            //Centrar
            Column1.TextAlign = HorizontalAlignment.Center;
            Column4.TextAlign = HorizontalAlignment.Center;
            Column5.TextAlign = HorizontalAlignment.Center;
            Column7.TextAlign = HorizontalAlignment.Center;
            Column8.TextAlign = HorizontalAlignment.Center;

            //Ancho culumnas
            Column1.MinimumWidth = 30;
            Column1.Width = 20;
            Column2.Width = 130;
            Column3.MinimumWidth = 60;
            Column3.Width = 200;           
            Column4.MinimumWidth = 80;
            Column4.Width = 80;
            Column5.MinimumWidth = 60;
            Column5.Width = 60;
            Column6.MinimumWidth = 200;
            Column6.Width = 300;
            Column7.MinimumWidth = 70;
            Column7.Width = 70;
            Column8.MinimumWidth = 80;
            Column8.Width = 80;

            //Texto de la cabecera
            Column1.Text = "Id";
            Column2.Text = "Asignatura";
            Column3.Text = "Tema";
            Column4.Text = "Valoracion";
            Column5.Text = "Tipo";
            Column6.Text = "Título";
            Column7.Text = "Estado";
            Column8.Text = "Eliminar";

            Column1.AspectName = "id";
            Column2.AspectName = "asignatura";
            Column3.AspectName = "tema";            
            Column4.AspectName = "valoracion";
            Column5.AspectName = "tipo";
            Column6.AspectName = "titulo";


            this.btnPrimero.BackColor = Color.FromArgb(32, 32, 32);
            this.btnSegundo.BackColor = Color.FromArgb(73, 55, 34);
            pedirEnlaces("todas");
        }

       
    }
}

