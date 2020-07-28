using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter_FatalCombat
{
    class Warrior
    {
        private int health = 100;
        public void addHealth(int amt) { health += amt; }
        public void subHealth(int amt) { health -= amt; }
        public int getHealth() { return health; }

    }
}

