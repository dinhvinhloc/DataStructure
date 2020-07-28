using System.Collections.Generic;

namespace Singleton_Lab
{
    internal class Labs
    {
        private List<string> labsList = new List<string>(new string[] { "J129","J130", "J131", "J133", "J135", "J140"});
        private static Labs theLab;
        private Labs()
        {
        }

        internal List<string> GetLabsList()
        {
            return labsList;
        }

        public static Labs GetLabs()
        {
            if (theLab == null)
            {
                theLab = new Labs();
            }
            return theLab;
        }

    }
}