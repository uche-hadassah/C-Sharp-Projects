//Class exercise Number 1
// Write a console application to prompt the user to enter two numbers and display their addition,
//subtraction, multiplication and division,
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;
            Console.Write("Enter a number: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter another number: ");
            num2 = Convert.ToInt32(Console.ReadLine());
            int sum = num1 + num2;
            int diff = num1 - num2;
            Console.WriteLine(num1 + " + " + num2 + " = " + sum);
           
            Console.WriteLine(num1 + " - " + num2 + " = " + diff);
            
            Console.ReadKey();
        }
    }
}
