using LiveCharts.WinForms;
namespace Proyecto_Presentacion
{
    partial class FormAreaPersonal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAreaPersonal));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.graficaNotas = new LiveCharts.WinForms.CartesianChart();
            this.graficaMedias = new LiveCharts.WinForms.PieChart();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbTrimestre = new System.Windows.Forms.TrackBar();
            this.lblTrimestre = new System.Windows.Forms.Label();
            this.btnAgregarNota = new System.Windows.Forms.Button();
            this.lbAsignaturas = new System.Windows.Forms.ListBox();
            this.notaIntroducir = new System.Windows.Forms.NumericUpDown();
            this.listadoEnlaces = new BrightIdeasSoftware.ObjectListView();
            this.columnaTitulo = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.columnaTema = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.columnaTipo = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.columnaValoracion = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.imageListSmall = new System.Windows.Forms.ImageList(this.components);
            this.imageListLarge = new System.Windows.Forms.ImageList(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbTrimestre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.notaIntroducir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listadoEnlaces)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.graficaNotas, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.graficaMedias, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.listadoEnlaces, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1127, 771);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // graficaNotas
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.graficaNotas, 2);
            this.graficaNotas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.graficaNotas.ForeColor = System.Drawing.Color.White;
            this.graficaNotas.Location = new System.Drawing.Point(3, 3);
            this.graficaNotas.Name = "graficaNotas";
            this.graficaNotas.Size = new System.Drawing.Size(744, 418);
            this.graficaNotas.TabIndex = 0;
            this.graficaNotas.Text = "cartesianChart1";
            // 
            // graficaMedias
            // 
            this.graficaMedias.Dock = System.Windows.Forms.DockStyle.Fill;
            this.graficaMedias.Location = new System.Drawing.Point(3, 427);
            this.graficaMedias.Name = "graficaMedias";
            this.graficaMedias.Size = new System.Drawing.Size(369, 341);
            this.graficaMedias.TabIndex = 1;
            this.graficaMedias.Text = "pieChart1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbTrimestre);
            this.groupBox1.Controls.Add(this.lblTrimestre);
            this.groupBox1.Controls.Add(this.btnAgregarNota);
            this.groupBox1.Controls.Add(this.lbAsignaturas);
            this.groupBox1.Controls.Add(this.notaIntroducir);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semilight", 12F);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(753, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(371, 418);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Agregar notra";
            // 
            // tbTrimestre
            // 
            this.tbTrimestre.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tbTrimestre.LargeChange = 1;
            this.tbTrimestre.Location = new System.Drawing.Point(3, 297);
            this.tbTrimestre.Maximum = 2;
            this.tbTrimestre.Name = "tbTrimestre";
            this.tbTrimestre.Size = new System.Drawing.Size(365, 45);
            this.tbTrimestre.TabIndex = 3;
            this.tbTrimestre.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.tbTrimestre.Scroll += new System.EventHandler(this.tbTrimestre_Scroll);
            // 
            // lblTrimestre
            // 
            this.lblTrimestre.AutoSize = true;
            this.lblTrimestre.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblTrimestre.Location = new System.Drawing.Point(3, 342);
            this.lblTrimestre.Name = "lblTrimestre";
            this.lblTrimestre.Size = new System.Drawing.Size(49, 21);
            this.lblTrimestre.TabIndex = 2;
            this.lblTrimestre.Text = "label1";
            this.lblTrimestre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAgregarNota
            // 
            this.btnAgregarNota.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnAgregarNota.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarNota.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnAgregarNota.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarNota.ForeColor = System.Drawing.Color.White;
            this.btnAgregarNota.Location = new System.Drawing.Point(3, 363);
            this.btnAgregarNota.Name = "btnAgregarNota";
            this.btnAgregarNota.Size = new System.Drawing.Size(365, 52);
            this.btnAgregarNota.TabIndex = 4;
            this.btnAgregarNota.Text = "Agregar";
            this.btnAgregarNota.UseVisualStyleBackColor = false;
            this.btnAgregarNota.Click += new System.EventHandler(this.btnAgregarNota_Click);
            // 
            // lbAsignaturas
            // 
            this.lbAsignaturas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.lbAsignaturas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbAsignaturas.ForeColor = System.Drawing.Color.White;
            this.lbAsignaturas.FormattingEnabled = true;
            this.lbAsignaturas.ItemHeight = 21;
            this.lbAsignaturas.Location = new System.Drawing.Point(3, 54);
            this.lbAsignaturas.Name = "lbAsignaturas";
            this.lbAsignaturas.Size = new System.Drawing.Size(365, 361);
            this.lbAsignaturas.TabIndex = 1;
            // 
            // notaIntroducir
            // 
            this.notaIntroducir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.notaIntroducir.DecimalPlaces = 2;
            this.notaIntroducir.Dock = System.Windows.Forms.DockStyle.Top;
            this.notaIntroducir.ForeColor = System.Drawing.Color.White;
            this.notaIntroducir.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.notaIntroducir.Location = new System.Drawing.Point(3, 25);
            this.notaIntroducir.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.notaIntroducir.Name = "notaIntroducir";
            this.notaIntroducir.Size = new System.Drawing.Size(365, 29);
            this.notaIntroducir.TabIndex = 0;
            this.notaIntroducir.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // listadoEnlaces
            // 
            this.listadoEnlaces.AllColumns.Add(this.columnaTitulo);
            this.listadoEnlaces.AllColumns.Add(this.columnaTema);
            this.listadoEnlaces.AllColumns.Add(this.columnaTipo);
            this.listadoEnlaces.AllColumns.Add(this.columnaValoracion);
            this.listadoEnlaces.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.listadoEnlaces.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnaTitulo,
            this.columnaTema,
            this.columnaTipo,
            this.columnaValoracion});
            this.tableLayoutPanel1.SetColumnSpan(this.listadoEnlaces, 2);
            this.listadoEnlaces.Cursor = System.Windows.Forms.Cursors.Default;
            this.listadoEnlaces.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listadoEnlaces.Font = new System.Drawing.Font("Segoe MDL2 Assets", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listadoEnlaces.ForeColor = System.Drawing.Color.White;
            this.listadoEnlaces.FullRowSelect = true;
            this.listadoEnlaces.Location = new System.Drawing.Point(378, 427);
            this.listadoEnlaces.Name = "listadoEnlaces";
            this.listadoEnlaces.RowHeight = 48;
            this.listadoEnlaces.SelectedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.listadoEnlaces.ShowGroups = false;
            this.listadoEnlaces.ShowImagesOnSubItems = true;
            this.listadoEnlaces.Size = new System.Drawing.Size(746, 341);
            this.listadoEnlaces.TabIndex = 3;
            this.listadoEnlaces.UnfocusedSelectedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.listadoEnlaces.UseCellFormatEvents = true;
            this.listadoEnlaces.UseCompatibleStateImageBehavior = false;
            this.listadoEnlaces.UseFiltering = true;
            this.listadoEnlaces.View = System.Windows.Forms.View.Details;
            this.listadoEnlaces.FormatCell += new System.EventHandler<BrightIdeasSoftware.FormatCellEventArgs>(this.listadoEnlaces_FormatCell);
            this.listadoEnlaces.ItemActivate += new System.EventHandler(this.listadoEnlaces_ItemActivate);
            // 
            // columnaTitulo
            // 
            this.columnaTitulo.AspectName = "titulo";
            this.columnaTitulo.FillsFreeSpace = true;
            this.columnaTitulo.ImageAspectName = "FeatureIcon";
            this.columnaTitulo.MinimumWidth = 120;
            this.columnaTitulo.Text = "Título y descripción";
            this.columnaTitulo.Width = 150;
            this.columnaTitulo.WordWrap = true;
            // 
            // columnaTema
            // 
            this.columnaTema.AspectName = "tema";
            this.columnaTema.Text = "Tema";
            this.columnaTema.Width = 200;
            // 
            // columnaTipo
            // 
            this.columnaTipo.AspectName = "tipo";
            this.columnaTipo.Text = "Tipo";
            this.columnaTipo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnaTipo.Width = 80;
            // 
            // columnaValoracion
            // 
            this.columnaValoracion.Text = "Valoracion";
            this.columnaValoracion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // imageListSmall
            // 
            this.imageListSmall.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imageListSmall.ImageSize = new System.Drawing.Size(40, 40);
            this.imageListSmall.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // imageListLarge
            // 
            this.imageListLarge.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListLarge.ImageStream")));
            this.imageListLarge.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListLarge.Images.SetKeyName(0, "entire_network");
            this.imageListLarge.Images.SetKeyName(1, "scheduled_tasks");
            this.imageListLarge.Images.SetKeyName(2, "search");
            this.imageListLarge.Images.SetKeyName(3, "workgroup");
            this.imageListLarge.Images.SetKeyName(4, "write_document");
            this.imageListLarge.Images.SetKeyName(5, "tick");
            this.imageListLarge.Images.SetKeyName(6, "ball");
            this.imageListLarge.Images.SetKeyName(7, "perros");
            // 
            // FormAreaPersonal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(1127, 771);
            this.Controls.Add(this.tableLayoutPanel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAreaPersonal";
            this.Text = "FormAreaPersonal";
            this.Load += new System.EventHandler(this.FormAreaPersonal_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbTrimestre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.notaIntroducir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listadoEnlaces)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private LiveCharts.WinForms.CartesianChart graficaNotas;
        private LiveCharts.WinForms.PieChart graficaMedias;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown notaIntroducir;
        private System.Windows.Forms.Label lblTrimestre;
        private System.Windows.Forms.TrackBar tbTrimestre;
        private System.Windows.Forms.ListBox lbAsignaturas;
        private System.Windows.Forms.Button btnAgregarNota;
        private BrightIdeasSoftware.ObjectListView listadoEnlaces;
        private BrightIdeasSoftware.OLVColumn columnaTitulo;
        private System.Windows.Forms.ImageList imageListSmall;
        private System.Windows.Forms.ImageList imageListLarge;
        private BrightIdeasSoftware.OLVColumn columnaTema;
        private BrightIdeasSoftware.OLVColumn columnaTipo;
        private BrightIdeasSoftware.OLVColumn columnaValoracion;
    }
}