using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise02
{
    class Program
    {
        //delegate 
        public delegate bool GradePredicate(double grade);

        static void Main(string[] args)
        {
            double[] gradeArray = { 50, 23, 32, 85, 88, 42, 49, 87, 89, 77 };

            //create local variable
            GradePredicate greaterVal;
            
            // create an instance of the NumberPredicate delegate type using an
            // implicit lambda expression
            greaterVal = grade => grade >= 50;

            //display list
            GradesFilter(gradeArray, greaterVal);
        }

        //method that has no retun type
        public static void GradesFilter(double[] grade, GradePredicate gradePredicate)
        {
            // all values of grades
            Console.WriteLine("All grades that this student have: ");
            foreach (double num in grade)
            {
                Console.Write(num+" ");
            }

            //filtering
            Console.WriteLine("\n\nUse a lamda expression to filter [Greater than 50]: ");
            foreach (double item in grade)
            {
                if (gradePredicate(item))
                {
                    Console.Write($"{item} ");
                }
            }

            Console.WriteLine("\n");
        }
        
    }
}
