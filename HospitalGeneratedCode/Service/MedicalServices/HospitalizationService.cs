/***********************************************************************
 * Module:  HospitalizationService.cs
 * Purpose: Definition of the Class Service.HospitalizationService
 ***********************************************************************/

using System;

namespace Service.MedicalServices
{
   public class HospitalizationService
   {
      public List<HospitalizationDTO> GetAllHospitalizationsByPatientId(long patientId)
      {
         // TODO: implement
         return null;
      }
      
      public List<HospitalizationDTO> GetAllHospitalizationsByRoomId(long roomId)
      {
         // TODO: implement
         return null;
      }
      
      public Dto.MedicalServiceDTOs.HospitalizationDTO AddNewHospitalization(Dto.MedicalServiceDTOs.HospitalizationDTO newHospitalization)
      {
         // TODO: implement
         return null;
      }
   
      public Repository.UserRepositories.UserRepository userRepository;
      public Repository.MedicalServicesRepositories.HospitalizationRepository hospitalizationRepository;
      public Repository.MedicalServicesRepositories.AppointmentRepository appointmentRepository;
      public Repository.MedicalServicesRepositories.OperationRepository operationRepository;
   
   }
}