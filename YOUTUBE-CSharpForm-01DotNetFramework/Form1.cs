 using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace YOUTUBE_CSharpForm_01DotNetFramework
{
    public partial class Form1 : Form
    {
        //-------------------------------------------------------------------------------------------------------------
        //                                                  //INSTANCE VARIABLES.
        private int intCount_Z;

        public Form1()
        {
            InitializeComponent();
            //                                              //Center the form
            this.StartPosition = FormStartPosition.CenterScreen;

            //                                              //Form will take size of the screen.
            //                                              //If the form in the project the size property is very big, 
            //                                              //  there for with the next code we could do appear the
            //                                              //  scroll automatically if the property autoscroll is
            //                                              //  true.
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;

            //                                              //Form will be maximized
            this.WindowState = FormWindowState.Maximized;

            // Registra el evento MouseWheel para desplazarme a los laterales con Shift + Rueda Mouse.
            this.MouseWheel += new MouseEventHandler(Form1_MouseWheel);

            domainUpDown1.Items.Add("Mexico");
            domainUpDown1.Items.Add("Eua");
            domainUpDown1.Items.Add("Francia");
        }

        //--------------------------------------------------------------------------------------------------------------
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            const int scrollAmount = 50;  // Aumenta este valor para un desplazamiento más largo.

            // Chequea si la tecla Control está siendo presionada.
            if ((keyData & Keys.Control) == Keys.Control)
            {
                switch (keyData)
                {
                    case Keys.Control | Keys.Up:
                        // Desplazamiento hacia arriba.
                        this.VerticalScroll.Value = Math.Max(0, this.VerticalScroll.Value - scrollAmount);
                        return true;

                    case Keys.Control | Keys.Down:
                        // Desplazamiento hacia abajo.
                        this.VerticalScroll.Value = Math.Min(this.VerticalScroll.Maximum - this.VerticalScroll.LargeChange + 1, this.VerticalScroll.Value + scrollAmount);
                        return true;

                    case Keys.Control | Keys.Left:
                        // Desplazamiento hacia la izquierda.
                        this.HorizontalScroll.Value = Math.Max(0, this.HorizontalScroll.Value - scrollAmount);
                        return true;

                    case Keys.Control | Keys.Right:
                        // Desplazamiento hacia la derecha.
                        this.HorizontalScroll.Value = Math.Min(this.HorizontalScroll.Maximum - this.HorizontalScroll.LargeChange + 1, this.HorizontalScroll.Value + scrollAmount);
                        return true;
                }
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        //--------------------------------------------------------------------------------------------------------------
        private void Form1_MouseWheel(object sender, MouseEventArgs e)
        {
            // Verifica si la tecla Shift está presionada
            if (Control.ModifierKeys == Keys.Shift)
            {
                // Desplaza el panel horizontalmente en base a la dirección de la rueda del ratón
                int newValue = this.HorizontalScroll.Value - e.Delta;
                newValue = Math.Max(0, newValue);  // Asegura que el valor no sea negativo
                newValue = Math.Min(this.HorizontalScroll.Maximum - this.HorizontalScroll.LargeChange + 1, newValue);  // Asegura que el valor no exceda el máximo
                this.HorizontalScroll.Value = newValue;

                // Indica que el evento fue manejado
                ((HandledMouseEventArgs)e).Handled = true;
            }
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
            frmMenuStrip menu = new frmMenuStrip(null);
            menu.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hola, Soy un cuadro de mensaje");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hola", "Mensage importante");
        }

        private void button14_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hola", "Titulo", MessageBoxButtons.YesNoCancel);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hola", "Titulo", MessageBoxButtons.AbortRetryIgnore);
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {

        }

        private void label26_Click(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {
            label27.Text = trackBar1.Value.ToString();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            frmMenuStrip frmMenuStrip = new frmMenuStrip(textBox2.Text);
            frmMenuStrip.Show();    
        }

        private void button18_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            intCount_Z++;
            label30.Text = intCount_Z.ToString();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label31_Click(object sender, EventArgs e)
        {

        }

        private void button19_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void label31_Click_1(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void button21_Click(object sender, EventArgs e)
        {
            frmTestStatusStrip frmStatusStrip = new frmTestStatusStrip();
            frmStatusStrip.Show();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            int intNum = dataGridView1.Rows.Add();
            dataGridView1.Rows[intNum].Cells[0].Value = textBox3.Text ?? "";
            dataGridView1.Rows[intNum].Cells[1].Value = textBox4.Text ?? "";
            dataGridView1.Rows[intNum].Cells[2].Value = textBox5.Text ?? "";

            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button23_Click(object sender, EventArgs e)
        {
            FrmToolStripContainer frmToolStripContainer = new FrmToolStripContainer();  
            frmToolStripContainer.Show();   
        }

        private void button24_Click(object sender, EventArgs e)
        {
            domainUpDown1.Items.Add(textBox6.Text);
        }

        private void domainUpDown1_Click(object sender, EventArgs e)
        {

        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {
            String pais = (String)domainUpDown1.SelectedItem;
            label39.Text = String.Format("El mejor pais del mundo es {0}", pais);
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
