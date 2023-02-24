/***********************************************************************
 * Module:  UserProfileController.cs
 * Purpose: Definition of the Class Controller.UserProfileController
 ***********************************************************************/

using System;

namespace Controller.UserControllers
{
   public class UserProfileController
   {
      public UserDTO GetUserProfile(long userID)
      {
         // TODO: implement
         return null;
      }
      
      public UserDTO EditUserProfile(UserDTO newUserData)
      {
         // TODO: implement
         return null;
      }
      
      public UserDTO ChangePassword(ChangePasswordDTO changePasswordDTO)
      {
         // TODO: implement
         return null;
      }
   
      public Service.UserServices.UserProfileService userProfileService;
   
   }
}