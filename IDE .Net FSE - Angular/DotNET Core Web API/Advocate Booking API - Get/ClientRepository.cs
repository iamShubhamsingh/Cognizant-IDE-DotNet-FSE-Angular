using GetWebApi.Interface;
using GetWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GetWebApi.Repository
{
    public class ClientRepository : IClient
    {        

        // Implement your code here
        
        List<Client> lsClients = StaticData.lsClients;
        
        public List<Client> GetAllCases()
        {
            return lsClients;
        }
        
        public Client GetClientByCaseId(int id)
        {
            return lsClients.FirstOrDefault(x => x.CaseId == id);
        }

    }
}
	 	  	  		 	     	     	      	 	
