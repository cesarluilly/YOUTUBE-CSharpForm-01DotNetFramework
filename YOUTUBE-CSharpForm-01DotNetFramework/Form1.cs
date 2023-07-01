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

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            listView1.Items.Add("Hola");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Canada");
            String strIteme = listBox1.SelectedItem?.ToString();
            label9.Text = strIteme;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (progressBar1.Value < 100)
                progressBar1.Value = progressBar1.Value + 10;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            label13.Text = dateTimePicker1.Text;
            label14.Text = dateTimePicker1.Value.ToString();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel1.LinkVisited = true;
            System.Diagnostics.Process.Start("https://www.unicoos.com/blog/la-constante-de-kaprekar/");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            label17.Text = numericUpDown1.Value.ToString();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            webBrowser miFormaWeb = new webBrowser();
            miFormaWeb.Show();
            //miFormaWeb.ShowDialog();
        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            frmMenuStrip menu = new frmMenuStrip();
            menu.Show();
        }
    }
}
