using GamePortal.Abstract;
using GamePortal.Entities;
using System;

namespace GamePortal.Concrete
{
    public class GamerManager : IGamerService
    {
        TestValidation _testValidation;
        public GamerManager(TestValidation testValidation)
        {
            _testValidation = testValidation;
        }

        public void Add(Gamer gamer)
        {
            Console.WriteLine("Gamer Added..");
            _testValidation.Validate();
        }

        public void Delete()
        {
            Console.WriteLine("Gamer Deleted..");
        }

        public void Update()
        {
            Console.WriteLine("Gamer Updated..");
        }
    }
}
