using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

namespace CodeAnalyzers.Episerver.Integration.Models.Pages
{
    [ContentType(DisplayName = "StartPage",
        GUID = "f36e94f4-2f49-45f6-825d-86e9ec3acb74",
        Description = "Start page",
        GroupName = "Structure",
        Order = 100)]
    [ImageUrl("image.png")]
    public class StartPage : PageData
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