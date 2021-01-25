using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Apoteka.Startup))]
namespace Apoteka
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
