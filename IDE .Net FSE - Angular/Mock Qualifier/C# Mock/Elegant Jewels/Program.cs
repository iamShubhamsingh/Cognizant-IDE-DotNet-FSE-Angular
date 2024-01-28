using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElegantJewels   //DO NOT change the namespace name
{
    public class Program  //DO NOT change the class name
    {
        public static void Main(string[] args)  //DO NOT the 'Main' method Signature
        {
            //Implement your code here
            Console.WriteLine("Enter the bill details");
            string billDetails = Console.ReadLine();
            Service s = new Service();
            s.ExtractDetails(billDetails);
            if(s.ValidateMetalName())
            Console.WriteLine("The bill amount is: "+s.CalculateTotalPrice());
            else
            Console.WriteLine("Invalid metal name");
        }
    }
}