using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.Framework.DataAnnotations;

namespace CodeAnalyzers.Episerver.Integration.Models.Media
{
    [ContentType(DisplayName = "DefaultImage", GUID = "c91438b4-0cd9-4514-921c-655a426a4a26", Description = "")]
    [MediaDescriptor(ExtensionString = "png,jpg,jpeg")]
    public class DefaultImage : ImageData
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