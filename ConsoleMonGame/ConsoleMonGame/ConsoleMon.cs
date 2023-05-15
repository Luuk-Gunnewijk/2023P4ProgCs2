using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMonGame
{
    internal class ConsoleMon
    {
        internal int health;
        internal int energy;
        internal string name;

        private List<Skill> skill = new List<Skill>();

        public void TakeDamage(int damage)
        {
            health -= damage;
        }

        public void DepleteEnergy(int energy)
        {
            this.energy -= energy;
        }
    }
}
