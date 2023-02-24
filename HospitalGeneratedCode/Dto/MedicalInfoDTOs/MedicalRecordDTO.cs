/***********************************************************************
 * Module:  ZdravstveniKarton.cs
 * Purpose: Definition of the Class ZdravstveniKarton
 ***********************************************************************/

using System;

namespace Dto.MedicalInfoDTOs
{
   public class MedicalRecordDTO
   {
      private String BloodType;
      private int Height;
      private int Weight;
      private double Dioptre;
      private Dictionary<long, String> Allergies;
      private long Id;
   
   }
}