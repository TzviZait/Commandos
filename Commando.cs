using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commandos
{
    public class Commando
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
            Console.WriteLine("the commando is " + status);
        }

        public void Hide()
        {
            status = "Hiding";
            Console.WriteLine("the commando is " + status);
        }


        public virtual void Attack()
        {
            Console.WriteLine(codeName + " is attack");
        }

        public void SayName(string commanderRank,string name , string codeName)
        {
            Console.WriteLine(Permissions.PermissionsName(commanderRank,name,codeName));
        }


    }
}
