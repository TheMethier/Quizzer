namespace WinFormsApp1
{
    partial class LeaderForm
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
            components = new System.ComponentModel.Container();
            button1 = new Button();
            comboBox4 = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            comboBox5 = new ComboBox();
            comboBox6 = new ComboBox();
            label4 = new Label();
            next = new Button();
            dataGridView1 = new DataGridView();
            bindingSource1 = new BindingSource(components);
            button2 = new Button();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(60, 57, 57);
            button1.BackgroundImageLayout = ImageLayout.None;
            button1.FlatAppearance.BorderColor = Color.White;
            button1.FlatAppearance.BorderSize = 2;
            button1.ForeColor = Color.FromArgb(241, 231, 241);
            button1.Location = new Point(271, 346);
            button1.Name = "button1";
            button1.Size = new Size(246, 69);
            button1.TabIndex = 8;
            button1.Text = "Back to menu";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // comboBox4
            // 
            comboBox4.FormattingEnabled = true;
            comboBox4.Items.AddRange(new object[] { "10", "20", "30", "40", "50" });
            comboBox4.Location = new Point(519, 27);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(192, 28);
            comboBox4.TabIndex = 30;
            comboBox4.Text = "10";
            comboBox4.SelectedIndexChanged += comboBox4_SelectedIndexChanged;
            comboBox4.Validating += Validating;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.FromArgb(241, 231, 241);
            label2.Location = new Point(365, 30);
            label2.Name = "label2";
            label2.Size = new Size(148, 20);
            label2.TabIndex = 29;
            label2.Text = "Number of questions";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.FromArgb(241, 231, 241);
            label3.Location = new Point(444, 135);
            label3.Name = "label3";
            label3.Size = new Size(69, 20);
            label3.TabIndex = 28;
            label3.Text = "Category";
            // 
            // comboBox5
            // 
            comboBox5.FormattingEnabled = true;
            comboBox5.Items.AddRange(new object[] { "General knowledge", "Books", "Film", "Music", "Science and nature", "Computers", "Mathematics", "Geography" });
            comboBox5.Location = new Point(519, 135);
            comboBox5.Name = "comboBox5";
            comboBox5.Size = new Size(192, 28);
            comboBox5.TabIndex = 27;
            comboBox5.Text = "Books";
            comboBox5.SelectedIndexChanged += comboBox5_SelectedIndexChanged;
            comboBox5.Validating += Validating3;
            // 
            // comboBox6
            // 
            comboBox6.FormattingEnabled = true;
            comboBox6.Items.AddRange(new object[] { "Easy", "Medium", "Hard" });
            comboBox6.Location = new Point(519, 81);
            comboBox6.Name = "comboBox6";
            comboBox6.Size = new Size(192, 28);
            comboBox6.TabIndex = 26;
            comboBox6.Text = "Easy";
            comboBox6.Validating += Validating1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.FromArgb(241, 231, 241);
            label4.Location = new Point(390, 81);
            label4.Name = "label4";
            label4.Size = new Size(123, 20);
            label4.TabIndex = 25;
            label4.Text = "Level of difficulty";
            // 
            // next
            // 
            next.BackColor = Color.FromArgb(60, 57, 57);
            next.BackgroundImageLayout = ImageLayout.None;
            next.FlatAppearance.BorderColor = Color.White;
            next.FlatAppearance.BorderSize = 2;
            next.ForeColor = Color.FromArgb(241, 231, 241);
            next.Location = new Point(415, 204);
            next.Name = "next";
            next.Size = new Size(160, 69);
            next.TabIndex = 24;
            next.Text = "Search";
            next.UseVisualStyleBackColor = false;
            next.Click += FilterMyData_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(46, 25);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(304, 246);
            dataGridView1.TabIndex = 31;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick_2;
            // 
            // bindingSource1
            // 
            bindingSource1.DataSource = typeof(TriviaAppSerices.Entities.Answer);
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(60, 57, 57);
            button2.BackgroundImageLayout = ImageLayout.None;
            button2.FlatAppearance.BorderColor = Color.White;
            button2.FlatAppearance.BorderSize = 2;
            button2.ForeColor = Color.FromArgb(241, 231, 241);
            button2.Location = new Point(581, 204);
            button2.Name = "button2";
            button2.Size = new Size(160, 69);
            button2.TabIndex = 32;
            button2.Text = "Show all";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(717, 143);
            label7.Name = "label7";
            label7.Size = new Size(50, 20);
            label7.TabIndex = 35;
            label7.Text = "label7";
            label7.Visible = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(717, 89);
            label6.Name = "label6";
            label6.Size = new Size(50, 20);
            label6.TabIndex = 34;
            label6.Text = "label6";
            label6.Visible = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(717, 35);
            label5.Name = "label5";
            label5.Size = new Size(50, 20);
            label5.TabIndex = 33;
            label5.Text = "label5";
            label5.Visible = false;
            label5.Click += label5_Click;
            // 
            // LeaderForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(60, 57, 57);
            ClientSize = new Size(856, 450);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(button2);
            Controls.Add(dataGridView1);
            Controls.Add(comboBox4);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(comboBox5);
            Controls.Add(comboBox6);
            Controls.Add(label4);
            Controls.Add(next);
            Controls.Add(button1);
            ForeColor = SystemColors.Control;
            Name = "LeaderForm";
            Text = "LeaderForm";
            Load += LeaderForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private BindingSource playerBindingSource;
        private ContextMenuStrip contextMenuStrip1;
        private ContextMenuStrip contextMenuStrip2;
        private ToolStripComboBox toolStripComboBox1;
        private Button button1;
        private ComboBox comboBox4;
        private Label label2;
        private Label label3;
        private ComboBox comboBox5;
        private ComboBox comboBox6;
        private Label label4;
        private Button next;
        private BindingSource answerBindingSource;
        private DataGridView dataGridView1;
        private BindingSource bindingSource1;
        private Button button2;
        private Label label7;
        private Label label6;
        private Label label5;
    }
}