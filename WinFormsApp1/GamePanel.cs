using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TriviaAppSerices.Entities;

namespace WinFormsApp1
{
    public partial class GamePanel : Form
    {
        private DataContext _dataContext;
        private List<Question> _questions;
        private List<Answer> _answers;
        private int index;
        private int _score;
        private bool isAnswer = false;
        public GamePanel(List<Question> questions, List<Answer> answers1, int index, int score)
        {
            _dataContext = new DataContext();
            this._score = score;
            this._questions = questions;
            this._answers = answers1;
            this.index = index;
            InitializeComponent();
        }

        public GamePanel()
        {
            _dataContext = new DataContext();
            _questions = new List<Question>();
            _answers = new List<Answer>();
            InitializeComponent();
        }

        public GamePanel(Question question, List<Answer> answers)
        {
            _questions = new List<Question>();
            _answers = (List<Answer>)answers;
            _dataContext = new DataContext();
        }

        private void GamePanel_Load(object sender, EventArgs e)
        {

            score.Text = _score.ToString();
            quesetion.Text = _questions[index].Text.ToString();
            abutton1.Text = _answers[0].Text.ToString();
            abutton2.Text = _answers[1].Text.ToString();
            abutton3.Text = _answers[2].Text.ToString();
            abutton4.Text = _answers[3].Text.ToString();
            int ind = index + 1;
            label1.Text = ind.ToString() + "/" + _questions.Count.ToString();
            List<Button> buttons = new List<Button>() { abutton1, abutton2, abutton3, abutton4 };
            abutton1.Click += new EventHandler(delegate { checkAnswer_Click(abutton1, e, buttons); });
            abutton2.Click += new EventHandler(delegate { checkAnswer_Click(abutton2, e, buttons); });
            abutton3.Click += new EventHandler(delegate { checkAnswer_Click(abutton3, e, buttons); });
            abutton4.Click += new EventHandler(delegate { checkAnswer_Click(abutton4, e, buttons); });
            if (index == _questions.Count - 1)
            {
                next.Text = "Show summary";
                next.Click += Next_Click1;
            }

        }

        private void Next_Click1(object? sender, EventArgs e)
        {
            SummaryForm fm = new SummaryForm(_questions.First().DeckId, _score);
            fm.Location = this.Location;
            fm.StartPosition = FormStartPosition.Manual;
            fm.Show();
            this.Hide();
        }

        private void checkAnswer_Click(object sender, EventArgs e, List<Button> buttons)
        {
            string correct = _answers.Where(x => x.Correctness)
                .Select(x => x.Text)
                .First();
            Button button = buttons.Where(x => x.Text == correct)
                .First();
            button.FlatAppearance.BorderColor = Color.Green;
            buttons.Except(new List<Button>() { button })
                .ToList()
                .ForEach(x => x.FlatAppearance.BorderColor = Color.Red);
            if (button == (Button)sender && !isAnswer)
            {
                _score = int.Parse(score.Text) + 10;
                score.Text = _score.ToString();
            }
            isAnswer = true;
            next.Visible = true;
            index++;
        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void quesetion_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void BackToMenu_Click(object sender, EventArgs e)
        {
            Menu fm = new Menu();
            fm.Location = this.Location;
            fm.StartPosition = FormStartPosition.Manual;
            fm.Show();
            this.Hide();
        }

        private void Next_Click(object sender, EventArgs e)
        {
            if (index < _questions.Count())
            {
                var answers = _dataContext.Answers
                    .Where(x => x.QuestionId == _questions[index].Id)
                    .ToList();
                GamePanel fm = new GamePanel(_questions, answers, index, _score);
                fm.Location = this.Location;
                fm.StartPosition = FormStartPosition.Manual;
                fm.Show();
                this.Hide();
            }

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void abutton2_Click(object sender, EventArgs e)
        {

        }
    }
}
