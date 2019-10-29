using EPiServer.Core;

namespace CodeAnalyzers.Episerver.Integration.Models.Pages
{
    public abstract class PageBase : PageData
    {
        public virtual string Title { get; set; }
    }
}