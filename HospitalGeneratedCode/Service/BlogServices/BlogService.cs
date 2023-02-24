/***********************************************************************
 * Module:  BlogService.cs
 * Purpose: Definition of the Class Service.BlogService
 ***********************************************************************/

using System;

namespace Service.BlogServices
{
   public class BlogService
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
   
      public Repository.BlogRepositories.ArticleRepository articleRepository;
      public Repository.BlogRepositories.CategoryRepository categoryRepository;
   
   }
}