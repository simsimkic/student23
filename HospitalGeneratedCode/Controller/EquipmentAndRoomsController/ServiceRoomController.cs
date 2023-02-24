/***********************************************************************
 * Module:  ServiceRoomController.cs
 * Purpose: Definition of the Class Controller.EquipmentAndRoomsController.ServiceRoomController
 ***********************************************************************/

using System;

namespace Controller.EquipmentAndRoomsController
{
   public class ServiceRoomController
   {
      public List<ServiceRoom> GetAllAvailableServiceRoomsForAppointment(DateTime startDate, int duration)
      {
         // TODO: implement
         return null;
      }
      
      public List<ServiceRoom> GetAllAvailableServiceRoomsForOperation(DateTime startDate, int duration, Model.EquipmentAndRooms.ServiceType serviceType)
      {
         // TODO: implement
         return null;
      }
   
      public Service.EquipmentAndRoomsServices.ServiceRoomService serviceRoomService;
   
   }
}