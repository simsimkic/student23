/***********************************************************************
 * Module:  ReportService.cs
 * Purpose: Definition of the Class Service.MedicalInfoServices.ReportService
 ***********************************************************************/

using System;

namespace Service.MedicalInfoServices
{
   public class ReportService
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
   
      public Repository.MedicalInfoRepositories.ReportRepository reportRepository;
   
   }
}