using System.ComponentModel.DataAnnotations;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.Forms.Core;
using EPiServer.Forms.Implementation.Elements;
using EPiServer.ServiceLocation;

namespace CodeAnalyzers.Episerver.Integration.Models.Forms
{
    [ContentType(GUID = "{AA310BB3-5753-4F5F-A608-165C7002F298}", GroupName = EPiServer.Forms.Constants.FormElementGroup_Container, Order = 4000)]
    [ServiceConfiguration(typeof(IFormContainerBlock))]
    public class EPiFormWithTwoColumnOptionBlock : FormContainerBlock
    {
        [Display(Name = "Use two column layout", Order = 1, GroupName = SystemTabNames.Content)]
        public virtual bool HasTwoColumns { get; set; }
    }
}