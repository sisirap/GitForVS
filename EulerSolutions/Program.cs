using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EulerSolutions
{
    class Program
    {
        static void Main(string[] args)
        {
            ProblemHelper helper = new ProblemHelper();
            Console.WriteLine(" The solution to (1)Multiples of 3 and 5 is {0}", helper.QuestionOne(1000));
            Console.WriteLine(" The solution to (1)Multiples of 3 and 5 is {0}", helper.QuestionOneLinq(1000));
        }
    }
}
