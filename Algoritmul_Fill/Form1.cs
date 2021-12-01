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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        bool state_maximized = false;
        Color button_pushed = Color.FromArgb(60, 174, 163);
        Color button_normal = Color.FromArgb(32, 99, 155);
        Color text_button_normal = Color.White;
        Color text_button_pushed = Color.FromArgb(23, 63, 95);

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        void click(Button b)
        {
            b.BackColor = button_pushed;
            b.ForeColor = text_button_pushed;
            panel2.BackColor = button_pushed;
        }

        private void menu(object sender, EventArgs e)
        {
            button4.BackColor = button_normal;
            button4.ForeColor = text_button_normal;
            button5.BackColor = button_normal;
            button5.ForeColor = text_button_normal;
            button7.BackColor = button_normal;
            button7.ForeColor = text_button_normal;
            Button b = (Button)sender;
            click(b);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            menu(sender, e);
            panel5.Dock = DockStyle.None;
            panel5.Width = 1;
            panel5.Height = 1;
            panel6.Dock = DockStyle.None;
            panel6.Width = 1;
            panel6.Height = 1;
            panel7.Dock = DockStyle.Fill;
            panel5.Visible = false;
            panel6.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            panel6.Visible = true;
            panel5.Visible = true;
            menu(sender, e);
            panel7.Dock = DockStyle.None;
            panel7.Width = 1;
            panel7.Height = 1;
            panel5.Width = 184;
            panel5.Height = 541;
            panel5.Dock = DockStyle.Left;
            panel6.Width = 1068;
            panel6.Height = 541;
            panel6.Dock = DockStyle.Right;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            animatie1.Visible = false;
            solutie_cpp1.Visible = false;
            cerinta1.Dock = DockStyle.Fill;
            cerinta1.Visible = true;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            cerinta1.Visible = false;
            solutie_cpp1.Visible = false;
            animatie1.Dock = DockStyle.Fill;
            animatie1.Visible = true;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            animatie1.Visible = false;
            cerinta1.Visible = false;
            solutie_cpp1.Dock = DockStyle.Fill;
            solutie_cpp1.Visible = true;
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            animatie1.Visible = false;
            solutie_cpp1.Visible = false;
            cerinta1.Visible = false;
            panel5.Visible = false;
            panel6.Visible = false;
            button4_Click(button4, e);
            webBrowser1.Navigate(Application.StartupPath + "/principii.html");
        }
    }
}
