using GamePortal.Concrete;
using GamePortal.Entities;

namespace GamePortal
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();
            game.Name = "GTA 6";
            Gamer gamer = new Gamer();
            gamer.Firstname = "Shemid";
            Campaign campaign = new Campaign();
            campaign.Name = "Zirto Companies";


            SalesManager sale = new SalesManager();
            sale.Sale(game, campaign, gamer);

            TestValidation testValidation = new TestValidation();
            GamerManager gamerManager = new GamerManager(testValidation);
            gamerManager.Add(gamer);
        }
    }
}
