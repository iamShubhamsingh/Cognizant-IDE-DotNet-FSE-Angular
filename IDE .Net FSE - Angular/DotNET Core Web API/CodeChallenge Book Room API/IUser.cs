using HotelWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace HotelWebApi.Interface
{
   public interface IUser
   {
       // Implement your code here
       bool AddUser(User user);
   }
}