/***********************************************************************
 * Module:  DurationPeriodController.cs
 * Purpose: Definition of the Class Controller.DoctorControllers.DurationPeriodController
 ***********************************************************************/

using System;

namespace Controller.DoctorControllers
{
   public class DurationPeriodController
   {
      public List<DurationPeriod> GetAllDurationPeriodsByDoctorId(long doctorId)
      {
         // TODO: implement
         return null;
      }
   
      public Service.DoctorServices.DurationPeriodService durationPeriodService;
   
   }
}