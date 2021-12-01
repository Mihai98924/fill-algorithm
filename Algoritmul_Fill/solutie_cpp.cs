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
    public partial class solutie_cpp : UserControl
    {
        public solutie_cpp()
        {
            InitializeComponent();
        }

        private void solutie_cpp_Load(object sender, EventArgs e)
        {
            richTextBox1.LoadFile(Application.StartupPath + "/solutia_cpp.rtf");
        }
    }
}
