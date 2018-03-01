using System;
namespace Fradogmi2018.Entities
{
    public class AppStatus
    {
        public int Rows;
        public int Columns;
        public int TotalVehicles;
        public int TotalRides;
        public int TotalSteps;
        public int RideBonus;

        public AppStatus(int rows, int columns, int totalVehicles, int totalRides, int rideBonus, int totalSteps)
        {
          Rows = rows;
          Columns = columns;
          TotalVehicles = totalVehicles;
          TotalRides = totalRides;
          RideBonus = rideBonus;
          TotalSteps = totalSteps;
        }
    }
}
