using System;
using System.Collections.Generic;
namespace HotelWebApi.Models
{
   public class User
   {
       // Implement your code here
       public int Id { get; set; }
       public string EmailId { get; set; }
       public string IdentityNumber { get; set; }
       public string FirstName { get; set; }
       public string LastName { get; set; }
       public string PhoneNumber { get; set; }
       public string Gender { get; set; }
   }
}