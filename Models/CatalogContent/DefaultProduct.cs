using CodeAnalyzers.Episerver.Integration.Business;
using EPiServer.Commerce.Catalog.ContentTypes;
using EPiServer.Commerce.Catalog.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using System.ComponentModel.DataAnnotations;

namespace CodeAnalyzers.Episerver.Integration.Models.CatalogContent
{
    [CatalogContentType(DisplayName = "DefaultProduct", GUID = "11af6ae2-1981-48f9-9c30-9bfb009d369f", Description = "Default")]
    [SiteImageUrl]
    public class DefaultProduct : ProductContent
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