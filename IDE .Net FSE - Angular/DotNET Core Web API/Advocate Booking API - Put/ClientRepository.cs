using PutWebApi.Interface;
using PutWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PutWebApi.Repository
{
    public class ClientRepository : IClient
    {        

        // Implement your code here
        List<Client> lsClients = StaticData.lsClients;
        
        public bool UpdateClientMobile(int caseid, string phoneno)
        {
            if (caseid == 0 || phoneno == "")
            {
                return false;
            }
            Client b = lsClients.FirstOrDefault(c => c.CaseId == caseid);
            if(b != null)
            {
                lsClients.FirstOrDefault(c => c.CaseId == caseid).PhoneNumber = phoneno;
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
	 	  	  		 	     	     	      	 	
