using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ArischaNurFadilah_04.Startup))]
namespace ArischaNurFadilah_04
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
