using System;
using System.Collections.Genric;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptiCamInnovations 
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CameraUtility camera = new CameraUtility();
            Console.WriteLine("Enter the Brand");
            camera. Brand = Console.ReadLine();
            Console.WriteLine("Enter the Resolution");
            camera. Resolution = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Weight");
            camera.Weight = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the ViewFinder");
            camera.ViewFinder = Console.ReadLine();
            Console.WriteLine("Enter the Battery");
            camera. Battery = Convert.ToInt32(Console.ReadLine());
            if (camera. ValidateSpecification())
            {
                double price = camera. CalculateCameraPrice();
                Console.WriteLine($"Total Price is {price}");
            }
            else
            {
                Console.WriteLine("Invalid specification");
            }
        }
    }
}
