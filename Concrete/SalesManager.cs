using GamePortal.Abstract;
using GamePortal.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GamePortal.Concrete
{
    class SalesManager : ISaleService
    {
        public void Sale(Game game, Campaign campaign, Gamer gamer)
        {
            Console.WriteLine(game.Name + " oyunu " + gamer.Firstname + " isimli oyuncuya " + campaign.Name + " tarafindan satildi." );
        }
    }
}
