using GamePortal.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GamePortal.Entities
{
    public class Gamer:IEntity
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
    }
}
