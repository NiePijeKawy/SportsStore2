﻿using SportsStore.WebUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace SportsStore.WebUI.HtmlHelpers
{
    public static class PagingHelpers
    {
        // metoda rozszerzająca
        public static MvcHtmlString PageLinks(this HtmlHelper html, PagingInfo pagingInfo, Func<int, string> pageUrl)
        {
            StringBuilder result = new StringBuilder();
            for (int i = 1; i <= pagingInfo.TotalPage; i++)
            {
                TagBuilder tag = new TagBuilder("a");
                tag.MergeAttribute("href", pageUrl(i));
                tag.InnerHtml = i.ToString();
                if (i== pagingInfo.CurrentPage)              
                    tag.AddCssClass("selected");

                result.Append(tag.ToString());
                
            }
            return MvcHtmlString.Create(result.ToString());
        }
    }
}