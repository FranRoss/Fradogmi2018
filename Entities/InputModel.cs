﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fradogmi2018.Entities
{
    public class InputModel
    {

        public int RowCount 

        public InputModel(string fileName)
        {
            using (StreamReader sr = new StreamReader(fileName))
            {
                string CurrentRow = sr.ReadLine();
                // 3 rows, 4 columns, 2 vehicles, 3 rides, 2 bonus and 10 steps
                var values = CurrentRow.Split(' ').Select(e => Convert.ToInt32(e)).ToArray();

                int rows, columns, vehicles, rides, bonus, steps;
                for (int i = 0; i < values.Length; i++)
                {

                }
            }

        }

    }
}