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
    public partial class frmTestStatusStrip : Form
    {
        public frmTestStatusStrip()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (prbarProgress.Value >= 100)
            {
                prbarProgress.Value = 100;
            }
            else
            {
                prbarProgress.Value = prbarProgress.Value + 10;
            }

            if (
                prbarProgress.Value >= 100
                )
            {
                lbStatus.Text = "Listo";
            }
        }
    }
}
