/***********************************************************************
 * Module:  MedicalEquipmentController.cs
 * Purpose: Definition of the Class Controller.EquipmentAndRoomsController.MedicalEquipmentController
 ***********************************************************************/

using System;

namespace Controller.EquipmentAndRoomsController
{
   public class MedicalEquipmentController
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
   
      public Service.EquipmentAndRoomsServices.MedicalEquipmentService medicalEquipmentService;
   
   }
}