using GameDemo.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Entities
{
    public class Campaign:Ientity
    {
        public int Id { get; set; }
        public string CampaignName { get; set; }

    }
}
