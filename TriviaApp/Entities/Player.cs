using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriviaAppSerices.Entities
{
    public class Player
    {
        public Player()
        {
            Name = string.Empty;
        }

        public Player(int id, int deckId, string name, int score, Deck deck)
        {
            Id = id;
            DeckId = deckId;
            Name = name;
            Score = score;
            Deck = deck;
        }

        public int Id { get; set; }
        public int DeckId { get; set; }
        public string Name { get; set; }
        public int Score { get; set; }
        public Deck Deck { get; set; }
    }
}
