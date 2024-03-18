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
   public class RoomController : Controller
   {
       private IRoom rooms = new RoomRepository();
       // Implement your code here
       [HttpGet]
       [Route("~/api/[controller]/GetAllRooms")]
       public ActionResult<List<Room>> GetAll()
       {
           return rooms.GetAllRooms();
       }
       [HttpGet("{id}")]
       [Route("~/api/[controller]/GetRoomById/{id}")]
       public ActionResult<Room> GetById(int id)
       {
           return rooms.GetRoomById(id);
       }
   }                  
}