/***********************************************************************
 * Module:  ShiftService.cs
 * Purpose: Definition of the Class Service.DoctorServices.ShiftService
 ***********************************************************************/

using System;

namespace Service.DoctorServices
{
   public class ShiftService
   {
      public Shift GetDoctorCurrentShift(long doctorId)
      {
         // TODO: implement
         return null;
      }
   
      public Repository.DoctorServicesRepositories.DurationPeriodRepository durationPeriodRepository;
      public Repository.DoctorServicesRepositories.ShiftRepository shiftRepository;
   
   }
}