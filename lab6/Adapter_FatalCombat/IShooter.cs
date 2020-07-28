namespace Adapter_FatalCombat
{
    internal interface IShooter
    {
        void incHealth(); //health++
        void decHealth(); //health--
        int getHealth();
    }
}