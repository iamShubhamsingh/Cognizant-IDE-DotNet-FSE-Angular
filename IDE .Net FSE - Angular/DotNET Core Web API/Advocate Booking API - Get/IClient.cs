using GetWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GetWebApi.Interface
{
    public interface IClient
    {
        // Implement your code here
        
        List<Client> GetAllCases();
        Client GetClientByCaseId(int id);

    }
}
