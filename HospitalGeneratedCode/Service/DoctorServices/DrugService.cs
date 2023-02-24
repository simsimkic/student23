/***********************************************************************
 * Module:  DrugService.cs
 * Purpose: Definition of the Class Service.DoctorServices.DrugService
 ***********************************************************************/

using System;

namespace Service.DoctorServices
{
   public class DrugService
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
   
      public Repository.DoctorServicesRepositories.DrugRepository drugRepository;
      public Repository.DoctorServicesRepositories.IngredientRepository ingredientRepository;
   
   }
}