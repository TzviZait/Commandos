using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Commandos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Commando commando = new Commando("tzvi", "z", new string[] { "knife", "grenade" , "rifle" }, "Waiting");
            commando.Walk();
            commando.Hide();
            commando.Attack();

            Weapon weapon = new Weapon("M16", "Raphael", 30);
            weapon.Shoot();
            Console.WriteLine(commando.SayName("general"));
            Console.WriteLine(commando.codeName);
            commando.CodeName = "t";
            Console.WriteLine(commando.CodeName);

            AirCommando airCommando = new AirCommando("tzvi", "z", new string[] { "knife", "grenade", "rifle" }, "Waiting");
            airCommando.Parachute();

            SeaCommando seaCommando = new SeaCommando("tzvi", "z", new string[] { "knife", "grenade", "rifle" }, "Waiting");
            seaCommando.Swim();

            Commando[] commandos = { commando, airCommando, seaCommando };
            foreach (var c in commandos)
            {
                Console.WriteLine(c.GetType());
                c.Attack();
            }
        }
    }
}
