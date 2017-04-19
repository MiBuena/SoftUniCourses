using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LearningSystemApplication.Helpers
{
    public static class HtmlHelpers
    {
        public static MvcHtmlString Button(this HtmlHelper helper, string text, int course)
        {
            TagBuilder builder = new TagBuilder("button");
            builder.AddCssClass("btn btn-success");
            builder.MergeAttribute("type", "submit");
            builder.InnerHtml = text;

            return new MvcHtmlString(builder.ToString());
        }
    }

}