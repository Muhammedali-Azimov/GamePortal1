using GamePortal.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GamePortal.Entities
{
    class Campaign:IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Stars { get; set; }
    }
}
