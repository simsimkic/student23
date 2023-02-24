/***********************************************************************
 * Module:  ReportController.cs
 * Purpose: Definition of the Class Controller.MedicalInfoControllers.ReportController
 ***********************************************************************/

using System;

namespace Controller.MedicalInfoControllers
{
   public class ReportController
   {
      public Dto.MedicalInfoDTOs.ReportDTO GetReportByAppointmentId(long appointmentId)
      {
         // TODO: implement
         return null;
      }
      
      public Dto.MedicalInfoDTOs.ReportDTO AddReport(Dto.MedicalInfoDTOs.ReportDTO reportDTO)
      {
         // TODO: implement
         return null;
      }
   
      public Service.MedicalInfoServices.ReportService reportService;
   
   }
}