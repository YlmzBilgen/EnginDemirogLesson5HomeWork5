using System;
using System.Collections.Generic;
using System.Text;

namespace EnginDemirogLesson5HomeWork5.Abstract
{
    public interface ICampaignService
    {
        void Add(ICampaign campaign);
        void Delete(int Id);
        void Update(ICampaign campaign);
    }
}
