using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElegantJewels   //DO NOT change the namespace name
{
    public class Service : Bill   //DO NOT change the class name
    {
        //Implement your code here
        public void ExtractDetails(string billDetails)
        {
            string[] billing = billDetails.Split(":");
            MetalName = billing[0];
            Weight = double.Parse(billing[1]);
            PurityOfMetal = double.Parse(billing[2]);
            WantDecoration = bool.Parse(billing[3]);
        }

        public bool ValidateMetalName()
        {
            if((MetalName=="Gold") || (MetalName=="Silver"))
            return true;
            return false;
        }

        public double CalculateTotalPrice()
        {
            if(MetalName=="Gold")
            {
                if(WantDecoration)
                return 50*PurityOfMetal*Weight*1.1;
                return 50*PurityOfMetal*Weight;
            }
            else
            {
                if(WantDecoration)
                return PurityOfMetal*Weight*1.1;
                return PurityOfMetal*Weight;
            }
        }
    }
}