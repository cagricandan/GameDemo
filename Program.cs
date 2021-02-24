using GameDemo.Abstract;
using GameDemo.Concrate;
using GameDemo.Entities;
using System;

namespace GameDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            IGamerServices gamerServices = new GamerManager(new RealIfPersonManager());

            Gamer gamer = new Gamer();
            gamer.Id = 1;
            gamer.FirstName = "çağrı";
            gamer.LastName = "candan";
            gamer.BirthYear = new DateTime(2000, 1, 11);
            gamer.NationalityId = "12312313";

            gamerServices.Add(gamer);
            gamerServices.Update(gamer);
            gamerServices.Delete(gamer);


            GameSales gameSales = new GameSales();
            Campaign campaign = new Campaign();

            campaign.Id = 1;
            campaign.CampaignName = "bir alana bir bedava";

            gameSales.Id = 1;
            gameSales.GameName = "pubg";

            ICampaignServices campaignServices = new CampaignManager();
            IGameSales gameSales1 = new GameSalesManager();

            campaignServices.Add(campaign);
            campaignServices.Update(campaign);
            campaignServices.Delete(campaign);

            gameSales1.Sale(gameSales,campaign);




        }
    }
}
