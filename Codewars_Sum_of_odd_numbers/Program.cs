using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars_Sum_of_odd_numbers
{
    class Program
    {  
        //##TASK DESCRIPTION##
        //Given the triangle of consecutive odd numbers:

        //                  1
        //               3     5
        //             7     9    11
        //          13    15    17    19
        //      21    23    25    27    29
        //...
        //Calculate the row sums of this triangle from the row index (starting at index 1) e.g.:

        //rowSumOddNumbers(1); // 1
        //rowSumOddNumbers(2); // 3 + 5 = 8

        static void Main(string[] args)
        {
            //My Solution
            long rowSumOddNumbers(long n)
            {
                int NumbersInTriangle = 0;
                int SumNumbersInTriangleLine = 0;

                int CountAmountInOddTriangle(int lastTriangleLine)
                {
                    for (int i = 1; i <= lastTriangleLine; i++)
                    {
                        NumbersInTriangle += i;
                    }
                    return NumbersInTriangle;
                }
                int SumLastLineInOddTriangle(int sumOfNumbersInTriangle)
                {
                    sumOfNumbersInTriangle = sumOfNumbersInTriangle * 2 - 1;
                    for (int i = 0; i < n; i++)
                    {

                        SumNumbersInTriangleLine += sumOfNumbersInTriangle;
                        sumOfNumbersInTriangle = sumOfNumbersInTriangle - 2;
                    }
                    return SumNumbersInTriangleLine;
                }

                return SumLastLineInOddTriangle(CountAmountInOddTriangle((int)n));

            }
            // Codewars best solution + code analysis for myself.

            long rowSumOddNumbers2(long n)
            {
                return n * n * n; //Knowledge of the mathformulas can save me a lot of time.
            }
        }    
    }
}
