using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week1SecA.Business;

namespace Week1SecA.Data
{
    public class ClientDBList
    {
        private List<Client> clientList = new List<Client>();

        public bool AddClient (Client client)
        {
            if (clientList.Contains(client))
                return false;
            else
            {
                clientList.Add(client);
                return true;
            }
        }

        public bool RemoveCLient(Client client)
        {
            if (clientList.Contains(client))
            {
                clientList.Remove(client);
                return true;
            }
            else return false;
        }

        public List<Client> GetClient()
        {
            return clientList;
        }
    }
}
