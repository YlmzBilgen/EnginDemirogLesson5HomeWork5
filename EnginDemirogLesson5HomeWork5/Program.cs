using EnginDemirogLesson5HomeWork5.Abstract;
using EnginDemirogLesson5HomeWork5.Concrete;
using EnginDemirogLesson5HomeWork5.Entity;
using System;

namespace EnginDemirogLesson5HomeWork5
{
    class Program
    {
        static void Main(string[] args)
        {
            BasePlayerManager csPlayerManager = new CounterStrikePlayerManager(new EDevletPlayerCheckManager());
            csPlayerManager.Add(new Player());

            BaseSaleManager onlineSaleManager = new OnlineSaleManager();
            onlineSaleManager.Sale(new CounterStrike(), new Player());



            Console.ReadKey();
        }
    }
}
