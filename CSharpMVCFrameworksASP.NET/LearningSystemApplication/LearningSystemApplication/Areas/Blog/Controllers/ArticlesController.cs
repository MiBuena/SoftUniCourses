using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AutoMapper;
using LearningSystem.Models.BindingModels;
using LearningSystem.Models.EntityModels;
using LearningSystem.Models.ViewModels;
using LearningSystem.Services;
using LearningSystem.Services.Interfaces;
using LearningSystem.Services.Services;
using LearningSystemApplication.Attributes;
using Microsoft.AspNet.Identity;

namespace LearningSystemApplication.Areas.Blog.Controllers
{
    [Authorize]
    public class ArticlesController : Controller
    {
        private IArticlesService articlesService;

        public ArticlesController(IArticlesService articlesService)
        {
            this.articlesService = articlesService;
        }

        // GET: Blog/Articles
        public ActionResult All()
        {
            var articles = this.articlesService.GetAllArticles();

            return View(articles);
        }

        [MyAuthorize(Roles = "BlogAuthor")]
        public ActionResult Publish()
        {
            string currentUserId = User.Identity.GetUserId();
            NewArticleViewModel newArticleViewModel = new NewArticleViewModel();

            newArticleViewModel.Id = currentUserId;

            return View(newArticleViewModel);
        }

        [MyAuthorize(Roles = "BlogAuthor")]
        [HttpPost]
        public ActionResult Publish([Bind(Include = "Id,Title,Content")] NewArticleBindingModel model)
        {
            if (this.ModelState.IsValid)
            {
                this.articlesService.PublishArticle(model);
                return this.RedirectToAction("All");
            }

            var articleViewModel = Mapper.Map<NewArticleBindingModel, NewArticleViewModel>(model);

            return View(articleViewModel);
        }
    }
}