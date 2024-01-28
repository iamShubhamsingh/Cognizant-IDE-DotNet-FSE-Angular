using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Motors_Hut   //DO NOT change the namespace name
{
    public class Program  //DO NOT change the class name
    {
        public static void Main(string[] args)  //DO NOT the 'Main' method Signature
        {
            //Implement your code here
            Console.WriteLine("Enter the parking details");
            string query = Console.ReadLine();
            Service s = new Service();
            s.ExtractDetails(query);
            if(s.ValidateVehicleType())
            Console.WriteLine("The amount to be paid: "+s.CalculateTotalAmount());
            else
            Console.WriteLine("Invalid vehicle type");
        }
    }
}