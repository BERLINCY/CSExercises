using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day3exercise
{
    class ExC3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your mark");
            String input = Console.ReadLine();
            int mark = Convert.ToInt32(input);


            String grade = "";

            if ((80 < mark) && (mark < 100)) grade = "A";
            if ((60 <= mark) && (mark < 79)) grade = "B";
            if ((40 <= mark) && (mark < 59)) grade = "C";
            if ((0 <= mark) && (mark < 39)) grade = "F";
            if (mark < 0) grade = "**ERROR**";
            if (mark > 100) grade = "**ERROR**";


            Console.WriteLine("Your grade is {0} ", grade);



        }
    }
}
