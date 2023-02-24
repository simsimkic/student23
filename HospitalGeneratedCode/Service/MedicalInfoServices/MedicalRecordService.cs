/***********************************************************************
 * Module:  MedicalRecordService.cs
 * Purpose: Definition of the Class Service.MedicalInfoServices.MedicalRecordService
 ***********************************************************************/

using System;

namespace Service.MedicalInfoServices
{
   public class MedicalRecordService
   {
      public Dto.MedicalInfoDTOs.MedicalRecordDTO GetMedicalRecordByPatientId(long patientId)
      {
         // TODO: implement
         return null;
      }
      
      public Dto.MedicalInfoDTOs.MedicalRecordDTO EditMedicalRecord(Dto.MedicalInfoDTOs.MedicalRecordDTO editedMedicalRecord)
      {
         // TODO: implement
         return null;
      }
      
      public Dto.MedicalInfoDTOs.MedicalRecordDTO DeleteMedicalRecordByPatientId(long patientId)
      {
         // TODO: implement
         return null;
      }
   
      public Repository.UserRepositories.UserRepository userRepository;
      public Repository.MedicalInfoRepositories.MedicalRecordRepository medicalRecordRepository;
   
   }
}