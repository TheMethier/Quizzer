namespace WinFormsApp1
{
    partial class SummaryForm
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
            scoreLabel = new Label();
            label2 = new Label();
            username = new TextBox();
            next = new Button();
            label3 = new Label();
            SuspendLayout();
            // 
            // quesetion
            // 
            quesetion.AllowDrop = true;
            quesetion.AutoEllipsis = true;
            quesetion.AutoSize = true;
            quesetion.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 238);
            quesetion.ForeColor = Color.FromArgb(241, 231, 241);
            quesetion.Location = new Point(286, 24);
            quesetion.MaximumSize = new Size(474, 200);
            quesetion.Name = "quesetion";
            quesetion.Size = new Size(216, 32);
            quesetion.TabIndex = 2;
            quesetion.Text = "Congratiulation!";
            quesetion.Click += quesetion_Click;
            // 
            // scoreLabel
            // 
            scoreLabel.AllowDrop = true;
            scoreLabel.AutoEllipsis = true;
            scoreLabel.AutoSize = true;
            scoreLabel.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 238);
            scoreLabel.ForeColor = Color.FromArgb(241, 231, 241);
            scoreLabel.Location = new Point(256, 95);
            scoreLabel.MaximumSize = new Size(474, 200);
            scoreLabel.Name = "scoreLabel";
            scoreLabel.Size = new Size(226, 32);
            scoreLabel.TabIndex = 3;
            scoreLabel.Text = "Your final score: ";
            scoreLabel.Click += label1_Click;
            // 
            // label2
            // 
            label2.AllowDrop = true;
            label2.AutoEllipsis = true;
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label2.ForeColor = Color.FromArgb(241, 231, 241);
            label2.Location = new Point(147, 190);
            label2.MaximumSize = new Size(474, 200);
            label2.Name = "label2";
            label2.Size = new Size(229, 32);
            label2.TabIndex = 4;
            label2.Text = "Enter your name ";
            label2.Click += label2_Click;
            // 
            // username
            // 
            username.Location = new Point(382, 195);
            username.Name = "username";
            username.Size = new Size(243, 27);
            username.TabIndex = 5;
            username.TextChanged += username_TextChanged;
            username.Validating += label3_Validating;
            // 
            // next
            // 
            next.BackColor = Color.FromArgb(60, 57, 57);
            next.BackgroundImageLayout = ImageLayout.None;
            next.FlatAppearance.BorderColor = Color.White;
            next.FlatAppearance.BorderSize = 2;
            next.ForeColor = Color.FromArgb(241, 231, 241);
            next.Location = new Point(271, 294);
            next.Name = "next";
            next.Size = new Size(246, 69);
            next.TabIndex = 6;
            next.Text = "Submit";
            next.UseVisualStyleBackColor = false;
            next.Click += next_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(632, 197);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 7;
            label3.Text = "label3";
            label3.Visible = false;
            label3.Click += label3_Click;
            // 
            // SummaryForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(60, 57, 57);
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(next);
            Controls.Add(username);
            Controls.Add(label2);
            Controls.Add(scoreLabel);
            Controls.Add(quesetion);
            Name = "SummaryForm";
            Text = "SummaryForm";
            Load += SummaryForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label quesetion;
        private Label label1;
        private Label label2;
        private TextBox username;
        private Button next;
        private Label scoreLabel;
        private Label label3;
    }
}