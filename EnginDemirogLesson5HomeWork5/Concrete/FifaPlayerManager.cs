using EnginDemirogLesson5HomeWork5.Abstract;
using EnginDemirogLesson5HomeWork5.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace EnginDemirogLesson5HomeWork5.Concrete
{
    public class FifaPlayerManager:BasePlayerManager
    {
        private IPlayerCheckService _playerCheckService;
        public FifaPlayerManager(IPlayerCheckService playerCheckService)
        {
            _playerCheckService = playerCheckService;
        }
        public override void Add(IPlayer player)
        {
            if (_playerCheckService.CheckPlayerInformation(player))
            {
                Console.WriteLine("Fifa oyuncusu Eklendi");
            }            
        }

        public override void Update(IPlayer player)
        {
            Console.WriteLine("Fifa Strike oyuncusu guncellendi");
        }
    }
}
