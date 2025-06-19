using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP_exe.Birds
{
    internal class DrorBird : ICanFly, IBird
    {
        public void Fly()
        {
            Console.WriteLine("Bird is flying...");
        }

        public void MakeBirdFly()
        {
            Fly();
        }

        public void NakeVoice()
        {
            Console.WriteLine("Re Re Re...");
        }
    }
}