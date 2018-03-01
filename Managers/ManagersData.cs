using System;
using System.Collections.Generic;
using Fradogmi2018.Entities;

namespace Fradogmi2018.Managers
{
    public class ManagersData
    {
        public ManagersData()
        {
        }

        public void ManageInputModel(InputModel model,int i){

            List<OutputManagerData> list = new List<OutputManagerData>();
                foreach (var vehicle in model.vehiclesList)
                {
                    if(vehicle.Status==VechicleStatus.Free){
                        foreach (var ride in model.ridesList)
                        {
                        var diffx= vehicle.PositionX - ride.StartX;
                        var diffy = vehicle.PositionY - ride.StartY;

                        var diffridex = ride.StartX - ride.StartY;
                        var diffridey = ride.EndX - ride.EndY;
                        var distanceRide = diffridex +diffridey;

                        var distance = diffx + diffy;

                        if (distance + i < ride.BestStart)                         
                            list.Add(new OutputManagerData(vehicle, ride));
                                


                        }
                    }
                        
                        

            }
        }
    }
}
