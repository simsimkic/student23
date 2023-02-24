/***********************************************************************
 * Module:  PrescriptionDTO.cs
 * Purpose: Definition of the Class Dto.MedicalInfoDTOs.PrescriptionDTO
 ***********************************************************************/

using System;

namespace Dto.MedicalInfoDTOs
{
   public class PrescriptionDTO
   {
      private DateTime IssueDate;
      private long DoctorId;
      private String DoctorName;
      private Dictionary<String, DrugDTO> DrugsList;
   
   }
}