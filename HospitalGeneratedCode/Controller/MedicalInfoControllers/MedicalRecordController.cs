/***********************************************************************
 * Module:  MedicalRecordController.cs
 * Purpose: Definition of the Class Controller.MedicalRecordController
 ***********************************************************************/

using System;

namespace Controller.MedicalInfoControllers
{
   public class MedicalRecordController
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
   
      public Service.MedicalInfoServices.MedicalRecordService medicalRecordService;
   
   }
}