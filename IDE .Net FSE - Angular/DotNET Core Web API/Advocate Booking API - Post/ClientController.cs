using Microsoft.AspNetCore.Mvc;
using PostWebApi.Interface;
using PostWebApi.Models;
using PostWebApi.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PostWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientController : ControllerBase
    {
        private IClient clients = new ClientRepository();

        // Implement your code here
        
        [HttpPost]
        [Route("~/api/[controller]/AddClient")]
        [Consumes(contentType: "application/json")]
        
        public IActionResult Post([FromBody] Client client)
        {
            var result = clients.AddClient(client);
            if (result == false)
            {
                return StatusCode(500);
            }
            else
            {
                return Ok(result);
            }
        }

    }
}
	 	  	  		 	     	     	      	 	
