using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriviaAppSerices.Entities
{
    public class Answer
    {
        public Answer()
        {
        }

        public Answer(string text, bool correctness, Question question)
        {
            Text = text;
            Correctness = correctness;
            Question = question;
        }

        public Answer(int questionId, string text, bool correctness, Question question)
        {
            QuestionId = questionId;
            Text = text;
            Correctness = correctness;
            Question = question;
        }

        public int Id { get; set; }
        public int QuestionId { get; set; }
        public string Text { get; set; }
        public bool Correctness { get; set; }
        public Question Question { get; set; }

    }
}
