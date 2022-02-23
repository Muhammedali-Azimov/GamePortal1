using GamePortal.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GamePortal.Abstract
{
    interface IGamerService
    {
        void Add(Gamer gamer);
        void Update();
        void Delete();
    }
}
