/***********************************************************************
 * Module:  DoctorsService.cs
 * Purpose: Definition of the Class Service.DoctorServices.DoctorsService
 ***********************************************************************/

using System;

namespace Service.DoctorServices
{
   public class DoctorsService
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
   
      private Boolean CheckAvailabilityBetween(Appointment firstAppointment, Appointment seccondAppointment)
      {
         // TODO: implement
         return null;
      }
   
      public Repository.DoctorServicesRepositories.DoctorRepository doctorRepository;
      public Repository.DoctorServicesRepositories.SpecialityRepository specialityRepository;
      public System.Collections.ArrayList appointmentRepository;
      
      /// <pdGenerated>default getter</pdGenerated>
      public System.Collections.ArrayList GetAppointmentRepository()
      {
         if (appointmentRepository == null)
            appointmentRepository = new System.Collections.ArrayList();
         return appointmentRepository;
      }
      
      /// <pdGenerated>default setter</pdGenerated>
      public void SetAppointmentRepository(System.Collections.ArrayList newAppointmentRepository)
      {
         RemoveAllAppointmentRepository();
         foreach (Repository.MedicalServicesRepositories.AppointmentRepository oAppointmentRepository in newAppointmentRepository)
            AddAppointmentRepository(oAppointmentRepository);
      }
      
      /// <pdGenerated>default Add</pdGenerated>
      public void AddAppointmentRepository(Repository.MedicalServicesRepositories.AppointmentRepository newAppointmentRepository)
      {
         if (newAppointmentRepository == null)
            return;
         if (this.appointmentRepository == null)
            this.appointmentRepository = new System.Collections.ArrayList();
         if (!this.appointmentRepository.Contains(newAppointmentRepository))
            this.appointmentRepository.Add(newAppointmentRepository);
      }
      
      /// <pdGenerated>default Remove</pdGenerated>
      public void RemoveAppointmentRepository(Repository.MedicalServicesRepositories.AppointmentRepository oldAppointmentRepository)
      {
         if (oldAppointmentRepository == null)
            return;
         if (this.appointmentRepository != null)
            if (this.appointmentRepository.Contains(oldAppointmentRepository))
               this.appointmentRepository.Remove(oldAppointmentRepository);
      }
      
      /// <pdGenerated>default removeAll</pdGenerated>
      public void RemoveAllAppointmentRepository()
      {
         if (appointmentRepository != null)
            appointmentRepository.Clear();
      }
      public Repository.MedicalServicesRepositories.OperationRepository operationRepository;
   
   }
}