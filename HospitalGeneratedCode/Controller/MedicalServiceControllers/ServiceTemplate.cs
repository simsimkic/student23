/***********************************************************************
 * Module:  ServiceTemplate.cs
 * Purpose: Definition of the Class Controller.MedicalServiceControllers.ServiceTemplate
 ***********************************************************************/

using System;

namespace Controller.MedicalServiceControllers
{
   public abstract class ServiceTemplate
   {
      public abstract List<AppointmentOperationDTO> GetAllServicesByPatientId();
      
      public sealed List<AppointmentOperationDTO> GetAllServicesByPatientIdAndValidate()
      {
         // TODO: implement
         return null;
      }
      
      public abstract List<AppointmentOperationDTO> GetAllServicecByDoctorId();
      
      public sealed List<AppointmentOperationDTO> GetAllServicesByDoctorIdAndValidate()
      {
         // TODO: implement
         return null;
      }
   
   }
}