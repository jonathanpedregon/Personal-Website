using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(JonathanPedregon.Startup))]
namespace JonathanPedregon
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            //ConfigureAuth(app);
        }
    }
}
