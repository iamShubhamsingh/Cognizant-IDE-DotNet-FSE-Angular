using DeleteWebApi.Interface;
using DeleteWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeleteWebApi.Repository
{
    public class ClientRepository : IClient
    {        

        // Implement your code here
        
        List<Client> lsClients = StaticData.lsClients;
        
        public bool RemoveClient(int id)
        {
            Client b = lsClients.FirstOrDefault(c => c.CaseId == id);
            if (b != null)
            {
                lsClients.Remove(b);
                return true;
            }
            else return false;
        }

    }
}
	 	  	  		 	     	     	      	 	
