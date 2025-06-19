using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP_exe.Shapes
{
    internal class Rectangle : IShape
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public int Area()
        { return Width * Height; }
    }

}
