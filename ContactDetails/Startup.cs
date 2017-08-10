using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ContactDetails.Startup))]
namespace ContactDetails
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
