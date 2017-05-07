using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TownHall.Startup))]
namespace TownHall
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
