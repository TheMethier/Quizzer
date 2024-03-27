using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriviaAppSerices.Entities
{
    public class Deck
    {
        public Deck()
        {
        }

        public Deck(int categoryId, int numberOfQuestions, string difficultyLevel, Category category)
        {
            CategoryId = categoryId;
            NumberOfQuestions = numberOfQuestions;
            DifficultyLevel = difficultyLevel;
            Category = category;
        }

        public Deck(int numberOfQuestions, string difficultyLevel, ICollection<Question> questions, ICollection<Player> players, Category category)
        {
            NumberOfQuestions = numberOfQuestions;
            DifficultyLevel = difficultyLevel;
            Questions = questions ?? throw new ArgumentNullException(nameof(questions));
            Players = players ?? throw new ArgumentNullException(nameof(players));
            Category = category ?? throw new ArgumentNullException(nameof(category));
        }

        public Deck(int id, int categoryId, int numberOfQuestions, string difficultyLevel, ICollection<Question> questions, ICollection<Player> players, Category category)
        {
            Id = id;
            CategoryId = categoryId;
            NumberOfQuestions = numberOfQuestions;
            DifficultyLevel = difficultyLevel;
            Questions = questions;
            Players = players;
            Category = category;
        }

        public int Id { get; set; }
        public int CategoryId { get; set; }
        public int NumberOfQuestions { get; set; }
        public string DifficultyLevel { get; set; }
        public ICollection<Question> Questions { get; set; }
        public ICollection<Player> Players { get; set; }
        public Category Category { get; set; }
    }
}

