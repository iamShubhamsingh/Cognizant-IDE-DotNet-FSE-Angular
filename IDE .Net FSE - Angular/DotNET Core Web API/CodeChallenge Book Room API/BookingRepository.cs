using HotelWebApi.Interface;
using HotelWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace HotelWebApi.Repository
{
   public class BookingRepository : IBooking
   {
       /*List<Booking> listBooking = new List<Booking>
       {
           new Booking{BookingId=50101, UserId=10001, BookedRooms=new Room { RoomId = 101, HotelId = 2001, Type = RoomType.Single, Status = RoomStatus.Occupied, Price = 1200.00 } , Paymentstatus=PaymentStatus.PAID, StartDate="12/12/2021", EndDate="15/12/2021"},
           new Booking{BookingId=60102, UserId=10002, BookedRooms=new Room{RoomId=301, HotelId=2001, Type=RoomType.Deluxe, Status=RoomStatus.Occupied, Price=5000.00 } , Paymentstatus=PaymentStatus.PAID, StartDate="12/12/2021", EndDate="15/12/2021"},
           new Booking{BookingId=70103, UserId=10003, BookedRooms=new Room{RoomId=701, HotelId=2005, Type=RoomType.Deluxe, Status=RoomStatus.Occupied, Price=5500.00 } , Paymentstatus=PaymentStatus.PAID, StartDate="12/12/2021", EndDate="15/12/2021"},

       }; */
       // Implement your code here
       List<Booking> lsBooking = StaticData.lsBooking;
       public bool UpdatePaymentStatus(int bookingid)
       {
           Booking b = lsBooking.SingleOrDefault(c => c.Id == bookingid);
           if(b != null)
           {
               return true;
           }
           else
           {
               return false;
           }
       }
   }
}