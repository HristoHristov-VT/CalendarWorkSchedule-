using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CalendarWorkSchedule.Startup))]
namespace CalendarWorkSchedule
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
