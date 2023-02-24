/***********************************************************************
 * Module:  SpecialityService.cs
 * Purpose: Definition of the Class Service.DoctorServices.SpecialityService
 ***********************************************************************/

using System;

namespace Service.DoctorServices
{
   public class SpecialityService
   {
      public List<Specialty> GetAllSpecialities()
      {
         // TODO: implement
         return null;
      }
      
      public Model.Doctor.Specialty GetSpecialityByDoctorId(long doctorId)
      {
         // TODO: implement
         return null;
      }
   
      public Repository.DoctorServicesRepositories.SpecialityRepository specialityRepository;
   
   }
}