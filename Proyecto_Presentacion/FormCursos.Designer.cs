﻿namespace Proyecto_Presentacion
{
    partial class FormCursos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panelCabecera = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tbBuscar = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSegundo = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnPrimero = new System.Windows.Forms.Button();
            this.panelListado = new System.Windows.Forms.Panel();
            this.listadoEnlaces = new BrightIdeasSoftware.ObjectListView();
            this.columnaTitulo = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.columnaTema = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.columnaTipo = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.columnaValoracion = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.columnaLike = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.columnaDontLike = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.columnaReportarFallo = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.imageListSmall = new System.Windows.Forms.ImageList(this.components);
            this.panelAsignaturas1 = new System.Windows.Forms.Panel();
            this.panelDinamico1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnBbdd = new System.Windows.Forms.Button();
            this.btnEntornos = new System.Windows.Forms.Button();
            this.btnLenguajes = new System.Windows.Forms.Button();
            this.btnProgramacion = new System.Windows.Forms.Button();
            this.btnSistemas = new System.Windows.Forms.Button();
            this.panelAsignaturas2 = new System.Windows.Forms.Panel();
            this.panelDinamico2 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAccesoDatos = new System.Windows.Forms.Button();
            this.btnInterfaces = new System.Windows.Forms.Button();
            this.btnGestion = new System.Windows.Forms.Button();
            this.btnProcesos = new System.Windows.Forms.Button();
            this.btnMultimedia = new System.Windows.Forms.Button();
            this.tmPanelAsig1 = new System.Windows.Forms.Timer(this.components);
            this.tmPanelAsig2 = new System.Windows.Forms.Timer(this.components);
            this.tmPanelAsigOcultar1 = new System.Windows.Forms.Timer(this.components);
            this.tmPanelAsigOcultar2 = new System.Windows.Forms.Timer(this.components);
            this.imageListLarge = new System.Windows.Forms.ImageList(this.components);
            this.panelCabecera.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panelListado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listadoEnlaces)).BeginInit();
            this.panelAsignaturas1.SuspendLayout();
            this.panelDinamico1.SuspendLayout();
            this.panelAsignaturas2.SuspendLayout();
            this.panelDinamico2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelCabecera
            // 
            this.panelCabecera.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.panelCabecera.Controls.Add(this.panel3);
            this.panelCabecera.Controls.Add(this.panel2);
            this.panelCabecera.Controls.Add(this.btnSegundo);
            this.panelCabecera.Controls.Add(this.panel1);
            this.panelCabecera.Controls.Add(this.btnPrimero);
            this.panelCabecera.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCabecera.Location = new System.Drawing.Point(0, 0);
            this.panelCabecera.Name = "panelCabecera";
            this.panelCabecera.Size = new System.Drawing.Size(959, 40);
            this.panelCabecera.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.tbBuscar);
            this.panel3.Location = new System.Drawing.Point(698, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(261, 40);
            this.panel3.TabIndex = 22;
            // 
            // tbBuscar
            // 
            this.tbBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbBuscar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBuscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(39)))));
            this.tbBuscar.Location = new System.Drawing.Point(36, 7);
            this.tbBuscar.Name = "tbBuscar";
            this.tbBuscar.Size = new System.Drawing.Size(193, 25);
            this.tbBuscar.TabIndex = 17;
            this.tbBuscar.Text = " Buscar ";
            this.tbBuscar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbBuscar.TextChanged += new System.EventHandler(this.tbBuscar_TextChanged);
            this.tbBuscar.Enter += new System.EventHandler(this.tbBuscar_Enter);
            this.tbBuscar.Leave += new System.EventHandler(this.tbBuscar_Leave);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(39)))));
            this.panel2.Location = new System.Drawing.Point(152, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(5, 40);
            this.panel2.TabIndex = 21;
            // 
            // btnSegundo
            // 
            this.btnSegundo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSegundo.FlatAppearance.BorderSize = 0;
            this.btnSegundo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(39)))));
            this.btnSegundo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(55)))), ((int)(((byte)(34)))));
            this.btnSegundo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSegundo.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSegundo.ForeColor = System.Drawing.Color.White;
            this.btnSegundo.Image = global::Proyecto_Presentacion.Properties.Resources.iconocurso;
            this.btnSegundo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSegundo.Location = new System.Drawing.Point(152, 0);
            this.btnSegundo.Name = "btnSegundo";
            this.btnSegundo.Size = new System.Drawing.Size(170, 40);
            this.btnSegundo.TabIndex = 20;
            this.btnSegundo.Text = "Segundo curso";
            this.btnSegundo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSegundo.UseVisualStyleBackColor = true;
            this.btnSegundo.Click += new System.EventHandler(this.btnSegundo_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(39)))));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(5, 40);
            this.panel1.TabIndex = 19;
            // 
            // btnPrimero
            // 
            this.btnPrimero.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrimero.FlatAppearance.BorderSize = 0;
            this.btnPrimero.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(39)))));
            this.btnPrimero.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(55)))), ((int)(((byte)(34)))));
            this.btnPrimero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrimero.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrimero.ForeColor = System.Drawing.Color.White;
            this.btnPrimero.Image = global::Proyecto_Presentacion.Properties.Resources.iconocurso;
            this.btnPrimero.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrimero.Location = new System.Drawing.Point(0, 0);
            this.btnPrimero.Name = "btnPrimero";
            this.btnPrimero.Size = new System.Drawing.Size(152, 40);
            this.btnPrimero.TabIndex = 18;
            this.btnPrimero.Text = "Primer curso";
            this.btnPrimero.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPrimero.UseVisualStyleBackColor = true;
            this.btnPrimero.Click += new System.EventHandler(this.btnPrimero_Click);
            // 
            // panelListado
            // 
            this.panelListado.Controls.Add(this.listadoEnlaces);
            this.panelListado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelListado.Location = new System.Drawing.Point(0, 120);
            this.panelListado.Name = "panelListado";
            this.panelListado.Size = new System.Drawing.Size(959, 524);
            this.panelListado.TabIndex = 1;
            // 
            // listadoEnlaces
            // 
            this.listadoEnlaces.AllColumns.Add(this.columnaTitulo);
            this.listadoEnlaces.AllColumns.Add(this.columnaTema);
            this.listadoEnlaces.AllColumns.Add(this.columnaTipo);
            this.listadoEnlaces.AllColumns.Add(this.columnaValoracion);
            this.listadoEnlaces.AllColumns.Add(this.columnaLike);
            this.listadoEnlaces.AllColumns.Add(this.columnaDontLike);
            this.listadoEnlaces.AllColumns.Add(this.columnaReportarFallo);
            this.listadoEnlaces.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.listadoEnlaces.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnaTitulo,
            this.columnaTema,
            this.columnaTipo,
            this.columnaValoracion,
            this.columnaLike,
            this.columnaDontLike,
            this.columnaReportarFallo});
            this.listadoEnlaces.Cursor = System.Windows.Forms.Cursors.Default;
            this.listadoEnlaces.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listadoEnlaces.Font = new System.Drawing.Font("Segoe MDL2 Assets", 12F);
            this.listadoEnlaces.ForeColor = System.Drawing.Color.White;
            this.listadoEnlaces.FullRowSelect = true;
            this.listadoEnlaces.Location = new System.Drawing.Point(0, 0);
            this.listadoEnlaces.Name = "listadoEnlaces";
            this.listadoEnlaces.RowHeight = 48;
            this.listadoEnlaces.SelectedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.listadoEnlaces.ShowGroups = false;
            this.listadoEnlaces.ShowImagesOnSubItems = true;
            this.listadoEnlaces.Size = new System.Drawing.Size(959, 524);
            this.listadoEnlaces.SmallImageList = this.imageListSmall;
            this.listadoEnlaces.TabIndex = 17;
            this.listadoEnlaces.UnfocusedSelectedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.listadoEnlaces.UseCellFormatEvents = true;
            this.listadoEnlaces.UseCompatibleStateImageBehavior = false;
            this.listadoEnlaces.UseFiltering = true;
            this.listadoEnlaces.View = System.Windows.Forms.View.Details;
            this.listadoEnlaces.CellClick += new System.EventHandler<BrightIdeasSoftware.CellClickEventArgs>(this.listadoEnlaces_CellClick);
            this.listadoEnlaces.CellToolTipShowing += new System.EventHandler<BrightIdeasSoftware.ToolTipShowingEventArgs>(this.listadoEnlaces_CellToolTipShowing);
            this.listadoEnlaces.FormatCell += new System.EventHandler<BrightIdeasSoftware.FormatCellEventArgs>(this.listadoEnlaces_FormatCell);
            this.listadoEnlaces.ItemActivate += new System.EventHandler(this.listadoEnlaces_ItemActivate);
            // 
            // columnaTitulo
            // 
            this.columnaTitulo.AspectName = "titulo";
            this.columnaTitulo.FillsFreeSpace = true;
            this.columnaTitulo.ImageAspectName = "FeatureIcon";
            this.columnaTitulo.MinimumWidth = 300;
            this.columnaTitulo.Text = "Título y descripción";
            this.columnaTitulo.Width = 300;
            this.columnaTitulo.WordWrap = true;
            // 
            // columnaTema
            // 
            this.columnaTema.AspectName = "tema";
            this.columnaTema.MinimumWidth = 80;
            this.columnaTema.Text = "Tema";
            this.columnaTema.Width = 270;
            // 
            // columnaTipo
            // 
            this.columnaTipo.AspectName = "tipo";
            this.columnaTipo.MinimumWidth = 100;
            this.columnaTipo.Text = "Tipo";
            this.columnaTipo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnaTipo.Width = 100;
            // 
            // columnaValoracion
            // 
            this.columnaValoracion.Text = "Valoración";
            this.columnaValoracion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // columnaLike
            // 
            this.columnaLike.Text = "Like";
            this.columnaLike.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // columnaDontLike
            // 
            this.columnaDontLike.Text = "Dont Like";
            this.columnaDontLike.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // columnaReportarFallo
            // 
            this.columnaReportarFallo.Text = "ReportarFallo";
            this.columnaReportarFallo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // imageListSmall
            // 
            this.imageListSmall.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imageListSmall.ImageSize = new System.Drawing.Size(40, 40);
            this.imageListSmall.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // panelAsignaturas1
            // 
            this.panelAsignaturas1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.panelAsignaturas1.Controls.Add(this.panelDinamico1);
            this.panelAsignaturas1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelAsignaturas1.Location = new System.Drawing.Point(0, 40);
            this.panelAsignaturas1.Name = "panelAsignaturas1";
            this.panelAsignaturas1.Size = new System.Drawing.Size(959, 40);
            this.panelAsignaturas1.TabIndex = 2;
            // 
            // panelDinamico1
            // 
            this.panelDinamico1.Controls.Add(this.btnBbdd);
            this.panelDinamico1.Controls.Add(this.btnEntornos);
            this.panelDinamico1.Controls.Add(this.btnLenguajes);
            this.panelDinamico1.Controls.Add(this.btnProgramacion);
            this.panelDinamico1.Controls.Add(this.btnSistemas);
            this.panelDinamico1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDinamico1.Location = new System.Drawing.Point(0, 0);
            this.panelDinamico1.Name = "panelDinamico1";
            this.panelDinamico1.Size = new System.Drawing.Size(959, 40);
            this.panelDinamico1.TabIndex = 4;
            // 
            // btnBbdd
            // 
            this.btnBbdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBbdd.FlatAppearance.BorderSize = 0;
            this.btnBbdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(39)))));
            this.btnBbdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(55)))), ((int)(((byte)(34)))));
            this.btnBbdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBbdd.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBbdd.ForeColor = System.Drawing.Color.White;
            this.btnBbdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBbdd.Location = new System.Drawing.Point(3, 3);
            this.btnBbdd.Name = "btnBbdd";
            this.btnBbdd.Size = new System.Drawing.Size(137, 40);
            this.btnBbdd.TabIndex = 22;
            this.btnBbdd.Text = "Bases de Datos";
            this.btnBbdd.UseVisualStyleBackColor = true;
            this.btnBbdd.Click += new System.EventHandler(this.btnBbdd_Click);
            // 
            // btnEntornos
            // 
            this.btnEntornos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEntornos.FlatAppearance.BorderSize = 0;
            this.btnEntornos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(39)))));
            this.btnEntornos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(55)))), ((int)(((byte)(34)))));
            this.btnEntornos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEntornos.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntornos.ForeColor = System.Drawing.Color.White;
            this.btnEntornos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEntornos.Location = new System.Drawing.Point(146, 3);
            this.btnEntornos.Name = "btnEntornos";
            this.btnEntornos.Size = new System.Drawing.Size(179, 40);
            this.btnEntornos.TabIndex = 24;
            this.btnEntornos.Text = "Entornos de Desarrollo";
            this.btnEntornos.UseVisualStyleBackColor = true;
            this.btnEntornos.Click += new System.EventHandler(this.btnEntornos_Click);
            // 
            // btnLenguajes
            // 
            this.btnLenguajes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLenguajes.FlatAppearance.BorderSize = 0;
            this.btnLenguajes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(39)))));
            this.btnLenguajes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(55)))), ((int)(((byte)(34)))));
            this.btnLenguajes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLenguajes.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLenguajes.ForeColor = System.Drawing.Color.White;
            this.btnLenguajes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLenguajes.Location = new System.Drawing.Point(331, 3);
            this.btnLenguajes.Name = "btnLenguajes";
            this.btnLenguajes.Size = new System.Drawing.Size(179, 40);
            this.btnLenguajes.TabIndex = 25;
            this.btnLenguajes.Text = "Lenguajes de marcas";
            this.btnLenguajes.UseVisualStyleBackColor = true;
            this.btnLenguajes.Click += new System.EventHandler(this.btnLenguajes_Click);
            // 
            // btnProgramacion
            // 
            this.btnProgramacion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProgramacion.FlatAppearance.BorderSize = 0;
            this.btnProgramacion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(39)))));
            this.btnProgramacion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(55)))), ((int)(((byte)(34)))));
            this.btnProgramacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProgramacion.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProgramacion.ForeColor = System.Drawing.Color.White;
            this.btnProgramacion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProgramacion.Location = new System.Drawing.Point(516, 3);
            this.btnProgramacion.Name = "btnProgramacion";
            this.btnProgramacion.Size = new System.Drawing.Size(133, 40);
            this.btnProgramacion.TabIndex = 26;
            this.btnProgramacion.Text = "Programación";
            this.btnProgramacion.UseVisualStyleBackColor = true;
            this.btnProgramacion.Click += new System.EventHandler(this.btnProgramacion_Click);
            // 
            // btnSistemas
            // 
            this.btnSistemas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSistemas.FlatAppearance.BorderSize = 0;
            this.btnSistemas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(39)))));
            this.btnSistemas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(55)))), ((int)(((byte)(34)))));
            this.btnSistemas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSistemas.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSistemas.ForeColor = System.Drawing.Color.White;
            this.btnSistemas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSistemas.Location = new System.Drawing.Point(655, 3);
            this.btnSistemas.Name = "btnSistemas";
            this.btnSistemas.Size = new System.Drawing.Size(179, 40);
            this.btnSistemas.TabIndex = 27;
            this.btnSistemas.Text = "Sistemas Informáticos";
            this.btnSistemas.UseVisualStyleBackColor = true;
            this.btnSistemas.Click += new System.EventHandler(this.btnSistemas_Click);
            // 
            // panelAsignaturas2
            // 
            this.panelAsignaturas2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.panelAsignaturas2.Controls.Add(this.panelDinamico2);
            this.panelAsignaturas2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelAsignaturas2.Location = new System.Drawing.Point(0, 80);
            this.panelAsignaturas2.Name = "panelAsignaturas2";
            this.panelAsignaturas2.Size = new System.Drawing.Size(959, 40);
            this.panelAsignaturas2.TabIndex = 3;
            // 
            // panelDinamico2
            // 
            this.panelDinamico2.Controls.Add(this.btnAccesoDatos);
            this.panelDinamico2.Controls.Add(this.btnInterfaces);
            this.panelDinamico2.Controls.Add(this.btnGestion);
            this.panelDinamico2.Controls.Add(this.btnProcesos);
            this.panelDinamico2.Controls.Add(this.btnMultimedia);
            this.panelDinamico2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDinamico2.Location = new System.Drawing.Point(0, 0);
            this.panelDinamico2.Name = "panelDinamico2";
            this.panelDinamico2.Size = new System.Drawing.Size(959, 40);
            this.panelDinamico2.TabIndex = 4;
            // 
            // btnAccesoDatos
            // 
            this.btnAccesoDatos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAccesoDatos.FlatAppearance.BorderSize = 0;
            this.btnAccesoDatos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(39)))));
            this.btnAccesoDatos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(55)))), ((int)(((byte)(34)))));
            this.btnAccesoDatos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccesoDatos.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccesoDatos.ForeColor = System.Drawing.Color.White;
            this.btnAccesoDatos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAccesoDatos.Location = new System.Drawing.Point(3, 3);
            this.btnAccesoDatos.Name = "btnAccesoDatos";
            this.btnAccesoDatos.Size = new System.Drawing.Size(137, 40);
            this.btnAccesoDatos.TabIndex = 28;
            this.btnAccesoDatos.Text = "Acceso a datos";
            this.btnAccesoDatos.UseVisualStyleBackColor = true;
            this.btnAccesoDatos.Click += new System.EventHandler(this.btnAccesoDatos_Click);
            // 
            // btnInterfaces
            // 
            this.btnInterfaces.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInterfaces.FlatAppearance.BorderSize = 0;
            this.btnInterfaces.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(39)))));
            this.btnInterfaces.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(55)))), ((int)(((byte)(34)))));
            this.btnInterfaces.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInterfaces.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInterfaces.ForeColor = System.Drawing.Color.White;
            this.btnInterfaces.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInterfaces.Location = new System.Drawing.Point(146, 3);
            this.btnInterfaces.Name = "btnInterfaces";
            this.btnInterfaces.Size = new System.Drawing.Size(179, 40);
            this.btnInterfaces.TabIndex = 29;
            this.btnInterfaces.Text = "Desarrollo de interfaces";
            this.btnInterfaces.UseVisualStyleBackColor = true;
            this.btnInterfaces.Click += new System.EventHandler(this.btnInterfaces_Click);
            // 
            // btnGestion
            // 
            this.btnGestion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGestion.FlatAppearance.BorderSize = 0;
            this.btnGestion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(39)))));
            this.btnGestion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(55)))), ((int)(((byte)(34)))));
            this.btnGestion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGestion.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestion.ForeColor = System.Drawing.Color.White;
            this.btnGestion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGestion.Location = new System.Drawing.Point(331, 3);
            this.btnGestion.Name = "btnGestion";
            this.btnGestion.Size = new System.Drawing.Size(244, 40);
            this.btnGestion.TabIndex = 30;
            this.btnGestion.Text = "Sistemas de gestión empresarial";
            this.btnGestion.UseVisualStyleBackColor = true;
            this.btnGestion.Click += new System.EventHandler(this.btnGestion_Click);
            // 
            // btnProcesos
            // 
            this.btnProcesos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProcesos.FlatAppearance.BorderSize = 0;
            this.btnProcesos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(39)))));
            this.btnProcesos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(55)))), ((int)(((byte)(34)))));
            this.btnProcesos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProcesos.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcesos.ForeColor = System.Drawing.Color.White;
            this.btnProcesos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProcesos.Location = new System.Drawing.Point(581, 3);
            this.btnProcesos.Name = "btnProcesos";
            this.btnProcesos.Size = new System.Drawing.Size(62, 40);
            this.btnProcesos.TabIndex = 31;
            this.btnProcesos.Text = "PSP";
            this.btnProcesos.UseVisualStyleBackColor = true;
            this.btnProcesos.Click += new System.EventHandler(this.btnProcesos_Click);
            // 
            // btnMultimedia
            // 
            this.btnMultimedia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMultimedia.FlatAppearance.BorderSize = 0;
            this.btnMultimedia.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(39)))));
            this.btnMultimedia.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(55)))), ((int)(((byte)(34)))));
            this.btnMultimedia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMultimedia.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMultimedia.ForeColor = System.Drawing.Color.White;
            this.btnMultimedia.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMultimedia.Location = new System.Drawing.Point(649, 3);
            this.btnMultimedia.Name = "btnMultimedia";
            this.btnMultimedia.Size = new System.Drawing.Size(207, 40);
            this.btnMultimedia.TabIndex = 32;
            this.btnMultimedia.Text = "Programación Multimedia";
            this.btnMultimedia.UseVisualStyleBackColor = true;
            this.btnMultimedia.Click += new System.EventHandler(this.btnMultimedia_Click);
            // 
            // tmPanelAsig1
            // 
            this.tmPanelAsig1.Interval = 10;
            this.tmPanelAsig1.Tick += new System.EventHandler(this.tmPanelAsig1_Tick);
            // 
            // tmPanelAsig2
            // 
            this.tmPanelAsig2.Interval = 10;
            this.tmPanelAsig2.Tick += new System.EventHandler(this.tmPanelAsig2_Tick);
            // 
            // tmPanelAsigOcultar1
            // 
            this.tmPanelAsigOcultar1.Interval = 10;
            this.tmPanelAsigOcultar1.Tick += new System.EventHandler(this.tmPanelAsigOcultar1_Tick);
            // 
            // tmPanelAsigOcultar2
            // 
            this.tmPanelAsigOcultar2.Interval = 10;
            this.tmPanelAsigOcultar2.Tick += new System.EventHandler(this.tmPanelAsigOcultar2_Tick);
            // 
            // imageListLarge
            // 
            this.imageListLarge.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imageListLarge.ImageSize = new System.Drawing.Size(80, 80);
            this.imageListLarge.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // FormCursos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(959, 644);
            this.Controls.Add(this.panelListado);
            this.Controls.Add(this.panelAsignaturas2);
            this.Controls.Add(this.panelAsignaturas1);
            this.Controls.Add(this.panelCabecera);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCursos";
            this.Text = "FormCursos";
            this.Load += new System.EventHandler(this.FormCursos_Load);
            this.panelCabecera.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panelListado.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.listadoEnlaces)).EndInit();
            this.panelAsignaturas1.ResumeLayout(false);
            this.panelDinamico1.ResumeLayout(false);
            this.panelAsignaturas2.ResumeLayout(false);
            this.panelDinamico2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelCabecera;
        private System.Windows.Forms.Panel panelListado;
        private System.Windows.Forms.Panel panelAsignaturas1;
        private System.Windows.Forms.Panel panelAsignaturas2;
        private System.Windows.Forms.TextBox tbBuscar;
        private System.Windows.Forms.Button btnPrimero;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSegundo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnSistemas;
        private System.Windows.Forms.Button btnProgramacion;
        private System.Windows.Forms.Button btnLenguajes;
        private System.Windows.Forms.Button btnEntornos;
        private System.Windows.Forms.Button btnBbdd;
        private System.Windows.Forms.FlowLayoutPanel panelDinamico1;
        private System.Windows.Forms.Button btnMultimedia;
        private System.Windows.Forms.Button btnAccesoDatos;
        private System.Windows.Forms.Button btnProcesos;
        private System.Windows.Forms.Button btnInterfaces;
        private System.Windows.Forms.Button btnGestion;
        private System.Windows.Forms.FlowLayoutPanel panelDinamico2;
        private System.Windows.Forms.Timer tmPanelAsig1;
        private System.Windows.Forms.Timer tmPanelAsig2;
        private System.Windows.Forms.Timer tmPanelAsigOcultar1;
        private System.Windows.Forms.Timer tmPanelAsigOcultar2;
        private System.Windows.Forms.ImageList imageListLarge;
        private System.Windows.Forms.ImageList imageListSmall;
        private BrightIdeasSoftware.ObjectListView listadoEnlaces;
        private BrightIdeasSoftware.OLVColumn columnaTitulo;
        private BrightIdeasSoftware.OLVColumn columnaTema;
        private BrightIdeasSoftware.OLVColumn columnaTipo;
        private BrightIdeasSoftware.OLVColumn columnaValoracion;
        private BrightIdeasSoftware.OLVColumn columnaLike;
        private BrightIdeasSoftware.OLVColumn columnaDontLike;
        private BrightIdeasSoftware.OLVColumn columnaReportarFallo;
    }
}