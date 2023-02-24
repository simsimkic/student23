/***********************************************************************
 * Module:  OperationTypeService.cs
 * Purpose: Definition of the Class Service.DoctorServices.OperationTypeService
 ***********************************************************************/

using System;

namespace Service.DoctorServices
{
   public class OperationTypeService
   {
      public List<OperationType> GetAllOperationTypes()
      {
         // TODO: implement
         return null;
      }
      
      public Model.MedicalService.OperationType GetOperationTypeById(int operationTypeId)
      {
         // TODO: implement
         return null;
      }
   
      public Repository.MedicalServicesRepositories.OperationTypeRepository operationTypeRepository;
   
   }
}