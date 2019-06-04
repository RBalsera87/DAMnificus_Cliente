using BrightIdeasSoftware;
using EntidadesCompartidas;
using Proyecto_Negocio;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text.RegularExpressions;
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
            listadoEnlaces.Font = new Font("Segoe UI Semilight", 9, FontStyle.Bold);
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
            botones("Bases de datos", sender);
        }

        private void btnEntornos_Click(object sender, System.EventArgs e)
        {
            restaurarColorBotones(panelDinamico1);
            this.btnEntornos.BackColor = Color.FromArgb(73, 55, 34);
            botones("Entornos de desarrollo", sender);
        }

        private void btnLenguajes_Click(object sender, System.EventArgs e)
        {
            restaurarColorBotones(panelDinamico1);
            this.btnLenguajes.BackColor = Color.FromArgb(73, 55, 34);
            botones("Lenguajes de marcas", sender);
        }
       
        private void btnProgramacion_Click(object sender, System.EventArgs e)
        {
            restaurarColorBotones(panelDinamico1);
            this.btnProgramacion.BackColor = Color.FromArgb(73, 55, 34);
            botones("Programación", sender);
        }

        private void btnSistemas_Click(object sender, System.EventArgs e)
        {
            restaurarColorBotones(panelDinamico1);
            this.btnSistemas.BackColor = Color.FromArgb(73, 55, 34);
            botones("Sistemas informáticos", sender);
        }
        
        // Botones de asignaturas de segundo
        private void btnAccesoDatos_Click(object sender, System.EventArgs e)
        {
            restaurarColorBotones(panelDinamico2);
            this.btnAccesoDatos.BackColor = Color.FromArgb(73, 55, 34);
            botones("Acceso a datos", sender);
        }

        private void btnInterfaces_Click(object sender, System.EventArgs e)
        {
            restaurarColorBotones(panelDinamico2);
            this.btnInterfaces.BackColor = Color.FromArgb(73, 55, 34);
            botones("Desarrollo de interfaces", sender);
        }

        private void btnGestion_Click(object sender, System.EventArgs e)
        {
            restaurarColorBotones(panelDinamico2);
            this.btnGestion.BackColor = Color.FromArgb(73, 55, 34);
            botones("Sistemas de gestión empresarial", sender);
        }

        private void btnProcesos_Click(object sender, System.EventArgs e)
        {
            restaurarColorBotones(panelDinamico2);
            this.btnProcesos.BackColor = Color.FromArgb(73, 55, 34);
            botones("Programación de servicios y procesos", sender);
        }

        private void btnMultimedia_Click(object sender, System.EventArgs e)
        {
            restaurarColorBotones(panelDinamico2);
            this.btnMultimedia.BackColor = Color.FromArgb(73, 55, 34);
            botones("Programación multimedia y dispositivos móviles", sender);
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

        private async void obtenerEnlaces(string asignatura)
        {
            datos.Clear();
            datos.Add("asignatura", asignatura);
            datos.Add("credenciales", UsuarioConectado.credenciales);

            listaEnlaces = await m.obtenerEnlaces(UsuarioConectado.nombre, datos);
            if (listaEnlaces != null)
            {
                iniciarObjectListView();
            }
            else
            {
                listadoEnlaces.EmptyListMsg = "Lo sentimos no hay enlaces para la asignatura " + asignatura + ". \nIntentaremos agregarlos lo antes posible.";
            }
            
            activarBotones();
        }
        private void botones(string asignatura, object sender)
        {
            tbBuscar.Text = " Buscar ";
            listadoEnlaces.ClearObjects();
            InitializeEmptyListMsgOverlay();
            listadoEnlaces.EmptyListMsg = "Cargando...";
            Button boton = (Button)sender;
            boton.Enabled = false;
            obtenerEnlaces(asignatura);
        }
        private void activarBotones()
        {
            btnBbdd.Enabled = true;
            btnEntornos.Enabled = true;
            btnLenguajes.Enabled = true;
            btnProgramacion.Enabled = true;
            btnSistemas.Enabled = true;
            btnAccesoDatos.Enabled = true;
            btnInterfaces.Enabled = true;
            btnGestion.Enabled = true;
            btnMultimedia.Enabled = true;
            btnProcesos.Enabled = true;
        }
        //Crea mensaje cuando el objectlistview esta vacio
        private void InitializeEmptyListMsgOverlay()
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
            listadoEnlaces.Font = new Font("Segoe UI Semilight", 9, FontStyle.Bold);
            listadoEnlaces.CellToolTip.Font = new Font("Segoe UI Semilight", 10, FontStyle.Bold);
            listadoEnlaces.EmptyListMsgFont = new Font("Segoe UI Semilight", 12, FontStyle.Bold);
            listadoEnlaces.Sort(columnaTema, SortOrder.Ascending); //Ordena los enlaces por la columna tema
        }
        public void InitializeModel()
        {
            cargarImagenes();

            //Inicializa los tooltip
            listadoEnlaces.CellToolTipShowing += new EventHandler<ToolTipShowingEventArgs>(listadoEnlaces_CellToolTipShowing);
            //Asigna tamaño del ancho de la fila
            listadoEnlaces.RowHeight = 90;
            this.columnaReportarFallo.ImageGetter = delegate (object x)
            {
                if (UsuarioConectado.credenciales == "admin")
                {
                    switch (((Enlaces)x).reportarFallo)
                    {
                        case 0:
                            return "reportar";
                        case 1:
                            return "ok";
                        case 2:
                            return "revision";
                    }
                }
                else
                {
                    switch (((Enlaces)x).reportarFallo)
                    {
                        case 0:
                            return "reportar";
                        case 1:
                            return "reportar";
                        case 2:
                            return "revision";
                    }
                }
                
                return "";
            };
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
                decoration.titleSize = 11;
                decoration.descriptionSize = 9;
                e.SubItem.Decoration = decoration;
            }
        }
        //  CAPTURO EVENTO CLICK CON LA CELDA QUE A CLICKADO Y SI ES LA COLUMNA LIKE
        //  OBTENGO EL OBJETO Y LE SUMO 1 LIKE
        private async void listadoEnlaces_CellClick(object sender, BrightIdeasSoftware.CellClickEventArgs e)
        {
            
            if (e.Column == columnaLike)
            {
                if (UsuarioConectado.credenciales.Equals("invitado"))
                {
                    MsgBox.Show("Estas funciones solo estan disponibles para usuarios registrados, por favor regístrate o logueate para disfrutar de estas ventajas", "Funciones solo para usuarios", MsgBox.Buttons.OK, MsgBox.Icon.Error, MsgBox.AnimateStyle.FadeIn);
                }else
                {
                    Enlaces enlace = (Enlaces)e.Model;
                    if (!enlace.like && !enlace.dontLike)
                    {
                        //Object linkSeleccionado = objectListView1.SelectedObject;
                        Dictionary<string, string> datos = new Dictionary<string, string>();
                        datos.Add("id", enlace.id);
                        datos.Add("operacion", "sumar");
                        string likeCorrecto = await m.sumarYRestarValoracion(UsuarioConectado.nombre, datos);
                        if (likeCorrecto.Equals("true"))
                        {
                            enlace.like = true;
                            listadoEnlaces.RefreshObject(enlace);
                        }
                        else
                        {
                            //¿¿MENSAJE??
                        }
                    }
                }
                
            }
            else if (e.Column == columnaDontLike)
            {
                if (UsuarioConectado.credenciales.Equals("invitado"))
                {
                    MsgBox.Show("Estas funciones solo estan disponibles para usuarios registrados, por favor regístrate o logueate para disfrutar de estas ventajas", "Funciones solo para usuarios", MsgBox.Buttons.OK, MsgBox.Icon.Error, MsgBox.AnimateStyle.FadeIn);
                }else
                {
                    Enlaces enlace = (Enlaces)e.Model;
                    if (!enlace.dontLike && !enlace.like)
                    {
                        Dictionary<string, string> datos = new Dictionary<string, string>();
                        datos.Add("id", enlace.id);
                        datos.Add("operacion", "restar");

                        string dontlikeCorrecto = await m.sumarYRestarValoracion(UsuarioConectado.nombre, datos);
                        if (dontlikeCorrecto.Equals("true"))
                        {
                            enlace.dontLike = true;
                            listadoEnlaces.RefreshObject(enlace);
                        }
                        else
                        {
                            //¿¿MENSAJE??
                        }
                    }
                }  
            }
            else if (e.Column == columnaReportarFallo)
            {
                if (UsuarioConectado.credenciales.Equals("invitado"))
                {
                    MsgBox.Show("Estas funciones solo estan disponibles para usuarios registrados, por favor regístrate o logueate para disfrutar de estas ventajas", "Funciones solo para usuarios", MsgBox.Buttons.OK, MsgBox.Icon.Error, MsgBox.AnimateStyle.FadeIn);
                }else
                {
                    Enlaces enlace = (Enlaces)e.Model;
                    if (enlace.reportarFallo == 1)
                    {
                        DialogResult respuesta = MsgBox.Show("¿Seguro que quieres reportar que el link esta caído?", "Reportar link",
                                    MsgBox.Buttons.YesNo, MsgBox.Icon.Question, MsgBox.AnimateStyle.FadeIn);


                        if (respuesta == DialogResult.Yes)
                        {
                            Dictionary<string, string> datos = new Dictionary<string, string>();
                            datos.Add("id", enlace.id);
                            datos.Add("credenciales", UsuarioConectado.credenciales);
                            int estadoCorrecto = await m.cambiarActivoRevisionDesactivo(UsuarioConectado.nombre, datos);

                            if (estadoCorrecto != -1)
                            {
                                enlace.reportarFallo = estadoCorrecto;
                                listadoEnlaces.RefreshObject(enlace);
                            }
                            else
                            {
                                //¿¿MENSAJE??
                            }
                        }
                    }
                }
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
            imageListSmall.Images.Add("ok", Proyecto_Presentacion.Properties.Resources.activo);
            imageListSmall.Images.Add("reportar", Proyecto_Presentacion.Properties.Resources.reportar);
            imageListSmall.Images.Add("revision", Proyecto_Presentacion.Properties.Resources.revision);
            imageListSmall.Images.Add("like", Proyecto_Presentacion.Properties.Resources.like);
            imageListSmall.Images.Add("like+1", Proyecto_Presentacion.Properties.Resources.like_1);
            imageListSmall.Images.Add("dontLike", Proyecto_Presentacion.Properties.Resources.dislike);
            imageListSmall.Images.Add("dontLike-1", Proyecto_Presentacion.Properties.Resources.dislike_1);

            listadoEnlaces.SmallImageList = imageListSmall;
            imageListLarge = m.cargarImageListLargeEnlaces(listaEnlaces, Application.StartupPath, 80);

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
            InitializeEmptyListMsgOverlay();
            listadoEnlaces.EmptyListMsg = "No hay coincidencias";
            if (tbBuscar.Text != " Buscar ")
            {
                this.listadoEnlaces.ModelFilter = new ModelFilter(delegate (object x)
                {
                    if (tbBuscar.Text != " Buscar " && tbBuscar.Text != "")
                    {
                        var enla = x as Enlaces;
                        string tituloSinAcentos = quitarAcentos(enla.titulo);
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
            if(tbBuscar.Text == "")
            {
                tbBuscar.Text = " Buscar ";
                listadoEnlaces.BuildList();
            }
        }
        //Limpia el texto Buscar del tbBuscar
        private void tbBuscar_Enter(object sender, EventArgs e)
        {
            tbBuscar.Clear();
        }

        //Método para poner los tooltip
        private void listadoEnlaces_CellToolTipShowing(object sender, ToolTipShowingEventArgs e)
        {
            e.ToolTipControl.IsBalloon = true;
            Enlaces enlace = (Enlaces)e.Model;

            if (e.Column == columnaLike)
            {
                e.Text = "Voto positivo";
            }else if (e.Column == columnaDontLike)
            {
                
                e.Text = "Voto negativo";
            }else if (e.Column == columnaReportarFallo)
            {
                if(UsuarioConectado.credenciales == "admin")
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
                }else
                {
                    if (enlace.reportarFallo == 1)
                    {
                        e.Text = "Reportar link caído";
                    }
                    else
                    {
                        e.Text = "Enlace en revisión";
                    }
                }
                
            }else if(e.Column == columnaTema)
            {
                e.Text = enlace.tema;
            }
        }
    }
}