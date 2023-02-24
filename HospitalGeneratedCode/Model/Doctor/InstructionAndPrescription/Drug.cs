/***********************************************************************
 * Module:  Lek.cs
 * Purpose: Definition of the Class Lek
 ***********************************************************************/

using System;

namespace Model.Doctor.InstructionAndPrescription
{
   public class Drug
   {
      public System.Collections.ArrayList ingredient;
      
      /// <pdGenerated>default getter</pdGenerated>
      public System.Collections.ArrayList GetIngredient()
      {
         if (ingredient == null)
            ingredient = new System.Collections.ArrayList();
         return ingredient;
      }
      
      /// <pdGenerated>default setter</pdGenerated>
      public void SetIngredient(System.Collections.ArrayList newIngredient)
      {
         RemoveAllIngredient();
         foreach (Ingredient oIngredient in newIngredient)
            AddIngredient(oIngredient);
      }
      
      /// <pdGenerated>default Add</pdGenerated>
      public void AddIngredient(Ingredient newIngredient)
      {
         if (newIngredient == null)
            return;
         if (this.ingredient == null)
            this.ingredient = new System.Collections.ArrayList();
         if (!this.ingredient.Contains(newIngredient))
            this.ingredient.Add(newIngredient);
      }
      
      /// <pdGenerated>default Remove</pdGenerated>
      public void RemoveIngredient(Ingredient oldIngredient)
      {
         if (oldIngredient == null)
            return;
         if (this.ingredient != null)
            if (this.ingredient.Contains(oldIngredient))
               this.ingredient.Remove(oldIngredient);
      }
      
      /// <pdGenerated>default removeAll</pdGenerated>
      public void RemoveAllIngredient()
      {
         if (ingredient != null)
            ingredient.Clear();
      }
   
      private String Code;
      private int Amount;
      private String Name;
      private String Description;
      private Boolean IsApproved = false;
   
   }
}