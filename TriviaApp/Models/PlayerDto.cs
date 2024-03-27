using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriviaAppSerices.Models
{
    internal class PlayerDto
    {
        public PlayerDto(string name, int score, string levelOfDifficulty, int numberOfQuestions, string category)
        {
            Name = name;
            Score = score;
            LevelOfDifficulty = levelOfDifficulty;
            NumberOfQuestions = numberOfQuestions;
            Category = category;
        }

        public string Name { get; set; }
        public int Score { get; set; }
        public string LevelOfDifficulty { get; set; }
        public int NumberOfQuestions { get; set; }
        public string Category { get; set; }

    }
}
