using GamePortal.Abstract;
using System;

namespace GamePortal.Concrete
{
    class GameManager : IGameService
    {
        public void Add()
        {
            Console.WriteLine("Game Added..");
        }

        public void Delete()
        {
            Console.WriteLine("Game Deleted..");
        }

        public void Update()
        {
            Console.WriteLine("Game Updated..");
        }
    }
}
