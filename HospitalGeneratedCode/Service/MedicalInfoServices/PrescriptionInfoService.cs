/***********************************************************************
 * Module:  PrescriptionInfoService.cs
 * Purpose: Definition of the Class Service.MedicalInfoServices.PrescriptionInfoService
 ***********************************************************************/

using System;

namespace Service.MedicalInfoServices
{
   public class PrescriptionInfoService
   {
      public List<PrescriptionDTO> GetAllPrescriptionsByPatientId(long patientId)
      {
         // TODO: implement
         return null;
      }
      
      public Dto.MedicalInfoDTOs.PrescriptionDTO AddNewPrescription(Dto.MedicalInfoDTOs.PrescriptionDTO newPrescriptionDTO)
      {
         // TODO: implement
         return null;
      }
   
      public Repository.MedicalInfoRepositories.PrescriptionRepository prescriptionRepository;
      public MedicalRecordService medicalRecordService;
      public Repository.DoctorServicesRepositories.DrugRepository drugRepository;
   
   }
}