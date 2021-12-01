
namespace Algoritmul_Fill
{
    partial class problema
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel5 = new System.Windows.Forms.Panel();
            this.button10 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.animatie1 = new Algoritmul_Fill.animatie();
            this.cerinta1 = new Algoritmul_Fill.cerinta();
            this.solutie_cpp1 = new Algoritmul_Fill.solutie_cpp();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.button10);
            this.panel5.Controls.Add(this.button9);
            this.panel5.Controls.Add(this.button8);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(184, 544);
            this.panel5.TabIndex = 1;
            this.panel5.Visible = false;
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.White;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Location = new System.Drawing.Point(25, 134);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(126, 56);
            this.button10.TabIndex = 2;
            this.button10.Text = "Solutie C++";
            this.button10.UseVisualStyleBackColor = false;
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.White;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Location = new System.Drawing.Point(25, 77);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(126, 51);
            this.button9.TabIndex = 1;
            this.button9.Text = "Animatie";
            this.button9.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.White;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Location = new System.Drawing.Point(24, 20);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(126, 51);
            this.button8.TabIndex = 0;
            this.button8.Text = "Cerinta";
            this.button8.UseVisualStyleBackColor = false;
            // 
            // animatie1
            // 
            this.animatie1.BackColor = System.Drawing.Color.Transparent;
            this.animatie1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.animatie1.Location = new System.Drawing.Point(30, 20);
            this.animatie1.Margin = new System.Windows.Forms.Padding(243, 165, 243, 165);
            this.animatie1.Name = "animatie1";
            this.animatie1.Size = new System.Drawing.Size(2092, 1092);
            this.animatie1.TabIndex = 1;
            // 
            // cerinta1
            // 
            this.cerinta1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cerinta1.Location = new System.Drawing.Point(26136, 4032);
            this.cerinta1.Margin = new System.Windows.Forms.Padding(1842, 1012, 1842, 1012);
            this.cerinta1.Name = "cerinta1";
            this.cerinta1.Size = new System.Drawing.Size(13533, 6288);
            this.cerinta1.TabIndex = 2;
            // 
            // solutie_cpp1
            // 
            this.solutie_cpp1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.solutie_cpp1.Location = new System.Drawing.Point(18759, 1455);
            this.solutie_cpp1.Margin = new System.Windows.Forms.Padding(1228, 704, 1228, 704);
            this.solutie_cpp1.Name = "solutie_cpp1";
            this.solutie_cpp1.Size = new System.Drawing.Size(8658, 6268);
            this.solutie_cpp1.TabIndex = 3;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.solutie_cpp1);
            this.panel6.Controls.Add(this.cerinta1);
            this.panel6.Controls.Add(this.animatie1);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(184, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(817, 544);
            this.panel6.TabIndex = 4;
            this.panel6.Visible = false;
            // 
            // problema
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Name = "problema";
            this.Size = new System.Drawing.Size(1001, 544);
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private animatie animatie1;
        private cerinta cerinta1;
        private solutie_cpp solutie_cpp1;
        private System.Windows.Forms.Panel panel6;
    }
}
