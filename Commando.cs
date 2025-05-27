using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commandos
{
    internal class Commando
    {
        private string name;
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

        public string SayName(string commanderRank)
        {
            if (commanderRank == "general")
            {
                return name;
            }

            else if (commanderRank == "colonel")
            {
                return codName;
            }

            else 
            {
                return "Classified information";
            }
        }

    }
}
