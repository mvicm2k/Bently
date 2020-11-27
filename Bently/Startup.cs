using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Bently.Startup))]
namespace Bently
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
