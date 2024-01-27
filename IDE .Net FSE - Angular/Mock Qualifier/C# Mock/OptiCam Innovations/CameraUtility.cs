using System;
using System.Collections.Genric;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptiCamInnovations //DO NOT change the namespace name
{
    public class CameraUtility: Camera 
    {
        string[] validBrand = { "Canon", "Sony", "Nikon" };
        string[] validViewFinders = { "Electronic", "Optical", "LCD screen" };

        if(!validBrands.Contains(Brand) || Resolution < 12 || Resolution > 34 || Weight < 1 || Weight > 1000 || !validateViewFinders.Contains(ViewFinder))
        {
            return false;
        }
        return true;
    }

    public double CalculateCameraPrice()
    {
        double basicPrice = 0;
        switch (Brand)
        {
            case "Canon":
                basicPrice = 50000;
                break;
            case "Sony":
                basicPrice = 25000;
                break;
            case "Nikon":
                basicPrice = 15000;
                break;
        }
    }
}