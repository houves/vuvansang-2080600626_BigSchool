using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(vuvansang_2080600626.Startup))]
namespace vuvansang_2080600626
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
