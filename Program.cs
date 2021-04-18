using System;
using System.Collections.Generic;

namespace ParkingLot
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> carNumbers = new HashSet<string>();// create a Data Structure HashSet

            while (true)
            {
                string line = Console.ReadLine();

                if (line == "END")
                {
                    //ToDo
                    if (carNumbers.Count!= 0)
                    {
                       PrintRemainingCars(carNumbers);
                    }
                    else
                    {
                        Console.WriteLine("Parking Lot is Empty");
                    }

                    break;
                }

                string[] details = line.Split(", ");
                string command = details[0];
                string plateNumber = details[1];

                if (command == "IN")
                {
                    carNumbers.Add(plateNumber);
                }
                else if (command == "OUT")
                {
                    carNumbers.Remove(plateNumber);
                }
            }
        }

        private static void PrintRemainingCars(HashSet<string> carNumbers)
        {
            foreach (var number in carNumbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}
