using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace FlightBooking  //Do not change the namespace name
{
    public class Program //Do not change the class name
    {
        public static void Main(string[] args) //Do not change the 'Main' method signature
        {
            //Implement code here
            Console.WriteLine("Enter the choice");
            Console.WriteLine("1. Update Airplane Price Details");
            Console.WriteLine("Get Airplane By Id");
            Console.WriteLine("3. Corporate Booking");
            Console.WriteLine("4. Exit");

            int choice = int.Parse(Console.ReadLine());
            Program p = new Program();

            switch(choice)
            {
                case 1:
                    Console.WriteLine("Enter the AirplaneID:");
                    int id = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter the price info:");
                    int price = int.Parse(Console.ReadLine());
                    p.UpdateAirplanePrice(id, price);
                    break;
                case 2:
                    Console.WriteLine("Enter the Airplane Id:");
                    id = int.Parse(Console.ReadLine());
                    FlightBooking obj = p.GetAirplaneById(id);
                    Console.WriteLine("AirplaneID BookingFrom BookingTo TotalSeats TicketPrice SeatStatus");
                    Console.WriteLine(obj);
                    break;
                case 3:
                    Console.WriteLine("Enter the Corporate Code");
                    string code = Console.ReadLine();
                    Console.WriteLine("Enter the Number of Passenger");
                    int noOfPassenger = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter the Airplane ID");
                    id = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter the price info :");
                    price = int.Parse(Console.ReadLine());
                    Booking ap = p.GetAirplaneById(id);
                    int cost = p.CalculateCost(code, noOfPassenger, ap);
                    Console.WriteLine("Total Ticket Cost:"+cost);
                    break;
                case 4:
                    Environment.Exit(0);
                    break;
            }
        }

        public void UpdateAirplanePrice(int id, int price) //Do not change the method signature
        {
            //Implement code here
            DBConnection db = new DBConnection();
            SqlConnection connection = db.GetConnection();

            SqlCommand command = new SqlCommand();

            connection.Open();

            command.Connection = connection;
            command.CommandText = "UPDATE Booking SET TicketPrice = @Price WHERE AirplaneID = @ID";
            command.Parameters.Add("@ID",SqlDbType.Int);
            command.Parameters["@ID"].Value = id;
            command.Parameters.Add("@Price",SqlDbType.Int);
            command.Parameters["@Price"].Value = price;
            command. ExecuteNonQuery();

            connection.Close();
        }

        public Booking GetAirplaneById(int id) //Do not change the method signature
        {
            //Implement code here
            DBConnection db = new DBConnection();
            SqlConnection connection = db.GetConnection();

            SqlCommand command = new SqlCommand();

            connection.Open();

            command.Connection = connection;
            command.CommandText = "SELECT * FROM Booking WHERE AirplaneID = @ID";
            command.Parameters.Add("@ID",SqlDbType.Int);
            command.Parameters["@ID"].Value = id;

            SqlDataReader reader = command.ExecuteReader();

            Booking book = new Booking();

            while(reader.Read() && reader.HasRows)
            {
                int idCol = reader.GetOrdinal("AirplaneID");
                int bfCol = (int)reader.GetOrdinal("BookingFrom");
                int btCol = (int)reader.GetOrdinal("BookingTo");
                int tsCol = (int)reader.GetOrdinal("TotalSeats");
                int tpCol = (int)reader.GetOrdinal("TicketPrice");
                int ssCol = (int)reader.GetOrdinal("SeatStatus");

                book = new Booking(reader.GetInt32(idCol),reader.GetString(bfCol),reader.GetString(btCol),reader.GetInt32(tsCol),reader.GetInt32(tpCol),reader.GetString(ssCol));
            }

            connection.Close();

            return book;
        }

        public int CalculateCost(string corporateCode, int noOfPassenger, Booking booking)  //Do not change the method signature
        {
            //Implement code here
            int cost = noOfPassenger*booking.TicketPrice;
            if(corporateCode == "IBM123")
            {
                if(noOfPassenger <= 10) cost = (cost*9)/10;
                else cost = (cost*8)/10;
            }
            else if(corporateCode == "CTS001")
            {
                if(noOfPassenger <= 10) cost = (cost*95)/100;
                else cost = (cost*9)/10;
            }
            else if(corporateCode == "COMMON")
            {
                if(noOfPassenger <= 10) cost = (cost*98)/100;
                else cost = (cost*95)/100;
            }

            return cost;

        }
    }
}