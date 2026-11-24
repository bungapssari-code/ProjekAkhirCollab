namespace proyekkolaborasi_catatan
{
    partial class Form4
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            pictureBox1 = new PictureBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(115, 38);
            label1.TabIndex = 0;
            label1.Text = "Catatan";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 59);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(403, 53);
            textBox1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ControlLightLight;
            label2.Font = new Font("Segoe UI Light", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(79, 78);
            label2.Name = "label2";
            label2.Size = new Size(93, 21);
            label2.TabIndex = 2;
            label2.Text = "Cari Catatan";
            // 
            // panel1
            // 
            panel1.BackColor = Color.AntiqueWhite;
            panel1.Location = new Point(27, 193);
            panel1.Name = "panel1";
            panel1.Size = new Size(175, 175);
            panel1.TabIndex = 3;
            // 
            // panel2
            // 
            panel2.BackColor = Color.PeachPuff;
            panel2.Location = new Point(240, 193);
            panel2.Name = "panel2";
            panel2.Size = new Size(175, 175);
            panel2.TabIndex = 4;
            // 
            // panel3
            // 
            panel3.BackColor = Color.LemonChiffon;
            panel3.Location = new Point(27, 374);
            panel3.Name = "panel3";
            panel3.Size = new Size(175, 175);
            panel3.TabIndex = 5;
            // 
            // panel4
            // 
            panel4.BackColor = Color.MistyRose;
            panel4.Location = new Point(240, 374);
            panel4.Name = "panel4";
            panel4.Size = new Size(175, 175);
            panel4.TabIndex = 6;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ButtonHighlight;
            pictureBox1.Image = Properties.Resources.search;
            pictureBox1.Location = new Point(27, 59);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(33, 44);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(button1);
            flowLayoutPanel1.Controls.Add(button2);
            flowLayoutPanel1.Controls.Add(button3);
            flowLayoutPanel1.Location = new Point(12, 131);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(358, 40);
            flowLayoutPanel1.TabIndex = 8;
            // 
            // button1
            // 
            button1.BackColor = Color.Linen;
            button1.Location = new Point(3, 3);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 9;
            button1.Text = "Semua";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Linen;
            button2.Location = new Point(121, 3);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 0;
            button2.Text = "Tugas";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.Linen;
            button3.Location = new Point(239, 3);
            button3.Name = "button3";
            button3.Size = new Size(106, 34);
            button3.TabIndex = 0;
            button3.Text = "Ide";
            button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.Location = new Point(356, 565);
            button4.Name = "button4";
            button4.Size = new Size(59, 49);
            button4.TabIndex = 9;
            button4.Text = "+";
            button4.UseVisualStyleBackColor = true;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Linen;
            ClientSize = new Size(444, 641);
            Controls.Add(button4);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(pictureBox1);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "Form4";
            Text = "Form4";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private PictureBox pictureBox1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}