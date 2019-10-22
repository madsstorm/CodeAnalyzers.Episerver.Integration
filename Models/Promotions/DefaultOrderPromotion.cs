using System.ComponentModel.DataAnnotations;
using EPiServer.Commerce.Marketing;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

namespace CodeAnalyzers.Episerver.Integration.Models.Promotions
{
    [ContentType(DisplayName = "DefaultOrderPromotion", GUID = "e8f80064-f4bf-4398-acde-ae6ec9d88c7c", Description = "")]
    public class DefaultOrderPromotion : OrderPromotion
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