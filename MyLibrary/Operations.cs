using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary
{
    public class Operations
    {
        public int Add(int number1, int number2)
        {
            return number1 + number2;
        }

        public bool IsEven(int number)
        {
            return number % 2 == 0;
        }
        public bool IsOdd(int number)
        {
            return number % 2 != 1;
        }
        public double AddDecimal(double number1, double number2)
        {
            return number1 + number2;
        }
        public IList<int> GetEvenNumbers(int start, int end)
        {
            //    List<int> evenNumbers = new List<int>();
            //    for (int i = start; i <= end; i++) 
            //    {
            //        if (i % 2 == 0)
            //        {
            //            evenNumbers.Add(i);
            //        }
            //return evenNumbers;                                  Es una flecha no un operador regular
            //List<int> numbers = Enumerable.Range(start, end).Where(number =>IsEven(number)).ToList();
            return Enumerable.Range(start, end)
                .Where(IsEven)
                .ToList();

        }

    }
}
