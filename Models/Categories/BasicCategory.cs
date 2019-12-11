using EPiServer.Core;
using EPiServer.DataAnnotations;
using Geta.EpiCategories;

namespace CodeAnalyzers.Episerver.Integration.Models.Categories
{
    [ContentType(Description = "Basic category", DisplayName = "Basic category", GUID = "{470D3048-DB7A-4E1E-AA72-780FFC45FC67}")]
    public class BasicCategory : CategoryData
    {
        [CultureSpecific]
        public virtual XhtmlString MainBody { get; set; }
    }
}