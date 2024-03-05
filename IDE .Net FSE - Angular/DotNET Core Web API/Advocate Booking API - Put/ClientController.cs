using Microsoft.AspNetCore.Mvc;
using PutWebApi.Interface;
using PutWebApi.Models;
using PutWebApi.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PutWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientController : ControllerBase
    {
        private IClient clients = new ClientRepository();

        // Implement your code here
        
        [HttpPut("{id}")]
        [Route("~/api/[controller]/UpdateMobile/{id}")]
        [Consumes(contentType: "application/json")]
        
        public async Task<IActionResult> UpdateMobile(int id, [FromBody] string phoneno)
        {
            Console.WriteLine("--1--id" + id + "---mobile----" + phoneno);
            var result = clients.UpdateClientMobile(id, phoneno);
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
	 	  	  		 	     	     	      	 	
