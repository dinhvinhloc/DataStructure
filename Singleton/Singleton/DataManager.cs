using System;

namespace Singleton
{
    internal class DataManager
    {
        private static DataManager dataManagetInstance;
        //private static DataManager dataManagetInstance = new DataManager();

        //Eager Instantiation
        private DataManager()
        {
        }

        public static DataManager GetDataManager()
        {
            if (dataManagetInstance == null)
            {
                dataManagetInstance = new DataManager();
            }
            return dataManagetInstance;
        }

        internal string getInfo()
        {
            return "Data Manager Unique Instance";
        }
    }
}