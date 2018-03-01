using System;
using System.IO;
using System.Text;
using Fradogmi2018.Entities;

namespace Fradogmi2018.Output
{
    public class OutputWriter
    {
        public string OutputFileName;

        public OutputWriter(string outputFile)
        {
            OutputFileName = outputFile;
        }

        public void WriteSolution(Vehicle[] vehicles) 
        {
            using (StreamWriter stream = new StreamWriter(OutputFileName))
            {
                StringBuilder result = new StringBuilder();
                for (int i = 0; i < vehicles.Length; i++) 
                {
                    Vehicle vehicle = vehicles[i];
                    result.Append(vehicle.RidesToDo.Count);
                    vehicle.RidesToDo.ForEach(e => 
                    {
                        result.Append(' ' + e);
                    });

                    result.AppendLine();
                }

                stream.WriteLine(result);
            }
        }
    }
}
