using System;
using System.Collections.Generic;

namespace Fradogmi2018.Entities
{
    public enum VechicleStatus {
        Free, 
        Busy, 
        Transfer
    }
    public class Vehicle
    {
        public int Id;
        public VechicleStatus Status { get; set; } = VechicleStatus.Free;
        public int PositionX { get; set; } = 0;  
        public int PositionY { get; set; } = 0;
        public int RemainingSteps { get; set; } = 0;
        public Ride currentRide { get; set; } = null;

        public List<int> RidesToDo;

        public bool CanDo(Ride ride, int currentTime)
        {
            return currentTime + ride.getDistanceFromStart(PositionX, PositionY) + ride.GetRideLength() < ride.MaxEnd;
        }

        public void DoRide(int rideId) 
        {
            RidesToDo.Add(rideId);
        }
    }
}
