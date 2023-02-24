/***********************************************************************
 * Module:  BlogController.cs
 * Purpose: Definition of the Class Controller.BlogController
 ***********************************************************************/

using System;

namespace Controller.BlogControllers
{
   public class BlogController
   {
      public List<ArticleDTO> GetAllArticles()
      {
         // TODO: implement
         return null;
      }
      
      public ArticleDTO EditArticle(ArticleDTO editedArticle)
      {
         // TODO: implement
         return null;
      }
      
      public ArticleDTO AddArticle(ArticleDTO newArticle)
      {
         // TODO: implement
         return null;
      }
      
      public List<Category> GetAllCategories()
      {
         // TODO: implement
         return null;
      }
   
      public Service.BlogServices.BlogService blogService;
   
   }
}