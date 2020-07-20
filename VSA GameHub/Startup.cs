using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VSA_GameHub.Startup))]
namespace VSA_GameHub
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
