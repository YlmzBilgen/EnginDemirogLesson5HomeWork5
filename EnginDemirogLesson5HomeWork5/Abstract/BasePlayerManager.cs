using EnginDemirogLesson5HomeWork5.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace EnginDemirogLesson5HomeWork5.Abstract
{
    public class BasePlayerManager : IPlayerService
    {
        public virtual void Add(IPlayer player)

        {
            Console.WriteLine("Oyuncu Eklendi..");
        }

        public void Delete(int id)
        {
            Console.WriteLine("Oyuncu Silindi");
        }

        public virtual void Update(IPlayer player)
        {
            Console.WriteLine("Oyuncu Guncellendi");
        }
    }
}
