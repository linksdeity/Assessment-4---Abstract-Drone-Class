using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractDroneClass
{
    class QuadrotorDrone : Drone
    {

        private int totalFlyTime1 { get; set; }
        private int totalDistance1 { get; set; }

        public QuadrotorDrone(int totalFlyTimeIn, int totalDistanceIn, int totalFlyTime1In, int totalDistance1In) : base(totalFlyTimeIn, totalDistanceIn)
        {
            totalFlyTime1 = totalFlyTime1In;
            totalDistance1 = totalDistance1In;
        }

        //the parent method gives result of a single input, while the new method takes two results and gives an average
        //we access the previous private members through properties

        public override double FlightSpeed()
        {
            return Math.Round((double)(this.GetDistance() + totalDistance1) / (double)(this.GetFlyTime() + totalFlyTime1),2);
        }



    }
}
