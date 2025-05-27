using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commandos
{
    internal class Weapon
    {
        public string name;
        public string manufacturer;
        public int bulletCount;

        public Weapon(string name, string manufacturer, int bulletCount)
        {
            this.name = name;
            this.manufacturer = manufacturer;
            this.bulletCount = bulletCount;
        }

        public void Shoot()
        {
            if (bulletCount > 0)
            {
                bulletCount--;
                Console.WriteLine($"Shot fired from {name}. Remaining bullets: {bulletCount}");
            }
            else
            {
                Console.WriteLine($"No bullets left in {name}.");
            }
        }
    }
}
