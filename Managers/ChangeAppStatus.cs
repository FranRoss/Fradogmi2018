using System;
using System.Collections.Generic;
using System.Linq;
using Fradogmi2018.Entities;

namespace Fradogmi2018.Managers
{
    public class ChangeAppStatus
    {
        public ChangeAppStatus()
        {
           
        }

        public void UpdateStatus(int currentStep, AppStatus appStatus, List<OutputManagerData> config)
        {
            //Vehicles
            for (int i = 0; i < appStatus.vehicles.Length; i++)
            {
                Vehicle currentVehicle = appStatus.vehicles[i];
                if (currentVehicle.Status == VechicleStatus.Free){
                    IEnumerable<OutputManagerData> foundRide = config.Where(c => c.vehicle.Id == currentVehicle.Id);
                    if (foundRide.Any()){
                        currentVehicle.Status = VechicleStatus.Busy;
                        currentVehicle.RemainingSteps = foundRide.First().ride.GetRideLength();
                    }
                } else {
                    currentVehicle.RemainingSteps--;
                    if (currentVehicle.RemainingSteps == 0)
                    {
                        currentVehicle.Status = VechicleStatus.Free;
                    }
                }
            }
        }
    }
}
