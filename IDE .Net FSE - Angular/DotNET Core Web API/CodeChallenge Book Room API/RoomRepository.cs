using HotelWebApi.Interface;
using HotelWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace HotelWebApi.Repository
{
   public class RoomRepository : IRoom
   {            
       /*List<Room> listRooms = new List<Room>
       {
           new Room{RoomId=101, HotelId=2001, Type=RoomType.Single, Status=RoomStatus.Occupied, Price=1200.00 },
           new Room{RoomId=201, HotelId=2001, Type=RoomType.Double, Status=RoomStatus.UnOccupied, Price=2700.00 },
           new Room{RoomId=301, HotelId=2001, Type=RoomType.Deluxe, Status=RoomStatus.Occupied, Price=5000.00 },
           new Room{RoomId=501, HotelId=2005, Type=RoomType.Single, Status=RoomStatus.UnOccupied, Price=1250.00 },
           new Room{RoomId=601, HotelId=2005, Type=RoomType.Double, Status=RoomStatus.UnOccupied, Price=2900.00 },
           new Room{RoomId=701, HotelId=2005, Type=RoomType.Deluxe, Status=RoomStatus.Occupied, Price=5500.00 },
       };*/

       // Implement your code here
       List<Room> lsRooms = StaticData.lsRooms;
       public List<Room> GetAllRooms()
       {
           return lsRooms;
       }
       public Room GetRoomById(int roomId)
       {
           return lsRooms.FirstOrDefault(x => x.Id == roomId);
       }
   }
}