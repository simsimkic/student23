/***********************************************************************
 * Module:  TipOperacije.cs
 * Purpose: Definition of the Class TipOperacije
 ***********************************************************************/

using System;

namespace Model.MedicalService
{
   public class OperationType
   {
      public Model.Doctor.Specialty specialty;
      
      /// <pdGenerated>default parent getter</pdGenerated>
      public Model.Doctor.Specialty GetSpecialty()
      {
         return specialty;
      }
      
      /// <pdGenerated>default parent setter</pdGenerated>
      /// <param>newSpecialty</param>
      public void SetSpecialty(Model.Doctor.Specialty newSpecialty)
      {
         if (this.specialty != newSpecialty)
         {
            if (this.specialty != null)
            {
               Model.Doctor.Specialty oldSpecialty = this.specialty;
               this.specialty = null;
               oldSpecialty.RemoveOperationType(this);
            }
            if (newSpecialty != null)
            {
               this.specialty = newSpecialty;
               this.specialty.AddOperationType(this);
            }
         }
      }
   
      private int OperationCode;
      private String OperationDescription;
   
   }
}