using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EjercicioMasterPage1._5.Startup))]
namespace EjercicioMasterPage1._5
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
