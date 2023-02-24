/***********************************************************************
 * Module:  Boravak.cs
 * Purpose: Definition of the Class Boravak
 ***********************************************************************/

using System;

namespace Model.MedicalService
{
   public class Hospitalization : MedicalService
   {
      public Model.EquipmentAndRooms.HospitalizationRoom hospitalizationRoom;
   
      private DateTime EndDate;
   
   }
}