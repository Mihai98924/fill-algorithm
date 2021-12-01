using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Algoritmul_Fill
{
    public partial class animatie : UserControl
    {
        public animatie()
        {
            InitializeComponent();
        }

        struct pozitie
        {
            public int x, y;
        }

        int n, m, L = 60, v, iv, jv;
        bool fill;
        int[,] A;
        int[] di = { -1, 0, 1, 0 }, dj = { 0, 1, 0, -1 };
        int[] Cnt;
        Button[,] B;
        List<Color> C;
        Color delimiter = Color.Blue;
        Queue<pozitie> Q;

        void generare()
        {
            A = new int[n, m];
            B = new Button[n, m];
            C = new List<Color>();
            Cnt = new int[n * m + 1];
            Random r = new Random();
            while (C.Count <= n * m)
            {
                Color a = Color.FromArgb(r.Next(255), r.Next(255), r.Next(255));
                if (!C.Contains(a) && a != delimiter)
                    C.Add(a);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                foreach (Button b in B)
                {
                    if (b.BackColor == delimiter)
                        b.BackColor = colorDialog1.Color;
                }
                delimiter = colorDialog1.Color;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            saveFileDialog1.InitialDirectory = Application.StartupPath;
            saveFileDialog1.FileName = "";
            saveFileDialog1.Filter = "Bitmap Image|*.bmp|PNG Image|*.png|JPEG Image|*.jpeg";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Bitmap image = new Bitmap(panel1.Width, panel1.Height);
                panel1.DrawToBitmap(image, new Rectangle(0, 0, B[n - 1, m - 1].Right, B[n - 1, m - 1].Bottom));
                image.Save(saveFileDialog1.FileName);
                MessageBox.Show("Imaginea s-a salvat cu succes!");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = Application.StartupPath;
            openFileDialog1.FileName = "";
            openFileDialog1.Filter = "IN File|*.in|Text File|*.txt";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamReader fin = new StreamReader(openFileDialog1.FileName);
                string[] s = fin.ReadLine().Split();
                panel1.Controls.Clear();
                n = int.Parse(s[0]);
                m = int.Parse(s[1]);
                numericUpDown1.Value = n;
                numericUpDown2.Value = m;
                generare();
                Form2 f = new Form2();
                f.ShowDialog();
                for (int i = 0; i < n; i++)
                {
                    s = fin.ReadLine().Split();
                    for (int j = 0; j < m; j++)
                    {
                        int value = int.Parse(s[j]);
                        B[i, j] = new Button();
                        B[i, j].FlatStyle = FlatStyle.Flat;
                        B[i, j].Width = B[i, j].Height = L;
                        B[i, j].Top = i * L;
                        B[i, j].Left = j * L;
                        B[i, j].Click += new EventHandler(click);
                        if (value == f.apa)
                        {
                            A[i, j] = -1;
                            B[i, j].PerformClick();
                        }
                        panel1.Controls.Add(B[i, j]);
                    }
                }
                fin.Close();
            }
            if (button5.Bottom < panel1.Height)
                this.Height = panel1.Height + L;
            else this.Height = button5.Bottom + L;
            this.Width = panel1.Right + L;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            saveFileDialog1.InitialDirectory = Application.StartupPath;
            saveFileDialog1.FileName = "";
            saveFileDialog1.Filter = "OUT File|*.out|Text File|*.txt";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamWriter fout = new StreamWriter(saveFileDialog1.FileName);
                fout.WriteLine(n.ToString() + " " + m.ToString());
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < m; j++)
                        fout.Write(A[i, j].ToString() + " ");
                    fout.Write("\n");
                }
                fout.Close();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (timer1.Enabled == false && v == 0)
            {
                for (int i = 0; i < n; i++)
                    for (int j = 0; j < m; j++)
                    {
                        if (A[i, j] == -1)
                        {
                            A[i, j] = 0;
                            B[i, j].BackColor = Color.Empty;
                        }
                        else
                        {
                            A[i, j] = -1;
                            B[i, j].BackColor = delimiter;
                        }
                    }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int max = -1, indice = 0;
            for (int i = 1; i <=v; i++)
            {
                if (max < Cnt[i])
                {
                    max = Cnt[i];
                    indice = i;
                }
            }
            foreach (Button b in B)
            {
                if (b.Text != indice.ToString() && b.BackColor != delimiter)
                {
                    b.BackColor = Color.Empty;
                    b.Text = "";
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            checkBox1.Enabled = true;
            timer1.Stop();
            fill = false;
            v = 0;
            checkBox1.Enabled = true;
            n = Convert.ToInt32(numericUpDown1.Value);
            m = Convert.ToInt32(numericUpDown2.Value);
            generare();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    B[i, j] = new Button();
                    B[i, j].FlatStyle = FlatStyle.Flat;
                    B[i, j].Width = B[i, j].Height = L;
                    B[i, j].Top = i * L;
                    B[i, j].Left = j * L;
                    B[i, j].Click += new EventHandler(click);
                    panel1.Controls.Add(B[i, j]);
                }
            }
            if (button5.Bottom < panel1.Height)
                this.Height = panel1.Height + L;
            else this.Height = button4.Bottom + L;
            this.Width = panel1.Right + L;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            checkBox1.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            fill = true;
            bool ok = false;
            Q = new Queue<pozitie>();
            for (int i = 0; i < n && !ok; i++)
                for (int j = 0; j < m; j++)
                {
                    if (A[i, j] == 0)
                    {
                        pozitie a;
                        a.x = i;
                        a.y = j;
                        Q.Enqueue(a);
                        v++;
                        Cnt[v]++;
                        B[i, j].BackColor = C[v];
                        A[i, j] = v;
                        B[i, j].Text = A[i, j].ToString();
                        ok = true;
                        timer1.Start();
                        break;
                    }
                }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Q.Count != 0)
            {
                pozitie Coord = Q.Peek();
                for (int k = 0; k < 4; k++)
                {
                    iv = Coord.x + di[k];
                    jv = Coord.y + dj[k];
                    if (iv >= 0 && iv < n && jv >= 0 && jv < m && A[iv, jv] != -1 && A[iv, jv] != v)
                    {
                        A[iv, jv] = v;
                        B[iv, jv].Text = A[iv, jv].ToString();
                        B[iv, jv].BackColor = C[v];
                        Cnt[v]++;
                        pozitie a;
                        a.x = iv;
                        a.y = jv;
                        Q.Enqueue(a);
                    }
                    else if (iv >= 0 && iv < n && jv >= 0 && jv < m)
                    {
                        Color c = B[iv, jv].BackColor;
                        B[iv, jv].BackColor = Color.Red;
                        B[iv, jv].Refresh();
                        System.Threading.Thread.Sleep(500);
                        B[iv, jv].BackColor = c;
                    }
                }
                Q.Dequeue();
            }
            else
            {
                bool ok = false;
                for (int i = 0; i < n && !ok; i++)
                    for (int j = 0; j < m; j++)
                        if (A[i, j] == 0)
                        {
                            pozitie a;
                            a.x = i;
                            a.y = j;
                            Q.Enqueue(a);
                            v++;
                            Cnt[v]++;
                            A[i, j] = v;
                            B[i, j].BackColor = C[v];
                            B[i, j].Text = A[i, j].ToString();
                            ok = true;
                            break;
                        }
                if (!ok)
                {
                    timer1.Stop();
                    MessageBox.Show("In matrice sunt " + v.ToString() + " zone");
                    button3.Enabled = true;
                    button4.Enabled = true;
                    button5.Enabled = true;
                    button6.Enabled = true;
                }
            }
        }

        private void click(object sender, EventArgs e)
        {
            Button a = (Button)sender;
            if (fill == true)
                return;
            if (a.BackColor == delimiter)
            {
                a.BackColor = Color.Empty;
                A[a.Top / L, a.Left / L] = 0;
            }
            else
            {
                a.BackColor = delimiter;
                A[a.Top / L, a.Left / L] = -1;
            }
        }
    }
}
