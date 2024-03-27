namespace WinFormsApp1
{
    partial class GamePanel
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
            quesetion = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            abutton4 = new Button();
            abutton1 = new Button();
            abutton3 = new Button();
            abutton2 = new Button();
            panel1 = new Panel();
            button6 = new Button();
            next = new Button();
            score = new Label();
            label2 = new Label();
            label1 = new Label();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // quesetion
            // 
            quesetion.AllowDrop = true;
            quesetion.AutoEllipsis = true;
            quesetion.AutoSize = true;
            quesetion.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 238);
            quesetion.ForeColor = Color.FromArgb(241, 231, 241);
            quesetion.Location = new Point(15, 9);
            quesetion.MaximumSize = new Size(474, 200);
            quesetion.Name = "quesetion";
            quesetion.Size = new Size(451, 96);
            quesetion.TabIndex = 1;
            quesetion.Text = "What is the name of the Japanese art of folding paper into decorative shapes and figures?";
            quesetion.Click += quesetion_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(abutton4, 1, 1);
            tableLayoutPanel1.Controls.Add(abutton1, 0, 0);
            tableLayoutPanel1.Controls.Add(abutton3, 0, 1);
            tableLayoutPanel1.Controls.Add(abutton2, 1, 0);
            tableLayoutPanel1.Location = new Point(12, 138);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(474, 278);
            tableLayoutPanel1.TabIndex = 6;
            // 
            // abutton4
            // 
            abutton4.BackColor = Color.FromArgb(60, 57, 57);
            abutton4.FlatAppearance.BorderColor = Color.White;
            abutton4.FlatAppearance.BorderSize = 2;
            abutton4.FlatStyle = FlatStyle.Flat;
            abutton4.ForeColor = Color.FromArgb(241, 231, 241);
            abutton4.Location = new Point(240, 142);
            abutton4.Name = "abutton4";
            abutton4.Size = new Size(231, 129);
            abutton4.TabIndex = 4;
            abutton4.Text = "button4";
            abutton4.UseVisualStyleBackColor = false;
            // 
            // abutton1
            // 
            abutton1.BackColor = Color.FromArgb(60, 57, 57);
            abutton1.FlatAppearance.BorderColor = Color.White;
            abutton1.FlatAppearance.BorderSize = 2;
            abutton1.FlatStyle = FlatStyle.Flat;
            abutton1.ForeColor = Color.FromArgb(241, 231, 241);
            abutton1.Location = new Point(3, 3);
            abutton1.Name = "abutton1";
            abutton1.Size = new Size(231, 129);
            abutton1.TabIndex = 1;
            abutton1.Text = "button1";
            abutton1.UseVisualStyleBackColor = false;
            // 
            // abutton3
            // 
            abutton3.BackColor = Color.FromArgb(60, 57, 57);
            abutton3.FlatAppearance.BorderColor = Color.White;
            abutton3.FlatAppearance.BorderSize = 2;
            abutton3.FlatStyle = FlatStyle.Flat;
            abutton3.ForeColor = Color.FromArgb(241, 231, 241);
            abutton3.Location = new Point(3, 142);
            abutton3.Name = "abutton3";
            abutton3.Size = new Size(231, 129);
            abutton3.TabIndex = 3;
            abutton3.Text = "button3";
            abutton3.UseVisualStyleBackColor = false;
            // 
            // abutton2
            // 
            abutton2.BackColor = Color.FromArgb(60, 57, 57);
            abutton2.FlatAppearance.BorderColor = Color.White;
            abutton2.FlatAppearance.BorderSize = 2;
            abutton2.FlatStyle = FlatStyle.Flat;
            abutton2.ForeColor = Color.FromArgb(241, 231, 241);
            abutton2.Location = new Point(240, 3);
            abutton2.Name = "abutton2";
            abutton2.Size = new Size(231, 129);
            abutton2.TabIndex = 2;
            abutton2.Text = "button2";
            abutton2.UseVisualStyleBackColor = false;
            abutton2.Click += abutton2_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(60, 57, 57);
            panel1.Controls.Add(button6);
            panel1.Controls.Add(next);
            panel1.Controls.Add(score);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(514, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(286, 455);
            panel1.TabIndex = 7;
            panel1.Paint += panel1_Paint;
            // 
            // button6
            // 
            button6.BackColor = Color.FromArgb(60, 57, 57);
            button6.FlatAppearance.BorderColor = Color.White;
            button6.FlatAppearance.BorderSize = 2;
            button6.ForeColor = Color.FromArgb(241, 231, 241);
            button6.Location = new Point(28, 343);
            button6.Name = "button6";
            button6.Size = new Size(246, 67);
            button6.TabIndex = 6;
            button6.Text = "Back to menu";
            button6.UseVisualStyleBackColor = false;
            button6.Click += BackToMenu_Click;
            // 
            // next
            // 
            next.BackColor = Color.FromArgb(60, 57, 57);
            next.BackgroundImageLayout = ImageLayout.None;
            next.FlatAppearance.BorderColor = Color.White;
            next.FlatAppearance.BorderSize = 2;
            next.ForeColor = Color.FromArgb(241, 231, 241);
            next.Location = new Point(28, 248);
            next.Name = "next";
            next.Size = new Size(246, 69);
            next.TabIndex = 5;
            next.Text = "Next question";
            next.UseVisualStyleBackColor = false;
            next.Visible = false;
            next.Click += Next_Click;
            // 
            // score
            // 
            score.AutoSize = true;
            score.Font = new Font("Segoe UI", 30F);
            score.ForeColor = Color.FromArgb(241, 231, 241);
            score.Location = new Point(116, 106);
            score.Name = "score";
            score.Size = new Size(56, 67);
            score.TabIndex = 1;
            score.Text = "0";
            score.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 40F);
            label2.ForeColor = Color.FromArgb(241, 231, 241);
            label2.Location = new Point(42, 10);
            label2.Name = "label2";
            label2.Size = new Size(202, 89);
            label2.TabIndex = 0;
            label2.Text = "Score";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 17F);
            label1.ForeColor = Color.FromArgb(241, 231, 241);
            label1.Location = new Point(437, 414);
            label1.Name = "label1";
            label1.Size = new Size(76, 40);
            label1.TabIndex = 8;
            label1.Text = "0/10";
            label1.Click += label1_Click_1;
            // 
            // GamePanel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(quesetion);
            Name = "GamePanel";
            Text = "GamePanel";
            Load += GamePanel_Load;
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label quesetion;
        private TableLayoutPanel tableLayoutPanel1;
        private Button abutton1;
        private Button abutton3;
        private Button abutton4;
        private Button abutton2;
        private Panel panel1;
        private Label label2;
        private Label score;
        private Button button6;
        private Button next;
        private Label label1;
    }
}