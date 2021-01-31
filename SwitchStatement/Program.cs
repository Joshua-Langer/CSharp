using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchStatement
{
    class Program
    {

        static void Main(string[] args)
        {
            (new Program()).Run();
        }

        void Run()
        {
            Console.WriteLine("Joshua Langer's Copy");
            int selectionNumber = readInt("Enter a number: ");

            string course = "";

            switch (selectionNumber)
            {
                case 1:
                    course = "IT 145";
                    break;
                case 2:
                    course = "IT 200";
                    break;
                case 3:
                    course = "IT 201";
                    break;
                case 4:
                    course = "IT 270";
                    break;
                case 5:
                    course = "IT 315";
                    break;
                case 6:
                    course = "IT 328";
                    break;
                case 7:
                    course = "IT 330";
                    break;
                default:
                    course = "ERROR";
                    break;
            }

            Console.WriteLine("Your Choice of " + selectionNumber + " is this course: " + course);
        }

        private int readInt(string text)
        {
            Console.Write(text);
            string line = Console.ReadLine();
            return int.Parse(line);
        }
    }
}
