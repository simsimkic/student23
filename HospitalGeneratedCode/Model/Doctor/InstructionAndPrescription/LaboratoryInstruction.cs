/***********************************************************************
 * Module:  UputZaLaboratoriju.cs
 * Purpose: Definition of the Class UputZaLaboratoriju
 ***********************************************************************/

using System;

namespace Model.Doctor.InstructionAndPrescription
{
   public class LaboratoryInstruction
   {
      public Model.User.Doctor doctor;
      public AnalysisType[] analysisType;
   
      private long Id;
      private DateTime IssueDate;
      private String AdditionalComment;
   
   }
}