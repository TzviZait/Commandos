using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Commandos
{
    internal static class Permissions
    {
        public static string PermissionsName(string commanderRank, string name , string codeName)
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
