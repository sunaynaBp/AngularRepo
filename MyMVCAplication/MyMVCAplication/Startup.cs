using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyMVCAplication.Startup))]
namespace MyMVCAplication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
