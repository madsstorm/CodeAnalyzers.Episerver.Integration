using System.ComponentModel.DataAnnotations;
using EPiServer.Commerce.Catalog.ContentTypes;
using EPiServer.Commerce.Catalog.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

namespace CodeAnalyzers.Episerver.Integration.Models.Variations
{
    [CatalogContentType(DisplayName = "Electronics Variation",
        GUID = "{9F54164B-2D36-4F9F-B079-FDAB3FB2CBD8}",
        Description = "Electronics variation",
        Order = 400,
        GroupName = "DefaultGroup")]
    [ImageUrl("image.png")]
    public class ElectronicsVariation : VariationContent
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