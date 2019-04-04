using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;


namespace Proyecto_Presentacion
{
    public partial class FormCursos : Form
    {
        public FormCursos()
        {
            InitializeComponent();
            DoubleBuffered = true;
        }

        private void FormCursos_Load(object sender, System.EventArgs e)
        {
            panelAsignaturas1.Height = 0;
            panelAsignaturas2.Height = 0;
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
    }
}