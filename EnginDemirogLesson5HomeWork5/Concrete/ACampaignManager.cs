using EnginDemirogLesson5HomeWork5.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace EnginDemirogLesson5HomeWork5.Concrete
{
    public class ACampaignManager : BaseCampaingManager
    {
        public override void Add(ICampaign campaign)
        {
            Console.WriteLine("A Kampanyası eklendi");
        }

        public override void Update(ICampaign campaign)
        {
            Console.WriteLine("A kampanyası guncellendi");
        }

        public override void Delete(int Id)
        {
            Console.WriteLine("A Kampanyası Silindi");
        }
    }
}
