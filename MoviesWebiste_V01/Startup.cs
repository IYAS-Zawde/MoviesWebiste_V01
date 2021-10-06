using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MoviesWebiste_V01.Startup))]
namespace MoviesWebiste_V01
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
