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
    public partial class FormLoad : Form
    {
        
        public FormLoad()
        {
            InitializeComponent();
        }

        private void FormLoad_Load(object sender, EventArgs e)
        {
            timer1.Start();
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            progressBar1.Value += 4;
            if (progressBar1.Value == 100)
            {
                FormMenu fo = new FormMenu();
                fo.Show();
                this.Visible = false;
                timer1.Stop();
                
            }
            
            
        }
    }
}
