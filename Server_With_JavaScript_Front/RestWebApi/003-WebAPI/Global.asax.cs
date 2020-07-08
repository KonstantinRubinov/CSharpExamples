using SimpleInjector;
using System.Web.Http;
using System.Web.Mvc;

namespace RestWebApi
{
    public class WebApiApplication : System.Web.HttpApplication
    {
		private void ConfigureApi()
		{
			var container = new Container();
			container.RegisterWebApiControllers(GlobalConfiguration.Configuration);
			container.Register<IHeroesRepository, HeroesManager>();
			container.Register<IProductsRepository, ProductsManager>();
			container.Verify();
			DependencyResolver.SetResolver(new SimpleInjectorDependencyResolver(container));
			GlobalConfiguration.Configuration.DependencyResolver = new SimpleInjectorDependencyResolver(container);
		}

		protected void Application_Start()
		{
			AreaRegistration.RegisterAllAreas();
			ConfigureApi();

			GlobalConfiguration.Configure(WebApiConfig.Register);
		}
	}
}
