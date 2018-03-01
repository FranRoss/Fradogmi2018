using System;
using Fradogmi2018.Entities;

namespace Fradogmi2018.Managers
{
    public class ManagersData
    {
        public ManagersData()
        {
        }

        public void ManageInputModel(InputModel model){
          
            for (int i = 0; i < model.status.TotalSteps; i++)
            {
                foreach (var vehicle in model.vehiclesList)
                {
                    if(vehicle.Status==VechicleStatus.Free){
                        foreach (var rides in model.ridesList)
                        {

                        }
                    }
                        
                        
                }
            }
        }
    }
}
