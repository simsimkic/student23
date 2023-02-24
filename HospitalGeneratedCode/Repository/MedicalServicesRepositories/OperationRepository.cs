/***********************************************************************
 * Module:  AppointmentRepository.cs
 * Purpose: Definition of the Class Repository.AppointmentRepository
 ***********************************************************************/

using System;

namespace Repository.MedicalServicesRepositories
{
   public class OperationRepository
   {
      public Model.MedicalService.Operation SaveOperation(Model.MedicalService.Operation operation)
      {
         // TODO: implement
         return null;
      }
      
      public Model.MedicalService.Operation DeleteOperationById(long operationId)
      {
         // TODO: implement
         return null;
      }
      
      public Model.MedicalService.Operation GetOperationById(long operationId)
      {
         // TODO: implement
         return null;
      }
      
      public List<Operation> GetAllOperationsByMedicalRecordId(long medicalRecordId)
      {
         // TODO: implement
         return null;
      }
      
      public List<Operation> GetAllOperationsByDoctorId(long doctorId)
      {
         // TODO: implement
         return null;
      }
      
      public List<Operation> GetAllOperationsByServiceRoom(Model.EquipmentAndRooms.ServiceRoom serviceRoome)
      {
         // TODO: implement
         return null;
      }
   
   }
}