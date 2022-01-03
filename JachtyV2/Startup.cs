using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(JachtyV2.Startup))]
namespace JachtyV2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
