using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WEBProjekatVezbe.Startup))]
namespace WEBProjekatVezbe
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
