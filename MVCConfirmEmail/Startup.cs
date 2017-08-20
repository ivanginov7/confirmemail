using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCConfirmEmail.Startup))]
namespace MVCConfirmEmail
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
