/***********************************************************************
 * Module:  TipUsluge.cs
 * Purpose: Definition of the Class TipUsluge
 ***********************************************************************/

using System;

namespace Model.EquipmentAndRooms
{
   public class ServiceType
   {
      public System.Collections.ArrayList serviceRoom;
      
      /// <pdGenerated>default getter</pdGenerated>
      public System.Collections.ArrayList GetServiceRoom()
      {
         if (serviceRoom == null)
            serviceRoom = new System.Collections.ArrayList();
         return serviceRoom;
      }
      
      /// <pdGenerated>default setter</pdGenerated>
      public void SetServiceRoom(System.Collections.ArrayList newServiceRoom)
      {
         RemoveAllServiceRoom();
         foreach (ServiceRoom oServiceRoom in newServiceRoom)
            AddServiceRoom(oServiceRoom);
      }
      
      /// <pdGenerated>default Add</pdGenerated>
      public void AddServiceRoom(ServiceRoom newServiceRoom)
      {
         if (newServiceRoom == null)
            return;
         if (this.serviceRoom == null)
            this.serviceRoom = new System.Collections.ArrayList();
         if (!this.serviceRoom.Contains(newServiceRoom))
         {
            this.serviceRoom.Add(newServiceRoom);
            newServiceRoom.SetServiceType(this);      
         }
      }
      
      /// <pdGenerated>default Remove</pdGenerated>
      public void RemoveServiceRoom(ServiceRoom oldServiceRoom)
      {
         if (oldServiceRoom == null)
            return;
         if (this.serviceRoom != null)
            if (this.serviceRoom.Contains(oldServiceRoom))
            {
               this.serviceRoom.Remove(oldServiceRoom);
               oldServiceRoom.SetServiceType((ServiceType)null);
            }
      }
      
      /// <pdGenerated>default removeAll</pdGenerated>
      public void RemoveAllServiceRoom()
      {
         if (serviceRoom != null)
         {
            System.Collections.ArrayList tmpServiceRoom = new System.Collections.ArrayList();
            foreach (ServiceRoom oldServiceRoom in serviceRoom)
               tmpServiceRoom.Add(oldServiceRoom);
            serviceRoom.Clear();
            foreach (ServiceRoom oldServiceRoom in tmpServiceRoom)
               oldServiceRoom.SetServiceType((ServiceType)null);
            tmpServiceRoom.Clear();
         }
      }
   
      private int ServiceCode;
      private String ServiceName;
   
   }
}