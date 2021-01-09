using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LucrumQuaestum.Startup))]
namespace LucrumQuaestum
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
