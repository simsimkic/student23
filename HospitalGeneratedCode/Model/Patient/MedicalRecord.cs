/***********************************************************************
 * Module:  ZdravstveniKarton.cs
 * Purpose: Definition of the Class ZdravstveniKarton
 ***********************************************************************/

using System;

namespace Model.Patient
{
   public class MedicalRecord
   {
      public System.Collections.ArrayList allergy;
      
      /// <pdGenerated>default getter</pdGenerated>
      public System.Collections.ArrayList GetAllergy()
      {
         if (allergy == null)
            allergy = new System.Collections.ArrayList();
         return allergy;
      }
      
      /// <pdGenerated>default setter</pdGenerated>
      public void SetAllergy(System.Collections.ArrayList newAllergy)
      {
         RemoveAllAllergy();
         foreach (Allergy oAllergy in newAllergy)
            AddAllergy(oAllergy);
      }
      
      /// <pdGenerated>default Add</pdGenerated>
      public void AddAllergy(Allergy newAllergy)
      {
         if (newAllergy == null)
            return;
         if (this.allergy == null)
            this.allergy = new System.Collections.ArrayList();
         if (!this.allergy.Contains(newAllergy))
            this.allergy.Add(newAllergy);
      }
      
      /// <pdGenerated>default Remove</pdGenerated>
      public void RemoveAllergy(Allergy oldAllergy)
      {
         if (oldAllergy == null)
            return;
         if (this.allergy != null)
            if (this.allergy.Contains(oldAllergy))
               this.allergy.Remove(oldAllergy);
      }
      
      /// <pdGenerated>default removeAll</pdGenerated>
      public void RemoveAllAllergy()
      {
         if (allergy != null)
            allergy.Clear();
      }
      public Prescription[] prescription;
      public Model.User.Patient patient;
      public MedicalService[] medicalService;
      public LaboratoryInstruction[] laboratoryInstruction;
   
      private long Id;
      private BloodType BloodType;
      private int Height;
      private int Weight;
      private double Dioptre;
   
   }
}