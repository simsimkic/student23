/***********************************************************************
 * Module:  VacationService.cs
 * Purpose: Definition of the Class Service.DoctorServices.VacationService
 ***********************************************************************/

using System;

namespace Service.DoctorServices
{
   public class VacationService
   {
      public Boolean RequestVacation(DateTime startDate, DateTime endDate)
      {
         // TODO: implement
         return null;
      }
   
      private Model.Doctor.Vacation CheckAvailabilityOfVacationRequest()
      {
         // TODO: implement
         return null;
      }
   
      public Repository.MedicalServicesRepositories.OperationRepository operationRepository;
      public Repository.MedicalServicesRepositories.AppointmentRepository appointmentRepository;
      public Repository.DoctorServicesRepositories.VacationRepository vacationRepository;
   
   }
}