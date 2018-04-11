using System;
using System.Text;
using System.Web.Mvc;
using System.Collections.Generic;
using System.Reflection;

namespace DistribucionDependencias.WebUI.HtmlHelpers
{
    public static class InputHelpers
    {
        public static MvcHtmlString DropDownListTextBox(this HtmlHelper html, string name, string placeholder, IEnumerable<SelectListItem> selectList, object htmlAttributes)
        {
            StringBuilder result = new StringBuilder();
            TagBuilder tag = new TagBuilder("input");
            tag.MergeAttribute("type", "text");
            tag.MergeAttribute("list", name);
            if ( !String.IsNullOrEmpty(placeholder) )
                tag.MergeAttribute("placeholder", placeholder);
            if (htmlAttributes != null)
            {
                Type tipo = htmlAttributes.GetType();
                IList<PropertyInfo> propiedades = new List<PropertyInfo>(tipo.GetProperties());
                foreach (PropertyInfo p in propiedades)
                {
                    tag.MergeAttribute(p.Name, p.GetValue(htmlAttributes, null).ToString());
                }
            }
            result.Append(tag.ToString());

            tag = new TagBuilder("datalist");
            tag.MergeAttribute("id",name);
            tag.InnerHtml = "";
            TagBuilder options = new TagBuilder("option");
            foreach(SelectListItem sli in selectList)
            {
                if (sli.Disabled)
                    options.MergeAttribute("disabled", null);
                if (sli.Selected)
                    options.MergeAttribute("selected", null);
                if (!String.IsNullOrEmpty(sli.Value))
                    options.MergeAttribute("value", sli.Value);
                options.InnerHtml = sli.Text;
                tag.InnerHtml += options.ToString();
                options = new TagBuilder("option");
            }
            result.Append(tag.ToString());

            return MvcHtmlString.Create(result.ToString());
        }
    }
}