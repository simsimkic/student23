/***********************************************************************
 * Module:  DrugController.cs
 * Purpose: Definition of the Class Controller.DoctorControllers.DrugController
 ***********************************************************************/

using System;

namespace Controller.DoctorControllers
{
   public class DrugController
   {
      public List<DrugDTO> GetAllDrugs()
      {
         // TODO: implement
         return null;
      }
      
      public List<DrugDTO> GetAllUnapprovedDrugs()
      {
         // TODO: implement
         return null;
      }
      
      public Model.Doctor.InstructionAndPrescription.Ingredient AddNewIngredient(Model.Doctor.InstructionAndPrescription.Ingredient newIngredient)
      {
         // TODO: implement
         return null;
      }
      
      public Dto.MedicalInfoDTOs.DrugDTO ApproveDrug(Dto.MedicalInfoDTOs.DrugDTO approvingDrug)
      {
         // TODO: implement
         return null;
      }
   
      public Service.DoctorServices.DrugService drugService;
   
   }
}