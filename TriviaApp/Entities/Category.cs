﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriviaAppSerices.Entities
{
    public class Category
    {
        public Category(string name)
        {

            Name = name;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Deck> Decks { get; set; }

    }
}
