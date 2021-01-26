using EnginDemirogLesson5HomeWork5.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace EnginDemirogLesson5HomeWork5.Entity
{
    public class CounterStrike : IGame
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public int Category { get; set; }
        public decimal Imdb { get; set; }
    }
}
