﻿using System.Web.Mvc;

namespace HelperMethods.Infrastructure
{
    public static class CustomerHelpers
    {
        public static MvcHtmlString ListArrayItems(this HtmlHelper html, string[] list)
        {
            TagBuilder tag = new TagBuilder("ul");
            foreach (string str in list)
            {
                TagBuilder itemTag = new TagBuilder("li");
                itemTag.SetInnerText(str);
                tag.InnerHtml += itemTag.ToString();
            }
            return new MvcHtmlString(tag.ToString());
        }

        public static MvcHtmlString DisplayMessage(this HtmlHelper html, string msg)
        {
            string encodeMessage = html.Encode(msg);
            string result = string.Format($"This is the message: <p>{encodeMessage}</p>");
            return new MvcHtmlString(result);
        }
    }
}