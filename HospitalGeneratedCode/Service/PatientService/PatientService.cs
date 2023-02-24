/***********************************************************************
 * Module:  PatientService.cs
 * Purpose: Definition of the Class Service.PatientService.PatientService
 ***********************************************************************/

using System;

namespace Service.PatientService
{
   public class PatientService
   {
      public List<UserDTO> GetAllPatientsByDoctorId(long doctorId)
      {
         // TODO: implement
         return null;
      }
      
      public Dto.MedicalServiceDTOs.AppointmentOperationDTO CancelAppointment(long appointmentId)
      {
         // TODO: implement
         return null;
      }
      
      public Dto.MedicalServiceDTOs.AppointmentOperationDTO PostponeAppointment(Dto.MedicalServiceDTOs.AppointmentOperationDTO postponedAppointment)
      {
         // TODO: implement
         return null;
      }
      
      public RateDTO RateDoctor(RateDTO rateInfo)
      {
         // TODO: implement
         return null;
      }
      
      public List<DateTime> GetRecommendedAppointmentsByDate(DateTime date)
      {
         // TODO: implement
         return null;
      }
   
      public Repository.MedicalServicesRepositories.AppointmentRepository appointmentRepository;
      public Repository.MedicalInfoRepositories.MedicalRecordRepository medicalRecordRepository;
      public Repository.UserRepositories.UserRepository userRepository;
      public Repository.MedicalServicesRepositories.OperationRepository operationRepository;
      public Repository.MedicalServicesRepositories.HospitalizationRepository hospitalizationRepository;
   
   }
}