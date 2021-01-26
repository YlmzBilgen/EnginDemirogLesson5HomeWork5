using EnginDemirogLesson5HomeWork5.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace EnginDemirogLesson5HomeWork5.Entity
{
    public class ACampaign : ICampaign
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string ValidityDate { get; set; }
    }
}
