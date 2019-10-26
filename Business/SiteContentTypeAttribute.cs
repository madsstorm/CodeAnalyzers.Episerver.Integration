using EPiServer.DataAnnotations;

namespace CodeAnalyzers.Episerver.Integration.Business
{
    public class SiteContentTypeAttribute : ContentTypeAttribute
    {
        public SiteContentTypeAttribute()
        {
            GroupName = "Content";
        }
    }
}