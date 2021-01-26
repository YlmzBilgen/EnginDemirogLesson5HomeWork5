using EnginDemirogLesson5HomeWork5.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace EnginDemirogLesson5HomeWork5.Abstract
{
    public abstract class BasePlayerCheckManager : IPlayerCheckService
    {
        public virtual bool CheckPlayerInformation(IPlayer player)
        {
            return true;
        }
    }
}
