using HotelWebApi.Interface;
using HotelWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace HotelWebApi.Repository
{
   public class UserRepository : IUser
   {        
       /*List<User> listUsers = new List<User>
       {
           new User{UserId=10001, EmailId="user1@test.com", AadhaarNumber="123400000011", FirstName="Raj", LastName="Kumar", PhoneNumber="1234567890", Gender="Male" },
           new User{UserId=10002, EmailId="user2@test.com", AadhaarNumber="123400000021", FirstName="Aravind", LastName="Swamy", PhoneNumber="2334567890", Gender="Male" },
           new User{UserId=10003, EmailId="user3@test.com", AadhaarNumber="123400000031", FirstName="Rahul", LastName="Dravid", PhoneNumber="3234567890", Gender="Male" },
           new User{UserId=10004, EmailId="user4@test.com", AadhaarNumber="123400000041", FirstName="Preethi", LastName="Singh", PhoneNumber="4123567890", Gender="Female" },
           new User{UserId=10005, EmailId="user5@test.com", AadhaarNumber="123400000051", FirstName="Laxmi", LastName="Devi", PhoneNumber="2345167890", Gender="Female" },

       };*/

       // Implement your code here
       List<User> lsUsers = StaticData.lsUsers;
       public bool AddUser(User user)
       {
           var isData = lsUsers.Where(w => w.Id == user.Id).Any();
           if(isData)
           {
               return false;
           }
           lsUsers.Add(user);
           return true;
       }
   }
}