namespace proyekkolaborasi_catatan
{
    partial class Form3
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
            button1 = new Button();
            button2 = new Button();
            label2 = new Label();
            label3 = new Label();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            panel1 = new Panel();
            button3 = new Button();
            button4 = new Button();
            checkedListBox1 = new CheckedListBox();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 65);
            label1.Name = "label1";
            label1.Size = new Size(250, 38);
            label1.TabIndex = 0;
            label1.Text = "Rangkuman Bab 4";
            // 
            // button1
            // 
            button1.BackColor = Color.Firebrick;
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 1;
            button1.Text = "Batal";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ButtonShadow;
            button2.Location = new Point(320, 12);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 2;
            button2.Text = "Simpan";
            button2.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Light", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(18, 103);
            label2.Name = "label2";
            label2.Size = new Size(106, 21);
            label2.TabIndex = 3;
            label2.Text = "Tugas · Hari ini";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 141);
            label3.Name = "label3";
            label3.Size = new Size(258, 25);
            label3.TabIndex = 4;
            label3.Text = "Fotosintesis terjadi di kloropas.";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(18, 197);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(217, 29);
            checkBox1.TabIndex = 5;
            checkBox1.Text = "Baca ulang subbab 2.4";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(18, 232);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(144, 29);
            checkBox2.TabIndex = 6;
            checkBox2.Text = "Buat diagram";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.BackColor = Color.AntiqueWhite;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(checkedListBox1);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Location = new Point(0, 571);
            panel1.Name = "panel1";
            panel1.Size = new Size(444, 69);
            panel1.TabIndex = 7;
            // 
            // button3
            // 
            button3.BackColor = Color.AntiqueWhite;
            button3.Location = new Point(18, 23);
            button3.Name = "button3";
            button3.Size = new Size(35, 35);
            button3.TabIndex = 8;
            button3.Text = "B";
            button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            button4.Location = new Point(144, 24);
            button4.Name = "button4";
            button4.Size = new Size(38, 34);
            button4.TabIndex = 8;
            button4.Text = "Ⅰ";
            button4.UseVisualStyleBackColor = true;
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Location = new Point(277, 23);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(28, 32);
            checkedListBox1.TabIndex = 8;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.add_image;
            pictureBox1.Location = new Point(380, 23);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(38, 32);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Linen;
            ClientSize = new Size(444, 641);
            Controls.Add(panel1);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "Form3";
            Text = "Form3";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Button button2;
        private Label label2;
        private Label label3;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private Panel panel1;
        private Button button3;
        private CheckedListBox checkedListBox1;
        private Button button4;
        private PictureBox pictureBox1;
    }
}