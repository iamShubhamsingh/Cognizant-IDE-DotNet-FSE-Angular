using HotelWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace HotelWebApi.Interface
{
   interface IBooking
   {
       bool UpdatePaymentStatus(int bookingid);
   }
}