/***********************************************************************
 * Module:  DoctorsController.cs
 * Purpose: Definition of the Class Controller.DoctorControllers.DoctorsController
 ***********************************************************************/

using System;

namespace Controller.DoctorControllers
{
   public class DoctorsController
   {
      public List<Doctor> GetDoctorsBySpeciality(int specialityId)
      {
         // TODO: implement
         return null;
      }
      
      public List<Doctor> GetAllAvailableDoctorsByRate(DateTime appointmentDateTime, int minRate)
      {
         // TODO: implement
         return null;
      }
      
      public List<Doctor> GetAllDoctorsByRate(int minRate)
      {
         // TODO: implement
         return null;
      }
      
      public List<DateTime> GetAllAvailableAppointmentTimes(DateTime date, long doctorId)
      {
         // TODO: implement
         return null;
      }
   
      public Service.DoctorServices.DoctorsService doctorsService;
   
   }
}