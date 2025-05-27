using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commandos
{
    internal class SeaCommando : Commando
    {
        public SeaCommando(string name, string codeName, string[] tolls, string status) : base(name, codeName, tolls, status)
        {
        }
        public void Swim()
        {
            Console.WriteLine("Sea commando swims into action!");
        }
    }
}
