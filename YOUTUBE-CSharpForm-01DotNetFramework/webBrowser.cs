using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YOUTUBE_CSharpForm_01DotNetFramework
{
    public partial class webBrowser : Form
    {
        public webBrowser()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void buttonIr_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(txtUrl.Text);
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void btnAdelante_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            webBrowser1.Stop();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            webBrowser1.GoHome();   
        }
    }
}
