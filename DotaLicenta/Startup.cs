using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DotaLicenta.Startup))]
namespace DotaLicenta
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
