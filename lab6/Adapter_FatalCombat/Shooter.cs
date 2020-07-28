namespace Adapter_FatalCombat
{
    internal class Shooter : Warrior, IShooter
    {
        public Shooter()
        {
        }
         
        public void decHealth()
        {
            subHealth(1);
        }

        public void incHealth()
        {
            addHealth(1);
        }
    }
}