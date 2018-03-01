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
                    if (foundRide.Count() == 0) return;
                    Ride rideToAssign = foundRide.First().ride;
                    if (foundRide.Any()){
                        rideToAssign.isBusy = true;
                        if (currentVehicle.PositionX == rideToAssign.StartX && currentVehicle.PositionY == rideToAssign.StartY){
                            currentVehicle.Status = VechicleStatus.Busy;
                            currentVehicle.PositionX = rideToAssign.EndX;
                            currentVehicle.PositionY = rideToAssign.EndY;
                            currentVehicle.RemainingSteps = rideToAssign.GetRideLength();
                            
                        }else{
                            currentVehicle.RemainingSteps = Math.Abs(rideToAssign.StartX - currentVehicle.PositionX) + Math.Abs(rideToAssign.StartY - currentVehicle.PositionY);
                            currentVehicle.Status = VechicleStatus.Transfer;
                            currentVehicle.PositionX = rideToAssign.StartX;
                            currentVehicle.PositionY = rideToAssign.StartY;
                         }
                        currentVehicle.currentRide = rideToAssign;
                    }

                } else {
                    currentVehicle.RemainingSteps--;
                    if (currentVehicle.RemainingSteps == 0 && currentVehicle.Status == VechicleStatus.Transfer)
                    {
                        currentVehicle.Status = VechicleStatus.Busy;
                        currentVehicle.RemainingSteps = currentVehicle.currentRide.GetRideLength();
                    }else if (currentVehicle.RemainingSteps == 0 && currentVehicle.Status == VechicleStatus.Busy){
                        currentVehicle.Status = VechicleStatus.Free;
                        appStatus.removeAvailable(currentVehicle.currentRide.Id);
                    }
                }
            }
        }
    }
}
