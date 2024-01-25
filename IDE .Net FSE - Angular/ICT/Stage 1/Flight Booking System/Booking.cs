using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightBooking  //Do not cahnge the namespace name
{
    public class Booking  //Do not change the class name
    {
        //Implement properties

        public int AirplaneID { get; set; }
        public string BookingFrom { get; set; }
        public string BookingTo { get; set; }
        public int TotalSeats { get; set; }
        public int TicketPrice { get; set; }
        public string SeatStatus { get; set; }

        public Booking()
        {

        }

        public Booking(int id, string bookingFrom, string bookingTo, int seats, int price, string status)
        {
            AirplaneID = id;
            BookingFrom = bookingFrom;
            BookingTo = bookingTo;
            TotalSeats = seats;
            TicketPrice = price;
            SeatStatus = status;
        }

        public override string ToString()
        {
            return AirplaneID+" "+BookingFrom+" "+BookingTo+" "+TotalSeats+" "+TicketPrice+" "+SeatStatus;
        }
    }
}