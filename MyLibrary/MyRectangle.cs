using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MyLibrary
{
    public class MyRectangle
    {
        public int Witdh { get; set; }
        public int Height { get; set; }
        public int GetArea() { return Witdh * Height; }

    }
}
