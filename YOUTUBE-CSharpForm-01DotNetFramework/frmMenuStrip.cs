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
    public partial class frmMenuStrip : Form
    {
        public frmMenuStrip(String strReceiveData)
        {
            InitializeComponent();
            if (strReceiveData != null && strReceiveData.Length > 0)
            {
                label2.Text = strReceiveData;
            }
            else
            {
                label2.Text = "Label para recibir informacion del formulario principal";
            }
        }

        private void subMenu1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Text = "Elemento seleccionado: SubMenu1";
        }

        private void subMenu2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Text = "Elemento seleccionado: SubMenu2";
        }

        private void sub1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Text = "Elemento seleccionado: Sub1";
        }

        private void sub2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Text = "Elemento seleccionado: Sub2";
        }
    }
}
