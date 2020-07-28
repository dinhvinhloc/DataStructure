namespace Adapter_FatalCombat
{
    internal class ObjAdShooter : IShooter
    {
        Warrior warrior = new Warrior();
        public void decHealth()
        {
            warrior.subHealth(1);
        }

        public int getHealth()
        {
            return warrior.getHealth();
        }

        public void incHealth()
        {
            warrior.addHealth(1);
        }
    }
}