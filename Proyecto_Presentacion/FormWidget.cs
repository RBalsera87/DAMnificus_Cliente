using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Permissions;
using System.IO;
using System.Runtime.InteropServices;

namespace Proyecto_Presentacion
{
    [ComVisible(true)]
    public partial class FormWidget : Form
    {
        private string path;
        public FormWidget()
        {
            InitializeComponent();
            //this.Load += new EventHandler(Widget_Load);
            //webBrowser1.DocumentCompleted += new WebBrowserDocumentCompletedEventHandler(webBrowser1_DocumentCompleted_1);
            //webBrowser1.ScriptErrorsSuppressed = true;
            this.path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "../../");
            InitializeWebBrowser();
        }
        void Widget_Load(object sender, EventArgs e)
        {
            //Uncomment the following line when you are finished debugging.
            webBrowser1.ScriptErrorsSuppressed = true;

            string CurrentDirectory = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
            this.webBrowser1.Url = new Uri(Path.Combine(this.path, "HTMLPage1.html"));
            //webBrowser1.Navigate("HTMLPage1.html");
        }
        private void InitializeWebBrowser()
        {
            //set the url to our own html
            this.webBrowser1.Url = new Uri(Path.Combine(this.path, "Graficas/GraficaBarras.html"));

            //set the magic ObjectForScripting to this;
            this.webBrowser1.ObjectForScripting = this;

            //Visual settings to integrate the WebBrowser in our Winform.
            this.webBrowser1.AllowWebBrowserDrop = false;
            this.webBrowser1.WebBrowserShortcutsEnabled = false;

            //Comment this line when you are still developing
            this.webBrowser1.ScriptErrorsSuppressed = true;
        }
        private void webBrowser1_DocumentCompleted_1(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            webBrowser1.ObjectForScripting = this;
        }
    }
}
