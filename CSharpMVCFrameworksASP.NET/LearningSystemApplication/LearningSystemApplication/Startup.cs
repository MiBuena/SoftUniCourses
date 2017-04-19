using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LearningSystemApplication.Startup))]
namespace LearningSystemApplication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
