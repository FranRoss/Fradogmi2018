using System;
using System.Collections.Generic;

namespace Fradogmi2018.Entities
{
    public class OutputManagerData
    {
        public Vehicle vehicle;
        public List<Ride>[] rides;
        public OutputManagerData(Vehicle vehicle,List<Ride>[] rides)
        {
            this.vehicle = vehicle;
            this.rides = rides;
        }
    }
}
