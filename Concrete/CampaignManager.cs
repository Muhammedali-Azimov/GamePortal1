using GamePortal.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GamePortal.Concrete
{
    class CampaignManager : ICampaignService
    {
        public void Add()
        {
            Console.WriteLine("Company Added..");
        }

        public void Delete()
        {
            Console.WriteLine("Company Deleted..");
        }

        public void Update()
        {
            Console.WriteLine("Company Updated..");
        }
    }
}
