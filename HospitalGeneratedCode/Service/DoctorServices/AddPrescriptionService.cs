/***********************************************************************
 * Module:  AddPrescriptionService.cs
 * Purpose: Definition of the Class Service.DoctorServices.AddPrescriptionService
 ***********************************************************************/

using System;

namespace Service.DoctorServices
{
   public class AddPrescriptionService
   {
      public Dto.MedicalInfoDTOs.PrescriptionDTO AddNewPrescription(Dto.MedicalInfoDTOs.PrescriptionDTO prescriptionDTO)
      {
         // TODO: implement
         return null;
      }
   
      public Repository.DoctorServicesRepositories.DrugRepository drugRepository;
      public Repository.MedicalInfoRepositories.PrescriptionRepository prescriptionRepository;
   
   }
}