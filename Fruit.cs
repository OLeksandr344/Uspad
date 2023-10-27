using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uspadtask
{
    internal class Fruit
    {
        public string Name { get; set; }
        public Fruit(string name)
        {
            Name = name;
        }
    }
    class Apple : Fruit
    {
        public string Variety { get; set; }
        public string Color { get; set; }
        public Apple(string name, string variety, string color) : base(name)
        {
            Variety = variety;
            Color = color;
        }
    }
    class Pear : Fruit
    {
        public string Variety { get; set; }
        public string Color { get; set; }
        public Pear(string name, string variety, string color) : base(name)
        {
            Variety = variety;
            Color = color;
        }
    }
}
