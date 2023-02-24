/***********************************************************************
 * Module:  ServiceRoomService.cs
 * Purpose: Definition of the Class Service.EquipmentAndRoomsServices.ServiceRoomService
 ***********************************************************************/

using System;

namespace Service.EquipmentAndRoomsServices
{
   public class ServiceRoomService
   {
      public List<ServiceRoom> GetAllAvailableServiceRoomsForAppointment(DateTime startDate, int duration)
      {
         // TODO: implement
         return null;
      }
      
      public List<ServiceRoom> GetAllAvailableServiceRoomsForOperation(DateTime startDate, int duration, Model.EquipmentAndRooms.ServiceType serviceType)
      {
         // TODO: implement
         return null;
      }
   
      private List<ServiceRoom> GetServiceRoomsWithoutMedicalServicesInSpecificPeriod(DateTime startDate, int duration, Dictionary<long, List> appointmentsByServiceRoom)
      {
         // TODO: implement
         return null;
      }
   
      public Repository.EquipmentAndRoomsRepositories.ServiceRoomRepository serviceRoomRepository;
      public Repository.MedicalServicesRepositories.OperationRepository operationRepository;
      public Repository.MedicalServicesRepositories.AppointmentRepository appointmentRepository;
   
   }
}