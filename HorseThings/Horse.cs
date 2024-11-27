using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HorseThings
{
    internal class Horse
    {
        public string _name { get; set; }
        public string _color { get; set; }
        public int _speed { get; set; }

        public Horse(string name, string color, int speed)
        {
            _name = name;
            _color = color;
            _speed = speed;
        }

        public void WriteInfo()
        {
            Console.WriteLine($"Name: {_name}\nColor: {_color}\nSpeed: {_speed}");
        }
    }
}
