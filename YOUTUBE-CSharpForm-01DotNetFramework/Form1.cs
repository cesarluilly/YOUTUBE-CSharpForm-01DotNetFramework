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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Aceptar_Click(object sender, EventArgs e)
        {
            this.label1.Text = "Ya se cambio el nombre del Label";
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            label1.Text = "Se cambiara el Texto por accion de boton";
        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (
                checkBox1.Checked == true
                )
            {
                label2.Text = "Hombre";
            }else if(
                checkBox2.Checked == true
                )
            {
                label2.Text = "Mujer";
            }
            else
            {
                label2.Text = "No ha selecionado ninguno";
            }
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (
                radioButton1.Checked == true
                )
            {
                label3.Text = "Hombre";
            }
            else if (
                radioButton2.Checked == true
                )
            {
                label3.Text = "Mujer";
            }
            else
            {
                label3.Text = "No ha selecionado ninguno radio button de H o M";
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label7.Text = comboBox1.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label7.Text = comboBox1.Text;
        }
    }
}
