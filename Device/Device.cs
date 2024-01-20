using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Device
{
    abstract internal class Device
    {
        public int height, width;
        string company;
        public int Height { get { return height; } set { height = value; } }
        public int Width { get { return width; } set { width = value; } }
        public string Company { get { return company; } set { company = value; } }
    }
}
