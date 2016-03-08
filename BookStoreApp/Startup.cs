using Autofac;
using Autofac.Integration.Mvc;
using Microsoft.AspNet.Identity;
using Microsoft.Owin;
using Microsoft.Owin.Security;
using Microsoft.Owin.Security.DataProtection;
using Owin;
using System;
using System.Web;
using System.Web.Mvc;
[assembly: OwinStartupAttribute(typeof(BookStoreApp.Startup))]
namespace BookStoreApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
			//AutoFac Model Configuration
			var builder = new ContainerBuilder();

			builder.RegisterModule(new Repository.AutofacModule());

			// REGISTER CONTROLLERS SO DEPENDENCIES ARE CONSTRUCTOR INJECTED
			builder.RegisterControllers(typeof(MvcApplication).Assembly);

			// BUILD THE CONTAINER
			var container = builder.Build();

			// REPLACE THE MVC DEPENDENCY RESOLVER WITH AUTOFAC
			DependencyResolver.SetResolver(new AutofacDependencyResolver(container));

			// REGISTER WITH OWIN
			app.UseAutofacMiddleware(container);
			app.UseAutofacMvc();

			ConfigureAuth(app);
		}
    }
}
