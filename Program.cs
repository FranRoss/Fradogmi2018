using System;
using System.Collections.Generic;
using Fradogmi2018.Entities;
using Fradogmi2018.Managers;
using Fradogmi2018.Output;

namespace Fradogmi2018
{
    class MainClass
    {
        public static string easyFile = "Assets/b_should_be_easy.in";
        public static string noHurryFile = "Assets/c_no_hurry.in";
        public static string metropolisFile = "Assets/d_metropolis.in";
        public static string highFile = "Assets/e_high_bonus.in";


        public static void Main(string[] args)
        {
            InputModel input = new InputModel(easyFile);

            ManagersData data = new ManagersData();
            for (int i = 0; i < input.status.TotalSteps; i++)
            {
                data.ManageInputModel(input, i);
            }

            new OutputWriter("ouput.txt").WriteSolution(input.status.vehicles);

        }
    }
}
