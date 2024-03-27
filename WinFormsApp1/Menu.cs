using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.Windows.Forms;
using TriviaAppSerices.Entities;

namespace WinFormsApp1
{
    public partial class Menu : Form
    {
        private DataContext _dataContext;



        public Menu()
        {
            _dataContext = new DataContext();
            InitializeComponent();

        }

        private void userControl11_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Validating += Validating;
            comboBox2.Validating += Validating1;
            comboBox3.Validating += Validating3;
        }

        private void Validating3(object? sender, CancelEventArgs e)
        {
            ComboBox comboBox = sender as ComboBox ?? new ComboBox();
            if (string.IsNullOrEmpty(comboBox.Text))
            {
                e.Cancel = true;
                label7.Visible = true;
                label7.ForeColor = Color.Red;
                label7.Text = "Field is empty";
            }
            else if (!comboBox.Items.Contains(comboBox.Text))
            {
                e.Cancel = true;
                label7.Visible = true;
                label7.ForeColor = Color.Red;
                label7.Text = "Incorrect input";
            }
            else
            {
                label7.Visible = false;
            }
        }

        private void Validating1(object? sender, CancelEventArgs e)
        {

            ComboBox comboBox = sender as ComboBox ?? new ComboBox();
            if (string.IsNullOrEmpty(comboBox.Text))
            {
                e.Cancel = true;
                label6.Visible = true;
                label6.ForeColor = Color.Red;
                label6.Text = "Field is empty";
            }
            else if (!comboBox.Items.Contains(comboBox.Text))
            {
                e.Cancel = true;
                label6.Visible = true;
                label6.ForeColor = Color.Red;
                label6.Text = "Incorrect input";
            }
            else
            {
                label6.Visible = false;
            }
        }

        private new void Validating(object? sender, System.ComponentModel.CancelEventArgs e)
        {

            ComboBox comboBox = sender as ComboBox ?? new ComboBox();
            if (string.IsNullOrEmpty(comboBox.Text))
            {
                e.Cancel = true;
                label5.Visible = true;
                label5.ForeColor = Color.Red;
                label5.Text = "Field is empty";
            }
            else if (!comboBox.Items.Contains(comboBox.Text))
            {
                e.Cancel = true;
                label5.Visible = true;
                label5.ForeColor = Color.Red;
                label5.Text = "Incorrect input";
            }
            else
            {
                label5.Visible = false;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                Dictionary<string, int> topics = new Dictionary<string, int>
                {
                { "general knowledge",1 },
                {"books", 2  },
                { "film" , 3 },
                {"music" , 4 },
                {"science and nature" , 5 },
                {"computers" , 6 },
                {"mathematics" , 7 },
                {"geography" , 8 }
                };
                int numberOfQuestions = int.Parse(comboBox3.Text);
                int categoryId = topics[comboBox2.Text];
                List<Question> questions = _dataContext.Decks
                    .Include(x => x.Questions)
                    .Where(x => x.DifficultyLevel == comboBox1.Text.ToString())
                    .Where(x => x.NumberOfQuestions == numberOfQuestions)
                    .Where(x => x.CategoryId == categoryId)
                    .Select(x => x.Questions)
                    .First()
                    .OrderBy(x => Random.Shared.Next())
                    .ToList();
                List<Answer> answers = _dataContext.Answers
                    .Where(x => x.QuestionId == questions.First().Id)
                    .ToList();
                GamePanel gamePanel = new GamePanel(questions, answers, 0, 0);
                gamePanel.Location = this.Location;
                gamePanel.StartPosition = FormStartPosition.Manual;
                gamePanel.FormClosing += delegate { this.Show(); };
                gamePanel.Show();
                this.Hide();
            }

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            LeaderForm leaderForm = new LeaderForm();
            leaderForm.Location = this.Location;
            leaderForm.StartPosition = FormStartPosition.Manual;
            leaderForm.FormClosing += delegate { this.Show(); };
            leaderForm.Show();
            this.Hide();
        }

        private void Options_click(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
