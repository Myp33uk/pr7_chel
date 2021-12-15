using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chel_pr5
{
    class Alcohol : Liquid
    {
        public double Strength { get; set; }
        public Alcohol() {}
        public Alcohol(string title, double strenght) : base(title)
        {
            Strength = strenght;
        }
        public Alcohol SetParams(double strength)
        {
            Strength = strength;
            return this;
        }
    }
    class Beer : Alcohol
    {
        public double Hops { get; set; }
        public Beer() {}
        public Beer(string title, double strenght, double hops) : base(title, strenght)
        {
            Hops = hops;
        }
        public Beer SetParams(double strength, double hops)
        {
            Strength = strength;
            Hops = hops;
            return this;
        }
    }
}
