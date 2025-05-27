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
        public string codeName;
        string[] tolls;
        public string status;
        public Commando(string name, string codeName, string[] tolls, string status)
        {
            this.name = name;
            this.codeName = codeName;
            this.tolls = tolls;
            this.status = status;
        }

        public string CodeName { get; set; }

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
            Console.WriteLine(codeName + " is attack");
        }

        public string SayName(string commanderRank)
        {
            if (commanderRank == "general")
            {
                return "the attack name is: " + name;
            }

            else if (commanderRank == "colonel")
            {
                return "the attack cod name is: " + codeName;
            }

            else
            {
                return "Classified information";
            }
        }


    }
}
