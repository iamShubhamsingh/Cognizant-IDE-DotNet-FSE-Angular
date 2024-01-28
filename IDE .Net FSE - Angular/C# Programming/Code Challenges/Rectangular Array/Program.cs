using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangularArray    //DO NOT change the namespace name
{
    public class Program    //DO NOT change the class name
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");
            int num = Convert.ToInt32(Console.ReadLine());
            int[,] matrix = GetArray(num);

            //Display the matrix
            for(int i=0; i<num; i++)
            {
                for(int j=0; j<num; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        public static int[,] GetArray(int num)
        {
            int[,] result = new int[num, num];
            for (int i=0; i<num; i++)
            {
                for(int j=0; j<num; j++)
                {
                    if(i==j) result[i,j] = 0;  //Diagonal filled with 0
                    else if(i<j) result[i<j] = 1;  //Upper triangular side filled with 1
                    else result[i,j]= -1; //Lower triangular side filled with -1
                }
            }

            return result;
        }
    }
}