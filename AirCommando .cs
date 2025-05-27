using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commandos
{
    internal class AirCommando : Commando
    {
        public AirCommando(string name, string codeName, string[] tolls, string status) : base(name, codeName, tolls, status)
        {
        }

        public void Parachute()
        {
            Console.WriteLine("Airborne commando drops into action!");
        }

        public override void Attack()
        {
            Console.WriteLine(codeName + " is attacking from the air!");
        } 
    }
}


