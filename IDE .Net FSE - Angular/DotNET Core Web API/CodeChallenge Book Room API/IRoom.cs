using HotelWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace HotelWebApi.Interface
{
   public interface IRoom
   {
       // Implement your code here
      List<Room> GetAllRooms();
      Room GetRoomById(int roomId);
   }
}