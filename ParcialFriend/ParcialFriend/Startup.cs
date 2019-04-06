using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ParcialFriend.Startup))]
namespace ParcialFriend
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
