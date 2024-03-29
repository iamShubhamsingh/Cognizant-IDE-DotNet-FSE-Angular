using Microsoft.AspNetCore.Mvc;
using DeleteWebApi.Interface;
using DeleteWebApi.Models;
using DeleteWebApi.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeleteWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientController : Controller
    {
        private IClient clients = new ClientRepository();

        // Implement your code here
        
        [HttpDelete("{id}")]
        [Route("~/api/[controller]/DeleteClient/{id}")]
        [Consumes(contentType: "application/json")]
        public IActionResult Delete(int id)
        {
            var result = clients.RemoveClient(id);
            if(result == false)
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
	 	  	  		 	     	     	      	 	
