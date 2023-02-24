/***********************************************************************
 * Module:  AppointmentService.cs
 * Purpose: Definition of the Class Service.AppointmentService
 ***********************************************************************/

using System;

namespace Service.MedicalServices
{
   public class AppointmentService
   {
      public List<AppointmentOperationDTO> GetAllAppointmentsByPatientId(long patientId)
      {
         // TODO: implement
         return null;
      }
      
      public List<AppointmentOperationDTO> GetAllAppointmentsByDoctorId(long doctorId)
      {
         // TODO: implement
         return null;
      }
      
      public Dto.MedicalServiceDTOs.AppointmentOperationDTO AddNewAppointment(Dto.MedicalServiceDTOs.AppointmentOperationDTO newAppointmentDTO)
      {
         // TODO: implement
         return null;
      }
      
      public List<DateTime> GetAvailableAppointmentTimesByDate(DateTime date)
      {
         // TODO: implement
         return null;
      }
      
      public Dto.MedicalServiceDTOs.AppointmentOperationDTO GetAppointmentById(long appointmentId)
      {
         // TODO: implement
         return null;
      }
      
      public List<DateTime> GetDatesWithAvailableAppointment(DateTime month)
      {
         // TODO: implement
         return null;
      }
   
      private List<DateTime> GetAvailableAppointmentsDates(Shift shift, List<Appointment> appointments)
      {
         // TODO: implement
         return null;
      }
      
      private Boolean CheckAvailabilityBetweenAppointments(Appointment firstAppointmnet, Appointment secondAppointment)
      {
         // TODO: implement
         return null;
      }
      
      private List<DateTime> GetAvailableAppointmentTimes(Shift shift, List<Appointments> appointments)
      {
         // TODO: implement
         return null;
      }
   
      public Repository.UserRepositories.UserRepository userRepository;
      public Repository.MedicalServicesRepositories.AppointmentRepository appointmentRepository;
      public Repository.EquipmentAndRoomsRepositories.ServiceRoomRepository serviceRoomRepository;
      public Repository.MedicalServicesRepositories.OperationRepository operationRepository;
      public Repository.MedicalServicesRepositories.HospitalizationRepository hospitalizationRepository;
      public Repository.DoctorServicesRepositories.DurationPeriodRepository durationPeriodRepository;
   
   }
}