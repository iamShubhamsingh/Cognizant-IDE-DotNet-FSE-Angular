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
   public class BookingController : Controller
   {
       private IBooking bookings = new BookingRepository();

       // Implement your code here
       [HttpPut("{id}")]
       [Route("~/api/[controller]/UpdatePaymentStatus/{id}")]
       [Consumes(contentType: "application/json")]
       public IActionResult BookingUpdate(int id)
       {
           var result = bookings.UpdatePaymentStatus(id);
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
