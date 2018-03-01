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
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < vehicles.Length; i++)
            {
                Vehicle vehicle = vehicles[i];
                result.Append(vehicle.RidesToDo.Count)
                      .Append(" ")
                      .Append(string.Join(" ", vehicle.RidesToDo))
                      .Append(Environment.NewLine);
            }

            var fs = new FileStream(OutputFileName, FileMode.Create,
                                       FileAccess.ReadWrite,
                                       FileShare.None);
            using (StreamWriter stream = new StreamWriter(fs))
            {
                stream.WriteLine(result.ToString());
            }
        }
    }
}
