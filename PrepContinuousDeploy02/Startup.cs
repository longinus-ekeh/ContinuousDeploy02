using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PrepContinuousDeploy02.Startup))]
namespace PrepContinuousDeploy02
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
