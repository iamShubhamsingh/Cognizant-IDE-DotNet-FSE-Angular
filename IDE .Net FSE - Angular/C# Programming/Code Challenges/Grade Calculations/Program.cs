using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgFundamentals5    //DO NOT change the namespace name
{
    public class Program      //DO NOT change the class name
    {
        public static void Main(string[] args)   //DO NOT change the 'Main' Signature
        {
            //Implement the code here

            Console.WriteLine("Enter English marks :");
            int english = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Math marks :");
            int math = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Language marks :");
            int language = int.Parse(Console.ReadLine());

            if(english<0 || math<0 || language<0)Console.WriteLine("Mark cannot be less than 0");
            else{
                Console.WriteLine("English Grade : "+Grade(english));
                Console.WriteLine("Math Grade : "+Grade(math));
                Console.WriteLine("Language Grade : "+Grade(language));
            }
        }

        public static string Grade(int marks)
        {
            if(marks>=80 && marks<=100)return "A+";
            if(marks>=60)return "A";
            if(marks>=40)return "B";
            if(marks>=0)return "FAIL";
            return "Mark cannot be less thab 0";
        }
    }
} 