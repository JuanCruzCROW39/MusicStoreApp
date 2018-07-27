using Autofac;
using Autofac.Integration.Mvc;
using Microsoft.Owin;
using Owin;
using System.ComponentModel;
using System.Web.Mvc;

[assembly: OwinStartupAttribute(typeof(UI.Startup))]
namespace UI
{
    public partial class Startup
    {
        private Autofac.IContainer container { get; set; }

        public void Configuration(IAppBuilder app)
        {
            var builder = new ContainerBuilder();
            builder.RegisterControllers(typeof(MvcApplication).Assembly);
            builder.RegisterType<Domain.Entities.TiendaDeMusicaEntities2>().AsSelf().InstancePerRequest();

            container = builder.Build();

            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));

            ConfigureAuth(app);
        }
    }
}
