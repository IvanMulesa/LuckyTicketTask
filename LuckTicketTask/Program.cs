using System;

namespace LackyTicket
{
    class Program
    {
        static void Main()
        {
            while (true)
            {
                Console.Clear();
                Console.Write("Please write number of your ticket: ");
                string inpuNumber = Console.ReadLine();
                Int16 FirstPartOfNum = 0, SecondPartOfnum = 0;
                if (inpuNumber.Length == 5 || inpuNumber.Length == 7) inpuNumber = "0" + inpuNumber;
                if (inpuNumber.Length > 3 && inpuNumber.Length < 9 && float.TryParse(inpuNumber, out _))
                {

                    for (int i = 0; i < inpuNumber.Length / 2; i++)
                    {
                        FirstPartOfNum += Convert.ToInt16(inpuNumber[i].ToString());
                        SecondPartOfnum += Convert.ToInt16(inpuNumber[inpuNumber.Length - i - 1].ToString());
                    }
                    if (FirstPartOfNum == SecondPartOfnum) Console.WriteLine("That's your lucky ticket.");
                    else Console.WriteLine("Sorry, it is not lucky ticket.");
                }
                else
                {
                    Console.WriteLine("Sorry, it is wrong number of ticket!");
                    Console.WriteLine("It should be number with 4 up to 8 digits!");
                }
                Console.WriteLine("Please press Enter to try again.");
                Console.ReadLine();
            }

        }
    }
}
