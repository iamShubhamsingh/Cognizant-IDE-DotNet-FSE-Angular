using PostWebApi.Interface;
using PostWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PostWebApi.Repository
{
    public class ClientRepository : IClient
    {        

        // Implement your code here
        List<Client> lsClients = StaticData.lsClients;
        
        public bool AddClient(Client client)
        {
            var isData = lsClients.Where(w => w.CaseId == client.CaseId).Any();
            if (isData)
            {
                return false;
            }
            
            lsClients.Add(client);
            return true;
        }

    }
}
	 	  	  		 	     	     	      	 	
