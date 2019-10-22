using System.ComponentModel.DataAnnotations;
using EPiServer.Commerce.Marketing;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

namespace CodeAnalyzers.Episerver.Integration.Models.Promotions
{
    [ContentType(DisplayName = "DefaultShippingPromotion", GUID = "48cc781a-9929-4e5b-af56-ff5990b56b30", Description = "")]
    public class DefaultShippingPromotion : ShippingPromotion
    {
        [CultureSpecific]
        [Display(
            Name = "Title",
            Description = "Title field's description",
            GroupName = SystemTabNames.Content,
            Order = 1)]
        public virtual string Title { get; set; }
    }
}