using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CRUDWebApi_Client1.Startup))]
namespace CRUDWebApi_Client1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
