
using LSP_exe.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP_exe
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }



        static void TestArea(IShape shape)
        {
             int area = shape.Area();
             Console.WriteLine(area);
        }
    }
}


