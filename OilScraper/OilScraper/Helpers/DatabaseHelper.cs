using OilScraper.Domain.Service;

namespace OilScraper.Helpers
{
    public interface IDatabaseHelper {
        void InsertRig(string rigName, string manager, string rigType, string ratedWaterDepth, string drillingDepth);
    }

    public class DatabaseHelper : IDatabaseHelper {

        private readonly IOilService _oilService;

        public DatabaseHelper(IOilService oilService) {
            _oilService = oilService;
        }

        public void InsertRig(string rigName, string manager, string rigType, string ratedWaterDepth, string drillingDepth) {
            _oilService.InsertOilRig(rigName, manager, rigType, ratedWaterDepth, drillingDepth);
        }
    }
}
