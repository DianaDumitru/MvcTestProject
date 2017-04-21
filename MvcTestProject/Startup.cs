using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MvcTestProject.Startup))]
namespace MvcTestProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
