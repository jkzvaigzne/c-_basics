using System;
using System.Collections.Generic;
using System.Linq;

namespace AdApp
{
    public class Campaign
    {
        private List<Advert> _campaign;
        private string _campaignName;

        public Campaign(string name)
        {
            _campaign = new List<Advert>();
            _campaignName = name;
        }

        public void AddAdvert(Advert a)
        {
            _campaign.Add(a);
        }

        public int GetCost()
        {
            return _campaign.Sum(item => item.Cost());
        }

        public override string ToString()
        {
            return "Advert Campaign Name: " + _campaignName + "\nTotal Cost = " + GetCost() + "£";
        }

        public void ShowAdverts()
        {
            foreach (var advert in _campaign)
            {
                Console.WriteLine(advert.GetType());
                Console.WriteLine(advert.ToString());
                Console.WriteLine($"Total cost: {advert.Cost()}");
            }
        }
    }
}