using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgEscalas
{
    public partial class FormSuporte : Form
    {
        public FormSuporte()
        {
            InitializeComponent();
        }

        private void FormSuporte_Load(object sender, EventArgs e)
        {
            webBrowser1.AllowWebBrowserDrop = false;
            webBrowser1.Url = new Uri("https://tawk.to/chat/599b3619dbb01a218b4dd8c4/default/?$_tawk_popout=true");
        }
    }
}
