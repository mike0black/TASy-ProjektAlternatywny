using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SprzedaneWebMVC.Startup))]
namespace SprzedaneWebMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
