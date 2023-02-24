/***********************************************************************
 * Module:  UserProfileService.cs
 * Purpose: Definition of the Class Service.UserProfileService
 ***********************************************************************/

using System;

namespace Service.UserServices
{
   public class UserProfileService
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
   
      public Repository.UserRepositories.UserRepository userRepository;
   
   }
}