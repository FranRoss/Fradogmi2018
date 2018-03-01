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
        AppStatus status;
        Ride[] ridesList;

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
                  Ride ride = new Ride();
                }
            }

        }

    }
}