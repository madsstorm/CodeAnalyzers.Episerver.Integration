using EPiServer.Core;

namespace CodeAnalyzers.Episerver.Integration.Models.Pages
{
    public interface ISettingsContent : IContentData
    {
        ContentReference Settings { get; set; }
    }
}