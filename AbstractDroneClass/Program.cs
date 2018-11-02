using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractDroneClass
{
    class Program
    {
        static void Main(string[] args)
        {


            //S - The QuadRotor class is only responsible for itself / it's own methods and properties
            //O - Instead of modifying the Drone class we extend it into QuadRotor Drone
            //L - We override the parent class to get new functionality in the FlightSpeed method
            //I - These objects do not use any interfaces they do not need (currently none infact)
            //D - the QuadRotor Drone only depends on the abstract parent class, Drone() - not vice versa



            Console.WriteLine("Welcome to the QuadRotor Drone class!");


            Console.WriteLine("\nHow far did your drone go?\n");

            int distance = Validator.GetNumber("Please enter first distance in feet (1 - 1000)", 1, 1000);

            int flyTime = Validator.GetNumber("Please enter first fly time in minutes (1 - 1000)", 1, 1000);

            int distance2 = Validator.GetNumber("Please enter second distance in feet (1 - 1000)", 1, 1000);

            int flyTime2 = Validator.GetNumber("Please enter second fly time in minutes (1 - 1000)", 1, 1000);

            QuadrotorDrone newDrone = new QuadrotorDrone(flyTime, distance, flyTime2, distance2);

            Console.WriteLine("Your (average) speed is {0} feet per minute!", newDrone.FlightSpeed());

            Console.ReadKey(true);

        }
    }
}
