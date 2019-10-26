using EPiServer.DataAnnotations;

namespace CodeAnalyzers.Episerver.Integration.Business
{
    public class SiteImageUrlAttribute : ImageUrlAttribute
    {
        public SiteImageUrlAttribute() : base("~/Static/gfx/page-type-thumbnail.png") { }
        public SiteImageUrlAttribute(string path) : base(path) { }
    }
}