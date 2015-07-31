using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MunicipalidaddelaCalera.Startup))]
namespace MunicipalidaddelaCalera
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
