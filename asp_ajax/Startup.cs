using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(asp_ajax.Startup))]
namespace asp_ajax
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
