using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace chel_pr5
{
    class Liquid
    {
        public string Title { get; set; }
        public int Volume { get; set; }
        public int Density { get; set; }
        public Liquid()
        {
            Title = string.Empty;   
            Volume = 0;
            Density = 0;
        }
        public Liquid(string title)
        {
            Title = title;
        }
        public Liquid SetParams(string title, int volume, int density)
        {
            Title = title;
            Volume = volume;
            Density = density;
            return this;
        }
        public Liquid SetParams(int volume)
        {
            Volume = volume;
            return this;
        }
        public static bool operator ==(Liquid c1, Liquid c2)
        {
            bool result;
            if (c1.Volume == c2.Volume) result = true;
            else result = false;
            return result;
        }
        public static bool operator !=(Liquid c1, Liquid c2)
        {
            bool result;
            if (c1.Volume == c2.Volume) result = true;
            else result = false;
            return result;
        }
        public static Liquid operator --(Liquid c1)
        {
            Liquid result = new Liquid();
            result.Volume = c1.Volume - 1;
            return result;
        }
        public static Liquid operator ++(Liquid c1)
        {
            Liquid result = new Liquid();
            result.Volume = c1.Volume + 1;
            return result;
        }
    }
}
