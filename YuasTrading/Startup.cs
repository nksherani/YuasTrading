using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(YuasTrading.Startup))]
namespace YuasTrading
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
