using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EjemploGIT.Startup))]
namespace EjemploGIT
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
