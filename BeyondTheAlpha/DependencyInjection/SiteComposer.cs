using Umbraco.Cms.Core.Composing;
using Umbraco.Cms.Search.BackOffice.DependencyInjection;
using Umbraco.Cms.Search.Core.DependencyInjection;
using Umbraco.Cms.Search.DeliveryApi.DependencyInjection;
using Umbraco.Cms.Search.Provider.Examine.DependencyInjection;

namespace BeyondTheAlpha.DependencyInjection
{
	internal sealed class SiteComposer : IComposer
	{
		public void Compose(IUmbracoBuilder builder)
		{
			builder
				.AddSearchCore()
				.AddBackOfficeSearch()
				.AddDeliveryApiSearch()
				.AddExamineSearchProvider();
		}
	}
}
