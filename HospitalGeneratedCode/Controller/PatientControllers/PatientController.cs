/***********************************************************************
 * Module:  PatientController.cs
 * Purpose: Definition of the Class Controller.PatientControllers.PatientController
 ***********************************************************************/

using System;

namespace Controller.PatientControllers
{
   public class PatientController
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
   
      public Service.PatientService.PatientService patientService;
   
   }
}