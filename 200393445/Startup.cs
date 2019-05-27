using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_200393445.Startup))]
namespace _200393445
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
