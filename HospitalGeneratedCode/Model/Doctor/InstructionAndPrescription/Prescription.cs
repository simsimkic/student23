/***********************************************************************
 * Module:  LekarskiRecept.cs
 * Purpose: Definition of the Class LekarskiRecept
 ***********************************************************************/

using System;

namespace Model.Doctor.InstructionAndPrescription
{
   public class Prescription
   {
      public System.Collections.ArrayList prescriptionItem;
      
      /// <pdGenerated>default getter</pdGenerated>
      public System.Collections.ArrayList GetPrescriptionItem()
      {
         if (prescriptionItem == null)
            prescriptionItem = new System.Collections.ArrayList();
         return prescriptionItem;
      }
      
      /// <pdGenerated>default setter</pdGenerated>
      public void SetPrescriptionItem(System.Collections.ArrayList newPrescriptionItem)
      {
         RemoveAllPrescriptionItem();
         foreach (PrescriptionItem oPrescriptionItem in newPrescriptionItem)
            AddPrescriptionItem(oPrescriptionItem);
      }
      
      /// <pdGenerated>default Add</pdGenerated>
      public void AddPrescriptionItem(PrescriptionItem newPrescriptionItem)
      {
         if (newPrescriptionItem == null)
            return;
         if (this.prescriptionItem == null)
            this.prescriptionItem = new System.Collections.ArrayList();
         if (!this.prescriptionItem.Contains(newPrescriptionItem))
            this.prescriptionItem.Add(newPrescriptionItem);
      }
      
      /// <pdGenerated>default Remove</pdGenerated>
      public void RemovePrescriptionItem(PrescriptionItem oldPrescriptionItem)
      {
         if (oldPrescriptionItem == null)
            return;
         if (this.prescriptionItem != null)
            if (this.prescriptionItem.Contains(oldPrescriptionItem))
               this.prescriptionItem.Remove(oldPrescriptionItem);
      }
      
      /// <pdGenerated>default removeAll</pdGenerated>
      public void RemoveAllPrescriptionItem()
      {
         if (prescriptionItem != null)
            prescriptionItem.Clear();
      }
      public Model.User.Doctor doctor;
   
      private long Id;
      private DateTime IssueDate;
   
   }
}