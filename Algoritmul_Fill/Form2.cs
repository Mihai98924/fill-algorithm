using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Algoritmul_Fill
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public int uscat, apa;
        public string label;

        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)(Keys.Back) && e.KeyChar != (char)(Keys.Insert))
                e.Handled = true;
        }

        private void Form2_Shown(object sender, EventArgs e)
        {
            label4.Text = label;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
                uscat = int.Parse(textBox1.Text);
            if (textBox2.Text != "")
                apa = int.Parse(textBox2.Text);
            this.Close();
        }
    }
}
