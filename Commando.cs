using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commandos
{
    internal class Commando
    {
        public string name;
        public string codName;
        string[] tolls;
        public string status;
        public Commando(string name, string codName, string[] tolls, string status)
        {
            this.name = name;
            this.codName = codName;
            this.tolls = tolls;
            this.status = status;
        }


        public void Walk()
        {
            status = "Walking";
            Console.WriteLine(status);
        }

        public void Hide()
        {
            status = "Hiding";
            Console.WriteLine(status);
        }


        public void Attack()
        {
            Console.WriteLine(codName + " is attack");
        }

    }
}
