/***********************************************************************
 * Module:  OperationService.cs
 * Purpose: Definition of the Class Service.OperationService
 ***********************************************************************/

using System;

namespace Service.MedicalServices
{
   public class OperationService
   {
      public List<AppointmentOperationDTO> GetAllOperationsByPatientId(long patientId)
      {
         // TODO: implement
         return null;
      }
      
      public List<AppointmentOperationDTO> GetAllOperationsByDoctorId(long doctorId)
      {
         // TODO: implement
         return null;
      }
      
      public Dto.MedicalServiceDTOs.AppointmentOperationDTO AddNewOperation(Dto.MedicalServiceDTOs.AppointmentOperationDTO newOperationDTO, Dto.EquipmentAndRoomsDTOs.MedicalEquipmentDTO reservedMedicalEquipment)
      {
         // TODO: implement
         return null;
      }
   
      private Boolean ReserveMedicalEquipment(Model.EquipmentAndRooms.ServiceRoom reservedRoom, Dto.EquipmentAndRoomsDTOs.MedicalEquipmentDTO reservedMedicalEquipmentDTO)
      {
         // TODO: implement
         return null;
      }
   
      public Repository.UserRepositories.UserRepository userRepository;
      public Repository.MedicalServicesRepositories.OperationRepository operationRepository;
      public Repository.EquipmentAndRoomsRepositories.ServiceRoomRepository serviceRoomRepository;
      public Repository.EquipmentAndRoomsRepositories.MedicalEquipmentRepository medicalEquipmentRepository;
      public System.Collections.ArrayList equipmentReservationTimeRepository;
      
      /// <pdGenerated>default getter</pdGenerated>
      public System.Collections.ArrayList GetEquipmentReservationTimeRepository()
      {
         if (equipmentReservationTimeRepository == null)
            equipmentReservationTimeRepository = new System.Collections.ArrayList();
         return equipmentReservationTimeRepository;
      }
      
      /// <pdGenerated>default setter</pdGenerated>
      public void SetEquipmentReservationTimeRepository(System.Collections.ArrayList newEquipmentReservationTimeRepository)
      {
         RemoveAllEquipmentReservationTimeRepository();
         foreach (Repository.EquipmentAndRoomsRepositories.EquipmentReservationTimeRepository oEquipmentReservationTimeRepository in newEquipmentReservationTimeRepository)
            AddEquipmentReservationTimeRepository(oEquipmentReservationTimeRepository);
      }
      
      /// <pdGenerated>default Add</pdGenerated>
      public void AddEquipmentReservationTimeRepository(Repository.EquipmentAndRoomsRepositories.EquipmentReservationTimeRepository newEquipmentReservationTimeRepository)
      {
         if (newEquipmentReservationTimeRepository == null)
            return;
         if (this.equipmentReservationTimeRepository == null)
            this.equipmentReservationTimeRepository = new System.Collections.ArrayList();
         if (!this.equipmentReservationTimeRepository.Contains(newEquipmentReservationTimeRepository))
            this.equipmentReservationTimeRepository.Add(newEquipmentReservationTimeRepository);
      }
      
      /// <pdGenerated>default Remove</pdGenerated>
      public void RemoveEquipmentReservationTimeRepository(Repository.EquipmentAndRoomsRepositories.EquipmentReservationTimeRepository oldEquipmentReservationTimeRepository)
      {
         if (oldEquipmentReservationTimeRepository == null)
            return;
         if (this.equipmentReservationTimeRepository != null)
            if (this.equipmentReservationTimeRepository.Contains(oldEquipmentReservationTimeRepository))
               this.equipmentReservationTimeRepository.Remove(oldEquipmentReservationTimeRepository);
      }
      
      /// <pdGenerated>default removeAll</pdGenerated>
      public void RemoveAllEquipmentReservationTimeRepository()
      {
         if (equipmentReservationTimeRepository != null)
            equipmentReservationTimeRepository.Clear();
      }
      public Repository.MedicalServicesRepositories.AppointmentRepository appointmentRepository;
      public Repository.MedicalServicesRepositories.HospitalizationRepository hospitalizationRepository;
   
   }
}