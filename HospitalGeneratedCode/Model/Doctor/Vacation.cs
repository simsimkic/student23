/***********************************************************************
 * Module:  GodisnjiOdmor.cs
 * Purpose: Definition of the Class GodisnjiOdmor
 ***********************************************************************/

using System;

namespace Model.Doctor
{
   public class Vacation
   {
      public Model.User.Doctor doctor;
   
      private DateTime StartDate;
      private DateTime EndDate;
      private Boolean IsApproved;
      private String RejectionReason;
   
   }
}