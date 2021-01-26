using EnginDemirogLesson5HomeWork5.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace EnginDemirogLesson5HomeWork5.Concrete
{
    public class OnlineSaleManager:BaseSaleManager
    {
        private ICampaignService _campaingService;
        public OnlineSaleManager(ICampaignService campaignService)
        {
            _campaingService = campaignService;
        }
        public override void Sale(IGame game, IPlayer player)
        {
            base.Sale(game, player);
        }
    }
}
