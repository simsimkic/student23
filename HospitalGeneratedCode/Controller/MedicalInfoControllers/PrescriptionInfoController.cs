/***********************************************************************
 * Module:  PrescriptionInfoController.cs
 * Purpose: Definition of the Class Controller.MedicalInfoControllers.PrescriptionInfoController
 ***********************************************************************/

using System;

namespace Controller.MedicalInfoControllers
{
   public class PrescriptionInfoController
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
   
      public Service.MedicalInfoServices.PrescriptionInfoService prescriptionInfoService;
   
   }
}