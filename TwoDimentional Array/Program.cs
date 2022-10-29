using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoDimentional_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string[] cities = new string[] { "Dhaka", "Rajshahi", "Mymensing", "Sylet", "Barishal" };


            for(int i = 0; i < cities.Length; i++)
            {
                Console.WriteLine(cities[i]);
            }

            int[,] number = new int[2, 3];

            number[0, 0] = 1;
            number[0, 1] = 2;
            number[0, 2] = 3;
            number[1, 0] = 4;
            number[1, 1] = 5;
            number[1, 2] = 6;

            for(int i=0; i<number.GetLength(0); i++){
                
                for(int j=0; j<number.GetLength(1); j++)
                {
                    Console.Write($"{number[i, j]} \t");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }//Main
    }//Class
}//Namespace
