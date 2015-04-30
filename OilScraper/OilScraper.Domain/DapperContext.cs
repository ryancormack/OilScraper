using System.Configuration;

namespace OilScraper.Domain
{
    public class DapperContext
    {
        public class Constant
        {
            public static string DatabaseConnection = ConfigurationManager.ConnectionStrings["OilScraper"].ConnectionString;
        }
    }
}
