using System;
namespace Fradogmi2018.Entities
{
    public class AppStatus
    {
        int Rows;
        int Columns;
        int TotalVehicles;
        int TotalRides;
        int TotalSteps;
        int RideBonus;

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
