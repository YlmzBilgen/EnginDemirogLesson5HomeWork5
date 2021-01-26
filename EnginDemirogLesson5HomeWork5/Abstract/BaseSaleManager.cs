using System;
using System.Collections.Generic;
using System.Text;

namespace EnginDemirogLesson5HomeWork5.Abstract
{
    public abstract class BaseSaleManager : ISaleManager
    {
        public virtual void Sale(IGame game, IPlayer player)
        {
            Console.WriteLine($"{game.Name} - {player.Name}");
        }
    }
}
