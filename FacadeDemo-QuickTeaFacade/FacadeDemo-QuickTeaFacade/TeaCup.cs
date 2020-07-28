using System;

namespace FacadeDemo_QuickTeaFacade
{
    internal class TeaCup
    {

        internal void addWater(Water water)
        {
            water.boil();
        }

        internal void addTeaInfuser(TeaInfuser teaInfuser)
        {
            Console.WriteLine("Tea Infuser added");
        }

        internal void setSteepTime()
        {
            Console.WriteLine("Sleep 5 minutes");
        }

        internal void steep()
        {
            Console.WriteLine("Steeping");
        }
    }
}