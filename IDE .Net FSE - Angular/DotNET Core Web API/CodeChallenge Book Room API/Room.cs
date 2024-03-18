using System;
namespace HotelWebApi.Models
{
   public class Room
   {
       // Implement your code here
       public int Id { get; set; }
       public string Type { get; set; }
       public bool IsOccupied { get; set; }
       public double Price { get; set; }
   }
}