/***********************************************************************
 * Module:  Operacija.cs
 * Purpose: Definition of the Class Operacija
 ***********************************************************************/

using System;

namespace Model.MedicalService
{
   public class Operation : MedicalService
   {
      public OperationType operationType;
      public Model.Doctor.SpecialistDoctor specialistDoctor;
   
      private int Duration;
   
   }
}