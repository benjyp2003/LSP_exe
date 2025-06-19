using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP_exe.Shapes
{
    internal interface IShape
    {
        int Width { get; set; }
        int Height { get; set; }

        int Area();
    }
}
