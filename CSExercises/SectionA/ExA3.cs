using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    //Write a program that will takes an integer as input and prints the square of that number
    //For this exercise, the input and output has been implemented for you in the template
    //You need to implement the square function

    public class ExA3
    {
        public static void Main(string[] args)
        {
            string inputString = Console.ReadLine();
            int inputInt = Convert.ToInt32(inputString);

            int result = square(inputInt);

            Console.WriteLine(result);
        }

        public static int square(int x)
        {
            int num1, result;
            //Displaying message
            Console.WriteLine("Please enter value");

            //Accepting Value in num1
            num1 = Int32.Parse(Console.ReadLine());
            result = num1 * num1; //processing value

            Console.WriteLine("square {0}  is {1}", num1, result); //Output

            Console.ReadLine();
            return 0;
            //try
        }
    }
}
