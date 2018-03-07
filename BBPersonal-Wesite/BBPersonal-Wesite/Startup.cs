using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BBPersonal_Wesite.Startup))]
namespace BBPersonal_Wesite
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
