/***********************************************************************
 * Module:  Pacijent.cs
 * Purpose: Definition of the Class Pacijent
 ***********************************************************************/

using System;

namespace Model.User
{
   public class Patient : User
   {
      public City birthplace;
      public MedicalRecord medicalRecord;
   
      private Sex Sex;
      private DateTime BirthDate;
      private Boolean GuestFlag;
   
   }
}