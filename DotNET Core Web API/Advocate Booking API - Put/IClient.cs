using PutWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PutWebApi.Interface
{
    public interface IClient
    {
        // Implement your code here
        
        bool UpdateClientMobile(int caseid, string phoneno);

    }
}
