using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01
{
    //method that returns smallest string value
    public delegate string Minimum(string s1, string s2, string s3);
    public delegate void AvgGrade(double d1, double d2, double d3);

    class Program
    {
        static void Main(string[] args)
        {
            //print using delegate
            Minimum min = Smallest;
            Console.WriteLine("Delegate values--------------------------------------------");
            Console.WriteLine($"    Shortest string: {min("Apple", "Banana", "Cherry")}");
            AvgGrade avgGrade = AverageGrade;
            avgGrade(98.9, 92, 89.1);
            Console.WriteLine("");

            //3 string parameters to input and 1 return string type
            Func<string, string, string, string> func1;
            //only 3 double and no returning type
            Action<double, double, double> act1;

            //built-in delegate 
            func1 = Smallest;   //Func
            act1 = AverageGrade;   //Action

            //print using with Predicate
            Console.WriteLine("Built-in Delegate values------------------------------------");
            Console.WriteLine($"    Shortest string: {Smallest("Korea", "Canada", "UnitedKingdom")}");
            act1(60,70,80);
            Console.WriteLine("");
        }
        private static string Smallest(string s1, string s2, string s3)
        {
            string[] fruits = new string[3]
            {
                s1, s2, s3
            };

            var shortestString = fruits.OrderBy(c => c.Length).FirstOrDefault();
            
            return shortestString;
        }

        private static void AverageGrade(double d1, double d2, double d3)
        {
            double[] grades = { d1, d2, d3 };

            var result = grades.Average();

            Console.WriteLine("     Average Grade: {0}", result);
        }
    }
}
