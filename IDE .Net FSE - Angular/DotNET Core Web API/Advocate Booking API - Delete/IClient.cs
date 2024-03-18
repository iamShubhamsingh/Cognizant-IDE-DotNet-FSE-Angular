using DeleteWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeleteWebApi.Interface
{
    public interface IClient
    {
        // Implement your code here
        bool RemoveClient(int id);

    }
}
