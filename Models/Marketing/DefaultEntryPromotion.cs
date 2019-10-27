using System.ComponentModel.DataAnnotations;
using EPiServer.Commerce.Marketing;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

namespace CodeAnalyzers.Episerver.Integration.Models.Marketing
{
    [ContentType(DisplayName = "DefaultEntryPromotion", GUID = "5d4a2b1f-3e82-473b-abf1-29159576326e", Description = "")]
    public class DefaultEntryPromotion : EntryPromotion
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