using GamePortal.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GamePortal.Entities
{
    public class Game:IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Cost { get; set; }
    }
}
