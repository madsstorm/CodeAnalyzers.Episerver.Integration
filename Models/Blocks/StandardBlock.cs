using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

namespace CodeAnalyzers.Episerver.Integration.Models.Blocks
{
    [ContentType(DisplayName = "StandardBlock",
        GUID = "e394d7a8-2090-4490-a15c-09c9b1bf81d4",
        Description = "",
        GroupName = "Structure",
        Order = 100)]
    public class StandardBlock : BlockData
    {
        [CultureSpecific]
        [Display(
            Name = "Name",
            Description = "Name field's description",
            GroupName = SystemTabNames.Content,
            Order = 1)]
        public virtual string Name { get; set; }
    }
}