/***********************************************************************
 * Module:  OperationTypeController.cs
 * Purpose: Definition of the Class Controller.DoctorControllers.OperationTypeController
 ***********************************************************************/

using System;

namespace Controller.DoctorControllers
{
   public class OperationTypeController
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
   
      public Service.DoctorServices.OperationTypeService operationTypeService;
   
   }
}