using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(np_project.Startup))]
namespace np_project
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
