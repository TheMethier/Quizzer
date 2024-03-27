using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriviaAppSerices.Models
{
    internal class TriviaRequest
    {
        public int NumberOfQuestions { get; set; }
        public int CategoryId { get; set; }
        public string Difficulty { get; set; }

        public TriviaRequest()
        {
            Difficulty = "easy";
            CategoryId = 9;
            NumberOfQuestions = 10;
        }

        public TriviaRequest(int numberOfQuestions, int category, string difficulty)
        {
            NumberOfQuestions = numberOfQuestions;
            CategoryId = category;
            Difficulty = difficulty;
        }

        public override bool Equals(object? obj)
        {
            return obj is TriviaRequest request &&
                   NumberOfQuestions == request.NumberOfQuestions &&
                   CategoryId == request.CategoryId &&
                   Difficulty == request.Difficulty;
        }
        //add validation
        public override int GetHashCode()
        {
            return HashCode.Combine(NumberOfQuestions, CategoryId, Difficulty);
        }
        public override string ToString()
        {
            string request = new StringBuilder()
                .Append("amount=")
                .Append(NumberOfQuestions)
                .Append("&category=")
                .Append(CategoryId)
                .Append("&difficulty=")
                .Append(Difficulty)
                .Append("&type=multiple")
                .ToString();
            return request;
        }
    }
}
