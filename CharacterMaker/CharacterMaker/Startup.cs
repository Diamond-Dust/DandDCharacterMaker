using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CharacterMaker.Startup))]
namespace CharacterMaker
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
