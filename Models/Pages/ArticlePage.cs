using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

namespace CodeAnalyzers.Episerver.Integration.Models.Pages
{
    [ContentType(DisplayName = "ArticlePage",
        GUID = "02d98a47-19c9-4464-92ab-a4248327ddba",
        Description = "Article page",
        GroupName = "Content",
        Order = 500)]
    [ImageUrl("image.png")]
    public class ArticlePage : PageData
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