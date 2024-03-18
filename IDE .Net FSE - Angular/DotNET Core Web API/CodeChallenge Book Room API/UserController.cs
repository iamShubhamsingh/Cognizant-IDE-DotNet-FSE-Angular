using Microsoft.AspNetCore.Mvc;
using HotelWebApi.Interface;
using HotelWebApi.Models;
using HotelWebApi.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace HotelWebApi.Controllers
{
   [Route("api/[controller]")]
   [ApiController]
   public class UserController : Controller
   {
       private IUser users = new UserRepository();
       // Implement your code here
       [HttpPost]
       [Route("~/api/[controller]/AddUser")]
       [Consumes(contentType: "application/json")]
       public IActionResult Post([FromBody] User user)
       {
           var result = users.AddUser(user);
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