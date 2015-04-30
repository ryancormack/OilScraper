using HtmlAgilityPack;

namespace OilScraper.Helpers
{
    public interface IWebLoaderHelper {
        HtmlDocument GetPageHtml(string pageUrl);
    }

    public class WebLoaderHelper : IWebLoaderHelper {
        public HtmlDocument GetPageHtml(string pageUrl) {
            var webGet = new HtmlWeb();

            var document = webGet.Load(pageUrl);

            return document;
        }
    }
}
