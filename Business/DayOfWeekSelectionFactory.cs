using System.Collections.Generic;
using EPiServer.Shell.ObjectEditing;

namespace CodeAnalyzers.Episerver.Integration.Business
{
    public class DayOfWeekSelectionFactory : ISelectionFactory
    {
        public IEnumerable<ISelectItem> GetSelections(ExtendedMetadata metadata)
        {
            yield return new SelectItem { Text = "Monday", Value = "Monday" };
            yield return new SelectItem { Text = "Tuesday", Value = "Tuesday" };
            yield return new SelectItem { Text = "Wednesday", Value = "Wednesday" };
            yield return new SelectItem { Text = "Thursday", Value = "Thursday" };
            yield return new SelectItem { Text = "Friday", Value = "Friday" };
            yield return new SelectItem { Text = "Saturday", Value = "Saturday" };
            yield return new SelectItem { Text = "Sunday", Value = "Sunday" };
        }
    }
}