using EnginDemirogLesson5HomeWork5.Abstract;
using EnginDemirogLesson5HomeWork5.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace EnginDemirogLesson5HomeWork5.Concrete
{
    public class CounterStrikePlayerManager: BasePlayerManager    
    {
        private IPlayerCheckService _playerCheckService;
        public CounterStrikePlayerManager(IPlayerCheckService playerCheckService)
        {
            _playerCheckService = playerCheckService;
        }
        public override void Add(IPlayer player)
        {
            if (_playerCheckService.CheckPlayerInformation(player))
            {

            }
            Console.WriteLine("Counter Strkike oyuncusu Eklendi");
        }

        public override void Update(IPlayer player)
        {
            Console.WriteLine("Counter Strike oyuncusu guncellendi");
        }
    }
}
