/***********************************************************************
 * Module:  HospitalizationRoomService.cs
 * Purpose: Definition of the Class Service.EquipmentAndRoomsServices.HospitalizationRoomService
 ***********************************************************************/

using System;

namespace Service.EquipmentAndRoomsServices
{
   public class HospitalizationRoomService
   {
      public List<HospitalizationRoom> GetAllAvailableHospitalizationRooms(DateTime startDate, DateTime endDate)
      {
         // TODO: implement
         return null;
      }
   
      public Repository.EquipmentAndRoomsRepositories.HospitalizationRoomRepository hospitalizationRoomRepository;
      public Repository.MedicalServicesRepositories.HospitalizationRepository hospitalizationRepository;
   
   }
}