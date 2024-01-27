using System;
using System.Collections.Genric;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Treasure_Mine
{
    public class Program
    {
        public static Dictionary<string, int> ProductDetails { get; set; } = new Dictionary<string, int>();
        public static void AddProductDetails(string itemName, int quantity)
        {
            ProductDetails[itemName] = quantity;
        }

        public static List<string> CheckReorderLevel(int reorderLevel)
        {
            List<string> reorderItems = new List<string>();
            foreach (var item in ProductDetails)
            {
                if(item.Value < reorderLevel)
                {
                    reorderItems.Add(item.Key);
                }
            }
            return reorderItems;
        } 

        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of products");
            int numProducts = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < numProducts; i++)
            {
                Console.WriteLine("Enter the item name");
                string itemName = Console.ReadLine();
                Console.WriteLine("Enter the stock quantity");
                int quantity = Convert.ToInt32(Console.ReadLine());
                AddProductDetails(itemName, quantity);
            }

            Console.WriteLine("Enter re-order level");
            int reorderLevel = Convert.ToInt32(Console.ReadLine());

            List<string> reorderItems = CheckReorderLevel(reorderLevel);

            if(reorderItems.Count > 0)
            {
                Console.WriteLine("List of Products - reorder level below " + reorderLevel);
                foreach (string item in reorderItems)
                {
                    Console.WriteLine(item);
                }
            }
            else{
                Console.WriteLine("No need for reorder");
            }
        }
    }
}