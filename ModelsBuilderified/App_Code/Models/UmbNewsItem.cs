﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Umbraco.Core;

namespace Umbraco.Web.PublishedContentModels
{
    public partial class UmbNewsItem
    {
        public DateTime DisplayDate
        {
            get
            {
                if (PublishDate == default(DateTime))
                    return CreateDate;
                return PublishDate;
            }
        }
        public IHtmlString Extract
        {
            get { return new HtmlString(BodyText.ToHtmlString().StripHtml().Truncate(200)); }
        }

    }
}