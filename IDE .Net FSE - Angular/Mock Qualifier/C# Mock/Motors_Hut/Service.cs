using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Motors_Hut   //DO NOT change the namespace name
{
    public class Service : Parking   //DO NOT change the class name
    {
        //Implement your code here
        public void ExtractDetails(string parkingDetails)
        {
            string[] parkingstr = parkingDetails.Split(":");
            VehicleNumber = parkingstr[0];
            Vehicletype = parkingstr[1];
            NumberOfDays = Int32.Parse(parkingstr[2]);
        }

        public bool ValidateVehicleType()
        {
            if((VehicleType=="2 Wheeler") || (VehicleType=="3 Wheeler") || (VehicleType=="4 Wheeler"))
            return true;
            return false;
        }

        public double CalculateTotalAmount()
        {
            if(VehicleType=="2 Wheeler")
            return NumberOfDays * 50;
            else if (VehicleType=="3 Wheeler")
            return NumberOfDays * 70;
            else
            return NumberOfDays * 100;
        }
    }
}