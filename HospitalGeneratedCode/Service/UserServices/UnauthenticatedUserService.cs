/***********************************************************************
 * Module:  UnauthenticatedUserService.cs
 * Purpose: Definition of the Class Service.UnauthenticatedUserService
 ***********************************************************************/

using System;

namespace Service.UserServices
{
   public class UnauthenticatedUserService
   {
      public UserInfoDTO GetUserInfoByEmail(String userEmail)
      {
         // TODO: implement
         return null;
      }
      
      public UserDTO Login(String email, String password)
      {
         // TODO: implement
         return null;
      }
      
      public UserDTO Registration(UserDTO newUser)
      {
         // TODO: implement
         return null;
      }
      
      public ChangeEmailDTO ChangeEmail(ChangeEmailDTO changeEmailDTO)
      {
         // TODO: implement
         return null;
      }
      
      public ChangePasswordDTO ChangeForgottenPassword(ChangePasswordDTO changePasswordDTO)
      {
         // TODO: implement
         return null;
      }
   
      public Repository.UserRepositories.UserRepository userRepository;
   
   }
}