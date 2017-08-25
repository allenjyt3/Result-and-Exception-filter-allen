using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ExceptionHandlingfilter.Startup))]
namespace ExceptionHandlingfilter
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
