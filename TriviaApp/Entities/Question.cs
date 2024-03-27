using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriviaAppSerices.Entities
{
    public class Question
    {
        public Question()
        {
        }

        public Question(string text, int value,Deck deck)
        {
            Text = text;
            Value = value;
            Deck = deck;
        }

        public int Id { get; set; }
        public int DeckId { get; set; }
        public string Text { get; set; }
        public int Value { get; set; }
        public ICollection<Answer> Answers { get; set; }
        public Deck Deck { get; set; }
        public override string ToString()
        {
            return Text.ToString();
        }
    }
}
