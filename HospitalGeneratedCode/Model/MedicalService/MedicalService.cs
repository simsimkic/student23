/***********************************************************************
 * Module:  MedicinskaUsluga.cs
 * Purpose: Definition of the Class MedicinskaUsluga
 ***********************************************************************/

using System;

namespace Model.MedicalService
{
   public class MedicalService
   {
      public Model.EquipmentAndRooms.ServiceRoom serviceRoom;
      public Model.Patient.MedicalRecord medicalRecord;
   
      private long Id;
      private DateTime StartDate;
   
   }
}