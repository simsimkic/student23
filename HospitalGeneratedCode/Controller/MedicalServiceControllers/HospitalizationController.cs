/***********************************************************************
 * Module:  HospitalizationController.cs
 * Purpose: Definition of the Class Controller.HospitalizationController
 ***********************************************************************/

using System;

namespace Controller.MedicalServiceControllers
{
   public class HospitalizationController
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
   
      public Service.MedicalServices.HospitalizationService hospitalizationService;
   
   }
}