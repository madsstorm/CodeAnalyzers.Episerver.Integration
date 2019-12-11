using EPiServer.DataAnnotations;
using EPiServer.Forms.EditView;
using EPiServer.Forms.Implementation.Elements.BaseClasses;

namespace CodeAnalyzers.Episerver.Integration.Models.Forms
{
    [ContentType(GUID = "{1B923E2E-D3AB-4090-BC6F-1FABA878398A}", GroupName = ConstantsFormsUI.FormElementGroup, Order = 2230)]
    public class MyCustomElementBlock : ValidatableElementBlockBase
    {
        public virtual string CustomProperty { get; set; }
    }
}