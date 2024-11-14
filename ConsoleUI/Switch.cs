using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    internal class Switch
    {
        public static void WhatDayByNumber()
        {
            //valid numbers are 1-7, simulate a real week

            int dayNumber = 5;

            switch (dayNumber)
            {
                case 1: Console.WriteLine("It's Monday.");
                    break;
                case 2: Console.WriteLine("It's Tuesday.");
                    break;
                case 3: Console.WriteLine("It's Wednesday.");
                    break;
                case 4: Console.WriteLine("It's Thursday.");
                    break;
                case 5: Console.WriteLine("It's Friday.");
                    break;
                case 6: Console.WriteLine("It's Saturday.");
                    break;
                case 7: Console.WriteLine("It's Sunday.");
                    break;
                default: Console.WriteLine("That's not a valid number.");
                    break;
            }
        }

        public static void DayByUserInput()
        {
            Console.Write("Type a number between 1-7: ");
            int.TryParse(Console.ReadLine(), out int dayNumber);

            switch (dayNumber)
            {
                case 1:
                    Console.WriteLine("It's Monday.");
                    break;
                case 2:
                    Console.WriteLine("It's Tuesday.");
                    break;
                case 3:
                    Console.WriteLine("It's Wednesday.");
                    break;
                case 4:
                    Console.WriteLine("It's Thursday.");
                    break;
                case 5:
                    Console.WriteLine("It's Friday.");
                    break;
                case 6:
                    Console.WriteLine("It's Saturday.");
                    break;
                case 7:
                    Console.WriteLine("It's Sunday.");
                    break;
                default:
                    DayByUserInput();
                    break;
            }
        }
    }
}
