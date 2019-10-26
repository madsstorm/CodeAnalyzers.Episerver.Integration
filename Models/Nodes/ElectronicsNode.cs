using System.ComponentModel.DataAnnotations;
using CodeAnalyzers.Episerver.Integration.Business;
using EPiServer.Commerce.Catalog.ContentTypes;
using EPiServer.Commerce.Catalog.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

namespace CodeAnalyzers.Episerver.Integration.Models.Nodes
{
    [CatalogContentType(DisplayName = "ElectronicsNode", GUID = "76721ca4-9699-4912-85c2-16fb95cb202f", Description = "")]
    [SiteImageUrl]
    public class ElectronicsNode : NodeContent
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