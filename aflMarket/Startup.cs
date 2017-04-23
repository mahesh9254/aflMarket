using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(aflMarket.Startup))]
namespace aflMarket
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
