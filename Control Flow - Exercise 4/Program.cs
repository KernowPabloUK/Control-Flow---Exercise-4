using System;

namespace Control_Flow___Exercise_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //4- Your job is to write a program for a speed camera.
            //For simplicity, ignore the details such as camera, sensors, etc and focus purely on the logic.
            //Write a program that asks the user to enter the speed limit.
            //Once set, the program asks for the speed of a car.
            //If the user enters a value less than the speed limit, program should display Ok on the console.
            //If the value is above the speed limit, the program should calculate the number of demerit points.
            //For every 5km/hr above the speed limit, 1 demerit points should be incurred and displayed on the console.
            //If the number of demerit points is above 12, the program should display License Suspended.

                Console.WriteLine("Please enter the speed limit of the road in mph...");
                string speedLimitInput = Console.ReadLine();
                int speedLimitNumber = int.Parse(speedLimitInput);

                Console.WriteLine("Please enter the speed the vehicle was travelling at in mph...");
                string vehicleSpeedInput = Console.ReadLine();
                int vehicleSpeedNumber = int.Parse(vehicleSpeedInput);

                if (vehicleSpeedNumber <= speedLimitNumber)
                    Console.WriteLine("OK");
                else
                {
                    const int milesPerDemeritPoints = 5;
                    decimal demeritPoints = (vehicleSpeedNumber - speedLimitNumber)/ milesPerDemeritPoints;
                    if (demeritPoints > 12)
                        Console.WriteLine("License Suspended");
                    else
                        Console.WriteLine($"You have accrued {demeritPoints} points");
            }
        }
    }
}
