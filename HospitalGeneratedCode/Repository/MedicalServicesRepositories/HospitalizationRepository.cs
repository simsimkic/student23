/***********************************************************************
 * Module:  HospitalizationRepository.cs
 * Purpose: Definition of the Class Repository.HospitalizationRepository
 ***********************************************************************/

using System;

namespace Repository.MedicalServicesRepositories
{
   public class HospitalizationRepository
   {
      public Model.MedicalService.Hospitalization SaveHospitalization(Model.MedicalService.Operation operation)
      {
         // TODO: implement
         return null;
      }
      
      public Model.MedicalService.Hospitalization DeleteHospitalizationById(long hospitalizationId)
      {
         // TODO: implement
         return null;
      }
      
      public Model.MedicalService.Hospitalization GetHospitalizationById(long hospitalizationId)
      {
         // TODO: implement
         return null;
      }
      
      public List<Hospitalization> GetAllHospitalizationsByMedicalRecordId(long medicalRecordId)
      {
         // TODO: implement
         return null;
      }
      
      public List<Hospitalization> GetAllHospitalizationsByRoomId(long roomId)
      {
         // TODO: implement
         return null;
      }
      
      public List<Hospitalization> GetAllHospitalizationsByHospitalizationRoom(Model.EquipmentAndRooms.HospitalizationRoom hospitalizationRoom)
      {
         // TODO: implement
         return null;
      }
   
   }
}