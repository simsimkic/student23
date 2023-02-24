/***********************************************************************
 * Module:  ProstorijaZaUsluge.cs
 * Purpose: Definition of the Class ProstorijaZaUsluge
 ***********************************************************************/

using System;

namespace Model.EquipmentAndRooms
{
   public class ServiceRoom : Room
   {
      public ServiceType serviceType;
      
      /// <pdGenerated>default parent getter</pdGenerated>
      public ServiceType GetServiceType()
      {
         return serviceType;
      }
      
      /// <pdGenerated>default parent setter</pdGenerated>
      /// <param>newServiceType</param>
      public void SetServiceType(ServiceType newServiceType)
      {
         if (this.serviceType != newServiceType)
         {
            if (this.serviceType != null)
            {
               ServiceType oldServiceType = this.serviceType;
               this.serviceType = null;
               oldServiceType.RemoveServiceRoom(this);
            }
            if (newServiceType != null)
            {
               this.serviceType = newServiceType;
               this.serviceType.AddServiceRoom(this);
            }
         }
      }
   
   }
}