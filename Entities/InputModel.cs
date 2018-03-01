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
        public InputModel(string fileName)
        {
            using (StreamReader sr = new StreamReader(fileName))
            {
                string CurrentRow = sr.ReadLine();
                //5 videos, 2 endpoints, 4 request descriptions, 3 caches 100MB each.
                var values = CurrentRow.Split(' ').Select(e => Convert.ToInt32(e)).ToArray();
            }

        }

    }
}