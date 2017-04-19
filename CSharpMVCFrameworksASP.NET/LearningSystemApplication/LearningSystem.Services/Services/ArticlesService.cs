using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using LearningSystem.Models.BindingModels;
using LearningSystem.Models.EntityModels;
using LearningSystem.Models.ViewModels;
using LearningSystem.Services.Interfaces;

namespace LearningSystem.Services.Services
{
    public class ArticlesService : Service, IArticlesService
    {

        public IEnumerable<AllArticlesViewModel> GetAllArticles()
        {
            var articles = this.Context.Articles.ToList();

            var articlesViewModels = Mapper.Map<IEnumerable<Article>, IEnumerable<AllArticlesViewModel>>(articles);

            return articlesViewModels;
        }

        public void PublishArticle(NewArticleBindingModel model)
        {
            Article article = new Article()
            {
                Content = model.Content,
                PublishDate = DateTime.Now,
                Title = model.Title
            };

            var user = this.Context.Users.Find(model.Id);

            article.Author = user;

            this.Context.Articles.Add(article);

            this.Context.SaveChanges();
        }


    }
}
