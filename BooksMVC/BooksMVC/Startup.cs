using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BooksMVC.Startup))]
namespace BooksMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
