using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(COMP229_F2016_Lesson1.Startup))]
namespace COMP229_F2016_Lesson1
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
