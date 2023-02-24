/***********************************************************************
 * Module:  EquipmentReservationTime.cs
 * Purpose: Definition of the Class Model.EquipmentAndRooms.EquipmentReservationTime
 ***********************************************************************/

using System;

namespace Model.EquipmentAndRooms
{
   public class EquipmentReservationTime
   {
      public Room room;
      public MedicalEquipment medicalEquipment;
   
      private DateTime StartDate;
      private int Duration;
      private int Amount;
   
   }
}