using System.Collections.Generic;
using LearningSystem.Models.BindingModels;
using LearningSystem.Models.ViewModels;

namespace LearningSystem.Services.Interfaces
{
    public interface IArticlesService
    {
        IEnumerable<AllArticlesViewModel> GetAllArticles();
        void PublishArticle(NewArticleBindingModel model);
    }
}