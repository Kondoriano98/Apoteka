using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
namespace Apoteka.Helperi
{
    public class helperi
    {

        public static MvcHtmlString MyHelper(string src, string tekst)
        {
            var tagBuilder = new TagBuilder("div");
            tagBuilder.InnerHtml = "<img src=" + src + ">" + tekst;
            tagBuilder.AddCssClass("studProg");
            return new MvcHtmlString(tagBuilder.ToString());

        }


    }
}