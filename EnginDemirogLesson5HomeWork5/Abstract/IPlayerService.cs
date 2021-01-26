using EnginDemirogLesson5HomeWork5.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace EnginDemirogLesson5HomeWork5.Abstract
{
    interface IPlayerService
    {
        void Add(IPlayer player);
        void Update(IPlayer player);
        void Delete(int id);
    }
}
