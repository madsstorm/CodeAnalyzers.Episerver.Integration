﻿using EPiServer.Commerce.Catalog.ContentTypes;
using EPiServer.Commerce.Catalog.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using System.ComponentModel.DataAnnotations;

namespace CodeAnalyzers.Episerver.Integration.Models.CatalogContent
{
    [CatalogContentType(DisplayName = "DefaultVariation",
        GUID = "f6b2ee6e-38a5-47fa-8d50-156dbb4c4f89",
        Description = "Default variation",
        Order = 400,
        GroupName = "DefaultGroup")]
    [ImageUrl("image.png")]
    public class DefaultVariation : VariationContent
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