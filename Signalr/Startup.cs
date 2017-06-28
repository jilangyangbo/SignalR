using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Signalr.Startup))]
namespace Signalr
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.MapSignalR();
        }
    }
}
