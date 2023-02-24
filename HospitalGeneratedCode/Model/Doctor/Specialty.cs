/***********************************************************************
 * Module:  Specijalnost.cs
 * Purpose: Definition of the Class Specijalnost
 ***********************************************************************/

using System;

namespace Model.Doctor
{
   public class Specialty
   {
      public System.Collections.ArrayList operationType;
      
      /// <pdGenerated>default getter</pdGenerated>
      public System.Collections.ArrayList GetOperationType()
      {
         if (operationType == null)
            operationType = new System.Collections.ArrayList();
         return operationType;
      }
      
      /// <pdGenerated>default setter</pdGenerated>
      public void SetOperationType(System.Collections.ArrayList newOperationType)
      {
         RemoveAllOperationType();
         foreach (OperationType oOperationType in newOperationType)
            AddOperationType(oOperationType);
      }
      
      /// <pdGenerated>default Add</pdGenerated>
      public void AddOperationType(OperationType newOperationType)
      {
         if (newOperationType == null)
            return;
         if (this.operationType == null)
            this.operationType = new System.Collections.ArrayList();
         if (!this.operationType.Contains(newOperationType))
         {
            this.operationType.Add(newOperationType);
            newOperationType.SetSpecialty(this);      
         }
      }
      
      /// <pdGenerated>default Remove</pdGenerated>
      public void RemoveOperationType(OperationType oldOperationType)
      {
         if (oldOperationType == null)
            return;
         if (this.operationType != null)
            if (this.operationType.Contains(oldOperationType))
            {
               this.operationType.Remove(oldOperationType);
               oldOperationType.SetSpecialty((Model.Doctor.Specialty)null);
            }
      }
      
      /// <pdGenerated>default removeAll</pdGenerated>
      public void RemoveAllOperationType()
      {
         if (operationType != null)
         {
            System.Collections.ArrayList tmpOperationType = new System.Collections.ArrayList();
            foreach (OperationType oldOperationType in operationType)
               tmpOperationType.Add(oldOperationType);
            operationType.Clear();
            foreach (OperationType oldOperationType in tmpOperationType)
               oldOperationType.SetSpecialty((Model.Doctor.Specialty)null);
            tmpOperationType.Clear();
         }
      }
   
      private int SpecialityCode;
      private String SpecialityName;
   
   }
}