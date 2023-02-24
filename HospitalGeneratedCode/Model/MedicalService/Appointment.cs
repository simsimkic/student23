/***********************************************************************
 * Module:  Pregled.cs
 * Purpose: Definition of the Class Pregled
 ***********************************************************************/

using System;

namespace Model.MedicalService
{
   public class Appointment : MedicalService
   {
      public Report report;
      public Model.User.Doctor doctor;
   
      private Boolean WasHeld;
      private int Duration;
      private Priority Priorty;
   
   }
}