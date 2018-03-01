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
        int rows, columns, vehicles, rides, bonus, steps;

        public InputModel(string fileName)
        {
            using (StreamReader sr = new StreamReader(fileName))
            {
                string CurrentRow = sr.ReadLine();
                // 3 rows, 4 columns, 2 vehicles, 3 rides, 2 bonus and 10 steps
                var values = CurrentRow.Split(' ').Select(e => Convert.ToInt32(e)).ToArray();
                rows = values[0];
                columns = values[1]; 
                vehicles = values[2];
                rides = values[3];
                bonus = values[4];
                steps = values[5];

                for (int i = 0; i < values.Length; i++)
                {

                }
            }

        }

    }
}