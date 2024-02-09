using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mountain_Height     //Do NOT change the namespace name
{
    public class Program    //DO NOT change the class name
    {
        public static Dictionary<string, int> MountainDetails = new Dictionary<string, int>();

        //Implement the methods as per the description

        public void AddMountainDetails(string[] mountain)
        {
            foreach(var val in mountain)
            {
                string[] lists = val.Split(":");
                MountainDetails.Add(lists[0],int.Parse(lists[1]));
            }
        }

        public int FindMountainHeight(string mountainName)
        {
            if(MountainDetails.ContainsKey(mountainName))return MountainDetails[mountainName];
            return -1;
        }

        public List<string> FindTheHighestMountains()
        {
            int maxi = 0;
            foreach(KeyValuePair<string,int> val in MountainDetails)
            {
                if(val.Value>maxi)maxi=val.Value;
            }
            
            List<string> ans = new List<string>();
            foreach(KeyValuePair<string,int> val in MountainDetails)
            {
                if(val.Value==maxi)ans.Add(val.Key);
            }
            return ans;
        }

        public static void Main(string[] args)   //DO NOT change the method signature
        {
            //Implement your code here

            Console.WriteLine("1. Add Mountain Details");
            Console.WriteLine("2. View Mountain Height");
            Console.WriteLine("3. View Mountains with Highest Height");
            Console.WriteLine("4. Exit");
            Console.WriteLine("Enter the choice");
            int choice = int.Parse(Console.ReadLine());

            Program p =new Program();

            switch(choice)
            {
                case 1:
                    Console.WriteLine("Enter the number of entries");
                    int entries = int.Parse(Console.ReadLine());
                    string[] mountains = new string[entries];
                    for(int i=0;i<entries;i++)
                    {
                        mountains[i]=Console.ReadLine();
                    }
                    p.AddMountainDetails(mountains);
                    break;
                case 2:
                    Console.WriteLine("Enter the mountain name needs to be searched");
                    string name = Console.ReadLine();
                    int height = p.FindMountainHeight(name);
                    if(height==-1)Console.WriteLine("No mountains are available");
                    else Console.WriteLine("Height is : "+height);
                    break;
                case 3:
                    Console.WriteLine("Mountain names with the highest height are:");
                    List<string>mountainsList=p.FindTheHighestMountains();
                    foreach(var val in mountainsList)Console.WriteLine(val);
                    break;
                case 4:
                    Console.WriteLine("Thank you.");
                    break;
            }
        }
    }
}