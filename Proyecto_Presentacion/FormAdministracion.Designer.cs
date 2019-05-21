namespace Proyecto_Presentacion
{
    partial class FormAdministracion
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
            this.imageListLarge = new System.Windows.Forms.ImageList(this.components);
            this.imageListSmall = new System.Windows.Forms.ImageList(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tbBuscar = new System.Windows.Forms.TextBox();
            this.panelCabecera = new System.Windows.Forms.Panel();
            this.btnSegundo = new System.Windows.Forms.Button();
            this.btnPrimero = new System.Windows.Forms.Button();
            this.objectListView1 = new BrightIdeasSoftware.ObjectListView();
            this.Column1 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.Column2 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.Column3 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.Column4 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.Column5 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.Column6 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.Column7 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.Column8 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.panel3.SuspendLayout();
            this.panelCabecera.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.objectListView1)).BeginInit();
            this.SuspendLayout();
            // 
            // imageListLarge
            // 
            this.imageListLarge.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imageListLarge.ImageSize = new System.Drawing.Size(80, 80);
            this.imageListLarge.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // imageListSmall
            // 
            this.imageListSmall.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageListSmall.ImageSize = new System.Drawing.Size(35, 35);
            this.imageListSmall.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(39)))));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(5, 40);
            this.panel1.TabIndex = 19;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(39)))));
            this.panel2.Location = new System.Drawing.Point(125, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(5, 40);
            this.panel2.TabIndex = 21;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.tbBuscar);
            this.panel3.Location = new System.Drawing.Point(682, 0);
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
            this.tbBuscar.Size = new System.Drawing.Size(197, 25);
            this.tbBuscar.TabIndex = 3;
            this.tbBuscar.Text = " Buscar ";
            this.tbBuscar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbBuscar.TextChanged += new System.EventHandler(this.tbBuscar_TextChanged);
            this.tbBuscar.Enter += new System.EventHandler(this.tbBuscar_Enter);
            this.tbBuscar.Leave += new System.EventHandler(this.tbBuscar_Leave);
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
            this.panelCabecera.Size = new System.Drawing.Size(943, 40);
            this.panelCabecera.TabIndex = 2;
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
            this.btnSegundo.Location = new System.Drawing.Point(128, 0);
            this.btnSegundo.Name = "btnSegundo";
            this.btnSegundo.Size = new System.Drawing.Size(122, 40);
            this.btnSegundo.TabIndex = 2;
            this.btnSegundo.Text = "Enlaces";
            this.btnSegundo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSegundo.UseVisualStyleBackColor = true;
            this.btnSegundo.Click += new System.EventHandler(this.btnSegundo_Click);
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
            this.btnPrimero.Size = new System.Drawing.Size(130, 40);
            this.btnPrimero.TabIndex = 1;
            this.btnPrimero.Text = "Usuarios";
            this.btnPrimero.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPrimero.UseVisualStyleBackColor = true;
            // 
            // objectListView1
            // 
            this.objectListView1.AllColumns.Add(this.Column1);
            this.objectListView1.AllColumns.Add(this.Column2);
            this.objectListView1.AllColumns.Add(this.Column3);
            this.objectListView1.AllColumns.Add(this.Column4);
            this.objectListView1.AllColumns.Add(this.Column5);
            this.objectListView1.AllColumns.Add(this.Column6);
            this.objectListView1.AllColumns.Add(this.Column7);
            this.objectListView1.AllColumns.Add(this.Column8);
            this.objectListView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.objectListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8});
            this.objectListView1.Cursor = System.Windows.Forms.Cursors.Default;
            this.objectListView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.objectListView1.Font = new System.Drawing.Font("Segoe MDL2 Assets", 8F, System.Drawing.FontStyle.Bold);
            this.objectListView1.ForeColor = System.Drawing.Color.White;
            this.objectListView1.FullRowSelect = true;
            this.objectListView1.Location = new System.Drawing.Point(0, 40);
            this.objectListView1.Name = "objectListView1";
            this.objectListView1.RowHeight = 48;
            this.objectListView1.SelectedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.objectListView1.ShowGroups = false;
            this.objectListView1.ShowImagesOnSubItems = true;
            this.objectListView1.Size = new System.Drawing.Size(943, 565);
            this.objectListView1.SmallImageList = this.imageListSmall;
            this.objectListView1.TabIndex = 3;
            this.objectListView1.UnfocusedSelectedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.objectListView1.UseCellFormatEvents = true;
            this.objectListView1.UseCompatibleStateImageBehavior = false;
            this.objectListView1.UseFiltering = true;
            this.objectListView1.View = System.Windows.Forms.View.Details;
            this.objectListView1.CellClick += new System.EventHandler<BrightIdeasSoftware.CellClickEventArgs>(this.objectListView1_CellClick);
            this.objectListView1.ItemActivate += new System.EventHandler(this.objectListView1_ItemActivate);
            // 
            // Column1
            // 
            this.Column1.AspectName = "Column1";
            this.Column1.ImageAspectName = "FeatureIcon";
            this.Column1.Text = "Column1";
            this.Column1.WordWrap = true;
            // 
            // Column2
            // 
            this.Column2.AspectName = "Column1";
            this.Column2.ImageAspectName = "ProgressIcon";
            this.Column2.Text = "Column2";
            // 
            // Column3
            // 
            this.Column3.AspectName = "Column3";
            this.Column3.Text = "Column3";
            // 
            // Column4
            // 
            this.Column4.AspectName = "Column4";
            this.Column4.Text = "Column4";
            // 
            // Column5
            // 
            this.Column5.AspectName = "Column5";
            this.Column5.Text = "Column5";
            // 
            // Column6
            // 
            this.Column6.AspectName = "Column6";
            this.Column6.Text = "Column6";
            // 
            // Column7
            // 
            this.Column7.AspectName = "Column7";
            this.Column7.Text = "Column7";
            // 
            // Column8
            // 
            this.Column8.AspectName = "Column8";
            this.Column8.Text = "Column8";
            // 
            // FormAdministracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 605);
            this.Controls.Add(this.objectListView1);
            this.Controls.Add(this.panelCabecera);
            this.Name = "FormAdministracion";
            this.Text = "FormAdministracion";
            this.Load += new System.EventHandler(this.FormAdministracion_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panelCabecera.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.objectListView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ImageList imageListLarge;
        private System.Windows.Forms.ImageList imageListSmall;
        private System.Windows.Forms.Button btnPrimero;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSegundo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox tbBuscar;
        private System.Windows.Forms.Panel panelCabecera;
        private BrightIdeasSoftware.ObjectListView objectListView1;
        private BrightIdeasSoftware.OLVColumn Column1;
        private BrightIdeasSoftware.OLVColumn Column2;
        private BrightIdeasSoftware.OLVColumn Column3;
        private BrightIdeasSoftware.OLVColumn Column4;
        private BrightIdeasSoftware.OLVColumn Column5;
        private BrightIdeasSoftware.OLVColumn Column6;
        private BrightIdeasSoftware.OLVColumn Column7;
        private BrightIdeasSoftware.OLVColumn Column8;
    }
}