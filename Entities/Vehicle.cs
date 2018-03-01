using System;
namespace Fradogmi2018.Entities
{
    public enum VechicleStatus {
        Free, 
        Busy
    }
    public class Vehicle
    {
        public VechicleStatus Status { get; set; } = VechicleStatus.Free;
        public int PositionX { get; set; } = 0;  
        public int PositionY { get; set; } = 0; 

    }
}
