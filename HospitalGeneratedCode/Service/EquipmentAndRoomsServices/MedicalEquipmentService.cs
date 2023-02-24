/***********************************************************************
 * Module:  MedicalEquipmentService.cs
 * Purpose: Definition of the Class Service.EquipmentAndRoomsServices.MedicalEquipmentService
 ***********************************************************************/

using System;

namespace Service.EquipmentAndRoomsServices
{
   public class MedicalEquipmentService
   {
      public List<MedicalEquipment> GetAllAvailableMedicalEquipment(DateTime startTime, int duration)
      {
         // TODO: implement
         return null;
      }
      
      public List<MedicalEquipment> GetMedicalEquipmentByServiceRoom(Model.EquipmentAndRooms.ServiceRoom serviceRoom)
      {
         // TODO: implement
         return null;
      }
   
      public Repository.EquipmentAndRoomsRepositories.MedicalEquipmentRepository medicalEquipmentRepository;
      public Repository.EquipmentAndRoomsRepositories.EquipmentReservationTimeRepository equipmentReservationTimeRepository;
   
   }
}