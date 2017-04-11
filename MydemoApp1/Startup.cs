using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MydemoApp1.Startup))]
namespace MydemoApp1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
