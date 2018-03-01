using System;

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

        public Vehicle(int id, int positionX, int positionY) {
          Id = id;
          PositionX = positionX;
          PositionY = positionY;
        }

        public bool CanDo(Ride ride, int currentTime)
        {
            return currentTime + ride.getDistanceFromStart(PositionX, PositionY) + ride.GetRideLength() < ride.MaxEnd;
        }
    }
}
