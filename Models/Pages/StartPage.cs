using System.ComponentModel.DataAnnotations;
using CodeAnalyzers.Episerver.Integration.Business;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.Web;

namespace CodeAnalyzers.Episerver.Integration.Models.Pages
{
    [SiteContentType(DisplayName = "StartPage",
        GUID = "f36e94f4-2f49-45f6-825d-86e9ec3acb74",
        Description = "Start page",
        Order = 100)]
    [SiteImageUrl]
    public class StartPage : PageData
    {
        [Display(
            Name = "Intro name",
            Description = "Intro description",
            GroupName = SystemTabNames.Content,
            Order = 5,
            Prompt = "Enter an introductory text")]
        [CultureSpecific]
        [UIHint(UIHint.Textarea)]
        public virtual string Intro { get; set; }

        [CultureSpecific]
        [Display(
            Name = "Main body",
            Description = "The main body will be shown in the main content area of the page, using the XHTML-editor you can insert for example text, images and tables.",
            GroupName = SystemTabNames.Content,
            Order = 10,
            Prompt = "Prompt")]
        public virtual XhtmlString MainBody { get; set; }
    }
}