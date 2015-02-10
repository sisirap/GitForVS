using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EulerSolutions
{
    class ProblemHelper
    {
        public int QuestionOne(int upperLimit)
        {
            int sum = 0;
            for (int i = 1; i < upperLimit; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    sum += i;
                }
            }
            return sum;
        }

        public int QuestionOneLinq(int upperLimit)
        {
            return Enumerable.Range(1, upperLimit).Where(x => x%3 == 0 || x%5 == 0).Sum();
        }
    }
}
