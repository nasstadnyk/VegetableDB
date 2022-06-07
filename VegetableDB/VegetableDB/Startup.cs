using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VegetableDB.Startup))]
namespace VegetableDB
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
