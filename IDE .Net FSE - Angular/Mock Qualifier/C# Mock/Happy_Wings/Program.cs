using System;
using System.Collections.Genric;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Happy_Wings   //DO NOT change the namespace name
{
    public class program   //DO NOT change the class name
    {
        public static Dictionary<string, int> BirdDetails = new Dictionary<string, int>();

        //Implement the methods as per the description
        public void AddBirdDetails(string[] bird)
        {
            foreach(string b in bird)
            {
                string[] arr b.Split(":");
                BirdDetails.Add(arr[0], int.Parse(arr[1]));
            }
        }

        public int FindTheBirdCount(string birdName)
        {
            if(BirdDetails.ContainsKey(birdName))
            {
                return BirdDetails[birdName];
            }
            else return -1;
        }

        public List<string> FindTheHighestCountOfBird()
        {
            List<string> Lister = new List<string>();
            int max = int.MinValue;
            foreach(var b in BirdDetails)
            {
                if(max<b.Value)
                {
                    max = b.Value;
                }
            }
            foreach(var b in BirdDetails)
            {
                if(b.Value==max)
                {
                    Lister.Add(b.Key);
                }
            }
            return Lister;
        }

        public static void Main(string[] args)   //DO NOT change the method signature
        {
            program p = new program();
            bool flag = true;
            while(flag)
            {
                Console.WriteLine("1.Add Bird Details");
                Console.WriteLine("2.View Number of Bird By Bird Name");
                Console.WriteLine("3. View Birds with Highest Count");
                Console.WriteLine("4. Exit");
                Console.WriteLine("Enter the Choice");
                int choice = int.Parse(Console.ReadLine());
                switch(choice)
                {
                    case 1:
                        Console.WriteLine("Enter the number of entries");
                        int entries = int.Parse(Console.ReadLine());
                        string[] bird = new string[entries];
                        for(int i=0; i<entries; i++)
                        {
                            bird[i] = Console.ReadLine();
                        }
                        p.AddBirdDetails(bird);
                        break;
                    case 2:
                        Console.WriteLine("Enter the bird name to get the number of birds");
                        string birdName = Console.ReadLine();
                        int result = p.FindTheBirdCount(birdName);
                        if(result != 1)
                        {
                            Console.WriteLine("Number of Birds : {0}", result);
                        }
                        else
                            Console.WriteLine("No of birds are available");
                        break;
                    case 3:
                        List<string> lister = p.FindTheHighestCountOfBird();
                        foreach(string s in lister)
                        {
                            Console.WriteLine(s);
                        }
                        break;
                    case 4:
                        Console.WriteLine("Thank-You");
                        flag = false;
                        break;
                }
            }
        }
    } 
}