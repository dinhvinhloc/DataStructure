using System;

namespace FacadeDemo_QuickTeaFacade
{
    internal class QuickTea
    {
        TeaCup teacup = new TeaCup();
        Tea tea = new Tea();
        TeaInfuser teaInfuser = new TeaInfuser();

        Water water = new Water();

        internal void MakeTea()
        {
            teaInfuser.addTea(tea);
            water.boil();
            teacup.addWater(water);
            teacup.addTeaInfuser(teaInfuser);
            teacup.setSteepTime();
            teacup.steep();

            Console.ReadLine();

        }
    }
}