using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PhuongTrieu.Startup))]
namespace PhuongTrieu
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
