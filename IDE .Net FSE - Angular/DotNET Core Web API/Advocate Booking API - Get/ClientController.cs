using Microsoft.AspNetCore.Mvc;
using GetWebApi.Interface;
using GetWebApi.Models;
using GetWebApi.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GetWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientController : ControllerBase
    {
        private IClient clients = new ClientRepository();

        // Implement your code here
        
        [HttpGet]
        [Route("~/api/[controller]/GetAllCases")]
        
        public ActionResult<List<Client>> GetAll()
        {
            return clients.GetAllCases();
        }
        
        [HttpGet("{id}")]
        [Route("~/api/[controller]/GetClientByCaseId/{id}")]
        public ActionResult<Client> GetById(int id)
        {
            return clients.GetClientByCaseId(id);
        }

    }
}
	 	  	  		 	     	     	      	 	
