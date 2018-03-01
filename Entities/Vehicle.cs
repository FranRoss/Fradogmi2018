using System;
namespace Fradogmi2018.Entities
{
    public enum VechicleStatus {
        Free, 
        Busy
    }
    public class Vehicle
    {
        public int Id;
        public VechicleStatus Status { get; set; } = VechicleStatus.Free;
        public int PositionX { get; set; } = 0;  
        public int PositionY { get; set; } = 0; 


        Vehicle(int id, int positionX, int positionY) {
          Id = id;
          PositionX = positionX;
          PositionY = positionY;
        }
    }
}
