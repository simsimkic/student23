/***********************************************************************
 * Module:  OperationController.cs
 * Purpose: Definition of the Class Controller.OperationController
 ***********************************************************************/

using System;

namespace Controller.MedicalServiceControllers
{
   public class OperationController : ServiceTemplate
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
      
      public Dto.MedicalServiceDTOs.AppointmentOperationDTO AddNewOperation(Dto.MedicalServiceDTOs.AppointmentOperationDTO newOperationDTO, Dto.EquipmentAndRoomsDTOs.MedicalEquipmentDTO reservedMedicalEquipment)
      {
         // TODO: implement
         return null;
      }
   
      public Service.MedicalServices.OperationService operationService;
   
   }
}