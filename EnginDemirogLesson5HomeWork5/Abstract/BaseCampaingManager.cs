using System;
using System.Collections.Generic;
using System.Text;

namespace EnginDemirogLesson5HomeWork5.Abstract
{
    public abstract class BaseCampaingManager : ICampaignService
    {
        public virtual void Add(ICampaign campaign)
        {
            Console.WriteLine("Kampanya Eklendi")
        }

        public virtual void Delete(int Id)
        {
            Console.WriteLine("Kampanya Silindi");
        }

        public virtual void Update(ICampaign campaign)
        {
            Console.WriteLine("Kampanya Guncellendi");
        }
    }
}
