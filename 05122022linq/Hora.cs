using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05122022linq
{
    internal class Hora
    {
        private string name;
        private int height;

        public Hora(string name, int height)
        {
            Name = name;
            Height = height;
        }

        public int Height { get => height; set => height = value; }
        public string Name { get => name; set => name = value; }
    }
}
