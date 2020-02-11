using SIS.MvcFramework;
namespace Panda.Web
{
    using Panda.Data;
    using SIS.MvcFramework.Routing;

    public class StartUp : IMvcApplication
    {
        public void Configure(IServerRoutingTable serverRoutingTable)
        {
            //once on start up
            using (var db = new PandaDbContext())
            {
                db.Database.EnsureCreated();
            }
        }

        public void ConfigureServices(SIS.MvcFramework.DependencyContainer.IServiceProvider serviceProvider)
        {
            //serviceProvider.Add
        }
    }
}
