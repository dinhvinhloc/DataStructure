using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week1SecA.Business;

namespace Week1SecA.Data
{
    class ClientDB
    {
        //Data Structure is an Fixed Length Array
        private Client[] clients = new Client[5];
        private int count = 0;

        public bool AddClient (Client client)
        {
            if (count < clients.Length)
            {
                clients[count] = client;
                count++;
                return true;
            }
            return false;
        }

        public Client[] GetClients()
        {
            return clients;
        }
    }
}
