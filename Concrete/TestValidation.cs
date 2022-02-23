using GamePortal.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GamePortal.Concrete
{
    public class TestValidation : IGamerValidation
    {
        public void Validate()
        {
            Console.WriteLine("Validated..");
        }
    }
}
