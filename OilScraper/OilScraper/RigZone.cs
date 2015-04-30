using OilScraper.Domain.Repository;
using OilScraper.Domain.Service;
using OilScraper.Helpers;

namespace OilScraper
{
    public static class RigZone
    {
        static readonly IWebLoaderHelper _webLoaderHelper;
        static readonly IDatabaseHelper _databaseHelper;

        static RigZone()
        {
            IOilService _oilService = new OilService(new OilRepository());
            _webLoaderHelper = new WebLoaderHelper();
            _databaseHelper = new DatabaseHelper(_oilService);
        }

        public static void GetRigZoneRigs()
        {
            var document = _webLoaderHelper.GetPageHtml("http://www.rigzone.com/data/results.asp?Rig_Type_ID=4");

            var nodes = document.DocumentNode.SelectNodes("//*[@id=\"largeTable\"]/tbody");
        }


    }
}
