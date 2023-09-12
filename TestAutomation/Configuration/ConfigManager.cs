using Microsoft.Extensions.Configuration;
namespace TaxuallyTestAutomation.Configuration
{
    public class ConfigManager
    {
        static IConfiguration _Configuration { get; set; }
        static ConfigManager()
        {
            var builder = new ConfigurationBuilder()
            .SetBasePath(AppContext.BaseDirectory)
            .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
            _Configuration = builder.Build();
        }

        public static string SiteUrl => _Configuration["SiteUrl"];
        public static string Browser => _Configuration["Browser"];
    }
}
