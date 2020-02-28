using Microsoft.AspNetCore.Hosting;

[assembly: HostingStartup(typeof(Prof_Me.Areas.Identity.IdentityHostingStartup))]
namespace Prof_Me.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) =>
            {
            });
        }
    }
}