using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP_exe.Birds
{
    internal class Penguin : IBird
    {
        public void NakeVoice()
        {
            Console.WriteLine("Ko Ko Ko...");
        }
    }
}
