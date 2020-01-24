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
            double[] gradeArray = { 50, 23, 99, 85, 88, 42, 49, 87, 89, 77 };

            GradePredicate greaterVal = IsGreater;

            // create an instance of the NumberPredicate delegate type using an
            // implicit lambda expression
            greaterVal = grade => grade >= 50;

            // call a lambda expression through a variable
            Console.WriteLine($"Use a lamda-expression variable: {greaterVal(1.3)}");

            // filter the even numbers using a lambda expression
            double[] overGrade = GradesFilter(gradeArray, greaterVal);
        }

        //display grades values which are >= 50
        //should take an array of type doubles and second argument is a variable of
        //Graderpredicate
        //no retun type
        public static void GradesFilter(double[] grade, GradePredicate gradePredicate)
        {
            Console.WriteLine("blar blar");
        }
        /*
        private static bool IsGreater(double grade)
        {
            if (grade >= 50)
                return true;
            else
                return false;
        }*/
    }
}
