using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ChristmasOrganizer.Startup))]
namespace ChristmasOrganizer
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
