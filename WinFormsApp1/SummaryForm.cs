using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TriviaAppSerices.Entities;

namespace WinFormsApp1
{
    public partial class SummaryForm : Form
    {
        private DataContext _dataContext;
        private int _deckId;
        private int _score;
        public SummaryForm()
        {
            InitializeComponent();
            _dataContext = new DataContext();
        }
        public SummaryForm(int deckId, int score)
        {
            InitializeComponent();
            _deckId = deckId;
            _score = score;
            _dataContext = new DataContext();
        }

        private void quesetion_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private async void next_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                Deck deck = _dataContext.Decks.First(x => x.Id == _deckId);
                Player player = new Player();
                player.Deck = deck;
                player.Score = _score;
                player.Name = username.Text;
                await _dataContext.AddAsync(player);
                await _dataContext.SaveChangesAsync();
                LeaderForm leaderForm = new LeaderForm();
                leaderForm.Location = this.Location;
                leaderForm.StartPosition = FormStartPosition.Manual;
                leaderForm.FormClosing += delegate { this.Show(); };
                leaderForm.Show();
                this.Hide();
            }
        }

        private void username_TextChanged(object sender, EventArgs e)
        {

        }

        private void SummaryForm_Load(object sender, EventArgs e)
        {
            scoreLabel.Text += _score.ToString();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Validating(object sender, CancelEventArgs e)
        {
            TextBox textBox = sender as TextBox ?? new TextBox();
            if (string.IsNullOrEmpty(textBox.Text))
            {
                e.Cancel = true;
                label3.Visible = true;
                label3.ForeColor = Color.Red;
                label3.Text = "Field is empty";
            }
            else
            {
                label3.Visible = false;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
