/***********************************************************************
 * Module:  AppointmentController.cs
 * Purpose: Definition of the Class Controller.AppointmentController
 ***********************************************************************/

using System;

namespace Controller.MedicalServiceControllers
{
   public class AppointmentController : ServiceTemplate
   {
      public List<AppointmentOperationDTO> GetAllServicesByPatientId(long patientId)
      {
         // TODO: implement
         return null;
      }
      
      public List<AppointmentOperationDTO> GetAllServicesByDoctorId(long doctorId)
      {
         // TODO: implement
         return null;
      }
      
      public Dto.MedicalServiceDTOs.AppointmentOperationDTO AddNewAppointment(Dto.MedicalServiceDTOs.AppointmentOperationDTO newAppointmentDTO)
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
      
      public List<DateTime> GetAvailableAppointmentTimesByDateAndPatientId(DateTime date, long patientId)
      {
         // TODO: implement
         return null;
      }
   
      public Service.MedicalServices.AppointmentService appointmentService;
   
   }
}