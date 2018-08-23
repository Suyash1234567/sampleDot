using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebAppAssignment2.Startup))]
namespace WebAppAssignment2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
