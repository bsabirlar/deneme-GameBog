using GameBog.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameBog.Entity
{
    class Campaigne:IEntity
    {
        public int Id { get; set; }
        public string CompanyName { get; set; }
        public string CompanyMath { get; set; }
    }
}
