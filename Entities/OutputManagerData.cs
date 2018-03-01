using System;
using System.Collections.Generic;

namespace Fradogmi2018.Entities
{
    public class OutputManagerData
    {
        public Vehicle vehicle;
        public Ride  ride;
        public OutputManagerData(Vehicle vehicle,Ride ride)
        {
            this.vehicle = vehicle;
            this.ride = ride;
        }
    }
}
