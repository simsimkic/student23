/***********************************************************************
 * Module:  DrugDTO.cs
 * Purpose: Definition of the Class Dto.MedicalInfoDTOs.DrugDTO
 ***********************************************************************/

using System;

namespace Dto.MedicalInfoDTOs
{
   public class DrugDTO
   {
      private int Amount;
      private String Name;
      private String Description;
      private Dictionary<long, String> Ingredients;
      private String Code;
   
   }
}