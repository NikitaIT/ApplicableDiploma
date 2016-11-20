using Microsoft.Owin;
using Owin;
using WebApplication7.Models;

[assembly: OwinStartupAttribute(typeof(WebApplication7.Startup))]
namespace WebApplication7
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            PersonDbInitializer dbInitializer = new PersonDbInitializer();
            ConfigureAuth(app);
        }
    }
}
