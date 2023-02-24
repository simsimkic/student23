/***********************************************************************
 * Module:  AppointmentOperationDTO.cs
 * Purpose: Definition of the Class Dto.AppointmentOperationDTO
 ***********************************************************************/

using System;

namespace Dto.MedicalServiceDTOs
{
   public class AppointmentOperationDTO
   {
      private DateTime StartDate;
      private long PatientId;
      private long DoctorId;
      private String PatientName;
      private String DoctorName;
      private long RoomId;
      private String RoomName;
      private Boolean WasHeld;
      private int Duration;
      private String MedicalServiceType;
      private int OperationTypeId;
   
   }
}