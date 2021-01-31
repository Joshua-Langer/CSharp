using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddMultiplyFourInts
{
    class Program
    {
        static void Main(string[] args)
        {
            //initialized requested ints
            int numberOne = 13; 
            int numberTwo = 55;
            int numberThree = 123;
            int numberFour = 325;

            int numberAddition = numberOne + numberTwo + numberThree + numberFour; //all requested ints added together
            int numberMultiplication = numberOne * numberTwo * numberThree * numberFour; //all requested ints multiplied together

            Console.WriteLine("Joshua Langer's Copy");
            Console.WriteLine("The sum of " + numberOne + ", " + numberTwo + ", " + numberThree + ", and " + numberFour + " = " + numberAddition); //Write line of the individual ints and their sum
            Console.WriteLine("The product of " + numberOne + ", " + numberTwo + ", " + numberThree + ", and " + numberFour + " = " + numberMultiplication); //Write line of the individual ints and their product
        }
    }
}
