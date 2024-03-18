using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace HotelWebApi.Models
{
   public class Booking
   {
       // Implement your code here
       public int Id { get; set; }
       public int UserId { get; set; }
       public Room Room { get; set; }
       public bool IsPaid { get; set; }
       public string StartDate { get; set; }
       public string EndDate { get; set; }
   }
}