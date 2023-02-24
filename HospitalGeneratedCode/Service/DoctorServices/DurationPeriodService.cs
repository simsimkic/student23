/***********************************************************************
 * Module:  DurationPeriodService.cs
 * Purpose: Definition of the Class Service.DoctorServices.DurationPeriodService
 ***********************************************************************/

using System;

namespace Service.DoctorServices
{
   public class DurationPeriodService
   {
      public List<DurationPeriod> GetAllDurationPeriodsByDoctorId(long doctorId)
      {
         // TODO: implement
         return null;
      }
   
      public Repository.DoctorServicesRepositories.DurationPeriodRepository durationPeriodRepository;
   
   }
}