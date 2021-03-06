﻿using System.ComponentModel.DataAnnotations;
using CodeAnalyzers.Episerver.Integration.Business;
using EPiServer.Commerce.Catalog.ContentTypes;
using EPiServer.Commerce.Catalog.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

namespace CodeAnalyzers.Episerver.Integration.Models.CatalogContent
{
    [CatalogContentType(DisplayName = "DefaultNode", GUID = "c9d15fd2-f0b3-4b2f-b743-b6159d12b189", Description = "Default node", GroupName = "")]
    [SiteImageUrl]
    public class DefaultNode : NodeContent
    {
        [CultureSpecific]
        [Display(
            Name = "Main body",
            Description = "The main body will be shown in the main content area of the page, using the XHTML-editor you can insert for example text, images and tables.",
            GroupName = SystemTabNames.Content,
            Order = 1)]
        public virtual XhtmlString MainBody { get; set; }
    }
}