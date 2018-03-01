using System;
using System.Collections.Generic;

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

        public Ride[] rides;
        public Vehicle[] vehicles;

        private List<Ride> completes = new List<Ride>();


        public AppStatus(int rows, int columns, int totalVehicles, int totalRides, int rides, int totalSteps)
        {
          Rows = rows;
          Columns = columns;
          TotalVehicles = totalVehicles;
          TotalRides = totalRides;
          RideBonus = rides;
          TotalSteps = totalSteps;
        }

        public void removeAvailable(int index) 
        {
            var element = rides[index];
            Ride[] newArray = RemoveAt(rides, index);

            completes.Add(element);

        }

        private Ride[] RemoveRide(Ride[] array, int startIndex, int length = 1)
        {

            if (length < 0)
            {
                startIndex += 1 + length;
                length = -length;
            }

            Ride[] newArray = new Ride[array.Length - length];

            Array.Copy(array, 0, newArray, 0, startIndex);
            Array.Copy(array, startIndex + length, newArray, startIndex, array.Length - startIndex - length);

            return newArray;
        }
    }
}
