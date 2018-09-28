using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCassignment1.Startup))]
namespace MVCassignment1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
