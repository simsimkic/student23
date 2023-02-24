/***********************************************************************
 * Module:  AppointmentRepository.cs
 * Purpose: Definition of the Class Repository.AppointmentRepository
 ***********************************************************************/

using System;

namespace Repository.MedicalServicesRepositories
{
   public class AppointmentRepository
   {
      public Appointment SaveAppoinment(Appointment appointment)
      {
         // TODO: implement
         return null;
      }
      
      public Appointment DeleteAppointmentById(long appointmentId)
      {
         // TODO: implement
         return null;
      }
      
      public Appointment GetAppointmentById(long appointmentId)
      {
         // TODO: implement
         return null;
      }
      
      public List<Appointment> GetAllAppointmentsByMedicalRecordId(long medicalRecordId)
      {
         // TODO: implement
         return null;
      }
      
      public List<Appointment> GetAllAppointmentsByDoctorId(long doctorId)
      {
         // TODO: implement
         return null;
      }
      
      public List<Appointment> GetAllApointmentsByServiceRoom(Model.EquipmentAndRooms.ServiceRoom serviceRoom)
      {
         // TODO: implement
         return null;
      }
      
      public List<Appointment> GetAllAppointmentsByDay(DateTime day)
      {
         // TODO: implement
         return null;
      }
      
      public List<Appointment> GetAppointmentsByPatientIdAndDay(long patientId, DateTime day)
      {
         // TODO: implement
         return null;
      }
   
   }
}