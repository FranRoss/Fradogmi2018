using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Fradogmi2018.Entities
{
    public class InputModel
    {
        public AppStatus status;
        public Ride[] ridesList;
        public Vehicle[] vehiclesList;

        public InputModel(string fileName)
        {
            using (StreamReader sr = new StreamReader(fileName))
            {
                
                string CurrentRow = sr.ReadLine();
                Console.Write(CurrentRow);
                // 3 rows, 4 columns, 2 vehicles, 3 rides, 2 bonus and 10 steps
                var values = CurrentRow.Split(' ').Select(e => Convert.ToInt32(e)).ToArray();
                
                int rows = values[0];
                int columns = values[1]; 
                int vehicles = values[2];
                int rides = values[3];
                int bonus = values[4];
                int steps = values[5];
                status = new AppStatus(rows, columns, vehicles, rides, bonus, steps);

                ridesList = new Ride[rides];
                for (int i = 0; i < rides; i++)
                {
                  string rideString = sr.ReadLine();
                  values = rideString.Split(' ').Select(e => Convert.ToInt32(e)).ToArray();
                  int startX = values[0];
                  int startY = values[1];
                  int endX = values[2];
                  int endY = values[3];
                  int bestStart = values[4];
                  int maxEnd = values[5];
                  Ride ride = new Ride(i, startX, startY, endX, endY, bestStart, maxEnd);
                  ridesList[i] = ride;
                }
            }

            ridesList = ridesList.OrderBy(e => e.BestStart).ToArray();
        }

    }
}