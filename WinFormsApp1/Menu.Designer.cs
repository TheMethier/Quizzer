namespace WinFormsApp1
{
    partial class Menu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            button3 = new Button();
            panel2 = new Panel();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            button1 = new Button();
            comboBox3 = new ComboBox();
            label2 = new Label();
            next = new Button();
            label3 = new Label();
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            label4 = new Label();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(60, 57, 57);
            label1.Font = new Font("Segoe UI", 40F);
            label1.ForeColor = Color.FromArgb(241, 231, 241);
            label1.Location = new Point(249, 0);
            label1.Name = "label1";
            label1.Size = new Size(277, 89);
            label1.TabIndex = 0;
            label1.Text = "Quizzier";
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(60, 57, 57);
            button3.BackgroundImageLayout = ImageLayout.None;
            button3.FlatAppearance.BorderColor = Color.White;
            button3.FlatAppearance.BorderSize = 2;
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor = Color.FromArgb(241, 231, 241);
            button3.Location = new Point(273, 377);
            button3.Name = "button3";
            button3.Size = new Size(253, 63);
            button3.TabIndex = 8;
            button3.Text = "Leaderboard";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(60, 57, 57);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(comboBox3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(next);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(comboBox2);
            panel2.Controls.Add(comboBox1);
            panel2.Controls.Add(label4);
            panel2.Location = new Point(-2, -2);
            panel2.Name = "panel2";
            panel2.Size = new Size(796, 453);
            panel2.TabIndex = 9;
            panel2.Paint += panel2_Paint;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(532, 263);
            label7.Name = "label7";
            label7.Size = new Size(50, 20);
            label7.TabIndex = 21;
            label7.Text = "label7";
            label7.Visible = false;
            label7.Click += label7_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(532, 209);
            label6.Name = "label6";
            label6.Size = new Size(50, 20);
            label6.TabIndex = 20;
            label6.Text = "label6";
            label6.Visible = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(532, 155);
            label5.Name = "label5";
            label5.Size = new Size(50, 20);
            label5.TabIndex = 19;
            label5.Text = "label5";
            label5.Visible = false;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(60, 57, 57);
            button1.BackgroundImageLayout = ImageLayout.None;
            button1.FlatAppearance.BorderColor = Color.White;
            button1.FlatAppearance.BorderSize = 2;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.FromArgb(241, 231, 241);
            button1.Location = new Point(14, 377);
            button1.Name = "button1";
            button1.Size = new Size(253, 63);
            button1.TabIndex = 18;
            button1.Text = "Choose your quiz";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "10", "20", "30", "40", "50" });
            comboBox3.Location = new Point(334, 152);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(192, 28);
            comboBox3.TabIndex = 17;
            comboBox3.Text = "10";
            comboBox3.SelectedIndexChanged += comboBox3_SelectedIndexChanged;
            comboBox3.Validating += Validating;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.FromArgb(241, 231, 241);
            label2.Location = new Point(161, 155);
            label2.Name = "label2";
            label2.Size = new Size(148, 20);
            label2.TabIndex = 16;
            label2.Text = "Number of questions";
            // 
            // next
            // 
            next.BackColor = Color.FromArgb(60, 57, 57);
            next.BackgroundImageLayout = ImageLayout.None;
            next.FlatAppearance.BorderColor = Color.White;
            next.FlatAppearance.BorderSize = 2;
            next.FlatStyle = FlatStyle.Flat;
            next.ForeColor = Color.FromArgb(241, 231, 241);
            next.Location = new Point(532, 377);
            next.Name = "next";
            next.Size = new Size(253, 63);
            next.TabIndex = 7;
            next.Text = "Options";
            next.UseVisualStyleBackColor = false;
            next.Click += Options_click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.FromArgb(241, 231, 241);
            label3.Location = new Point(240, 260);
            label3.Name = "label3";
            label3.Size = new Size(69, 20);
            label3.TabIndex = 15;
            label3.Text = "Category";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "general knowledge", "books", "film", "music", "science and nature", "computers", "mathematics", "geography" });
            comboBox2.Location = new Point(334, 260);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(192, 28);
            comboBox2.TabIndex = 14;
            comboBox2.Text = "books";
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged_1;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "easy", "medium", "hard" });
            comboBox1.Location = new Point(334, 206);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(192, 28);
            comboBox1.TabIndex = 13;
            comboBox1.Text = "easy";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.FromArgb(241, 231, 241);
            label4.Location = new Point(186, 206);
            label4.Name = "label4";
            label4.Size = new Size(123, 20);
            label4.TabIndex = 12;
            label4.Text = "Level of difficulty";
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(794, 450);
            Controls.Add(panel2);
            Name = "Menu";
            Text = "Form1";
            Load += Form1_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Button button3;
        private Panel panel1;
        private Panel panel2;
        private ComboBox comboBox3;
        private Label label2;
        private Button next;
        private Label label3;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private Label label4;
        private Button button1;
        private Label label5;
        private Label label7;
        private Label label6;
    }
}
