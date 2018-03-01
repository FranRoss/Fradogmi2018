using System;
using System.Collections.Generic;
using Fradogmi2018.Entities;
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
            List<Vehicle> vehicles = new List<Vehicle>();
            Vehicle first = new Vehicle(0, 1, 1);
            first.DoRide(0);
            first.DoRide(1);
            first.DoRide(2);
            first.DoRide(3);
            Vehicle second = new Vehicle(0, 1, 1);
            second.DoRide(4);
            second.DoRide(5);
            Vehicle third = new Vehicle(0, 1, 1);
            third.DoRide(6);
            third.DoRide(7);
            Vehicle fourth = new Vehicle(0, 1, 1);
            fourth.DoRide(8);
            fourth.DoRide(9);
            fourth.DoRide(10);

            vehicles.Add(first);
            vehicles.Add(second);
            vehicles.Add(third);
            vehicles.Add(fourth);

            OutputWriter output = new OutputWriter("output.txt");
            output.WriteSolution(vehicles.ToArray());

            InputModel input = new InputModel(easyFile);
            for (int i = 0; i < input.status.TotalSteps; i++)
            {
                
            }

        }
    }
}
