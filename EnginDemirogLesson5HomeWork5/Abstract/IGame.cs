using System;
using System.Collections.Generic;
using System.Text;

namespace EnginDemirogLesson5HomeWork5.Abstract
{
    public interface IGame:IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Category { get; set; }
        public decimal Imdb { get; set; }
    }
}
