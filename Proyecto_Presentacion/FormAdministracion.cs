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
        private List<Enlaces> listadoEnlaces = new List<Enlaces>();
        private List<Usuario> listadoUsuarios = new List<Usuario>();
        private Dictionary<string, string> datos = new Dictionary<string, string>();
        private string listaAMostrar = "";
        public FormAdministracion()
        {
            InitializeComponent();
        }
        private void FormAdministracion_Load(object sender, EventArgs e)
        {
            iniciarObjectListView();
            InitializeEmptyListMsgOverlay();
            tbBuscar.TabStop = false;
        }
        private async void obtenerEnlaces()
        {
            if (UsuarioConectado.credenciales.Equals("admin"))
            {
                datos.Clear();
                datos.Add("asignatura", "todas");
                datos.Add("credenciales", UsuarioConectado.credenciales);

                listadoEnlaces = await mfc.obtenerEnlaces(UsuarioConectado.nombre, datos);

                if (listadoEnlaces != null)
                {
                    InitializeModel();
                }
                else
                {
                    objectListView1.EmptyListMsg = "No hay enlaces";
                }
            }
            else { MsgBox.Show("No tienes permiso para acceder", "ATENCIÓN", MsgBox.Buttons.OK, MsgBox.Icon.Error, MsgBox.AnimateStyle.FadeIn); }
            btnEnlaces.Enabled = true;
        }

        private async void ObtenerUsuarios()
        {
            if(UsuarioConectado.credenciales.Equals("admin")){
                
                datos.Clear();
                datos.Add("credenciales", UsuarioConectado.credenciales);//Nunca pasaría si no es admin pero aun así tambien compruebo en el servidor
 
                listadoUsuarios = await mfa.obtenerUsuarios(UsuarioConectado.nombre, datos);

                if (listadoUsuarios != null)
                {
                    InitializeModel();       
                }
                else
                {
                    objectListView1.EmptyListMsg = "No hay Usuarios";
                }
            }else { MsgBox.Show("No tienes permiso para acceder", "ATENCIÓN", MsgBox.Buttons.OK, MsgBox.Icon.Error, MsgBox.AnimateStyle.FadeIn); }
            btnUsuarios.Enabled = true;
        }

        private void iniciarObjectListView()
        {

            objectListView1.HeaderStyle = ColumnHeaderStyle.None;
            objectListView1.Font = new Font("Segoe UI Semilight", 9, FontStyle.Bold);
            objectListView1.CellToolTip.Font = new Font("Segoe UI Semilight",10, FontStyle.Bold);
            objectListView1.CellToolTip.ForeColor = Color.Red;

        }
        protected virtual void InitializeEmptyListMsgOverlay()
        {
            TextOverlay textOverlay = this.objectListView1.EmptyListMsgOverlay as TextOverlay;
            textOverlay.TextColor = Color.FromArgb(231, 120, 0);
            textOverlay.BackColor = Color.FromArgb(32, 32, 32);
            textOverlay.BorderWidth = 0.0f;
            textOverlay.Font = new Font("Segoe UI Semilight", 22);
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
                if (listaAMostrar.Equals("usuarios"))
                {
                    if(!UsuarioConectado.nombre.Equals("admin") && ((Usuario)x).Credenciales.Equals("admin"))
                    {
                        return "";
                    }
                }
                return "papelera";
            };
            this.Column7.ImageGetter = delegate (object x)
            {
                if (listaAMostrar.Equals("enlaces"))
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
                }
                return "";
            };

            if (listaAMostrar.Equals("enlaces"))
            {
                this.objectListView1.SetObjects(this.listadoEnlaces);
            }
            else
            {
                this.objectListView1.SetObjects(this.listadoUsuarios);
            }
        }

        
        //  CAPTURO EVENTO CLICK CON LA CELDA QUE A CLICKADO Y SI ES LA COLUMNA LIKE
        //  OBTENGO EL OBJETO Y LE SUMO 1 LIKE
        private async void objectListView1_CellClick(object sender, BrightIdeasSoftware.CellClickEventArgs e)
        {
            datos.Clear();
            if (e.Column == Column7)
            {
                if (listaAMostrar.Equals("enlaces"))
                {
                    Enlaces enlace = (Enlaces)e.Model;
                    Dictionary<string, string> datos = new Dictionary<string, string>();
                    datos.Add("id", enlace.id);
                    datos.Add("credenciales", UsuarioConectado.credenciales);
                    int estadoCorrecto = await mfc.cambiarActivoRevisionDesactivo(UsuarioConectado.nombre, datos);
                    if (estadoCorrecto != -1)
                    {
                        enlace.reportarFallo = estadoCorrecto;
                        objectListView1.RefreshObject(enlace);
                    }
                    else
                    {
                        MsgBox.Show("Ha ocurrido un error al actualizar la Base de datos", "ATENCIÓN", MsgBox.Buttons.OK, MsgBox.Icon.Error, MsgBox.AnimateStyle.FadeIn);
                    }
                }
            }
            else if (e.Column == Column6)
            {
                if (listaAMostrar.Equals("usuarios"))
                {
                    Usuario usuario = (Usuario)e.Model;
                    if (usuario.Credenciales.Equals("admin") && !UsuarioConectado.nombre.Equals("admin"))
                    {

                    }
                    else
                    {
                        bool cambiar = false;
                        string newRango;
                        if (usuario.Credenciales.Equals("normal")) { newRango = "admin"; }
                        else { newRango = "normal"; }

                        datos.Add("id", usuario.Id);
                        datos.Add("nombre", usuario.Nombre);
                        datos.Add("newRango", newRango);

                        if (UsuarioConectado.nombre.Equals("admin"))
                        {
                            cambiar = true;
                        }
                        else
                        {
                            DialogResult respuesta = MsgBox.Show("¿Está seguro de que desea conceder privilegios de Admin al usuario " + usuario.User +
                                "? Una vez tenga privilegios de Admin no podrá quitarselos usted, tendrá que mandar un correo al administrador para que los quite.", "Conceder privilegios", MsgBox.Buttons.YesNo, MsgBox.Icon.Question, MsgBox.AnimateStyle.FadeIn);
                            if (respuesta == DialogResult.Yes) { cambiar = true; }
                        }
                        if (cambiar)
                        {
                            if (await mfa.cambiarRango(UsuarioConectado.nombre, datos))
                            {
                                usuario.Credenciales = newRango;
                                objectListView1.RefreshObject(usuario);
                            }
                            else
                            {
                                MsgBox.Show("Ha ocurrido un error al actualizar la Base de datos", "ATENCIÓN", MsgBox.Buttons.OK, MsgBox.Icon.Error, MsgBox.AnimateStyle.FadeIn);
                            }
                        }
                    }
                }
                
            }
            else if (e.Column == Column8)
            {
                if (listaAMostrar.Equals("enlaces"))
                {
                    Enlaces enlace = (Enlaces)e.Model;

                    DialogResult respuesta = MsgBox.Show("¿Está seguro de que desea eliminar el enlace con id " + enlace.id + "?", "Eliminar", MsgBox.Buttons.YesNo, MsgBox.Icon.Question, MsgBox.AnimateStyle.FadeIn);

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
                }else
                {
                    Usuario usuario = (Usuario)e.Model;
                    if(usuario.Credenciales.Equals("admin") && !UsuarioConectado.nombre.Equals("admin"))
                    {
                        
                    }else
                    {
                        DialogResult respuesta = MsgBox.Show("¿Está seguro de que desea eliminar al usuario " + usuario.User + "?", "Eliminar", MsgBox.Buttons.YesNo, MsgBox.Icon.Question, MsgBox.AnimateStyle.FadeIn);

                        if (respuesta == DialogResult.Yes)
                        {
                            Dictionary<string, string> datos = new Dictionary<string, string>();
                            datos.Add("credenciales", UsuarioConectado.credenciales);
                            datos.Add("idBorrar", usuario.Id);
                            bool correcto = await mfa.borrarUsuario(UsuarioConectado.nombre, datos);
                            if (correcto)
                            {
                                objectListView1.RemoveObject(usuario);
                                objectListView1.BuildList();
                            }
                            else
                            {
                                MsgBox.Show("Ha ocurrido un error al borrar al Usuario", "Error al borrar", MsgBox.Buttons.OK, MsgBox.Icon.Error, MsgBox.AnimateStyle.FadeIn);
                            }
                        }
                    }
                    
                }
            }


        }

        //Abre link al hacer doble click sobre la Fila
        private void objectListView1_ItemActivate(object sender, EventArgs e)
        {
            if (listaAMostrar.Equals("enlaces"))
            {
                try
                {
                    Object enlaceSeleccionado = objectListView1.SelectedObject;
                    Enlaces enlace = (Enlaces)enlaceSeleccionado;
                    System.Diagnostics.Process.Start(enlace.link);
                }catch(Exception)
                {
                    MsgBox.Show("Ha ocurrido un error abrir el enlace", "Error enlace", MsgBox.Buttons.OK, MsgBox.Icon.Error, MsgBox.AnimateStyle.FadeIn);
                }

            }
            
        }

        public void cargarImagenes()
        {
            imageListSmall.Images.Add("ok", Proyecto_Presentacion.Properties.Resources.activo);
            imageListSmall.Images.Add("problem", Proyecto_Presentacion.Properties.Resources.revision);
            imageListSmall.Images.Add("error", Proyecto_Presentacion.Properties.Resources.reportar);
            imageListSmall.Images.Add("papelera", Proyecto_Presentacion.Properties.Resources.papelera);

            objectListView1.SmallImageList = imageListSmall;

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
            objectListView1.EmptyListMsg = "No hay coincidencias";
            if (tbBuscar.Text != " Buscar ")
            {
                this.objectListView1.ModelFilter = new ModelFilter(delegate (object x)
                {
                    if (tbBuscar.Text != " Buscar " && tbBuscar.Text != "")
                    {
                        if (listaAMostrar.Equals("enlaces"))
                        {
                            var enlace = x as Enlaces;
                            return x != null && (enlace.id.Equals(tbBuscar.Text));
                        }
                        else
                        {
                            var usuario = x as Usuario;
                            string tituloSinAcentos = quitarAcentos(usuario.User);
                            string tbBuscarSinAcentos = quitarAcentos(tbBuscar.Text);
                            return x != null && (containsIgnoreMayusMin(tituloSinAcentos, tbBuscarSinAcentos, StringComparison.InvariantCultureIgnoreCase));
                        }
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
            if (listaAMostrar.Equals("enlaces"))
            {
                Enlaces enlace = (Enlaces)e.Model;

                if (e.Column == Column5)
                {
                    e.Text = enlace.tema;
                }
                else if (e.Column == Column3)
                {
                    e.Text = enlace.titulo;
                }
                else if (e.Column == Column7)
                {
                    if (enlace.reportarFallo == 1)
                    {
                        e.Text = "Activo";
                    }
                    else if (enlace.reportarFallo == 2)
                    {
                        e.Text = "Revisar";
                    }
                    else
                    {
                        e.Text = "Caido";
                    }
                }
            }
            else
            {
                Usuario usuario = (Usuario)e.Model;
                if(e.Column == Column6)
                {
                    if (UsuarioConectado.nombre.Equals("admin"))
                    {
                        if (usuario.Credenciales.Equals("admin"))
                        {
                            e.Text = "Quitar privilegios de admin";
                        }
                    }
                    if (usuario.Credenciales.Equals("normal"))
                    {
                        e.Text = "Conceder privilegios de admin";
                    }
                }
            }
            
            if (e.Column == Column8)
            {
                if (listaAMostrar.Equals("usuarios"))
                {
                    Usuario usuario = (Usuario)e.Model;
                    if (usuario.Credenciales.Equals("admin") && !UsuarioConectado.nombre.Equals("admin")){ }
                    else
                    {
                        e.Text = "Eliminar";
                    }
                }else
                {
                    e.Text = "Eliminar";
                }
                
                
            }
        }

        private void btnEnlaces_Click(object sender, EventArgs e)
        {
            tbBuscar.Text = " Buscar ";
            listaAMostrar = "enlaces";
            this.btnUsuarios.BackColor = Color.FromArgb(32, 32, 32);
            this.btnEnlaces.BackColor = Color.FromArgb(73, 55, 34);
            objectListView1.ClearObjects();
            objectListView1.EmptyListMsg = "Cargando...";
            //Muestro columna 7
            Column7.IsVisible = true;
            objectListView1.RebuildColumns();
            //Muestro cabezera columnas
            objectListView1.HeaderStyle = ColumnHeaderStyle.Clickable;
            btnEnlaces.Enabled = false; 
            objectListView1.Focus();
            //Ocupa el espacio libre           
            Column5.FillsFreeSpace = true;
            //Centrar
            Column1.TextAlign = HorizontalAlignment.Center;
            Column4.TextAlign = HorizontalAlignment.Center;
            Column5.TextAlign = HorizontalAlignment.Center;
            Column7.TextAlign = HorizontalAlignment.Center;
            Column8.TextAlign = HorizontalAlignment.Center;

            //Ancho culumnas
            Column1.MinimumWidth = 30;
            Column1.Width = 20;
            Column2.Width = 150;
            Column3.MinimumWidth = 200;
            Column3.Width = 300;
            Column4.MinimumWidth = 80;
            Column4.Width = 80;
            Column5.MinimumWidth = 60;
            Column5.Width = 100;
            Column6.MinimumWidth = 80;
            Column6.MaximumWidth = 80;
            Column6.Width = 80;
            Column7.MinimumWidth = 70;
            Column7.Width = 70;
            Column8.MinimumWidth = 80;
            Column8.Width = 80;

            //Texto de la cabecera
            Column1.Text = "Id";
            Column2.Text = "Asignatura";
            Column3.Text = "Título";
            Column4.Text = "Valoración";
            Column5.Text = "Tema";
            Column6.Text = "Tipo";
            Column7.Text = "Estado";
            Column8.Text = "Eliminar";            

            Column1.AspectName = "id";
            Column2.AspectName = "asignatura";
            Column3.AspectName = "titulo";
            Column4.AspectName = "valoracion";
            Column5.AspectName = "tema";     
            Column6.AspectName = "tipo";
           
            objectListView1.RebuildColumns();
            obtenerEnlaces();
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            tbBuscar.Text = " Buscar ";
            listaAMostrar = "usuarios";
            this.btnEnlaces.BackColor = Color.FromArgb(32, 32, 32);
            this.btnUsuarios.BackColor = Color.FromArgb(73, 55, 34);
            objectListView1.ClearObjects();
            objectListView1.EmptyListMsg = "Cargando...";
            //Oculto columna 7
            Column7.IsVisible = false;
            objectListView1.RebuildColumns();
            //Muestro cabezera columnas
            objectListView1.HeaderStyle = ColumnHeaderStyle.Clickable;
            btnUsuarios.Enabled = false;
            objectListView1.Focus();
            //Ocupar el espacio libre
            //Column1.FillsFreeSpace = false;
            Column5.FillsFreeSpace = true;
            //Centrar
            Column1.TextAlign = HorizontalAlignment.Center;
            Column2.TextAlign = HorizontalAlignment.Center;
            Column3.TextAlign = HorizontalAlignment.Center;
            Column4.TextAlign = HorizontalAlignment.Center;
            Column5.TextAlign = HorizontalAlignment.Center;
            Column6.TextAlign = HorizontalAlignment.Center;
            Column8.TextAlign = HorizontalAlignment.Center;

            //Ancho culumnas
            Column1.MinimumWidth = 60;
            Column1.Width = 60;
            Column2.Width = 150;
            Column3.MinimumWidth = 60;
            Column3.Width = 100;
            Column4.MinimumWidth = 80;
            Column4.Width = 120;
            Column5.MinimumWidth = 100;
            Column5.Width = 140;
            Column6.MinimumWidth = 90;
            Column6.Width = 80;
            Column8.MinimumWidth = 80;
            Column8.Width = 80;

            //Texto de la cabecera
            Column1.Text = "Id";
            Column2.Text = "Usuario";
            Column3.Text = "Nombre";
            Column4.Text = "Apellidos";
            Column5.Text = "Email";
            Column6.Text = "Credenciales";
            Column8.Text = "Eliminar";

            Column1.AspectName = "Id";
            Column2.AspectName = "User";
            Column3.AspectName = "Nombre";
            Column4.AspectName = "Apellidos";
            Column5.AspectName = "Email";
            Column6.AspectName = "Credenciales";

            objectListView1.RebuildColumns();

            ObtenerUsuarios();
        }
    }
}

