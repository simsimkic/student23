/***********************************************************************
 * Module:  HospitalizationRoomController.cs
 * Purpose: Definition of the Class Controller.EquipmentAndRoomsController.HospitalizationRoomController
 ***********************************************************************/

using System;

namespace Controller.EquipmentAndRoomsController
{
   public class HospitalizationRoomController
   {
      public List<HospitalizationRoom> GetAllAvailableHospitalizationRooms(DateTime startDate, DateTime endDate)
      {
         // TODO: implement
         return null;
      }
   
      public Service.EquipmentAndRoomsServices.HospitalizationRoomService hospitalizationRoomService;
   
   }
}