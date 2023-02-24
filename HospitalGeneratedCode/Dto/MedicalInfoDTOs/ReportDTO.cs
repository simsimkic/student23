/***********************************************************************
 * Module:  ReportDTO.cs
 * Purpose: Definition of the Class Dto.MedicalInfoDTOs.ReportDTO
 ***********************************************************************/

using System;

namespace Dto.MedicalInfoDTOs
{
   public class ReportDTO
   {
      private String ProblemDescription;
      private String AppointmentDescription;
      private Dictionary<String, String> Diagnosis;
   
   }
}