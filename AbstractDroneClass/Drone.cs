using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractDroneClass
{
    public abstract class Drone
    {

        private int totalFlyTime { get; set; }
        private int totalDistance { get; set; }

        public string Color { get; set; }



        public Drone(int totalFlyTimeIn, int totalDistanceIn)
        {
            totalDistance = totalDistanceIn;
            totalFlyTime = totalFlyTimeIn;
        }

        public Drone(int totalFlyTimeIn, int totalDistanceIn, string color)
        {
            totalDistance = totalDistanceIn;
            totalFlyTime = totalFlyTimeIn;
            Color = color;
        }

        public int GetFlyTime()
        {
            return totalFlyTime;
        }

        public int GetDistance()
        {
            return totalDistance;
        }

        
        public virtual double FlightSpeed()
        {
            double calculatedSpeed = (double)(totalDistance / totalFlyTime);
            return calculatedSpeed;
        }


        

    }
}
