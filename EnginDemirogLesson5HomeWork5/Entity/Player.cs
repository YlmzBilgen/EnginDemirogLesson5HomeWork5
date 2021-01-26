using EnginDemirogLesson5HomeWork5.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace EnginDemirogLesson5HomeWork5.Entity
{
    public class Player : IPlayer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
    }
}
