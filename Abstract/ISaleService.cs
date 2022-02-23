using GamePortal.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GamePortal.Abstract
{
    interface ISaleService
    {
        void Sale(Game game, Campaign campaign, Gamer gamer);
    }
}
