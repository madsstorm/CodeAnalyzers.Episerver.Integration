using EPiServer.Core;
using EPiServer.Framework;
using EPiServer.Framework.Initialization;
using Mediachase.Commerce.Orders;

namespace CodeAnalyzers.Episerver.Integration.Business
{
    [InitializableModule]
    [ModuleDependency(typeof(EPiServer.Web.InitializationModule))]
    public class InitializationModule : IInitializableModule
    {
        public void Initialize(InitializationEngine context)
        {
            var contentEvents = context.Locate.Advanced.GetInstance<IContentEvents>();

            contentEvents.SavingContent += ContentEvents_SavingContent;
        }

        public void Uninitialize(InitializationEngine context)
        {
        }

        private void ContentEvents_SavingContent(object sender, EPiServer.ContentEventArgs e)
        {
            OrderContext.Current.OrderGroupUpdated += Current_OrderGroupUpdated;
        }

        private void Current_OrderGroupUpdated(object sender, OrderGroupEventArgs e)
        {
            var orderGroup = OrderContext.Current.Get<OrderGroup>(e.OrderGroupId);
            string currency = orderGroup.BillingCurrency;
        }
    }
}