/***********************************************************************
 * Module:  UserRepository.cs
 * Purpose: Definition of the Class Repository.UserRepository
 ***********************************************************************/

using System;

namespace Repository.UserRepositories
{
   public class UserRepository
   {
      public User SaveUser(User user)
      {
         // TODO: implement
         return null;
      }
      
      public User DeleteUserById(long userId)
      {
         // TODO: implement
         return null;
      }
      
      public User GetUserById(long userId)
      {
         // TODO: implement
         return null;
      }
      
      public User GetUserByEmail(String userEmail)
      {
         // TODO: implement
         return null;
      }
      
      public UserRepository GetInstance()
      {
         // TODO: implement
         return null;
      }
   
      private UserRepository()
      {
         // TODO: implement
      }
   
      public UserRepository userRepositoryB;
   
      private static UserRepository Instance;
   
   }
}