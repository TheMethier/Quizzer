using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TriviaAppSerices.Entities;
using TriviaAppSerices.Models;

namespace WinFormsApp1
{
    public partial class LeaderForm : Form
    {
        private DataContext _dataContext;
        private List<PlayerDto> _players1;
        public LeaderForm()
        {
            _players1 = new List<PlayerDto>();
            _dataContext = new DataContext();
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Filter_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void next_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Menu fm = new Menu();
            fm.Location = this.Location;
            fm.StartPosition = FormStartPosition.Manual;
            fm.Show();
            this.Hide();
        }

        private void LeaderForm_Load(object sender, EventArgs e)
        {
            List<Player> players = _dataContext.Players.Include(x => x.Deck)
                .OrderByDescending(x => x.Score)
                .ToList();
            players.ForEach(x =>
            {
                string category = _dataContext.Decks.Where(y => y.Id == x.DeckId)
                    .Include(y => y.Category)
                    .Select(y => y.Category.Name)
                    .First();
                _players1.Add(new PlayerDto(x.Name, x.Score, x.Deck.DifficultyLevel, x.Deck.NumberOfQuestions, category));
            });
            dataGridView1.ForeColor = Color.Black;
            dataGridView1.DataSource = _players1;
            dataGridView1.Columns.Remove("LevelOfDifficulty");
            dataGridView1.Columns.Remove("NumberOfQuestions");
            dataGridView1.Columns.Remove("Category");
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = true;
        }


        private void FilterMyData_Click(object sender, EventArgs e)
        {

            string category = comboBox5.Text.ToString();
            int numberOfQuestions = int.Parse(comboBox4.Text.ToString());
            string levelOfDifficulty = comboBox6.Text.ToString().ToLower();
            dataGridView1.DataSource = _players1
                .Where(x => x.NumberOfQuestions == numberOfQuestions)
                .Where(x => x.LevelOfDifficulty == levelOfDifficulty)
                .Where(x => x.Category == category)
                .OrderByDescending(x=>x.Score)
                .ToList();
            dataGridView1.Columns.Remove("LevelOfDifficulty");
            dataGridView1.Columns.Remove("NumberOfQuestions");
            dataGridView1.Columns.Remove("Category");
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _players1;
            /*if (dataGridView1.Columns.Count > 2)
            {

            }*/
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

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

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
